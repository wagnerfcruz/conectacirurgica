import { useState } from 'react';
import { Calendar, MapPin, Search, X } from 'lucide-react';
import clsx from 'clsx';
import { useStore } from '../../store/useStore';
import type { Demanda } from '../../store/useStore';
import { format, parseISO } from 'date-fns';

export default function Acionamentos() {
  const { demandas, instrumentadores, convites, enviarConvite } = useStore();
  const [selectedDemandaId, setSelectedDemandaId] = useState<number | null>(null);

  const demandasAbertas = demandas.filter(d => ['pendente', 'alocando'].includes(d.status));
  const selectedDemanda = demandas.find(d => d.id === selectedDemandaId);

  // Lógica simples de match
  const getProfissionaisCompativeis = (demanda: Demanda) => {
    return instrumentadores.map(prof => {
      let match = 50; // Base score
      let disponivel = false;
      const tags: string[] = [];

      // Check specialty
      const hasEspecialidade = prof.especialidades.some(e => demanda.procedimento.toLowerCase().includes(e.toLowerCase()));
      if (hasEspecialidade) {
        match += 30;
        tags.push('Especialidade compatível');
      }

      // Check availability for the exact date
      const dispDia = prof.disponibilidade[demanda.data];
      if (dispDia && (dispDia.includes('manha') || dispDia.includes('tarde') || dispDia.includes('noite'))) {
        match += 20;
        disponivel = true;
        tags.push('Disponível na data');
      } else if (!dispDia) {
         // Sem informação, assume indisponível ou incerto para demonstração.
      }

      // Conflito de agenda simples se já estiver confirmado no mesmo dia
      const conflito = demandas.some(d => d.instrumentadorId === prof.id && d.data === demanda.data && d.status === 'confirmado');
      if (conflito) {
        match = 0;
        disponivel = false;
        tags.push('Conflito de agenda');
      }

      return { prof, match, disponivel, tags };
    }).sort((a, b) => b.match - a.match);
  };

  const compativeis = selectedDemanda ? getProfissionaisCompativeis(selectedDemanda) : [];

  const handleSendConvite = (instrumentadorId: number) => {
    if (!selectedDemandaId) return;
    enviarConvite(selectedDemandaId, instrumentadorId);
    setSelectedDemandaId(null); // Volta pra lista após convidar
  };

  const formatDate = (dateStr: string) => {
    try {
      return format(parseISO(dateStr), 'dd/MM/yyyy');
    } catch {
      return dateStr;
    }
  };

  return (
    <div className="flex flex-col lg:flex-row gap-6 h-auto lg:h-[calc(100vh-8rem)]">
      {/* Lista de Demandas */}
      <div className="w-full lg:w-1/3 flex flex-col bg-white rounded-xl shadow-sm border border-slate-100 overflow-hidden min-h-[300px] lg:min-h-0">
        <div className="p-4 border-b border-slate-100 bg-slate-50">
          <h2 className="font-bold text-slate-800">Demandas Abertas ({demandasAbertas.length})</h2>
        </div>
        <div className="flex-1 overflow-y-auto p-2 space-y-2">
          {demandasAbertas.map(d => (
            <button
              key={d.id}
              onClick={() => setSelectedDemandaId(d.id)}
              className={clsx(
                "w-full text-left p-3 rounded-lg border transition-colors",
                selectedDemandaId === d.id ? "bg-primary-50 border-primary-200" : "bg-white border-slate-100 hover:border-primary-100"
              )}
            >
              <div className="flex justify-between items-start mb-1">
                <span className="font-semibold text-sm text-slate-900">{d.procedimento}</span>
                <span className={clsx("text-[10px] uppercase font-bold px-1.5 py-0.5 rounded", d.status === 'pendente' ? 'bg-red-100 text-red-700' : 'bg-amber-100 text-amber-700')}>
                  {d.status}
                </span>
              </div>
              <div className="text-xs text-slate-500 flex items-center gap-1 mt-1"><Calendar className="w-3 h-3"/> {formatDate(d.data)} - {d.hora}</div>
              <div className="text-xs text-slate-500 flex items-center gap-1 mt-1"><MapPin className="w-3 h-3"/> {d.hospital}</div>
            </button>
          ))}
          {demandasAbertas.length === 0 && (
             <div className="p-4 text-center text-slate-500 text-sm">Nenhuma demanda aguardando alocação.</div>
          )}
        </div>
      </div>

      {/* Área de Match */}
      <div className="w-full lg:w-2/3 bg-white rounded-xl shadow-sm border border-slate-100 flex flex-col min-h-[400px] lg:min-h-0">
        {selectedDemanda ? (
          <>
            <div className="p-6 border-b border-slate-100">
              <h2 className="text-xl font-bold text-slate-900 mb-2">Busca de Profissionais</h2>
              <div className="flex gap-4 text-sm text-slate-600">
                <span className="flex items-center gap-1"><Search className="w-4 h-4"/> {selectedDemanda.procedimento}</span>
                <span className="flex items-center gap-1"><Calendar className="w-4 h-4"/> {formatDate(selectedDemanda.data)}</span>
                <span className="flex items-center gap-1"><MapPin className="w-4 h-4"/> {selectedDemanda.hospital}</span>
              </div>
            </div>

            <div className="flex-1 overflow-y-auto p-6 bg-slate-50">
              <div className="space-y-4">
                {compativeis.map(({prof, match, disponivel, tags}) => {
                  const jaConvidado = convites.some(c => c.demandaId === selectedDemanda.id && c.instrumentadorId === prof.id);

                  return (
                    <div key={prof.id} className={clsx("bg-white p-4 rounded-xl border", disponivel ? "border-emerald-200" : "border-slate-200 opacity-60")}>
                      <div className="flex justify-between items-start">
                        <div className="flex items-center gap-3">
                          <div className="w-10 h-10 bg-slate-100 rounded-full flex items-center justify-center font-bold text-slate-600">
                            {prof.nome.substring(0,2)}
                          </div>
                          <div>
                            <h4 className="font-bold text-slate-900 flex items-center gap-2">
                              {prof.nome}
                              {jaConvidado && <span className="text-[10px] bg-blue-100 text-blue-700 px-1.5 py-0.5 rounded uppercase">Já Convidado</span>}
                            </h4>
                            <p className="text-xs text-slate-500">{prof.especialidades.join(', ')}</p>
                          </div>
                        </div>
                        <div className="text-right">
                          <span className={clsx("text-lg font-bold", match > 80 ? "text-emerald-600" : "text-amber-600")}>
                            {match}%
                          </span>
                          <p className="text-[10px] text-slate-400 uppercase font-bold">Compatibilidade</p>
                        </div>
                      </div>
                      
                      <div className="mt-3 flex flex-wrap gap-1">
                        {tags.map(tag => (
                          <span key={tag} className="text-xs px-2 py-1 bg-slate-100 text-slate-600 rounded">
                            {tag}
                          </span>
                        ))}
                      </div>

                      <div className="mt-4 pt-4 border-t border-slate-100 flex justify-end">
                        {jaConvidado ? (
                          <button disabled className="bg-slate-100 text-slate-400 px-4 py-2 rounded-lg text-sm font-medium">
                            Aguardando Resposta
                          </button>
                        ) : disponivel ? (
                          <button onClick={() => handleSendConvite(prof.id)} className="bg-primary-600 hover:bg-primary-700 text-white px-4 py-2 rounded-lg text-sm font-medium transition-colors">
                            Convidar
                          </button>
                        ) : (
                          <span className="text-xs text-red-500 font-medium flex items-center gap-1"><X className="w-4 h-4"/> Indisponível</span>
                        )}
                      </div>
                    </div>
                  );
                })}
              </div>
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
