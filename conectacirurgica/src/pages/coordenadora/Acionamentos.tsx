import { useState, useRef } from 'react';
import { Calendar, MapPin, Search, X, Plus, Trash2, Edit2, AlertCircle, Download, Copy } from 'lucide-react';
import clsx from 'clsx';
import { useStore } from '../../store/useStore';
import type { Demanda } from '../../store/useStore';
import { format, parseISO } from 'date-fns';
import html2canvas from 'html2canvas';

export default function Acionamentos() {
  const { demandas, instrumentadores, enviarConvite, deleteDemanda, deleteDemandas, addDemandaManual, updateDemanda } = useStore();
  const [selectedIdsForDelete, setSelectedIdsForDelete] = useState<number[]>([]);
  const [selectedDemandaId, setSelectedDemandaId] = useState<number | null>(null);

  // Modal de edição / criação
  const [isModalOpen, setIsModalOpen] = useState(false);
  const [editingDemanda, setEditingDemanda] = useState<Partial<Demanda> | null>(null);

  const [confirmDelete, setConfirmDelete] = useState<number | null>(null);
  const [previewInvite, setPreviewInvite] = useState<number | null>(null);

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

  const handleOpenPreview = (instrumentadorId: number) => {
    setPreviewInvite(instrumentadorId);
  };

  const instPreview = instrumentadores.find(i => i.id === previewInvite);

  const handleSendConvite = () => {
    if (!selectedDemandaId || !previewInvite) return;
    enviarConvite(selectedDemandaId, previewInvite);
    setPreviewInvite(null);
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
      unidadeLocal: '',
      medico: '',
      tipoEvento: 'AGENDAMENTO',
      valorFreelancer: '',
      mc: '',
      paciente: '',
      empresa: 'Meditec',
      convenio: '',
      produtosLista: [],
      equipamentosLista: [],
      representante: '',
      confirmacao: 'SEM DADOS',
      emergencia: false,
      retornoOp: 'Não retornado',
      observacoes: ''
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

  const handleMultiDelete = () => {
    if (window.confirm(`Tem certeza que deseja excluir ${selectedIdsForDelete.length} acionamentos?`)) {
      deleteDemandas(selectedIdsForDelete);
      setSelectedIdsForDelete([]);
      if (selectedDemandaId && selectedIdsForDelete.includes(selectedDemandaId)) {
        setSelectedDemandaId(null);
      }
    }
  };

  const toggleSelectForDelete = (e: React.MouseEvent, id: number) => {
    e.stopPropagation();
    if (selectedIdsForDelete.includes(id)) {
      setSelectedIdsForDelete(prev => prev.filter(i => i !== id));
    } else {
      setSelectedIdsForDelete(prev => [...prev, id]);
    }
  };

  const cardRef = useRef<HTMLDivElement>(null);

  const handleDownloadPNG = async () => {
    if (!cardRef.current) return;
    try {
      const canvas = await html2canvas(cardRef.current, { scale: 2 });
      const dataUrl = canvas.toDataURL('image/png');
      const link = document.createElement('a');
      link.download = `Acionamento_${selectedDemanda?.mc || 'Sem_MC'}.png`;
      link.href = dataUrl;
      link.click();
    } catch (err) {
      console.error('Erro ao gerar PNG', err);
    }
  };

  const handleCopyText = () => {
    if (!selectedDemanda) return;
    const text = `
Agendamento Freelance - MC: ${selectedDemanda.mc || 'S/N'}
Data: ${formatDate(selectedDemanda.data)} às ${selectedDemanda.hora}
Hospital: ${selectedDemanda.hospital}
Médico: ${selectedDemanda.medico}
Procedimento: ${selectedDemanda.procedimento}
Valor do Free: ${selectedDemanda.valorFreelancer || 'A combinar'}
    `.trim();
    navigator.clipboard.writeText(text);
    alert('Texto copiado para a área de transferência!');
  };

  return (
    <div className="flex flex-col lg:flex-row gap-6 h-auto lg:h-[calc(100vh-8rem)]">
      {/* Lista de Demandas */}
      <div className="w-full lg:w-1/3 flex flex-col bg-white rounded-xl shadow-sm border border-slate-100 overflow-hidden min-h-[300px] lg:min-h-0">
        <div className="p-4 border-b border-slate-100 bg-slate-50 flex items-center justify-between">
          <p className="text-xs text-slate-500 font-medium">Selecione para excluir</p>
          {selectedIdsForDelete.length > 0 && (
            <button onClick={handleMultiDelete} className="px-2 py-1 bg-red-100 text-red-700 hover:bg-red-200 rounded text-xs font-bold flex items-center gap-1">
              <Trash2 className="w-3 h-3" />
              Excluir ({selectedIdsForDelete.length})
            </button>
          )}
        </div>
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
                <div className="pt-1">
                  <input 
                    type="checkbox" 
                    className="w-4 h-4 rounded border-slate-300 text-primary-600 focus:ring-primary-500 cursor-pointer"
                    checked={selectedIdsForDelete.includes(d.id)}
                    onChange={() => {}}
                    onClick={(e) => toggleSelectForDelete(e, d.id)}
                  />
                </div>
                <div className="flex-1">
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
                    <button onClick={(e) => { e.stopPropagation(); setConfirmDelete(null); }} className="px-2 py-1 text-xs bg-slate-100 rounded text-slate-600">Cancelar</button>
                    <button onClick={(e) => { e.stopPropagation(); handleDelete(d.id); }} className="px-2 py-1 text-xs bg-red-600 text-white rounded">Excluir</button>
                  </div>
                </div>
              )}
                </div>
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
                    <div className="mt-3 p-3 bg-amber-50 border border-amber-200 rounded-lg text-sm text-amber-800 flex flex-col gap-2">
                      <div>
                        <strong>Atenção:</strong> O instrumentador solicitou cancelamento.<br/>
                        <em>Motivo:</em> {selectedDemanda.motivoCancelamento}
                      </div>
                      <div className="flex gap-2 mt-1">
                        <button 
                          onClick={() => {
                            if(window.confirm('Tem certeza que deseja aceitar o cancelamento? A demanda voltará para a fila de alocação.')) {
                              updateDemanda(selectedDemanda.id, { status: 'pendente', instrumentadorId: null, motivoCancelamento: '' });
                            }
                          }}
                          className="px-3 py-1.5 bg-amber-600 text-white font-bold rounded shadow-sm text-xs hover:bg-amber-700"
                        >
                          Aceitar Cancelamento (Reabrir Vaga)
                        </button>
                      </div>
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
                    onClick={() => handleOpenPreview(prof.id)}
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

      {/* Modal Preview Convite */}
      {previewInvite && selectedDemanda && (
        <div className="fixed inset-0 z-50 flex items-center justify-center p-4 bg-slate-900/50 backdrop-blur-sm">
          <div className="bg-white rounded-xl shadow-xl w-full max-w-sm overflow-hidden flex flex-col">
            <div className="flex justify-between items-center p-4 border-b border-slate-100">
              <h2 className="text-lg font-bold text-slate-900">Prévia do Convite</h2>
              <div className="flex gap-2">
                <button onClick={handleCopyText} className="p-2 bg-slate-100 hover:bg-slate-200 rounded-md text-slate-600" title="Copiar Texto">
                  <Copy className="w-4 h-4" />
                </button>
                <button onClick={handleDownloadPNG} className="p-2 bg-slate-100 hover:bg-slate-200 rounded-md text-slate-600" title="Baixar PNG">
                  <Download className="w-4 h-4" />
                </button>
                <button onClick={() => setPreviewInvite(null)} className="ml-2 text-slate-400 hover:text-slate-600">
                  <X className="w-5 h-5" />
                </button>
              </div>
            </div>
            <div className="p-4 space-y-4">
              <p className="text-sm text-slate-600 mb-2">Assim que o profissional receberá o acionamento no painel:</p>
              
              <div ref={cardRef} className="bg-white border border-slate-300 rounded-xl overflow-hidden shadow-sm relative text-xs" style={{ width: '380px', margin: '0 auto' }}>
                {/* Header Header */}
                <div className="bg-white p-3 flex justify-between items-center border-b-4 border-cyan-100">
                  <div className="flex items-center gap-2">
                    <div className="w-8 h-8 rounded-full border border-slate-200 bg-slate-50 flex items-center justify-center">
                       <span className="font-bold text-slate-800 text-lg">M</span>
                    </div>
                    <div className="font-bold text-slate-800 text-sm">{selectedDemanda.empresa || 'MEDITEC'}</div>
                  </div>
                  <div className="text-[10px] font-bold text-slate-500 uppercase tracking-widest text-right">
                    Agendamento<br/>Freelance
                  </div>
                </div>

                {/* Banner */}
                <div className="bg-cyan-100 p-3 flex justify-between items-center">
                  <div className="font-bold text-cyan-900">
                    <div className="text-[10px] text-cyan-700 uppercase">Instrumentador(a)</div>
                    <div>FREE {instPreview ? instPreview.nome.toUpperCase() : 'NOME'} ({instPreview?.nivel ? instPreview.nivel.toUpperCase() : 'NÍVEL 1'})</div>
                  </div>
                  <div className="bg-slate-800 text-white rounded p-2 text-center w-20">
                    <div className="text-[10px] font-medium opacity-80">MC:</div>
                    <div className="font-bold text-sm">{selectedDemanda.mc || 'S/N'}</div>
                  </div>
                </div>

                {/* Patient/Empresa/Hospital */}
                <div className="p-3 border-b border-cyan-100 flex flex-col gap-2">
                  <div>
                    <span className="text-[10px] text-slate-500 uppercase block">Paciente</span>
                    <span className="font-bold text-slate-800 uppercase">{selectedDemanda.paciente ? 'Omitido na prévia (Confirme para exibir)' : 'SEM DADOS'}</span>
                  </div>
                  <div className="grid grid-cols-2 gap-2">
                    <div>
                      <span className="text-[10px] text-slate-500 uppercase block">Empresa</span>
                      <span className="font-bold text-slate-800 uppercase">{selectedDemanda.empresa || 'MEDITEC'}</span>
                    </div>
                    <div>
                      <span className="text-[10px] text-slate-500 uppercase block">Convênio</span>
                      <span className="font-bold text-slate-800 uppercase">{selectedDemanda.convenio || 'SEM DADOS'}</span>
                    </div>
                  </div>
                  <div>
                    <span className="text-[10px] text-slate-500 uppercase block">Hospital</span>
                    <span className="font-bold text-slate-800 uppercase">{selectedDemanda.hospital || 'SEM DADOS'}</span>
                  </div>
                </div>

                {/* Date / Time */}
                <div className="bg-cyan-50 p-2 grid grid-cols-2 gap-2 border-b border-cyan-100">
                  <div>
                    <span className="text-[10px] text-slate-500 uppercase block">Data</span>
                    <span className="font-bold text-slate-800 uppercase">{selectedDemanda.data ? formatDate(selectedDemanda.data) : 'SEM DADOS'}</span>
                  </div>
                  <div>
                    <span className="text-[10px] text-slate-500 uppercase block">Horário</span>
                    <span className="font-bold text-slate-800 uppercase">{selectedDemanda.hora ? `${selectedDemanda.hora}H` : 'SEM DADOS'}</span>
                  </div>
                </div>

                {/* Evento (Agendamento / Reagendamento) */}
                {selectedDemanda.tipoEvento && selectedDemanda.tipoEvento !== 'AGENDAMENTO' && (
                  <div className="bg-yellow-200 text-yellow-900 text-center font-bold text-[10px] uppercase py-1">
                    {selectedDemanda.tipoEvento}
                  </div>
                )}

                {/* Medico / Procedimento */}
                <div className="p-3 border-b border-cyan-100 flex flex-col gap-2">
                  <div>
                    <span className="text-[10px] text-slate-500 uppercase block">Médico</span>
                    <span className="font-bold text-slate-800 uppercase">{selectedDemanda.medico || 'SEM DADOS'}</span>
                  </div>
                  <div>
                    <span className="text-[10px] text-slate-500 uppercase block">Procedimento</span>
                    <span className="font-bold text-slate-800 uppercase">{selectedDemanda.procedimento || 'SEM DADOS'}</span>
                  </div>
                  <div>
                    <span className="text-[10px] text-slate-500 uppercase block">Produtos / Materiais</span>
                    <div className="font-bold text-slate-700">
                      {(!selectedDemanda.produtosLista || selectedDemanda.produtosLista.length === 0) ? 'SEM DADOS' : (
                        <ul className="list-disc pl-4 mt-1 space-y-1">
                          {selectedDemanda.produtosLista.map(p => (
                            <li key={p.id} className="leading-tight">
                              Produto: {p.descricao} {p.observacoes ? `*(${p.observacoes})` : ''} Qtd: {p.quantidade} {p.codigoReferencia ? `Cód: ${p.codigoReferencia}` : ''}
                            </li>
                          ))}
                        </ul>
                      )}
                    </div>
                  </div>
                  <div>
                    <span className="text-[10px] text-slate-500 uppercase block">Equipamentos / Serviços</span>
                    <div className="font-bold text-slate-700">
                      {(!selectedDemanda.equipamentosLista || selectedDemanda.equipamentosLista.length === 0) ? 'SEM DADOS' : (
                        <ul className="list-disc pl-4 mt-1 space-y-1">
                          {selectedDemanda.equipamentosLista.map(e => (
                            <li key={e.id} className="leading-tight">
                              {e.tipo === 'equipamento' ? 'Equip:' : 'Serv:'} {e.descricao} {e.observacoes ? `(${e.observacoes})` : ''}
                            </li>
                          ))}
                        </ul>
                      )}
                    </div>
                  </div>
                </div>

                {/* Bottom Details */}
                <div className="p-3 grid grid-cols-2 gap-3 bg-slate-50">
                  <div className="space-y-2">
                    <div>
                      <span className="text-[10px] text-slate-500 uppercase block">Representante</span>
                      <span className="font-bold text-slate-800 uppercase">{selectedDemanda.representante || 'SEM DADOS'}</span>
                    </div>
                    <div>
                      <span className="text-[10px] text-slate-500 uppercase block">Valor do Free</span>
                      <span className="font-bold text-lg text-emerald-700 uppercase">{selectedDemanda.valorFreelancer || 'A COMBINAR'}</span>
                    </div>
                    <div>
                      <span className="text-[10px] text-slate-500 uppercase block">Retorno OF</span>
                      <span className="font-bold text-slate-800 uppercase">{selectedDemanda.retornoOp || 'NÃO RETORNADO'}</span>
                    </div>
                  </div>
                  <div className="space-y-2">
                    <div>
                      <span className="text-[10px] text-slate-500 uppercase block">Confirmação</span>
                      <span className="font-bold text-slate-800 uppercase">{selectedDemanda.confirmacao || 'SEM DADOS'}</span>
                    </div>
                    <div>
                      <span className="text-[10px] text-slate-500 uppercase block">Observações</span>
                      <span className="font-bold text-slate-800 uppercase leading-tight block">{selectedDemanda.observacoes || 'SEM DADOS'}</span>
                    </div>
                    <div>
                      <span className="text-[10px] text-slate-500 uppercase block">Emergência</span>
                      <span className="font-bold text-slate-800 uppercase">{selectedDemanda.emergencia ? 'SIM' : 'NÃO'}</span>
                    </div>
                  </div>
                </div>
              </div>

            </div>
            <div className="p-4 border-t border-slate-100 bg-slate-50 flex justify-end gap-2">
              <button onClick={() => setPreviewInvite(null)} className="px-4 py-2 text-sm font-medium text-slate-600">Cancelar</button>
              <button 
                onClick={handleSendConvite} 
                className="px-4 py-2 bg-primary-600 text-white rounded text-sm font-bold hover:bg-primary-700"
              >
                Confirmar e Enviar
              </button>
            </div>
          </div>
        </div>
      )}

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
            
            <div className="p-6 overflow-y-auto flex-1 space-y-8">
              {/* A. Identificação do atendimento */}
              <section>
                <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider mb-3 border-b pb-1">A. Identificação do Atendimento</h3>
                <div className="grid grid-cols-2 gap-4">
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Código MC</label>
                    <input type="text" value={editingDemanda.mc || ''} onChange={e => setEditingDemanda({...editingDemanda, mc: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 focus:border-primary-500" />
                  </div>
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Tipo de Evento</label>
                    <select value={editingDemanda.tipoEvento || 'AGENDAMENTO'} onChange={e => setEditingDemanda({...editingDemanda, tipoEvento: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 bg-white">
                      <option value="AGENDAMENTO">Agendamento</option>
                      <option value="REAGENDAMENTO">Reagendamento</option>
                    </select>
                  </div>
                </div>
              </section>

              {/* B. Paciente, empresa e convênio */}
              <section>
                <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider mb-3 border-b pb-1">B. Paciente, Empresa e Convênio</h3>
                <div className="grid grid-cols-1 gap-4 mb-4">
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Paciente</label>
                    <input type="text" value={editingDemanda.paciente || ''} onChange={e => setEditingDemanda({...editingDemanda, paciente: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500" />
                  </div>
                </div>
                <div className="grid grid-cols-2 gap-4">
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Empresa</label>
                    <input type="text" value={editingDemanda.empresa || ''} onChange={e => setEditingDemanda({...editingDemanda, empresa: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500" />
                  </div>
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Convênio</label>
                    <input type="text" value={editingDemanda.convenio || ''} onChange={e => setEditingDemanda({...editingDemanda, convenio: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500" />
                  </div>
                </div>
              </section>

              {/* C. Hospital, data e horário */}
              <section>
                <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider mb-3 border-b pb-1">C. Hospital, Data e Horário</h3>
                <div className="grid grid-cols-2 gap-4 mb-4">
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Hospital</label>
                    <input type="text" value={editingDemanda.hospital || ''} onChange={e => setEditingDemanda({...editingDemanda, hospital: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500" />
                  </div>
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Unidade/Local Complementar</label>
                    <input type="text" value={editingDemanda.unidadeLocal || ''} onChange={e => setEditingDemanda({...editingDemanda, unidadeLocal: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500" />
                  </div>
                </div>
                <div className="grid grid-cols-2 gap-4">
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Data</label>
                    <input type="date" value={editingDemanda.data || ''} onChange={e => setEditingDemanda({...editingDemanda, data: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500" />
                  </div>
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Horário</label>
                    <input type="time" value={editingDemanda.hora || ''} onChange={e => setEditingDemanda({...editingDemanda, hora: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500" />
                  </div>
                </div>
              </section>

              {/* D. Médico, procedimento e evento */}
              <section>
                <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider mb-3 border-b pb-1">D. Médico e Procedimento</h3>
                <div className="grid grid-cols-2 gap-4">
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Médico Responsável</label>
                    <input type="text" value={editingDemanda.medico || ''} onChange={e => setEditingDemanda({...editingDemanda, medico: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500" />
                  </div>
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Procedimento Cirúrgico</label>
                    <input type="text" value={editingDemanda.procedimento || ''} onChange={e => setEditingDemanda({...editingDemanda, procedimento: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500" />
                  </div>
                </div>
              </section>

              {/* E. Produtos e materiais */}
              <section>
                <div className="flex justify-between items-center mb-3 border-b pb-1">
                  <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider">E. Produtos e Materiais</h3>
                  <button onClick={() => setEditingDemanda({...editingDemanda, produtosLista: [...(editingDemanda.produtosLista || []), { id: Date.now().toString(), descricao: '', quantidade: '1', observacoes: '', codigoReferencia: '' }]})} className="text-xs font-bold text-primary-600 hover:text-primary-800 flex items-center gap-1">
                    <Plus className="w-3 h-3"/> Adicionar Item
                  </button>
                </div>
                <div className="space-y-3">
                  {(!editingDemanda.produtosLista || editingDemanda.produtosLista.length === 0) && (
                    <p className="text-xs text-slate-500 italic">Nenhum produto adicionado.</p>
                  )}
                  {editingDemanda.produtosLista?.map((prod, idx) => (
                    <div key={prod.id} className="p-3 bg-slate-50 border border-slate-200 rounded relative">
                      <button onClick={() => setEditingDemanda({...editingDemanda, produtosLista: editingDemanda.produtosLista?.filter((_, i) => i !== idx)})} className="absolute top-2 right-2 text-red-500 hover:text-red-700"><Trash2 className="w-4 h-4"/></button>
                      <div className="grid grid-cols-4 gap-3 pr-6 mb-2">
                        <div className="col-span-2">
                          <label className="block text-[10px] uppercase text-slate-500 font-bold mb-1">Descrição</label>
                          <input type="text" value={prod.descricao} onChange={e => { const nl = [...editingDemanda.produtosLista!]; nl[idx].descricao = e.target.value; setEditingDemanda({...editingDemanda, produtosLista: nl}); }} className="w-full text-xs p-1.5 border rounded" />
                        </div>
                        <div>
                          <label className="block text-[10px] uppercase text-slate-500 font-bold mb-1">Qtd.</label>
                          <input type="text" value={prod.quantidade} onChange={e => { const nl = [...editingDemanda.produtosLista!]; nl[idx].quantidade = e.target.value; setEditingDemanda({...editingDemanda, produtosLista: nl}); }} className="w-full text-xs p-1.5 border rounded" />
                        </div>
                        <div>
                          <label className="block text-[10px] uppercase text-slate-500 font-bold mb-1">Cód/Ref</label>
                          <input type="text" value={prod.codigoReferencia || ''} onChange={e => { const nl = [...editingDemanda.produtosLista!]; nl[idx].codigoReferencia = e.target.value; setEditingDemanda({...editingDemanda, produtosLista: nl}); }} className="w-full text-xs p-1.5 border rounded" />
                        </div>
                      </div>
                      <div>
                        <label className="block text-[10px] uppercase text-slate-500 font-bold mb-1">Observações / Instruções</label>
                        <input type="text" placeholder="Ex: Enviar todos os tamanhos" value={prod.observacoes || ''} onChange={e => { const nl = [...editingDemanda.produtosLista!]; nl[idx].observacoes = e.target.value; setEditingDemanda({...editingDemanda, produtosLista: nl}); }} className="w-full text-xs p-1.5 border rounded" />
                      </div>
                    </div>
                  ))}
                </div>
              </section>

              {/* F. Equipamentos e serviços */}
              <section>
                <div className="flex justify-between items-center mb-3 border-b pb-1">
                  <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider">F. Equipamentos e Serviços</h3>
                  <button onClick={() => setEditingDemanda({...editingDemanda, equipamentosLista: [...(editingDemanda.equipamentosLista || []), { id: Date.now().toString(), tipo: 'equipamento', descricao: '', quantidade: '1', observacoes: '' }]})} className="text-xs font-bold text-primary-600 hover:text-primary-800 flex items-center gap-1">
                    <Plus className="w-3 h-3"/> Adicionar Item
                  </button>
                </div>
                <div className="space-y-3">
                  {(!editingDemanda.equipamentosLista || editingDemanda.equipamentosLista.length === 0) && (
                    <p className="text-xs text-slate-500 italic">Nenhum equipamento/serviço adicionado.</p>
                  )}
                  {editingDemanda.equipamentosLista?.map((eq, idx) => (
                    <div key={eq.id} className="p-3 bg-slate-50 border border-slate-200 rounded relative">
                      <button onClick={() => setEditingDemanda({...editingDemanda, equipamentosLista: editingDemanda.equipamentosLista?.filter((_, i) => i !== idx)})} className="absolute top-2 right-2 text-red-500 hover:text-red-700"><Trash2 className="w-4 h-4"/></button>
                      <div className="grid grid-cols-4 gap-3 pr-6 mb-2">
                        <div>
                          <label className="block text-[10px] uppercase text-slate-500 font-bold mb-1">Tipo</label>
                          <select value={eq.tipo} onChange={e => { const nl = [...editingDemanda.equipamentosLista!]; nl[idx].tipo = e.target.value as 'equipamento'|'servico'; setEditingDemanda({...editingDemanda, equipamentosLista: nl}); }} className="w-full text-xs p-1.5 border rounded bg-white">
                            <option value="equipamento">Equipamento</option>
                            <option value="servico">Serviço</option>
                          </select>
                        </div>
                        <div className="col-span-2">
                          <label className="block text-[10px] uppercase text-slate-500 font-bold mb-1">Descrição</label>
                          <input type="text" value={eq.descricao} onChange={e => { const nl = [...editingDemanda.equipamentosLista!]; nl[idx].descricao = e.target.value; setEditingDemanda({...editingDemanda, equipamentosLista: nl}); }} className="w-full text-xs p-1.5 border rounded" />
                        </div>
                        <div>
                          <label className="block text-[10px] uppercase text-slate-500 font-bold mb-1">Qtd.</label>
                          <input type="text" value={eq.quantidade || ''} onChange={e => { const nl = [...editingDemanda.equipamentosLista!]; nl[idx].quantidade = e.target.value; setEditingDemanda({...editingDemanda, equipamentosLista: nl}); }} className="w-full text-xs p-1.5 border rounded" />
                        </div>
                      </div>
                      <div>
                        <label className="block text-[10px] uppercase text-slate-500 font-bold mb-1">Observações</label>
                        <input type="text" value={eq.observacoes || ''} onChange={e => { const nl = [...editingDemanda.equipamentosLista!]; nl[idx].observacoes = e.target.value; setEditingDemanda({...editingDemanda, equipamentosLista: nl}); }} className="w-full text-xs p-1.5 border rounded" />
                      </div>
                    </div>
                  ))}
                </div>
              </section>

              {/* G. Representante e controles operacionais */}
              <section>
                <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider mb-3 border-b pb-1">G. Representante e Controles</h3>
                <div className="grid grid-cols-2 gap-4 mb-4">
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Representante</label>
                    <input type="text" value={editingDemanda.representante || ''} onChange={e => setEditingDemanda({...editingDemanda, representante: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500" />
                  </div>
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Confirmação</label>
                    <select value={editingDemanda.confirmacao || 'SEM DADOS'} onChange={e => setEditingDemanda({...editingDemanda, confirmacao: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 bg-white">
                      <option value="SEM DADOS">Sem Dados</option>
                      <option value="CONFIRMADO">Confirmado</option>
                      <option value="PENDENTE">Pendente</option>
                    </select>
                  </div>
                </div>
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Observações Gerais da Demanda</label>
                  <textarea rows={2} value={editingDemanda.observacoes || ''} onChange={e => setEditingDemanda({...editingDemanda, observacoes: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500"></textarea>
                </div>
              </section>

              {/* H. Valor do freelancer, emergência e retorno */}
              <section>
                <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider mb-3 border-b pb-1">H. Operacional Financeiro</h3>
                <div className="grid grid-cols-3 gap-4">
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Valor Free (R$)</label>
                    <input type="text" placeholder="Ex: 300,00" value={editingDemanda.valorFreelancer || ''} onChange={e => setEditingDemanda({...editingDemanda, valorFreelancer: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500" />
                  </div>
                  <div>
                    <label className="block text-sm font-medium text-slate-700 mb-1">Retorno OF</label>
                    <select value={editingDemanda.retornoOp || 'NÃO RETORNADO'} onChange={e => setEditingDemanda({...editingDemanda, retornoOp: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 bg-white">
                      <option value="NÃO RETORNADO">Não retornado</option>
                      <option value="RETORNADO">Retornado</option>
                    </select>
                  </div>
                  <div className="flex flex-col justify-center pt-5">
                    <label className="flex items-center gap-2 text-sm font-medium text-slate-700 cursor-pointer">
                      <input type="checkbox" checked={editingDemanda.emergencia || false} onChange={e => setEditingDemanda({...editingDemanda, emergencia: e.target.checked})} className="w-4 h-4 text-red-600 rounded border-slate-300 focus:ring-red-500" />
                      Emergência?
                    </label>
                  </div>
                </div>
              </section>
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
