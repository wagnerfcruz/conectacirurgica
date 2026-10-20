import { Users, FileText, CheckCircle, Clock, AlertTriangle } from 'lucide-react';
import { useStore } from '../../store/useStore';
import { useNavigate } from 'react-router-dom';

export default function DashboardCoordenadora() {
  const { instrumentadores, demandas, convites, relatorios } = useStore();
  const navigate = useNavigate();

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

  // Identificando pendências reais
  const cancelamentosSolicitados = demandas.filter(d => d.status === 'cancelamento_solicitado');
  const documentosPendentes = relatorios.filter(r => r.status === 'pendente');
  const demandasSemAlocacao = demandas.filter(d => d.status === 'pendente' || d.status === 'alocando');

  const atividades = [
    ...convites.slice(-3).reverse().map(c => ({
      id: `conv_${c.id}`,
      text: `Convite ${c.status} para a demanda ${c.demandaId}`,
      color: c.status === 'aceito' ? 'bg-emerald-500' : c.status === 'recusado' ? 'bg-red-500' : 'bg-amber-500'
    })),
    ...relatorios.slice(-2).reverse().map(r => ({
      id: `rel_${r.id}`,
      text: `Documento ${r.tipo} de demanda ${r.demandaId} ${r.status}`,
      color: r.status === 'recebido' ? 'bg-emerald-500' : 'bg-blue-500'
    }))
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
          <h3 className="text-lg font-bold text-slate-900 mb-4 flex items-center gap-2">
            <AlertTriangle className="w-5 h-5 text-amber-500" /> Atenção Necessária
          </h3>
          <div className="space-y-3">
            
            {cancelamentosSolicitados.map(d => (
              <div key={`canc_${d.id}`} className="flex items-center justify-between p-3 bg-red-50 rounded-lg border border-red-100">
                <div>
                  <p className="font-semibold text-slate-800">{d.procedimento}</p>
                  <p className="text-sm text-red-600 font-medium">Cancelamento Solicitado!</p>
                </div>
                <button onClick={() => navigate('/coordenadora/acionamentos')} className="text-sm font-medium text-red-600 hover:text-red-700">Verificar</button>
              </div>
            ))}

            {demandasSemAlocacao.map(d => (
              <div key={`dem_${d.id}`} className="flex items-center justify-between p-3 bg-amber-50 rounded-lg border border-amber-100">
                <div>
                  <p className="font-semibold text-slate-800">{d.procedimento}</p>
                  <p className="text-sm text-amber-700">{d.data} - Aguardando alocação</p>
                </div>
                <button onClick={() => navigate('/coordenadora/acionamentos')} className="text-sm font-medium text-amber-600 hover:text-amber-700">Verificar</button>
              </div>
            ))}

            {documentosPendentes.map(r => (
              <div key={`doc_${r.id}`} className="flex items-center justify-between p-3 bg-blue-50 rounded-lg border border-blue-100">
                <div>
                  <p className="font-semibold text-slate-800">Falta {r.tipo}</p>
                  <p className="text-sm text-blue-700">Demanda: {r.demandaId}</p>
                </div>
                <button onClick={() => navigate('/coordenadora/documentos')} className="text-sm font-medium text-blue-600 hover:text-blue-700">Verificar</button>
              </div>
            ))}

            {cancelamentosSolicitados.length === 0 && demandasSemAlocacao.length === 0 && documentosPendentes.length === 0 && (
              <p className="text-slate-500 text-sm italic">Nenhuma pendência crítica no momento.</p>
            )}

          </div>
        </div>

        <div className="bg-white rounded-xl p-6 shadow-sm border border-slate-100">
          <h3 className="text-lg font-bold text-slate-900 mb-4">Atividades Recentes</h3>
          <div className="space-y-4">
            {atividades.map((ativ) => (
              <div key={ativ.id} className="flex gap-3">
                <div className={`w-2 h-2 mt-2 rounded-full ${ativ.color} shrink-0`}></div>
                <div>
                  <p className="text-sm font-medium text-slate-800">{ativ.text}</p>
                  <p className="text-xs text-slate-500">Hoje</p>
                </div>
              </div>
            ))}
            {atividades.length === 0 && (
              <p className="text-slate-500 text-sm italic">Nenhuma atividade recente.</p>
            )}
          </div>
        </div>
      </div>
    </div>
  );
}
