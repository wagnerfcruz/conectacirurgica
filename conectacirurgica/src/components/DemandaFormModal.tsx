import { useState, useEffect } from 'react';
import { X, Plus, Trash2 } from 'lucide-react';
import type { Demanda } from '../store/useStore';

interface Props {
  isOpen: boolean;
  onClose: () => void;
  demanda: Partial<Demanda>;
  onSave: (d: Partial<Demanda>) => void;
}

export default function DemandaFormModal({ isOpen, onClose, demanda: initialDemanda, onSave }: Props) {
  const [demanda, setDemanda] = useState<Partial<Demanda>>(initialDemanda);

  useEffect(() => {
    setDemanda(initialDemanda);
  }, [initialDemanda, isOpen]);

  if (!isOpen) return null;

  return (
    <div className="fixed inset-0 z-50 flex items-center justify-center p-4 bg-slate-900/50 backdrop-blur-sm overflow-y-auto">
      <div className="bg-white rounded-xl shadow-xl w-full max-w-4xl flex flex-col my-auto max-h-[90vh]">
        <div className="flex justify-between items-center p-6 border-b border-slate-100 shrink-0">
          <h2 className="text-xl font-bold text-slate-900">{demanda.id ? 'Editar Demanda / Ver Detalhes' : 'Nova Demanda'}</h2>
          <button onClick={onClose} className="text-slate-400 hover:text-slate-600">
            <X className="w-6 h-6" />
          </button>
        </div>
        
        <div className="p-6 overflow-y-auto flex-1 custom-scrollbar">
          <div className="space-y-6">
            
            {/* A. Info Principais */}
            <section className="bg-slate-50 p-4 rounded-xl border border-slate-100">
              <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider mb-3 border-b pb-1">A. Informações do Evento</h3>
              <div className="grid grid-cols-2 gap-4">
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Código MC</label>
                  <input type="text" value={demanda.mc || ''} onChange={e => setDemanda({...demanda, mc: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white" />
                </div>
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Tipo de Evento</label>
                  <select value={demanda.tipoEvento || 'AGENDAMENTO'} onChange={e => setDemanda({...demanda, tipoEvento: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white">
                    <option value="AGENDAMENTO">Agendamento</option>
                    <option value="REAGENDAMENTO">Reagendamento</option>
                    <option value="CANCELAMENTO">Cancelamento</option>
                  </select>
                </div>
              </div>
            </section>

            {/* B. Paciente, empresa e convênio */}
            <section className="bg-slate-50 p-4 rounded-xl border border-slate-100">
              <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider mb-3 border-b pb-1">B. Paciente, Empresa e Convênio</h3>
              <div className="grid grid-cols-1 gap-4 mb-4">
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Paciente</label>
                  <input type="text" value={demanda.paciente || ''} onChange={e => setDemanda({...demanda, paciente: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white" />
                </div>
              </div>
              <div className="grid grid-cols-2 gap-4">
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Empresa</label>
                  <input type="text" value={demanda.empresa || ''} onChange={e => setDemanda({...demanda, empresa: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white" />
                </div>
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Convênio</label>
                  <input type="text" value={demanda.convenio || ''} onChange={e => setDemanda({...demanda, convenio: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white" />
                </div>
              </div>
            </section>

            {/* C. Local e Data */}
            <section className="bg-slate-50 p-4 rounded-xl border border-slate-100">
              <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider mb-3 border-b pb-1">C. Local e Data</h3>
              <div className="grid grid-cols-2 gap-4 mb-4">
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Hospital</label>
                  <input type="text" value={demanda.hospital || ''} onChange={e => setDemanda({...demanda, hospital: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white" />
                </div>
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Unidade/Local Complementar</label>
                  <input type="text" value={demanda.unidadeLocal || ''} onChange={e => setDemanda({...demanda, unidadeLocal: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white" />
                </div>
              </div>
              <div className="grid grid-cols-2 gap-4">
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Data</label>
                  <input type="date" value={demanda.data || ''} onChange={e => setDemanda({...demanda, data: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white" />
                </div>
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Horário</label>
                  <input type="time" value={demanda.hora || ''} onChange={e => setDemanda({...demanda, hora: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white" />
                </div>
              </div>
            </section>

            {/* D. Médico e Procedimento */}
            <section className="bg-slate-50 p-4 rounded-xl border border-slate-100">
              <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider mb-3 border-b pb-1">D. Médico e Procedimento</h3>
              <div className="grid grid-cols-2 gap-4">
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Médico Responsável</label>
                  <input type="text" value={demanda.medico || ''} onChange={e => setDemanda({...demanda, medico: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white" />
                </div>
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Procedimento Cirúrgico</label>
                  <input type="text" value={demanda.procedimento || ''} onChange={e => setDemanda({...demanda, procedimento: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white" />
                </div>
              </div>
            </section>

            {/* E. Produtos / Materiais */}
            <section className="bg-slate-50 p-4 rounded-xl border border-slate-100">
              <div className="flex justify-between items-center mb-3 border-b pb-1">
                <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider">E. Produtos / Materiais</h3>
                <button onClick={() => setDemanda({...demanda, produtosLista: [...(demanda.produtosLista||[]), { id: crypto.randomUUID(), descricao: '', quantidade: '1', codigoReferencia: '' }]})} className="text-xs flex items-center gap-1 bg-white border border-slate-300 px-2 py-1 rounded text-slate-700 hover:bg-slate-100">
                  <Plus className="w-3 h-3"/> Adicionar
                </button>
              </div>
              <div className="space-y-3">
                {(demanda.produtosLista || []).map((prod, idx) => (
                  <div key={idx} className="bg-white p-3 rounded border border-slate-200 relative flex gap-2">
                    <div className="flex-1 grid grid-cols-1 md:grid-cols-3 gap-2">
                      <div className="md:col-span-2">
                        <label className="block text-[10px] uppercase text-slate-500 font-bold mb-1">Produto</label>
                        <input type="text" value={prod.descricao} onChange={e => { const nl = [...demanda.produtosLista!]; nl[idx].descricao = e.target.value; setDemanda({...demanda, produtosLista: nl}); }} className="w-full text-xs p-1.5 border rounded" />
                      </div>
                      <div>
                        <label className="block text-[10px] uppercase text-slate-500 font-bold mb-1">Qtd.</label>
                        <input type="text" value={prod.quantidade || ''} onChange={e => { const nl = [...demanda.produtosLista!]; nl[idx].quantidade = e.target.value; setDemanda({...demanda, produtosLista: nl}); }} className="w-full text-xs p-1.5 border rounded" />
                      </div>
                    </div>
                    <button onClick={() => { const nl = demanda.produtosLista!.filter((_, i) => i !== idx); setDemanda({...demanda, produtosLista: nl}); }} className="text-red-500 hover:text-red-700 self-center p-2">
                      <Trash2 className="w-4 h-4"/>
                    </button>
                  </div>
                ))}
                {(!demanda.produtosLista || demanda.produtosLista.length === 0) && (
                  <p className="text-xs text-slate-500 italic">Nenhum produto listado.</p>
                )}
              </div>
            </section>

            {/* F. Equipamentos / Serviços */}
            <section className="bg-slate-50 p-4 rounded-xl border border-slate-100">
              <div className="flex justify-between items-center mb-3 border-b pb-1">
                <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider">F. Equipamentos / Serviços</h3>
                <button onClick={() => setDemanda({...demanda, equipamentosLista: [...(demanda.equipamentosLista||[]), { id: crypto.randomUUID(), tipo: 'servico', descricao: '', quantidade: '1' }]})} className="text-xs flex items-center gap-1 bg-white border border-slate-300 px-2 py-1 rounded text-slate-700 hover:bg-slate-100">
                  <Plus className="w-3 h-3"/> Adicionar
                </button>
              </div>
              <div className="space-y-3">
                {(demanda.equipamentosLista || []).map((eq, idx) => (
                  <div key={idx} className="bg-white p-3 rounded border border-slate-200 relative flex gap-2">
                    <div className="flex-1 grid grid-cols-1 md:grid-cols-4 gap-2">
                      <div>
                        <label className="block text-[10px] uppercase text-slate-500 font-bold mb-1">Tipo</label>
                        <select value={eq.tipo} onChange={e => { const nl = [...demanda.equipamentosLista!]; nl[idx].tipo = e.target.value as 'equipamento'|'servico'; setDemanda({...demanda, equipamentosLista: nl}); }} className="w-full text-xs p-1.5 border rounded bg-white">
                          <option value="equipamento">Equipamento</option>
                          <option value="servico">Serviço</option>
                        </select>
                      </div>
                      <div className="md:col-span-2">
                        <label className="block text-[10px] uppercase text-slate-500 font-bold mb-1">Descrição</label>
                        <input type="text" value={eq.descricao} onChange={e => { const nl = [...demanda.equipamentosLista!]; nl[idx].descricao = e.target.value; setDemanda({...demanda, equipamentosLista: nl}); }} className="w-full text-xs p-1.5 border rounded" />
                      </div>
                      <div>
                        <label className="block text-[10px] uppercase text-slate-500 font-bold mb-1">Qtd.</label>
                        <input type="text" value={eq.quantidade || ''} onChange={e => { const nl = [...demanda.equipamentosLista!]; nl[idx].quantidade = e.target.value; setDemanda({...demanda, equipamentosLista: nl}); }} className="w-full text-xs p-1.5 border rounded" />
                      </div>
                    </div>
                    <button onClick={() => { const nl = demanda.equipamentosLista!.filter((_, i) => i !== idx); setDemanda({...demanda, equipamentosLista: nl}); }} className="text-red-500 hover:text-red-700 self-center p-2">
                      <Trash2 className="w-4 h-4"/>
                    </button>
                  </div>
                ))}
                {(!demanda.equipamentosLista || demanda.equipamentosLista.length === 0) && (
                  <p className="text-xs text-slate-500 italic">Nenhum equipamento/serviço listado.</p>
                )}
              </div>
            </section>

            {/* G. Informações Finais */}
            <section className="bg-slate-50 p-4 rounded-xl border border-slate-100">
              <h3 className="text-sm font-bold text-slate-800 uppercase tracking-wider mb-3 border-b pb-1">G. Informações Finais</h3>
              <div className="grid grid-cols-2 gap-4 mb-4">
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Representante</label>
                  <input type="text" value={demanda.representante || ''} onChange={e => setDemanda({...demanda, representante: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white" />
                </div>
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Confirmação</label>
                  <select value={demanda.confirmacao || 'SEM DADOS'} onChange={e => setDemanda({...demanda, confirmacao: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white">
                    <option value="SEM DADOS">Sem Dados</option>
                    <option value="CONFIRMADO">Confirmado</option>
                    <option value="PENDENTE">Pendente</option>
                  </select>
                </div>
              </div>
              <div className="mb-4">
                <label className="block text-sm font-medium text-slate-700 mb-1">Observações Gerais da Demanda</label>
                <textarea rows={2} value={demanda.observacoes || ''} onChange={e => setDemanda({...demanda, observacoes: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white"></textarea>
              </div>
              <div className="grid grid-cols-3 gap-4">
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Valor Free (R$)</label>
                  <input type="text" placeholder="Ex: 300,00" value={demanda.valorFreelancer || ''} onChange={e => setDemanda({...demanda, valorFreelancer: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white" />
                </div>
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Retorno OF</label>
                  <select value={demanda.retornoOp || 'NÃO RETORNADO'} onChange={e => setDemanda({...demanda, retornoOp: e.target.value})} className="w-full border border-slate-300 rounded-md p-2 text-sm bg-white">
                    <option value="NÃO RETORNADO">Não retornado</option>
                    <option value="RETORNADO">Retornado</option>
                  </select>
                </div>
                <div className="flex flex-col justify-center pt-5">
                  <label className="flex items-center gap-2 text-sm font-medium text-slate-700 cursor-pointer">
                    <input type="checkbox" checked={demanda.emergencia || false} onChange={e => setDemanda({...demanda, emergencia: e.target.checked})} className="w-4 h-4 text-red-600 rounded border-slate-300" />
                    Emergência?
                  </label>
                </div>
              </div>
            </section>
          </div>
        </div>

        <div className="p-6 border-t border-slate-100 bg-slate-50 flex justify-end gap-3 shrink-0">
          <button onClick={onClose} className="px-6 py-2 border border-slate-300 rounded-lg text-slate-700 font-medium hover:bg-white transition-colors">
            Cancelar
          </button>
          <button onClick={() => onSave(demanda)} className="px-6 py-2 bg-primary-600 text-white rounded-lg font-bold hover:bg-primary-700 transition-colors shadow-sm">
            Salvar Alterações
          </button>
        </div>
      </div>
    </div>
  );
}
