import { Download, Eye, AlertCircle } from 'lucide-react';

export default function Documentos() {
  const relatorios = [
    { id: 1, prof: 'João Silva', proc: 'Artroplastia Joelho', data: '18/10/2026', status: 'recebido' },
    { id: 2, prof: 'Ana Costa', proc: 'Hérnia Disco', data: '19/10/2026', status: 'pendente' },
    { id: 3, prof: 'Mariana Souza', proc: 'Artrodese', data: '20/10/2026', status: 'recebido' },
  ];

  return (
    <div className="space-y-6">
      <div>
        <h1 className="text-2xl font-bold text-slate-900">Relatórios e Documentos</h1>
        <p className="text-slate-500">Controle de recebimento de relatórios cirúrgicos e NFs.</p>
      </div>

      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-4">
         <div className="bg-white rounded-xl p-4 shadow-sm border border-slate-100 border-l-4 border-l-amber-500">
           <p className="text-sm text-slate-500 font-medium">Pendentes na semana</p>
           <p className="text-2xl font-bold text-slate-900 mt-1">12</p>
         </div>
         <div className="bg-white rounded-xl p-4 shadow-sm border border-slate-100 border-l-4 border-l-emerald-500">
           <p className="text-sm text-slate-500 font-medium">Recebidos hoje</p>
           <p className="text-2xl font-bold text-slate-900 mt-1">5</p>
         </div>
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-100 overflow-hidden">
        <div className="p-4 border-b border-slate-100 bg-slate-50 flex justify-between items-center">
          <h3 className="font-bold text-slate-800">Acompanhamento de Relatórios Cirúrgicos</h3>
          <span className="text-xs text-slate-500 bg-white px-2 py-1 rounded border border-slate-200">
            Apenas Demonstração - Arquivos não são salvos
          </span>
        </div>
        <table className="min-w-full divide-y divide-slate-200">
          <thead className="bg-white">
            <tr>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Profissional</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Procedimento</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Data Cirurgia</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Status</th>
              <th scope="col" className="relative px-6 py-3"><span className="sr-only">Ações</span></th>
            </tr>
          </thead>
          <tbody className="bg-white divide-y divide-slate-100">
            {relatorios.map((rel) => (
              <tr key={rel.id} className="hover:bg-slate-50">
                <td className="px-6 py-4 whitespace-nowrap text-sm font-medium text-slate-900">{rel.prof}</td>
                <td className="px-6 py-4 whitespace-nowrap text-sm text-slate-500">{rel.proc}</td>
                <td className="px-6 py-4 whitespace-nowrap text-sm text-slate-500">{rel.data}</td>
                <td className="px-6 py-4 whitespace-nowrap">
                  {rel.status === 'recebido' ? (
                    <span className="inline-flex items-center px-2.5 py-0.5 rounded-full text-xs font-medium bg-emerald-100 text-emerald-800">
                      Recebido
                    </span>
                  ) : (
                    <span className="inline-flex items-center gap-1 px-2.5 py-0.5 rounded-full text-xs font-medium bg-amber-100 text-amber-800">
                      <AlertCircle className="w-3 h-3" /> Pendente
                    </span>
                  )}
                </td>
                <td className="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                  {rel.status === 'recebido' ? (
                    <div className="flex justify-end gap-3">
                      <button className="text-slate-400 hover:text-primary-600 transition-colors" title="Visualizar">
                        <Eye className="w-5 h-5" />
                      </button>
                      <button className="text-slate-400 hover:text-primary-600 transition-colors" title="Baixar">
                        <Download className="w-5 h-5" />
                      </button>
                    </div>
                  ) : (
                    <button className="text-primary-600 hover:text-primary-900 text-xs font-bold uppercase tracking-wider">
                      Cobrar Envio
                    </button>
                  )}
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}
