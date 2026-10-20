import { useState } from 'react';
import { Calendar, MapPin, Search, Check, X } from 'lucide-react';
import clsx from 'clsx';

export default function Acionamentos() {
  const [selectedDemanda, setSelectedDemanda] = useState<number | null>(1);
  const [conviteState, setConviteState] = useState<'nenhum' | 'selecionando' | 'enviado'>('nenhum');

  const demandas = [
    { id: 1, data: '22/10/2026', hora: '08:00', hospital: 'Hosp. Santa Catarina', proc: 'Artroplastia Joelho', status: 'pendente' },
    { id: 2, data: '24/10/2026', hora: '14:30', hospital: 'Hosp. Sírio-Libanês', proc: 'Hérnia Disco', status: 'alocando' },
  ];

  const profissionais = [
    { id: 1, nome: 'João Silva', espec: 'Ortopedia', match: '98%', disponivel: true, tags: ['Já trabalhou com médico', 'Região próxima'] },
    { id: 2, nome: 'Ana Costa', espec: 'Ortopedia', match: '85%', disponivel: true, tags: ['Especialidade compatível'] },
    { id: 3, nome: 'Carlos Mendes', espec: 'Ortopedia', match: '40%', disponivel: false, tags: ['Conflito de agenda'] },
  ];

  const handleSendConvite = () => {
    setConviteState('enviado');
    setTimeout(() => setConviteState('nenhum'), 3000);
  };

  return (
    <div className="flex gap-6 h-[calc(100vh-8rem)]">
      {/* Lista de Demandas */}
      <div className="w-1/3 flex flex-col bg-white rounded-xl shadow-sm border border-slate-100 overflow-hidden">
        <div className="p-4 border-b border-slate-100 bg-slate-50">
          <h2 className="font-bold text-slate-800">Demandas Abertas</h2>
        </div>
        <div className="flex-1 overflow-y-auto p-2 space-y-2">
          {demandas.map(d => (
            <button
              key={d.id}
              onClick={() => { setSelectedDemanda(d.id); setConviteState('nenhum'); }}
              className={clsx(
                "w-full text-left p-3 rounded-lg border transition-colors",
                selectedDemanda === d.id ? "bg-primary-50 border-primary-200" : "bg-white border-slate-100 hover:border-primary-100"
              )}
            >
              <div className="flex justify-between items-start mb-1">
                <span className="font-semibold text-sm text-slate-900">{d.proc}</span>
                <span className={clsx("text-[10px] uppercase font-bold px-1.5 py-0.5 rounded", d.status === 'pendente' ? 'bg-red-100 text-red-700' : 'bg-amber-100 text-amber-700')}>
                  {d.status}
                </span>
              </div>
              <div className="text-xs text-slate-500 flex items-center gap-1 mt-1"><Calendar className="w-3 h-3"/> {d.data} - {d.hora}</div>
              <div className="text-xs text-slate-500 flex items-center gap-1 mt-1"><MapPin className="w-3 h-3"/> {d.hospital}</div>
            </button>
          ))}
        </div>
      </div>

      {/* Área de Match */}
      <div className="w-2/3 bg-white rounded-xl shadow-sm border border-slate-100 flex flex-col">
        {selectedDemanda ? (
          <>
            <div className="p-6 border-b border-slate-100">
              <h2 className="text-xl font-bold text-slate-900 mb-2">Busca de Profissionais</h2>
              <div className="flex gap-4 text-sm text-slate-600">
                <span className="flex items-center gap-1"><SearchIcon className="w-4 h-4"/> Ortopedia</span>
                <span className="flex items-center gap-1"><Calendar className="w-4 h-4"/> 22/10 Manhã</span>
                <span className="flex items-center gap-1"><MapPin className="w-4 h-4"/> São Paulo (Sul)</span>
              </div>
            </div>

            <div className="flex-1 overflow-y-auto p-6 bg-slate-50">
              {conviteState === 'enviado' ? (
                <div className="h-full flex flex-col items-center justify-center text-center">
                  <div className="w-16 h-16 bg-emerald-100 rounded-full flex items-center justify-center mb-4">
                    <Check className="w-8 h-8 text-emerald-600" />
                  </div>
                  <h3 className="text-xl font-bold text-slate-900">Convite Enviado!</h3>
                  <p className="text-slate-500 mt-2">O profissional receberá a notificação em seu aplicativo.</p>
                </div>
              ) : (
                <div className="space-y-4">
                  {profissionais.map(p => (
                    <div key={p.id} className={clsx("bg-white p-4 rounded-xl border", p.disponivel ? "border-emerald-200" : "border-slate-200 opacity-60")}>
                      <div className="flex justify-between items-start">
                        <div className="flex items-center gap-3">
                          <div className="w-10 h-10 bg-slate-100 rounded-full flex items-center justify-center font-bold text-slate-600">
                            {p.nome.substring(0,2)}
                          </div>
                          <div>
                            <h4 className="font-bold text-slate-900">{p.nome}</h4>
                            <p className="text-xs text-slate-500">{p.espec}</p>
                          </div>
                        </div>
                        <div className="text-right">
                          <span className={clsx("text-lg font-bold", parseInt(p.match) > 80 ? "text-emerald-600" : "text-amber-600")}>
                            {p.match}
                          </span>
                          <p className="text-[10px] text-slate-400 uppercase font-bold">Compatibilidade</p>
                        </div>
                      </div>
                      
                      <div className="mt-3 flex flex-wrap gap-1">
                        {p.tags.map(tag => (
                          <span key={tag} className="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded">
                            {tag}
                          </span>
                        ))}
                      </div>

                      <div className="mt-4 pt-4 border-t border-slate-100 flex justify-end">
                        {p.disponivel ? (
                          <button onClick={handleSendConvite} className="bg-primary-600 hover:bg-primary-700 text-white px-4 py-2 rounded-lg text-sm font-medium transition-colors">
                            Convidar
                          </button>
                        ) : (
                          <span className="text-xs text-red-500 font-medium flex items-center gap-1"><X className="w-4 h-4"/> Indisponível</span>
                        )}
                      </div>
                    </div>
                  ))}
                </div>
              )}
            </div>
          </>
        ) : (
          <div className="h-full flex items-center justify-center text-slate-400">
            Selecione uma demanda para ver opções.
          </div>
        )}
      </div>
    </div>
  );
}

function SearchIcon(props: any) {
  return <Search {...props} />;
}
