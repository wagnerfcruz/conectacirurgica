import { CheckCircle, ChevronDown, ChevronUp, Calendar as CalendarIcon, Clock } from 'lucide-react';
import { useState } from 'react';
import { useStore } from '../../store/useStore';
import { format, parseISO, isAfter, eachDayOfInterval, getDay } from 'date-fns';
import clsx from 'clsx';

const DIAS_SEMANA = ['Dom', 'Seg', 'Ter', 'Qua', 'Qui', 'Sex', 'Sáb'];

export default function PesquisaDisponibilidade() {
  const { instrumentadores } = useStore();
  const [dataInicial, setDataInicial] = useState(() => format(new Date(), 'yyyy-MM-dd'));
  const [dataFinal, setDataFinal] = useState(() => format(new Date(), 'yyyy-MM-dd'));
  const [periodoFilter, setPeriodoFilter] = useState('');
  const [especialidadeFilter, setEspecialidadeFilter] = useState('');

  const [expandedProf, setExpandedProf] = useState<number | null>(null);

  const datesToSearch = () => {
    try {
      const start = parseISO(dataInicial);
      const end = parseISO(dataFinal);
      if (isAfter(start, end)) return [];
      return eachDayOfInterval({ start, end }).map(d => format(d, 'yyyy-MM-dd'));
    } catch {
      return [];
    }
  };

  const searchedDates = datesToSearch();

  const profissionaisFiltrados = instrumentadores.filter(prof => {
    let matches = true;
    if (searchedDates.length > 0) {
      const hasAvailability = searchedDates.some(date => {
        const dispDia = prof.disponibilidade[date];
        if (!dispDia) return false;
        if (dispDia.includes('indisponivel')) return false;
        if (periodoFilter && !dispDia.includes('integral') && !dispDia.includes(periodoFilter)) return false;
        return true;
      });
      if (!hasAvailability) matches = false;
    }
    if (especialidadeFilter && !prof.especialidades.some(e => e.toLowerCase().includes(especialidadeFilter.toLowerCase()))) {
      matches = false;
    }
    return matches;
  });

  return (
    <div className="space-y-6 pb-12">
      <div>
        <h1 className="text-2xl font-bold text-slate-900">Disponibilidade da Equipe</h1>
        <p className="text-slate-500 text-sm mt-1">Encontre profissionais disponíveis pesquisando em um intervalo de datas.</p>
      </div>

      <div className="bg-white rounded-2xl p-5 shadow-sm border border-slate-100 flex flex-wrap gap-4 items-end">
        <div className="flex-1 min-w-[140px]">
          <label className="block text-xs font-bold text-slate-700 mb-1.5">Data Inicial</label>
          <input 
            type="date" 
            value={dataInicial}
            onChange={(e) => setDataInicial(e.target.value)}
            className="w-full border-slate-300 rounded-lg shadow-sm focus:border-cyan-500 focus:ring-cyan-500 text-sm p-2.5 border" 
          />
        </div>
        <div className="flex-1 min-w-[140px]">
          <label className="block text-xs font-bold text-slate-700 mb-1.5">Data Final</label>
          <input 
            type="date" 
            value={dataFinal}
            onChange={(e) => setDataFinal(e.target.value)}
            className="w-full border-slate-300 rounded-lg shadow-sm focus:border-cyan-500 focus:ring-cyan-500 text-sm p-2.5 border" 
          />
        </div>
        <div className="flex-1 min-w-[140px]">
          <label className="block text-xs font-bold text-slate-700 mb-1.5">Período</label>
          <select 
            value={periodoFilter}
            onChange={(e) => setPeriodoFilter(e.target.value)}
            className="w-full border-slate-300 rounded-lg shadow-sm focus:border-cyan-500 focus:ring-cyan-500 text-sm p-2.5 border bg-white"
          >
            <option value="">Qualquer período</option>
            <option value="manha">Manhã</option>
            <option value="tarde">Tarde</option>
            <option value="noite">Noite</option>
          </select>
        </div>
        <div className="flex-1 min-w-[180px]">
          <label className="block text-xs font-bold text-slate-700 mb-1.5">Especialidade</label>
          <select 
            value={especialidadeFilter}
            onChange={(e) => setEspecialidadeFilter(e.target.value)}
            className="w-full border-slate-300 rounded-lg shadow-sm focus:border-cyan-500 focus:ring-cyan-500 text-sm p-2.5 border bg-white"
          >
            <option value="">Todas</option>
            <option value="ortopedia">Ortopedia</option>
            <option value="coluna">Coluna</option>
            <option value="cranio">Crânio</option>
            <option value="neurologia">Neurologia</option>
          </select>
        </div>
      </div>

      <div className="space-y-4">
        {profissionaisFiltrados.length === 0 ? (
          <div className="bg-white rounded-2xl p-8 text-center text-slate-500 border border-slate-100 shadow-sm">
            Nenhum profissional encontrado com os filtros selecionados para esse período.
          </div>
        ) : (
          profissionaisFiltrados.map((prof) => {
            const availableDays = searchedDates.filter(date => {
              const dispDia = prof.disponibilidade[date];
              if (!dispDia || dispDia.includes('indisponivel')) return false;
              if (periodoFilter && !dispDia.includes('integral') && !dispDia.includes(periodoFilter)) return false;
              return true;
            });
            
            const isExpanded = expandedProf === prof.id;

            return (
              <div key={prof.id} className="bg-white rounded-2xl shadow-sm border border-slate-100 overflow-hidden">
                <div 
                  className={clsx("p-4 flex flex-col md:flex-row md:items-center justify-between gap-4 cursor-pointer transition-colors", isExpanded ? "bg-slate-50" : "hover:bg-slate-50")}
                  onClick={() => setExpandedProf(isExpanded ? null : prof.id)}
                >
                  <div className="flex items-center gap-4">
                    <div className="w-12 h-12 bg-slate-800 rounded-full flex items-center justify-center text-white font-bold text-lg shrink-0 shadow-inner">
                      {prof.nome.substring(0,2).toUpperCase()}
                    </div>
                    <div>
                      <div className="font-bold text-slate-900 text-lg flex items-center gap-1.5 leading-tight">
                        {prof.nome} 
                        {prof.validado && <CheckCircle className="w-4 h-4 text-emerald-500" />}
                      </div>
                      <div className="text-xs font-medium text-slate-500 mt-0.5">{prof.regiao}</div>
                      <div className="text-xs text-slate-600 mt-1 flex gap-1 flex-wrap">
                        {prof.especialidades.map((esp, i) => (
                          <span key={i} className="bg-slate-200/50 px-2 py-0.5 rounded text-[10px] uppercase font-bold tracking-wider">{esp}</span>
                        ))}
                      </div>
                    </div>
                  </div>
                  
                  <div className="flex items-center justify-between md:justify-end gap-6 md:w-auto w-full border-t md:border-0 border-slate-100 pt-3 md:pt-0">
                    <div className="text-left md:text-right">
                      <p className="text-xs font-bold text-slate-500 uppercase tracking-wider mb-0.5">Disponibilidade</p>
                      <p className="text-sm font-bold text-emerald-600">
                        {availableDays.length} {availableDays.length === 1 ? 'dia compatível' : 'dias compatíveis'}
                      </p>
                    </div>
                    <button className="text-slate-400 p-2 hover:bg-slate-200 rounded-full transition-colors">
                      {isExpanded ? <ChevronUp className="w-5 h-5" /> : <ChevronDown className="w-5 h-5" />}
                    </button>
                  </div>
                </div>

                {isExpanded && (
                  <div className="border-t border-slate-100 bg-white p-4 animate-in fade-in slide-in-from-top-2">
                    <h4 className="text-xs font-bold text-slate-700 uppercase tracking-wider mb-3">Detalhamento dos dias disponíveis</h4>
                    <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 lg:grid-cols-4 gap-3">
                      {availableDays.map(date => {
                        const p = prof.disponibilidade[date];
                        return (
                          <div key={date} className="flex flex-col border border-slate-200 rounded-xl p-3 bg-slate-50">
                            <div className="flex items-center gap-2 mb-1">
                              <CalendarIcon className="w-4 h-4 text-emerald-600" />
                              <span className="font-bold text-sm text-slate-800">{format(parseISO(date), 'dd/MM/yyyy')}</span>
                              <span className="text-xs text-slate-500">({DIAS_SEMANA[getDay(parseISO(date))]})</span>
                            </div>
                            <div className="flex items-center gap-1.5 mt-1">
                              <Clock className="w-3.5 h-3.5 text-slate-400" />
                              <span className="text-xs font-semibold text-slate-700 uppercase tracking-wide">
                                {p.includes('integral') ? 'Dia Inteiro' : p.join(', ')}
                              </span>
                            </div>
                          </div>
                        );
                      })}
                    </div>
                    <div className="mt-4 flex justify-end">
                       <button className="text-sm font-bold text-cyan-700 bg-cyan-50 px-4 py-2 rounded-lg hover:bg-cyan-100 transition-colors border border-cyan-200">
                         Acessar Perfil Completo
                       </button>
                    </div>
                  </div>
                )}
              </div>
            );
          })
        )}
      </div>
    </div>
  );
}
