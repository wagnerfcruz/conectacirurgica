import { Users, FileText, CheckCircle, Clock } from 'lucide-react';

export default function DashboardCoordenadora() {
  const stats = [
    { title: 'Profissionais Disponíveis', value: '24', icon: Users, color: 'text-blue-600', bg: 'bg-blue-100' },
    { title: 'Demandas Abertas', value: '7', icon: FileText, color: 'text-amber-600', bg: 'bg-amber-100' },
    { title: 'Convites Pendentes', value: '3', icon: Clock, color: 'text-orange-600', bg: 'bg-orange-100' },
    { title: 'Procedimentos Confirmados', value: '12', icon: CheckCircle, color: 'text-emerald-600', bg: 'bg-emerald-100' },
  ];

  return (
    <div className="space-y-6">
      <div>
        <h1 className="text-2xl font-bold text-slate-900">Visão Geral</h1>
        <p className="text-slate-500">Acompanhe as métricas de alocação de hoje.</p>
      </div>

      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-4">
        {stats.map((stat, i) => (
          <div key={i} className="bg-white rounded-xl p-6 shadow-sm border border-slate-100 flex items-center gap-4">
            <div className={`w-12 h-12 rounded-lg flex items-center justify-center ${stat.bg}`}>
              <stat.icon className={`w-6 h-6 ${stat.color}`} />
            </div>
            <div>
              <p className="text-sm font-medium text-slate-500">{stat.title}</p>
              <h3 className="text-2xl font-bold text-slate-900">{stat.value}</h3>
            </div>
          </div>
        ))}
      </div>

      <div className="grid grid-cols-1 lg:grid-cols-2 gap-6">
        <div className="bg-white rounded-xl p-6 shadow-sm border border-slate-100">
          <h3 className="text-lg font-bold text-slate-900 mb-4">Atenção Necessária</h3>
          <div className="space-y-3">
            {[1, 2, 3].map(i => (
              <div key={i} className="flex items-center justify-between p-3 bg-amber-50 rounded-lg border border-amber-100">
                <div>
                  <p className="font-semibold text-slate-800">Artroplastia de Quadril</p>
                  <p className="text-sm text-slate-600">Faltam 2 dias - Sem alocação</p>
                </div>
                <button className="text-sm font-medium text-primary-600 hover:text-primary-700">Verificar</button>
              </div>
            ))}
          </div>
        </div>

        <div className="bg-white rounded-xl p-6 shadow-sm border border-slate-100">
          <h3 className="text-lg font-bold text-slate-900 mb-4">Atividades Recentes</h3>
          <div className="space-y-4">
            <div className="flex gap-3">
              <div className="w-2 h-2 mt-2 rounded-full bg-emerald-500"></div>
              <div>
                <p className="text-sm font-medium text-slate-800">João Silva aceitou o convite</p>
                <p className="text-xs text-slate-500">Há 5 minutos - Hosp. Santa Catarina</p>
              </div>
            </div>
            <div className="flex gap-3">
              <div className="w-2 h-2 mt-2 rounded-full bg-amber-500"></div>
              <div>
                <p className="text-sm font-medium text-slate-800">Maria Oliveira atualizou disponibilidade</p>
                <p className="text-xs text-slate-500">Há 30 minutos - Amanhã (Manhã)</p>
              </div>
            </div>
            <div className="flex gap-3">
              <div className="w-2 h-2 mt-2 rounded-full bg-blue-500"></div>
              <div>
                <p className="text-sm font-medium text-slate-800">Novo mapa cirúrgico importado</p>
                <p className="text-xs text-slate-500">Há 2 horas - 15 registros</p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}
