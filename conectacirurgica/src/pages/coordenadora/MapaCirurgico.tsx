import { Upload, FilePlus, AlertCircle } from 'lucide-react';

export default function MapaCirurgico() {
  return (
    <div className="space-y-6">
      <div className="flex justify-between items-end">
        <div>
          <h1 className="text-2xl font-bold text-slate-900">Mapa Cirúrgico</h1>
          <p className="text-slate-500">Importe planilhas para gerar demandas automaticamente.</p>
        </div>
        <button className="bg-white border border-slate-300 hover:bg-slate-50 text-slate-700 px-4 py-2 rounded-md font-medium text-sm transition-colors">
          Download Modelo CSV
        </button>
      </div>

      {/* Área de Importação Demonstrativa */}
      <div className="border-2 border-dashed border-slate-300 rounded-xl p-12 bg-white text-center hover:bg-slate-50 transition-colors cursor-pointer group">
        <div className="w-16 h-16 bg-primary-50 rounded-full flex items-center justify-center mx-auto mb-4 group-hover:bg-primary-100 transition-colors">
          <Upload className="w-8 h-8 text-primary-600" />
        </div>
        <h3 className="text-lg font-medium text-slate-900 mb-1">Importar Planilha do Hospital</h3>
        <p className="text-sm text-slate-500 mb-6">Arraste e solte o arquivo XLSX ou CSV aqui, ou clique para selecionar</p>
        <button className="bg-primary-600 hover:bg-primary-700 text-white px-6 py-2 rounded-md font-medium text-sm inline-flex items-center gap-2 transition-colors">
          <FilePlus className="w-4 h-4" /> Selecionar Arquivo
        </button>
      </div>

      {/* Pré-visualização Fictícia */}
      <div className="bg-white rounded-xl shadow-sm border border-slate-100 overflow-hidden mt-8">
        <div className="px-6 py-4 border-b border-slate-100 bg-slate-50 flex justify-between items-center">
          <h3 className="font-semibold text-slate-800">Pré-visualização da Importação (Demonstração)</h3>
          <span className="text-xs font-medium bg-blue-100 text-blue-800 px-2 py-1 rounded-full">4 registros encontrados</span>
        </div>
        <table className="min-w-full divide-y divide-slate-200">
          <thead className="bg-slate-50/50">
            <tr>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Data/Hora</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Hospital/Sala</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Procedimento</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Status</th>
            </tr>
          </thead>
          <tbody className="bg-white divide-y divide-slate-200">
            <tr className="hover:bg-slate-50">
              <td className="px-6 py-4 whitespace-nowrap text-sm text-slate-900">22/10/2026<br/><span className="text-slate-500">08:00</span></td>
              <td className="px-6 py-4 whitespace-nowrap text-sm text-slate-900">Hosp. Santa Catarina<br/><span className="text-slate-500">Sala 3</span></td>
              <td className="px-6 py-4 whitespace-nowrap text-sm text-slate-900">Artroplastia Total Joelho<br/><span className="text-slate-500">Dr. Roberto Almeida</span></td>
              <td className="px-6 py-4 whitespace-nowrap text-sm"><span className="text-emerald-600 font-medium">Pronto para importar</span></td>
            </tr>
            <tr className="bg-red-50/50 hover:bg-red-50">
              <td className="px-6 py-4 whitespace-nowrap text-sm text-slate-900">22/10/2026<br/><span className="text-slate-500">08:00</span></td>
              <td className="px-6 py-4 whitespace-nowrap text-sm text-slate-900">Hosp. Santa Catarina<br/><span className="text-slate-500">Sala 3</span></td>
              <td className="px-6 py-4 whitespace-nowrap text-sm text-slate-900">Artroplastia Total Joelho<br/><span className="text-slate-500">Dr. Roberto Almeida</span></td>
              <td className="px-6 py-4 whitespace-nowrap text-sm flex items-center gap-1 text-red-600 font-medium"><AlertCircle className="w-4 h-4"/> Possível Duplicidade</td>
            </tr>
          </tbody>
        </table>
        <div className="px-6 py-4 border-t border-slate-100 bg-slate-50 flex justify-end gap-3">
          <button className="bg-white border border-slate-300 hover:bg-slate-50 text-slate-700 px-4 py-2 rounded-md font-medium text-sm transition-colors">
            Cancelar
          </button>
          <button className="bg-primary-600 hover:bg-primary-700 text-white px-4 py-2 rounded-md font-medium text-sm transition-colors opacity-50 cursor-not-allowed">
            Confirmar Importação
          </button>
        </div>
      </div>
    </div>
  );
}
