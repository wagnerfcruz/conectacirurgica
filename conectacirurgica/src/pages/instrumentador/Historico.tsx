import { CheckCircle, XCircle, Clock } from 'lucide-react';

export default function Historico() {
  const historico = [
    { id: 1, data: '18/10/2026', hospital: 'Hospital Santa Catarina', especialidade: 'Ortopedia', status: 'realizado' },
    { id: 2, data: '15/10/2026', hospital: 'Hospital Sírio-Libanês', especialidade: 'Coluna', status: 'realizado' },
    { id: 3, data: '10/10/2026', hospital: 'Hospital das Clínicas', especialidade: 'Ortopedia', status: 'cancelado' },
    { id: 4, data: '05/10/2026', hospital: 'Hospital São Luiz', especialidade: 'Crânio', status: 'realizado' },
  ];

  return (
    <div className="p-4 space-y-4">
      <header className="mb-6">
        <h2 className="text-xl font-bold text-slate-900">Histórico</h2>
        <p className="text-sm text-slate-500">Últimos procedimentos atendidos</p>
      </header>

      <div className="space-y-3">
        {historico.map((item) => (
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
                <span className="text-xs text-slate-500 whitespace-nowrap ml-2">{item.data}</span>
              </div>
              <p className="text-sm text-slate-600 mb-2">{item.especialidade}</p>
              
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
        ))}
      </div>
    </div>
  );
}
