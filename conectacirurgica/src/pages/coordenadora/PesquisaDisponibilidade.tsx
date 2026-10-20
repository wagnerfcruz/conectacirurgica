import { CheckCircle } from 'lucide-react';
import { useState } from 'react';
import { useStore } from '../../store/useStore';
import { format, parseISO, isAfter, eachDayOfInterval } from 'date-fns';

export default function PesquisaDisponibilidade() {
  const { instrumentadores } = useStore();
  const [dataInicial, setDataInicial] = useState(format(new Date(), 'yyyy-MM-dd'));
  const [dataFinal, setDataFinal] = useState(format(new Date(), 'yyyy-MM-dd'));
  const [periodoFilter, setPeriodoFilter] = useState('');
  const [especialidadeFilter, setEspecialidadeFilter] = useState('');

  // Get all dates in range
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
      // Must have availability for AT LEAST ONE of the requested dates
      const hasAvailability = searchedDates.some(date => {
        const dispDia = prof.disponibilidade[date];
        if (!dispDia) return false;
        if (dispDia.includes('indisponivel')) return false;
        if (periodoFilter && !dispDia.includes('integral') && !dispDia.includes(periodoFilter)) return false;
        return true;
      });

      if (!hasAvailability) {
        matches = false;
      }
    }

    if (especialidadeFilter && !prof.especialidades.some(e => e.toLowerCase().includes(especialidadeFilter.toLowerCase()))) {
      matches = false;
    }

    return matches;
  });

  return (
    <div className="space-y-6">
      <div>
        <h1 className="text-2xl font-bold text-slate-900">Disponibilidade da Equipe</h1>
        <p className="text-slate-500">Encontre profissionais disponíveis pesquisando em um intervalo de datas.</p>
      </div>

      <div className="bg-white rounded-xl p-4 shadow-sm border border-slate-100 flex flex-wrap gap-4 items-end">
        <div className="flex-1 min-w-[150px]">
          <label className="block text-xs font-medium text-slate-500 mb-1">Data Inicial</label>
          <input 
            type="date" 
            value={dataInicial}
            onChange={(e) => setDataInicial(e.target.value)}
            className="w-full border-slate-300 rounded-md shadow-sm focus:border-primary-500 focus:ring-primary-500 text-sm p-2 border" 
          />
        </div>
        <div className="flex-1 min-w-[150px]">
          <label className="block text-xs font-medium text-slate-500 mb-1">Data Final</label>
          <input 
            type="date" 
            value={dataFinal}
            onChange={(e) => setDataFinal(e.target.value)}
            className="w-full border-slate-300 rounded-md shadow-sm focus:border-primary-500 focus:ring-primary-500 text-sm p-2 border" 
          />
        </div>
        <div className="flex-1 min-w-[150px]">
          <label className="block text-xs font-medium text-slate-500 mb-1">Período</label>
          <select 
            value={periodoFilter}
            onChange={(e) => setPeriodoFilter(e.target.value)}
            className="w-full border-slate-300 rounded-md shadow-sm focus:border-primary-500 focus:ring-primary-500 text-sm p-2 border bg-white"
          >
            <option value="">Qualquer período</option>
            <option value="manha">Manhã</option>
            <option value="tarde">Tarde</option>
            <option value="noite">Noite</option>
          </select>
        </div>
        <div className="flex-1 min-w-[200px]">
          <label className="block text-xs font-medium text-slate-500 mb-1">Especialidade</label>
          <select 
            value={especialidadeFilter}
            onChange={(e) => setEspecialidadeFilter(e.target.value)}
            className="w-full border-slate-300 rounded-md shadow-sm focus:border-primary-500 focus:ring-primary-500 text-sm p-2 border bg-white"
          >
            <option value="">Todas</option>
            <option value="ortopedia">Ortopedia</option>
            <option value="coluna">Coluna</option>
            <option value="cranio">Crânio</option>
            <option value="neurologia">Neurologia</option>
          </select>
        </div>
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-100 overflow-x-auto">
        {profissionaisFiltrados.length === 0 ? (
          <div className="p-8 text-center text-slate-500">
            Nenhum profissional encontrado com os filtros selecionados para esse período.
          </div>
        ) : (
          <table className="min-w-full divide-y divide-slate-200">
            <thead className="bg-slate-50">
              <tr>
                <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Profissional</th>
                <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Especialidade</th>
                <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Dias Encontrados no Período</th>
                <th scope="col" className="relative px-6 py-3"><span className="sr-only">Ações</span></th>
              </tr>
            </thead>
            <tbody className="bg-white divide-y divide-slate-200">
              {profissionaisFiltrados.map((prof) => {
                
                // Collect days where this prof is available
                const availableDays = searchedDates.filter(date => {
                  const dispDia = prof.disponibilidade[date];
                  if (!dispDia) return false;
                  if (dispDia.includes('indisponivel')) return false;
                  if (periodoFilter && !dispDia.includes('integral') && !dispDia.includes(periodoFilter)) return false;
                  return true;
                });

                return (
                  <tr key={prof.id} className="hover:bg-slate-50 transition-colors">
                    <td className="px-6 py-4 whitespace-nowrap">
                      <div className="flex items-center">
                        <div className="flex-shrink-0 h-10 w-10 bg-slate-200 rounded-full flex items-center justify-center text-slate-600 font-bold">
                          {prof.nome.substring(0,2).toUpperCase()}
                        </div>
                        <div className="ml-4">
                          <div className="text-sm font-bold text-slate-900 flex items-center gap-1">
                            {prof.nome} {prof.validado && <CheckCircle className="w-3.5 h-3.5 text-emerald-500" />}
                          </div>
                          <div className="text-xs text-slate-500">{prof.regiao}</div>
                        </div>
                      </div>
                    </td>
                    <td className="px-6 py-4">
                      <div className="text-sm text-slate-900">{prof.especialidades.join(', ')}</div>
                    </td>
                    <td className="px-6 py-4">
                      <div className="flex flex-wrap gap-2 max-w-sm">
                        {availableDays.map(date => {
                          const p = prof.disponibilidade[date];
                          return (
                            <div key={date} className="flex flex-col border border-slate-200 rounded p-1 text-xs">
                              <span className="font-bold text-slate-700">{format(parseISO(date), 'dd/MM')}</span>
                              <span className="text-slate-500 uppercase text-[10px]">{p.includes('integral') ? 'Integral' : p.join(',')}</span>
                            </div>
                          );
                        })}
                      </div>
                    </td>
                    <td className="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                      <button className="text-primary-600 hover:text-primary-900 font-semibold border border-primary-200 px-3 py-1 rounded hover:bg-primary-50">
                        Ver Perfil
                      </button>
                    </td>
                  </tr>
                );
              })}
            </tbody>
          </table>
        )}
      </div>
    </div>
  );
}
