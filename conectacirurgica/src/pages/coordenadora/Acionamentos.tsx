import { useState } from 'react';
import { Calendar, MapPin, Search, X, Plus, Trash2, Edit2, AlertCircle } from 'lucide-react';
import clsx from 'clsx';
import { useStore } from '../../store/useStore';
import type { Demanda } from '../../store/useStore';
import { format, parseISO } from 'date-fns';

export default function Acionamentos() {
  const { demandas, instrumentadores, enviarConvite, deleteDemanda, addDemandaManual, updateDemanda } = useStore();
  const [selectedDemandaId, setSelectedDemandaId] = useState<number | null>(null);

  // Modal de edição / criação
  const [isModalOpen, setIsModalOpen] = useState(false);
  const [editingDemanda, setEditingDemanda] = useState<Partial<Demanda> | null>(null);

  const [confirmDelete, setConfirmDelete] = useState<number | null>(null);

  const demandasAbertas = demandas.filter(d => ['pendente', 'alocando', 'cancelamento_solicitado'].includes(d.status));
  const selectedDemanda = demandas.find(d => d.id === selectedDemandaId);

  // Lógica de match
  const getProfissionaisCompativeis = (demanda: Demanda) => {
    return instrumentadores.map(prof => {
      let match = 50; 
      let disponivel = false;
      const tags: string[] = [];

      const hasEspecialidade = prof.especialidades.some(e => demanda.procedimento.toLowerCase().includes(e.toLowerCase()));
      if (hasEspecialidade) {
        match += 30;
        tags.push('Especialidade compatível');
      }

      const dispDia = prof.disponibilidade[demanda.data];
      if (dispDia && !dispDia.includes('indisponivel')) {
        match += 20;
        disponivel = true;
        tags.push('Disponível na data');
      } else if (dispDia?.includes('indisponivel')) {
        match = 0;
        disponivel = false;
        tags.push('Indisponível (Exceção)');
      }

      const conflito = demandas.some(d => d.instrumentadorId === prof.id && d.data === demanda.data && d.status === 'confirmado');
      if (conflito) {
        match = 0;
        disponivel = false;
        tags.push('Conflito de agenda (Ocupado)');
      }

      return { prof, match, disponivel, tags };
    }).sort((a, b) => b.match - a.match);
  };

  const compativeis = selectedDemanda ? getProfissionaisCompativeis(selectedDemanda) : [];

  const handleSendConvite = (instrumentadorId: number) => {
    if (!selectedDemandaId) return;
    enviarConvite(selectedDemandaId, instrumentadorId);
    setSelectedDemandaId(null);
  };

  const formatDate = (dateStr: string) => {
    try {
      return format(parseISO(dateStr), 'dd/MM/yyyy');
    } catch {
      return dateStr;
    }
  };

  const openNewDemanda = () => {
    setEditingDemanda({
      data: format(new Date(), 'yyyy-MM-dd'),
      hora: '08:00',
      procedimento: '',
      hospital: '',
      medico: '',
      valorFreelancer: ''
    });
    setIsModalOpen(true);
  };

  const openEditDemanda = (d: Demanda) => {
    setEditingDemanda(d);
    setIsModalOpen(true);
  };

  const handleSaveDemanda = () => {
    if (editingDemanda) {
      if (editingDemanda.id) {
        updateDemanda(editingDemanda.id, editingDemanda);
      } else {
        addDemandaManual(editingDemanda as Omit<Demanda, 'id'|'status'>);
      }
    }
    setIsModalOpen(false);
    setEditingDemanda(null);
  };

  const handleDelete = (id: number) => {
    deleteDemanda(id);
    setConfirmDelete(null);
    if (selectedDemandaId === id) setSelectedDemandaId(null);
  };

  return (
    <div className="flex flex-col lg:flex-row gap-6 h-auto lg:h-[calc(100vh-8rem)]">
      {/* Lista de Demandas */}
      <div className="w-full lg:w-1/3 flex flex-col bg-white rounded-xl shadow-sm border border-slate-100 overflow-hidden min-h-[300px] lg:min-h-0">
        <div className="p-4 border-b border-slate-100 bg-slate-50 flex justify-between items-center">
          <h2 className="font-bold text-slate-800">Demandas ({demandasAbertas.length})</h2>
          <button onClick={openNewDemanda} className="bg-primary-600 hover:bg-primary-700 text-white p-1.5 rounded" title="Adicionar Manualmente">
            <Plus className="w-4 h-4" />
          </button>
        </div>
        <div className="flex-1 overflow-y-auto p-2 space-y-2">
          {demandasAbertas.length === 0 && (
            <div className="p-4 text-center text-slate-500 text-sm">Nenhuma demanda aguardando alocação.</div>
          )}
          {demandasAbertas.map(d => (
            <div key={d.id} className="relative">
              <div 
                className={clsx(
                  "p-3 rounded-lg border cursor-pointer transition-all pr-16",
                  selectedDemandaId === d.id ? "bg-primary-50 border-primary-300 ring-1 ring-primary-300" : "bg-white border-slate-200 hover:border-primary-200"
                )}
                onClick={() => setSelectedDemandaId(d.id)}
              >
                <div className="flex justify-between items-start mb-1">
                  <span className="font-bold text-sm text-slate-900 truncate">{d.procedimento}</span>
                </div>
                <div className="text-xs text-slate-500 flex items-center gap-2 mb-1">
                  <Calendar className="w-3 h-3"/> {formatDate(d.data)} às {d.hora}
                </div>
                <div className="text-xs text-slate-500 flex items-center gap-2 truncate">
                  <MapPin className="w-3 h-3 shrink-0"/> <span className="truncate">{d.hospital}</span>
                </div>
                {d.status === 'cancelamento_solicitado' && (
                  <div className="mt-2 text-xs font-bold text-amber-600 flex items-center gap-1">
                    <AlertCircle className="w-3 h-3"/> Cancelamento Solicitado
                  </div>
                )}
              </div>

              {/* Botões de Ação na Lista */}
              <div className="absolute top-2 right-2 flex flex-col gap-1">
                <button onClick={(e) => { e.stopPropagation(); openEditDemanda(d); }} className="p-1.5 text-slate-400 hover:text-primary-600 bg-white shadow-sm border border-slate-200 rounded">
                  <Edit2 className="w-3 h-3" />
                </button>
                <button onClick={(e) => { e.stopPropagation(); setConfirmDelete(d.id); }} className="p-1.5 text-slate-400 hover:text-red-600 bg-white shadow-sm border border-slate-200 rounded">
                  <Trash2 className="w-3 h-3" />
                </button>
              </div>

              {/* Confirmação de exclusão */}
              {confirmDelete === d.id && (
                <div className="absolute inset-0 bg-white/95 z-10 flex flex-col items-center justify-center rounded-lg border border-red-200 p-2 text-center">
                  <p className="text-xs font-bold text-red-600 mb-2">Excluir rascunho?</p>
                  <div className="flex gap-2">
                    <button onClick={() => setConfirmDelete(null)} className="px-2 py-1 text-xs bg-slate-100 rounded text-slate-600">Cancelar</button>
                    <button onClick={() => handleDelete(d.id)} className="px-2 py-1 text-xs bg-red-600 text-white rounded">Excluir</button>
                  </div>
                </div>
              )}
            </div>
          ))}
        </div>
      </div>

      {/* Área de Match */}
      <div className="w-full lg:w-2/3 bg-white rounded-xl shadow-sm border border-slate-100 flex flex-col min-h-[400px] lg:min-h-0">
        {selectedDemanda ? (
          <>
            <div className="p-6 border-b border-slate-100 shrink-0">
              <div className="flex justify-between items-start mb-4">
                <div>
                  <h2 className="text-xl font-bold text-slate-900">{selectedDemanda.procedimento}</h2>
                  <p className="text-slate-500 text-sm">Equipe: {selectedDemanda.medico}</p>
                  {selectedDemanda.valorFreelancer && (
                    <p className="text-emerald-600 font-bold text-sm mt-1">Valor do Plantão: {selectedDemanda.valorFreelancer}</p>
                  )}
                  {selectedDemanda.status === 'cancelamento_solicitado' && (
                    <div className="mt-3 p-3 bg-amber-50 border border-amber-200 rounded-lg text-sm text-amber-800">
                      <strong>Atenção:</strong> O instrumentador solicitou cancelamento.<br/>
                      <em>Motivo:</em> {selectedDemanda.motivoCancelamento}
                    </div>
                  )}
                </div>
                <button onClick={() => setSelectedDemandaId(null)} className="p-2 hover:bg-slate-100 rounded-full text-slate-400">
                  <X className="w-5 h-5" />
                </button>
              </div>
              <div className="flex gap-6 text-sm text-slate-600">
                <span className="flex items-center gap-2"><Calendar className="w-4 h-4"/> {formatDate(selectedDemanda.data)} às {selectedDemanda.hora}</span>
                <span className="flex items-center gap-2"><MapPin className="w-4 h-4"/> {selectedDemanda.hospital}</span>
              </div>
            </div>

            <div className="p-4 bg-slate-50 border-b border-slate-100 shrink-0">
              <div className="flex gap-4">
                <div className="flex-1 relative">
                  <Search className="w-4 h-4 absolute left-3 top-2.5 text-slate-400" />
                  <input type="text" placeholder="Buscar profissional..." className="w-full pl-9 pr-4 py-2 text-sm border-slate-300 rounded-md shadow-sm" />
                </div>
              </div>
            </div>

            <div className="flex-1 overflow-y-auto p-6 space-y-4">
              <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider mb-4">Candidatos Sugeridos (Match)</h3>
              
              {compativeis.map(({ prof, match, disponivel, tags }) => (
                <div key={prof.id} className="flex items-center justify-between p-4 border border-slate-200 rounded-xl hover:border-primary-300 transition-colors">
                  <div className="flex items-center gap-4">
                    <div className="w-12 h-12 bg-slate-100 rounded-full flex items-center justify-center font-bold text-slate-600 text-lg">
                      {prof.nome.substring(0,2).toUpperCase()}
                    </div>
                    <div>
                      <div className="flex items-center gap-2">
                        <h4 className="font-bold text-slate-900">{prof.nome}</h4>
                        <span className={clsx("text-xs font-bold px-2 py-0.5 rounded", match >= 70 ? "bg-emerald-100 text-emerald-700" : match > 0 ? "bg-amber-100 text-amber-700" : "bg-red-100 text-red-700")}>
                          Match {match}%
                        </span>
                      </div>
                      <div className="text-sm text-slate-500 mt-1 flex flex-wrap gap-2">
                        {tags.map(t => (
                          <span key={t} className="bg-slate-100 px-2 py-0.5 rounded text-xs">{t}</span>
                        ))}
                      </div>
                    </div>
                  </div>
                  <button 
                    disabled={!disponivel}
                    onClick={() => handleSendConvite(prof.id)}
                    className={clsx(
                      "px-4 py-2 rounded-lg font-medium text-sm transition-colors",
                      disponivel 
                        ? "bg-primary-600 hover:bg-primary-700 text-white" 
                        : "bg-slate-100 text-slate-400 cursor-not-allowed"
                    )}
                  >
                    Convidar
                  </button>
                </div>
              ))}
            </div>
          </>
        ) : (
          <div className="flex-1 flex flex-col items-center justify-center text-slate-400 p-8">
            <Search className="w-16 h-16 mb-4 text-slate-200" />
            <p className="text-lg font-medium text-slate-500">Selecione uma demanda para alocar</p>
            <p className="text-sm text-center mt-2 max-w-sm">Escolha uma demanda na lista lateral para ver os profissionais compatíveis e gerenciar convites.</p>
          </div>
        )}
      </div>

      {/* Modal de Criação / Edição de Demanda */}
      {isModalOpen && editingDemanda && (
        <div className="fixed inset-0 z-50 flex items-center justify-center p-4 bg-slate-900/50 backdrop-blur-sm">
          <div className="bg-white rounded-xl shadow-xl w-full max-w-lg overflow-hidden flex flex-col max-h-[90vh]">
            <div className="flex justify-between items-center p-6 border-b border-slate-100 shrink-0">
              <h2 className="text-xl font-bold text-slate-900">{editingDemanda.id ? 'Editar Demanda' : 'Nova Demanda'}</h2>
              <button onClick={() => setIsModalOpen(false)} className="text-slate-400 hover:text-slate-600">
                <X className="w-6 h-6" />
              </button>
            </div>
            
            <div className="p-6 overflow-y-auto flex-1 space-y-4">
              <div>
                <label className="block text-sm font-medium text-slate-700 mb-1">Procedimento</label>
                <input 
                  type="text" 
                  value={editingDemanda.procedimento || ''} 
                  onChange={e => setEditingDemanda({...editingDemanda, procedimento: e.target.value})}
                  className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 focus:border-primary-500"
                />
              </div>
              <div className="grid grid-cols-2 gap-4">
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Data</label>
                  <input 
                    type="date" 
                    value={editingDemanda.data || ''} 
                    onChange={e => setEditingDemanda({...editingDemanda, data: e.target.value})}
                    className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 focus:border-primary-500"
                  />
                </div>
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Hora</label>
                  <input 
                    type="time" 
                    value={editingDemanda.hora || ''} 
                    onChange={e => setEditingDemanda({...editingDemanda, hora: e.target.value})}
                    className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 focus:border-primary-500"
                  />
                </div>
              </div>
              <div>
                <label className="block text-sm font-medium text-slate-700 mb-1">Hospital</label>
                <input 
                  type="text" 
                  value={editingDemanda.hospital || ''} 
                  onChange={e => setEditingDemanda({...editingDemanda, hospital: e.target.value})}
                  className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 focus:border-primary-500"
                />
              </div>
              <div>
                <label className="block text-sm font-medium text-slate-700 mb-1">Equipe Médica / Médico</label>
                <input 
                  type="text" 
                  value={editingDemanda.medico || ''} 
                  onChange={e => setEditingDemanda({...editingDemanda, medico: e.target.value})}
                  className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 focus:border-primary-500"
                />
              </div>
              <div>
                <label className="block text-sm font-medium text-slate-700 mb-1">Valor do Freelancer (Demonstrativo)</label>
                <input 
                  type="text" 
                  placeholder="R$ 0,00"
                  value={editingDemanda.valorFreelancer || ''} 
                  onChange={e => setEditingDemanda({...editingDemanda, valorFreelancer: e.target.value})}
                  className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 focus:border-primary-500"
                />
                <p className="text-xs text-slate-500 mt-1">Este valor será exibido no convite se configurado.</p>
              </div>
            </div>

            <div className="p-6 border-t border-slate-100 bg-slate-50 flex justify-end gap-3 shrink-0">
              <button onClick={() => setIsModalOpen(false)} className="px-4 py-2 border border-slate-300 rounded-md text-sm font-medium text-slate-700 bg-white hover:bg-slate-50 transition-colors">
                Cancelar
              </button>
              <button onClick={handleSaveDemanda} className="px-4 py-2 rounded-md text-sm font-medium text-white bg-primary-600 hover:bg-primary-700 transition-colors">
                Salvar Demanda
              </button>
            </div>
          </div>
        </div>
      )}

    </div>
  );
}
