import { Search, Filter, ShieldCheck, ShieldAlert } from 'lucide-react';

export default function Profissionais() {
  const profissionais = [
    { id: 1, nome: 'João Silva', espec: 'Ortopedia, Coluna', regiao: 'SP - Centro, Sul', validado: true, atuacoes: 45, nota: 'A' },
    { id: 2, nome: 'Ana Costa', espec: 'Crânio, Neurologia', regiao: 'SP - Todas', validado: true, atuacoes: 128, nota: 'A+' },
    { id: 3, nome: 'Carlos Mendes', espec: 'Ortopedia Geral', regiao: 'SP - Leste', validado: false, atuacoes: 0, nota: '-' },
    { id: 4, nome: 'Mariana Souza', espec: 'Coluna', regiao: 'SP - Sul', validado: true, atuacoes: 12, nota: 'B' },
  ];

  return (
    <div className="space-y-6">
      <div className="flex justify-between items-end">
        <div>
          <h1 className="text-2xl font-bold text-slate-900">Carteira de Profissionais</h1>
          <p className="text-slate-500">Gerencie instrumentadores e valide suas competências.</p>
        </div>
        <button className="bg-primary-600 hover:bg-primary-700 text-white px-4 py-2 rounded-md font-medium text-sm transition-colors">
          + Convidar Profissional
        </button>
      </div>

      <div className="bg-white rounded-xl p-4 shadow-sm border border-slate-100 flex gap-4">
        <div className="flex-1 relative">
          <Search className="w-5 h-5 absolute left-3 top-2.5 text-slate-400" />
          <input 
            type="text" 
            placeholder="Buscar por nome ou CPF..." 
            className="w-full pl-10 pr-4 py-2 border border-slate-300 rounded-md shadow-sm focus:border-primary-500 focus:ring-primary-500 text-sm"
          />
        </div>
        <button className="bg-white border border-slate-300 hover:bg-slate-50 text-slate-700 px-4 py-2 rounded-md font-medium text-sm flex items-center gap-2 transition-colors">
          <Filter className="w-4 h-4" /> Filtros Avançados
        </button>
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-100 overflow-hidden">
        <table className="min-w-full divide-y divide-slate-200">
          <thead className="bg-slate-50">
            <tr>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Nome</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Especialidades</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Região</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Status Validação</th>
              <th scope="col" className="px-6 py-3 text-center text-xs font-medium text-slate-500 uppercase tracking-wider">Atuações</th>
              <th scope="col" className="relative px-6 py-3"><span className="sr-only">Ações</span></th>
            </tr>
          </thead>
          <tbody className="bg-white divide-y divide-slate-200">
            {profissionais.map((prof) => (
              <tr key={prof.id} className="hover:bg-slate-50 transition-colors">
                <td className="px-6 py-4 whitespace-nowrap">
                  <div className="flex items-center">
                    <div className="flex-shrink-0 h-10 w-10 bg-slate-200 rounded-full flex items-center justify-center text-slate-600 font-bold">
                      {prof.nome.substring(0,2).toUpperCase()}
                    </div>
                    <div className="ml-4">
                      <div className="text-sm font-bold text-slate-900">{prof.nome}</div>
                      <div className="text-xs text-slate-500">ID: {2000 + prof.id}</div>
                    </div>
                  </div>
                </td>
                <td className="px-6 py-4">
                  <div className="text-sm text-slate-900">{prof.espec}</div>
                </td>
                <td className="px-6 py-4 whitespace-nowrap">
                  <span className="text-sm text-slate-500">{prof.regiao}</span>
                </td>
                <td className="px-6 py-4 whitespace-nowrap">
                  {prof.validado ? (
                    <span className="inline-flex items-center gap-1 px-2.5 py-1 rounded-full text-xs font-medium bg-emerald-100 text-emerald-800">
                      <ShieldCheck className="w-3.5 h-3.5" /> Validado
                    </span>
                  ) : (
                    <span className="inline-flex items-center gap-1 px-2.5 py-1 rounded-full text-xs font-medium bg-amber-100 text-amber-800">
                      <ShieldAlert className="w-3.5 h-3.5" /> Em Análise
                    </span>
                  )}
                </td>
                <td className="px-6 py-4 whitespace-nowrap text-center text-sm text-slate-500">
                  {prof.atuacoes}
                </td>
                <td className="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                  <button className="text-primary-600 hover:text-primary-900 font-semibold">Editar Perfil</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}
