import { Users, FileText, CheckCircle, Clock } from 'lucide-react';
import { useStore } from '../../store/useStore';

export default function DashboardCoordenadora() {
  const { instrumentadores, demandas, convites } = useStore();

  const disponíveis = instrumentadores.filter(i => i.validado).length;
  const abertas = demandas.filter(d => d.status === 'pendente' || d.status === 'alocando').length;
  const pendentes = convites.filter(c => c.status === 'aguardando').length;
  const confirmados = demandas.filter(d => d.status === 'confirmado').length;

  const stats = [
    { title: 'Profissionais Validados', value: disponíveis, icon: Users, color: 'text-blue-600', bg: 'bg-blue-100' },
    { title: 'Demandas Abertas', value: abertas, icon: FileText, color: 'text-amber-600', bg: 'bg-amber-100' },
    { title: 'Convites Pendentes', value: pendentes, icon: Clock, color: 'text-orange-600', bg: 'bg-orange-100' },
    { title: 'Procedimentos Confirmados', value: confirmados, icon: CheckCircle, color: 'text-emerald-600', bg: 'bg-emerald-100' },
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
            {demandas.filter(d => d.status === 'pendente' || d.status === 'alocando').map(d => (
              <div key={d.id} className="flex items-center justify-between p-3 bg-amber-50 rounded-lg border border-amber-100">
                <div>
                  <p className="font-semibold text-slate-800">{d.procedimento}</p>
                  <p className="text-sm text-slate-600">{d.data} - Sem alocação</p>
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
                <p className="text-sm font-medium text-slate-800">Sistema Atualizado</p>
                <p className="text-xs text-slate-500">Demonstração Interativa Iniciada</p>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}
