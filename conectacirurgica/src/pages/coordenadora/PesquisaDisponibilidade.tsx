import { Search as SearchIcon, CheckCircle } from 'lucide-react';
import { useState } from 'react';
import { useStore } from '../../store/useStore';
import { format } from 'date-fns';

export default function PesquisaDisponibilidade() {
  const { instrumentadores } = useStore();
  const [dataFilter, setDataFilter] = useState(format(new Date(), 'yyyy-MM-dd'));
  const [periodoFilter, setPeriodoFilter] = useState('');
  const [especialidadeFilter, setEspecialidadeFilter] = useState('');

  const profissionaisFiltrados = instrumentadores.filter(prof => {
    let matches = true;

    if (dataFilter) {
      const dispDia = prof.disponibilidade[dataFilter];
      if (!dispDia) {
        matches = false;
      } else if (periodoFilter && !dispDia.includes('integral') && !dispDia.includes(periodoFilter.toLowerCase())) {
        matches = false;
      } else if (dispDia.includes('indisponivel')) {
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
        <p className="text-slate-500">Encontre profissionais disponíveis por data e especialidade.</p>
      </div>

      <div className="bg-white rounded-xl p-4 shadow-sm border border-slate-100 flex flex-wrap gap-4">
        <div className="flex-1 min-w-[200px]">
          <label className="block text-xs font-medium text-slate-500 mb-1">Data</label>
          <input 
            type="date" 
            value={dataFilter}
            onChange={(e) => setDataFilter(e.target.value)}
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
          </select>
        </div>
        <div className="flex-none flex items-end">
          <button className="bg-primary-600 hover:bg-primary-700 text-white px-6 py-2 rounded-md font-medium text-sm flex items-center gap-2 transition-colors">
            <SearchIcon className="w-4 h-4" /> Buscar
          </button>
        </div>
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-100 overflow-hidden">
        {profissionaisFiltrados.length === 0 ? (
          <div className="p-8 text-center text-slate-500">
            Nenhum profissional encontrado com os filtros selecionados.
          </div>
        ) : (
          <table className="min-w-full divide-y divide-slate-200">
            <thead className="bg-slate-50">
              <tr>
                <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Profissional</th>
                <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Especialidade</th>
                <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Período Declarado</th>
                <th scope="col" className="relative px-6 py-3"><span className="sr-only">Ações</span></th>
              </tr>
            </thead>
            <tbody className="bg-white divide-y divide-slate-200">
              {profissionaisFiltrados.map((prof) => (
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
                  <td className="px-6 py-4 whitespace-nowrap">
                    <div className="flex flex-wrap gap-1">
                      {prof.disponibilidade[dataFilter]?.includes('integral') ? (
                        <span className="px-2 py-1 text-xs font-medium bg-emerald-100 text-emerald-800 rounded">Dia Inteiro</span>
                      ) : (
                        prof.disponibilidade[dataFilter]?.map(p => (
                          <span key={p} className="px-2 py-1 text-xs font-medium bg-blue-100 text-blue-800 rounded capitalize">{p}</span>
                        ))
                      )}
                    </div>
                  </td>
                  <td className="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                    <button className="text-primary-600 hover:text-primary-900 font-semibold border border-primary-200 px-3 py-1 rounded hover:bg-primary-50">
                      Ver Perfil
                    </button>
                  </td>
                </tr>
              ))}
            </tbody>
          </table>
        )}
      </div>
    </div>
  );
}
