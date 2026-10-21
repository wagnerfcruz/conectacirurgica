import { CheckCircle, XCircle, Clock, CalendarIcon } from 'lucide-react';
import { useStore } from '../../store/useStore';
import { format, parseISO } from 'date-fns';

export default function Historico() {
  const currentUserId = 1;
  const { demandas } = useStore();

  const historico = demandas
    .filter(d => d.instrumentadorId === currentUserId && (d.status === 'realizado' || d.status === 'cancelado'))
    .sort((a, b) => new Date(`${b.data}T${b.hora}`).getTime() - new Date(`${a.data}T${a.hora}`).getTime());

  const formatDate = (dateStr: string) => {
    try {
      return format(parseISO(dateStr), 'dd/MM/yyyy');
    } catch {
      return dateStr;
    }
  };

  return (
    <div className="p-4 space-y-4 max-w-lg mx-auto pb-8">
      <header className="mb-6">
        <h2 className="text-xl font-bold text-slate-900">Histórico</h2>
        <p className="text-sm text-slate-500">Últimos procedimentos atendidos</p>
      </header>

      <div className="space-y-3">
        {historico.length === 0 ? (
          <div className="bg-slate-50 p-8 text-center rounded-2xl border border-slate-100">
            <CalendarIcon className="w-10 h-10 text-slate-300 mx-auto mb-2" />
            <p className="text-slate-500 font-medium">Nenhum histórico disponível ainda.</p>
          </div>
        ) : (
          historico.map((item) => (
            <div key={item.id} className="bg-white p-4 rounded-xl shadow-sm border border-slate-100 flex items-start gap-4">
              <div className="mt-1">
                {item.status === 'realizado' ? (
                  <CheckCircle className="w-6 h-6 text-emerald-500" />
                ) : item.status === 'cancelado' ? (
                  <XCircle className="w-6 h-6 text-red-500" />
                ) : (
                  <Clock className="w-6 h-6 text-amber-500" />
                )}
              </div>
              <div className="flex-1">
                <div className="flex justify-between items-start mb-1">
                  <h4 className="font-semibold text-slate-900">{item.hospital}</h4>
                  <span className="text-xs text-slate-500 whitespace-nowrap ml-2">{formatDate(item.data)}</span>
                </div>
                <p className="text-sm text-slate-600 mb-2">{item.procedimento}</p>
                
                <div className="flex items-center gap-2">
                  <span className={`inline-flex px-2 py-0.5 rounded text-xs font-medium uppercase tracking-wider
                    ${item.status === 'realizado' ? 'bg-emerald-50 text-emerald-700 border border-emerald-200' : ''}
                    ${item.status === 'cancelado' ? 'bg-red-50 text-red-700 border border-red-200' : ''}
                  `}>
                    {item.status}
                  </span>
                </div>
              </div>
            </div>
          ))
        )}
      </div>
    </div>
  );
}
