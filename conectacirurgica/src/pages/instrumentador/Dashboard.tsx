import { Calendar as CalendarIcon, MapPin, Clock, AlertTriangle, X, FileText, CheckCircle } from 'lucide-react';
import { useStore } from '../../store/useStore';
import { format, parseISO } from 'date-fns';
import { useState } from 'react';

export default function DashboardInstrumentador() {
  const currentUserId = 1; 
  
  const { demandas, convites, relatorios, responderConvite, solicitarCancelamento, updateRelatorio } = useStore();

  const convitesPendentes = convites
    .filter(c => c.instrumentadorId === currentUserId && c.status === 'aguardando')
    .map(c => {
      const demanda = demandas.find(d => d.id === c.demandaId)!;
      return { ...c, demanda };
    });

  const proximasCirurgias = demandas
    .filter(d => d.instrumentadorId === currentUserId && (d.status === 'confirmado' || d.status === 'cancelamento_solicitado'))
    .sort((a, b) => new Date(`${a.data}T${a.hora}`).getTime() - new Date(`${b.data}T${b.hora}`).getTime());

  const docsPendentes = relatorios.filter(r => r.instrumentadorId === currentUserId && r.status === 'pendente').map(r => {
    const demanda = demandas.find(d => d.id === r.demandaId);
    return { ...r, demanda };
  });

  const [cancelModalOpen, setCancelModalOpen] = useState(false);
  const [selectedCirurgiaId, setSelectedCirurgiaId] = useState<number | null>(null);
  const [motivoCancelamento, setMotivoCancelamento] = useState('');

  const formatDate = (dateStr: string) => {
    try {
      return format(parseISO(dateStr), 'dd/MM/yyyy');
    } catch {
      return dateStr;
    }
  };

  const handleOpenCancel = (id: number) => {
    setSelectedCirurgiaId(id);
    setMotivoCancelamento('');
    setCancelModalOpen(true);
  };

  const handleConfirmCancel = () => {
    if (selectedCirurgiaId && motivoCancelamento.trim()) {
      solicitarCancelamento(selectedCirurgiaId, motivoCancelamento);
      setCancelModalOpen(false);
    }
  };

  return (
    <div className="p-4 space-y-6 max-w-lg mx-auto pb-24">
      {/* Resumo */}
      <div className="grid grid-cols-2 gap-4">
        <div className="bg-primary-600 rounded-2xl p-4 text-white shadow-lg shadow-primary-600/20">
          <p className="text-primary-100 text-sm font-medium mb-1">Confirmadas</p>
          <p className="text-3xl font-bold">{proximasCirurgias.length}</p>
        </div>
        <div className="bg-white rounded-2xl p-4 border border-slate-100 shadow-sm">
          <p className="text-slate-500 text-sm font-medium mb-1">Convites</p>
          <p className="text-3xl font-bold text-slate-800">{convitesPendentes.length}</p>
        </div>
      </div>

      {/* Docs Pendentes */}
      {docsPendentes.length > 0 && (
        <div>
          <h2 className="text-lg font-bold text-amber-900 mb-3 flex items-center justify-between">
            Pendências (Documentos)
            <span className="bg-amber-500 text-white text-xs px-2 py-0.5 rounded-full">{docsPendentes.length} pendentes</span>
          </h2>
          <div className="space-y-3">
            {docsPendentes.map((d) => (
              <div key={d.id} className="bg-amber-50 border border-amber-200 rounded-2xl p-4 shadow-sm relative overflow-hidden">
                <div className="flex items-start gap-3">
                  <div className="p-2 bg-amber-100 rounded-full shrink-0">
                    <FileText className="w-5 h-5 text-amber-600" />
                  </div>
                  <div className="flex-1">
                    <h3 className="font-bold text-amber-900 leading-tight">Enviar {d.tipo}</h3>
                    <p className="text-sm text-amber-800 mt-1">{d.demanda?.procedimento}</p>
                    <p className="text-xs text-amber-700 mt-0.5">Cirurgia do dia {formatDate(d.demanda?.data || '')}</p>
                    <button 
                      onClick={() => updateRelatorio(d.id, 'recebido')}
                      className="mt-3 bg-white text-emerald-600 border border-emerald-200 hover:bg-emerald-50 w-full py-2 rounded-xl text-sm font-bold flex items-center justify-center gap-2 transition-colors"
                    >
                      <CheckCircle className="w-4 h-4"/> Enviar Documento (Simulação)
                    </button>
                  </div>
                </div>
              </div>
            ))}
          </div>
        </div>
      )}

      {/* Convites Pendentes */}
      {convitesPendentes.length > 0 && (
        <div>
          <h2 className="text-lg font-bold text-slate-900 mb-3 flex items-center justify-between">
            Novos Convites
            <span className="bg-red-500 text-white text-xs px-2 py-0.5 rounded-full">{convitesPendentes.length} pendentes</span>
          </h2>
          <div className="space-y-3">
            {convitesPendentes.map((c) => (
              <div key={c.id} className="bg-white border-2 border-primary-100 rounded-2xl p-4 shadow-sm relative overflow-hidden">
                <div className="absolute top-0 right-0 w-20 h-20 bg-primary-50 rounded-bl-full -mr-4 -mt-4 z-0"></div>
                
                <div className="relative z-10 mb-4">
                  <span className="inline-block px-2 py-1 bg-primary-100 text-primary-700 text-xs font-bold rounded mb-2 uppercase tracking-wider">
                    Convite Recebido
                  </span>
                  <h3 className="font-bold text-lg text-slate-900 leading-tight">{c.demanda?.procedimento}</h3>
                  <p className="text-sm text-slate-600 mt-1">{c.demanda?.medico}</p>
                  {c.demanda?.valorFreelancer && (
                    <p className="text-sm font-bold text-emerald-600 mt-1">Valor: {c.demanda?.valorFreelancer}</p>
                  )}
                </div>

                <div className="grid grid-cols-2 gap-3 mb-5 relative z-10 bg-slate-50 p-3 rounded-xl">
                  <div className="flex items-center gap-2 text-slate-600">
                    <CalendarIcon className="w-4 h-4 text-slate-400" />
                    <span className="text-sm font-medium">{formatDate(c.demanda?.data || '')}</span>
                  </div>
                  <div className="flex items-center gap-2 text-slate-600">
                    <Clock className="w-4 h-4 text-slate-400" />
                    <span className="text-sm font-medium">{c.demanda?.hora}</span>
                  </div>
                  <div className="col-span-2 flex items-center gap-2 text-slate-600">
                    <MapPin className="w-4 h-4 text-slate-400 shrink-0" />
                    <span className="text-sm font-medium truncate">{c.demanda?.hospital}</span>
                  </div>
                </div>

                <div className="flex gap-3 relative z-10">
                  <button 
                    onClick={() => responderConvite(c.id, 'recusado')}
                    className="flex-1 bg-white border-2 border-slate-200 text-slate-700 py-2.5 rounded-xl font-bold text-sm hover:bg-slate-50 hover:border-slate-300 transition-colors"
                  >
                    Recusar
                  </button>
                  <button 
                    onClick={() => responderConvite(c.id, 'aceito')}
                    className="flex-1 bg-primary-600 text-white py-2.5 rounded-xl font-bold text-sm shadow-md shadow-primary-500/20 hover:bg-primary-700 transition-colors"
                  >
                    Aceitar
                  </button>
                </div>
              </div>
            ))}
          </div>
        </div>
      )}

      {/* Próximas Cirurgias */}
      <div>
        <h2 className="text-lg font-bold text-slate-900 mb-3">Minha Agenda</h2>
        
        {proximasCirurgias.length === 0 ? (
          <div className="bg-slate-50 rounded-2xl border border-slate-100 p-8 text-center">
            <div className="w-12 h-12 bg-slate-200 rounded-full flex items-center justify-center mx-auto mb-3">
              <CalendarIcon className="w-6 h-6 text-slate-400" />
            </div>
            <p className="text-slate-500 font-medium">Nenhuma cirurgia agendada no momento.</p>
          </div>
        ) : (
          <div className="space-y-3">
            {proximasCirurgias.map((d) => (
              <div key={d.id} className="bg-white border border-slate-100 rounded-2xl p-4 shadow-sm flex flex-col gap-3">
                <div className="flex justify-between items-start">
                  <div>
                    <h3 className="font-bold text-slate-900">{d.procedimento}</h3>
                    <p className="text-sm text-slate-500">{d.hospital}</p>
                    {d.valorFreelancer && (
                      <p className="text-sm font-medium text-emerald-600 mt-1">{d.valorFreelancer}</p>
                    )}
                  </div>
                  <div className="text-right">
                    <p className="text-sm font-bold text-primary-600">{formatDate(d.data)}</p>
                    <p className="text-xs text-slate-500">{d.hora}</p>
                  </div>
                </div>
                
                {d.status === 'cancelamento_solicitado' ? (
                  <div className="bg-amber-50 text-amber-800 text-xs font-bold p-2 rounded flex items-center gap-2 border border-amber-200">
                    <AlertTriangle className="w-4 h-4" /> Cancelamento Solicitado
                  </div>
                ) : (
                  <div className="flex justify-end pt-2 border-t border-slate-50">
                    <button 
                      onClick={() => handleOpenCancel(d.id)}
                      className="text-xs font-medium text-red-500 hover:text-red-700 hover:underline"
                    >
                      Solicitar Cancelamento
                    </button>
                  </div>
                )}
              </div>
            ))}
          </div>
        )}
      </div>

      {cancelModalOpen && (
        <div className="fixed inset-0 z-50 flex items-center justify-center p-4 bg-slate-900/50 backdrop-blur-sm">
          <div className="bg-white rounded-xl shadow-xl w-full max-w-sm overflow-hidden flex flex-col">
            <div className="flex justify-between items-center p-4 border-b border-slate-100">
              <h2 className="text-lg font-bold text-slate-900">Solicitar Cancelamento</h2>
              <button onClick={() => setCancelModalOpen(false)} className="text-slate-400 hover:text-slate-600">
                <X className="w-5 h-5" />
              </button>
            </div>
            <div className="p-4 space-y-4">
              <p className="text-sm text-slate-600">Ao solicitar o cancelamento, a coordenação será notificada para aprovação e substituição.</p>
              <div>
                <label className="block text-sm font-medium text-slate-700 mb-1">Motivo do cancelamento (Obrigatório)</label>
                <textarea 
                  rows={3}
                  value={motivoCancelamento}
                  onChange={(e) => setMotivoCancelamento(e.target.value)}
                  className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 focus:border-primary-500"
                  placeholder="Descreva brevemente o motivo..."
                ></textarea>
              </div>
            </div>
            <div className="p-4 border-t border-slate-100 bg-slate-50 flex justify-end gap-2">
              <button onClick={() => setCancelModalOpen(false)} className="px-4 py-2 text-sm font-medium text-slate-600">Voltar</button>
              <button 
                onClick={handleConfirmCancel} 
                disabled={!motivoCancelamento.trim()}
                className="px-4 py-2 bg-red-600 text-white rounded text-sm font-medium hover:bg-red-700 disabled:opacity-50"
              >
                Confirmar Solicitação
              </button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
}
