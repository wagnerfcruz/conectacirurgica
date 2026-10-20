import { Search as SearchIcon, CheckCircle } from 'lucide-react';

export default function PesquisaDisponibilidade() {
  return (
    <div className="space-y-6">
      <div>
        <h1 className="text-2xl font-bold text-slate-900">Disponibilidade da Equipe</h1>
        <p className="text-slate-500">Encontre profissionais disponíveis por data e especialidade.</p>
      </div>

      <div className="bg-white rounded-xl p-4 shadow-sm border border-slate-100 flex flex-wrap gap-4">
        <div className="flex-1 min-w-[200px]">
          <label className="block text-xs font-medium text-slate-500 mb-1">Data</label>
          <input type="date" className="w-full border-slate-300 rounded-md shadow-sm focus:border-primary-500 focus:ring-primary-500 text-sm p-2 border" />
        </div>
        <div className="flex-1 min-w-[150px]">
          <label className="block text-xs font-medium text-slate-500 mb-1">Período</label>
          <select className="w-full border-slate-300 rounded-md shadow-sm focus:border-primary-500 focus:ring-primary-500 text-sm p-2 border bg-white">
            <option>Qualquer período</option>
            <option>Manhã</option>
            <option>Tarde</option>
            <option>Noite</option>
          </select>
        </div>
        <div className="flex-1 min-w-[200px]">
          <label className="block text-xs font-medium text-slate-500 mb-1">Especialidade</label>
          <select className="w-full border-slate-300 rounded-md shadow-sm focus:border-primary-500 focus:ring-primary-500 text-sm p-2 border bg-white">
            <option>Todas especialidades</option>
            <option>Ortopedia</option>
            <option>Coluna</option>
            <option>Crânio</option>
          </select>
        </div>
        <div className="flex items-end">
          <button className="bg-primary-600 hover:bg-primary-700 text-white px-4 py-2 rounded-md font-medium text-sm flex items-center gap-2 transition-colors">
            <SearchIcon className="w-4 h-4" /> Buscar
          </button>
        </div>
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-100 overflow-hidden">
        <table className="min-w-full divide-y divide-slate-200">
          <thead className="bg-slate-50">
            <tr>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Profissional</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Especialidades</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Períodos</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Atualização</th>
              <th scope="col" className="relative px-6 py-3"><span className="sr-only">Ações</span></th>
            </tr>
          </thead>
          <tbody className="bg-white divide-y divide-slate-200">
            {[
              { nome: 'João Silva', espec: 'Ortopedia, Coluna', periodos: 'Manhã, Tarde', atualizado: 'Hoje, 08:30' },
              { nome: 'Ana Costa', espec: 'Crânio', periodos: 'Tarde, Noite', atualizado: 'Hoje, 10:15' },
              { nome: 'Carlos Mendes', espec: 'Ortopedia', periodos: 'Dia Inteiro', atualizado: 'Ontem, 18:00' },
            ].map((prof, i) => (
              <tr key={i} className="hover:bg-slate-50 transition-colors">
                <td className="px-6 py-4 whitespace-nowrap">
                  <div className="flex items-center">
                    <div className="flex-shrink-0 h-8 w-8 bg-primary-100 rounded-full flex items-center justify-center text-primary-700 font-bold text-xs">
                      {prof.nome.substring(0,2).toUpperCase()}
                    </div>
                    <div className="ml-4">
                      <div className="text-sm font-medium text-slate-900">{prof.nome}</div>
                      <div className="text-sm text-emerald-600 flex items-center gap-1"><CheckCircle className="w-3 h-3"/> Validado</div>
                    </div>
                  </div>
                </td>
                <td className="px-6 py-4 whitespace-nowrap text-sm text-slate-500">{prof.espec}</td>
                <td className="px-6 py-4 whitespace-nowrap">
                  <span className="px-2 inline-flex text-xs leading-5 font-semibold rounded-full bg-blue-100 text-blue-800">
                    {prof.periodos}
                  </span>
                </td>
                <td className="px-6 py-4 whitespace-nowrap text-sm text-slate-500">{prof.atualizado}</td>
                <td className="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                  <button className="text-primary-600 hover:text-primary-900">Ver Perfil</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}
