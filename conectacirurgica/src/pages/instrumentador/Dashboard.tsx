import { Calendar as CalendarIcon, MapPin, Clock } from 'lucide-react';

export default function DashboardInstrumentador() {
  const proximasCirurgias = [
    { id: 1, hospital: 'Hospital Santa Catarina', data: '22/10/2026', hora: '08:00', tipo: 'Artroplastia Total de Joelho', medico: 'Dr. Roberto Almeida' },
    { id: 2, hospital: 'Hospital Sírio-Libanês', data: '24/10/2026', hora: '14:30', tipo: 'Hérnia de Disco', medico: 'Dra. Fernanda Lima' },
  ];

  const convitesPendentes = [
    { id: 101, hospital: 'Hospital das Clínicas', data: '25/10/2026', hora: '10:00', especialidade: 'Ortopedia' }
  ];

  return (
    <div className="p-4 space-y-6">
      <div className="bg-white rounded-xl p-4 shadow-sm border border-slate-100">
        <h2 className="text-lg font-semibold text-slate-800 mb-2">Bem-vindo, João!</h2>
        <p className="text-sm text-slate-500">Você tem <strong className="text-primary-600">{convitesPendentes.length} convite(s)</strong> pendente(s) e <strong className="text-emerald-600">{proximasCirurgias.length} cirurgia(s)</strong> confirmada(s) nesta semana.</p>
      </div>

      {convitesPendentes.length > 0 && (
        <section>
          <div className="flex items-center justify-between mb-3">
            <h3 className="text-sm font-bold text-slate-700 uppercase tracking-wider">Convites Pendentes</h3>
          </div>
          <div className="space-y-3">
            {convitesPendentes.map((convite) => (
              <div key={convite.id} className="bg-amber-50 rounded-xl p-4 border border-amber-200">
                <div className="flex justify-between items-start mb-2">
                  <span className="inline-flex items-center px-2 py-0.5 rounded text-xs font-medium bg-amber-100 text-amber-800">
                    Aguardando Resposta
                  </span>
                  <span className="text-xs font-medium text-amber-800">{convite.especialidade}</span>
                </div>
                <h4 className="font-semibold text-slate-900 text-lg mb-2">{convite.hospital}</h4>
                <div className="flex items-center text-slate-600 text-sm mb-1 gap-2">
                  <CalendarIcon className="w-4 h-4 text-amber-500" /> {convite.data}
                </div>
                <div className="flex items-center text-slate-600 text-sm mb-4 gap-2">
                  <Clock className="w-4 h-4 text-amber-500" /> {convite.hora}
                </div>
                <div className="flex gap-2">
                  <button className="flex-1 bg-emerald-600 hover:bg-emerald-700 text-white py-2 rounded-lg text-sm font-medium transition-colors">
                    Aceitar
                  </button>
                  <button className="flex-1 bg-white border border-slate-300 hover:bg-slate-50 text-slate-700 py-2 rounded-lg text-sm font-medium transition-colors">
                    Recusar
                  </button>
                </div>
              </div>
            ))}
          </div>
        </section>
      )}

      <section>
        <div className="flex items-center justify-between mb-3">
          <h3 className="text-sm font-bold text-slate-700 uppercase tracking-wider">Próximos Compromissos</h3>
        </div>
        <div className="space-y-3">
          {proximasCirurgias.map((cirurgia) => (
            <div key={cirurgia.id} className="bg-white rounded-xl p-4 shadow-sm border border-slate-100 flex flex-col">
              <div className="flex justify-between items-start mb-2">
                <h4 className="font-semibold text-slate-900 leading-tight">{cirurgia.tipo}</h4>
                <span className="inline-flex items-center px-2 py-0.5 rounded text-xs font-medium bg-emerald-100 text-emerald-800 whitespace-nowrap ml-2">
                  Confirmado
                </span>
              </div>
              
              <div className="space-y-1.5 mb-3">
                <div className="flex items-center text-slate-600 text-sm gap-2">
                  <MapPin className="w-4 h-4 text-slate-400" /> {cirurgia.hospital}
                </div>
                <div className="flex items-center text-slate-600 text-sm gap-2">
                  <CalendarIcon className="w-4 h-4 text-slate-400" /> {cirurgia.data}
                </div>
                <div className="flex items-center text-slate-600 text-sm gap-2">
                  <Clock className="w-4 h-4 text-slate-400" /> {cirurgia.hora}
                </div>
              </div>
              
              <div className="mt-auto pt-3 border-t border-slate-100">
                <p className="text-sm text-slate-500">Cirurgião: <span className="font-medium text-slate-700">{cirurgia.medico}</span></p>
              </div>
            </div>
          ))}
        </div>
      </section>
    </div>
  );
}
