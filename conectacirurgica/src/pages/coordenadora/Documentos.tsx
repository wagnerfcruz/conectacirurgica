import { Download, Eye, AlertCircle, CheckCircle, FileText } from 'lucide-react';
import { useStore } from '../../store/useStore';
import { useState } from 'react';
import { format, parseISO } from 'date-fns';

export default function Documentos() {
  const { relatorios, demandas, instrumentadores, updateRelatorio, cobrarDocumento } = useStore();
  const [modalOpen, setModalOpen] = useState(false);
  const [selectedDemandaId, setSelectedDemandaId] = useState<number | null>(null);
  const [tipoDoc, setTipoDoc] = useState('Relatório Cirúrgico');
  const [message, setMessage] = useState('');

  // Encontrar cirurgias confirmadas/realizadas que ainda não têm documento cobrado
  const confirmadasSemDoc = demandas.filter(d => 
    (d.status === 'confirmado' || d.status === 'realizado') && 
    !relatorios.some(r => r.demandaId === d.id) &&
    d.instrumentadorId
  );

  const relatoriosCompletos = relatorios.map(r => {
    const demanda = demandas.find(d => d.id === r.demandaId);
    const instrumentador = instrumentadores.find(i => i.id === r.instrumentadorId);
    return { ...r, demanda, instrumentador };
  });

  const getInstName = (id?: number | null) => {
    return instrumentadores.find(i => i.id === id)?.nome || 'Desconhecido';
  };

  const handleCobrar = () => {
    if (selectedDemandaId) {
      const d = demandas.find(dem => dem.id === selectedDemandaId);
      if (d && d.instrumentadorId) {
        cobrarDocumento(d.instrumentadorId, d.id, tipoDoc);
        setModalOpen(false);
      }
    }
  };

  const showMessage = (msg: string) => {
    setMessage(msg);
    setTimeout(() => setMessage(''), 3000);
  };

  const handleVerArquivo = () => {
    showMessage("O arquivo não está disponível na demonstração.");
  };

  return (
    <div className="space-y-6">
      <div className="flex justify-between items-end flex-wrap gap-4">
        <div>
          <h1 className="text-2xl font-bold text-slate-900">Relatórios e Documentos</h1>
          <p className="text-slate-500">Controle de recebimento de relatórios cirúrgicos e NFs.</p>
        </div>
        <button 
          onClick={() => {
            if(confirmadasSemDoc.length === 0) {
              showMessage("Não há novas cirurgias para cobrar documentos.");
            } else {
              setSelectedDemandaId(confirmadasSemDoc[0].id);
              setModalOpen(true);
            }
          }}
          className="bg-primary-600 hover:bg-primary-700 text-white px-4 py-2 rounded-md font-medium text-sm transition-colors"
        >
          Cobrar Documento
        </button>
      </div>

      {message && (
        <div className="bg-blue-50 text-blue-800 p-3 rounded-lg border border-blue-200 text-sm font-medium flex items-center justify-center">
          {message}
        </div>
      )}

      <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-4">
         <div className="bg-white rounded-xl p-4 shadow-sm border border-slate-100 border-l-4 border-l-amber-500">
           <p className="text-sm text-slate-500 font-medium">Pendentes de Envio</p>
           <p className="text-2xl font-bold text-slate-900 mt-1">{relatorios.filter(r => r.status === 'pendente').length}</p>
         </div>
         <div className="bg-white rounded-xl p-4 shadow-sm border border-slate-100 border-l-4 border-l-emerald-500">
           <p className="text-sm text-slate-500 font-medium">Recebidos (Revisão)</p>
           <p className="text-2xl font-bold text-slate-900 mt-1">{relatorios.filter(r => r.status === 'recebido').length}</p>
         </div>
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-100 overflow-x-auto">
        <table className="min-w-full divide-y divide-slate-200">
          <thead className="bg-slate-50">
            <tr>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Profissional</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Procedimento</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Tipo Documento</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Status</th>
              <th scope="col" className="relative px-6 py-3"><span className="sr-only">Ações</span></th>
            </tr>
          </thead>
          <tbody className="bg-white divide-y divide-slate-100">
            {relatoriosCompletos.length === 0 && (
              <tr>
                <td colSpan={5} className="p-8 text-center text-slate-500">
                  <FileText className="w-8 h-8 text-slate-300 mx-auto mb-2" />
                  Nenhum documento cobrado ou recebido.
                </td>
              </tr>
            )}
            {relatoriosCompletos.map((rel) => (
              <tr key={rel.id} className="hover:bg-slate-50">
                <td className="px-6 py-4 whitespace-nowrap text-sm font-medium text-slate-900">{rel.instrumentador?.nome}</td>
                <td className="px-6 py-4 whitespace-nowrap">
                  <div className="text-sm text-slate-900">{rel.demanda?.procedimento}</div>
                  <div className="text-xs text-slate-500">
                    {rel.demanda?.data ? format(parseISO(rel.demanda.data), 'dd/MM/yyyy') : ''}
                  </div>
                </td>
                <td className="px-6 py-4 whitespace-nowrap text-sm text-slate-500">{rel.tipo}</td>
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
                      <button onClick={handleVerArquivo} className="text-primary-600 hover:text-primary-900 flex items-center gap-1" title="Ver Arquivo">
                        <Eye className="w-4 h-4" />
                      </button>
                      <button onClick={handleVerArquivo} className="text-slate-400 hover:text-slate-600" title="Baixar">
                        <Download className="w-4 h-4" />
                      </button>
                    </div>
                  ) : (
                    <button 
                      onClick={() => updateRelatorio(rel.id, 'recebido')}
                      className="text-emerald-600 hover:text-emerald-900 border border-emerald-200 px-3 py-1 rounded hover:bg-emerald-50 text-xs flex items-center gap-1 ml-auto"
                    >
                      <CheckCircle className="w-3 h-3" /> Marcar Recebido
                    </button>
                  )}
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>

      {modalOpen && (
        <div className="fixed inset-0 z-50 flex items-center justify-center p-4 bg-slate-900/50 backdrop-blur-sm">
          <div className="bg-white rounded-xl shadow-xl w-full max-w-md overflow-hidden flex flex-col">
            <div className="flex justify-between items-center p-4 border-b border-slate-100">
              <h2 className="text-lg font-bold text-slate-900">Cobrar Documento</h2>
              <button onClick={() => setModalOpen(false)} className="text-slate-400 hover:text-slate-600">×</button>
            </div>
            <div className="p-4 space-y-4">
              <div>
                <label className="block text-sm font-medium text-slate-700 mb-1">Selecione a Demanda</label>
                <select 
                  value={selectedDemandaId || ''} 
                  onChange={e => setSelectedDemandaId(Number(e.target.value))}
                  className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500"
                >
                  {confirmadasSemDoc.map(d => (
                    <option key={d.id} value={d.id}>
                      {d.procedimento} ({d.data}) - {getInstName(d.instrumentadorId)}
                    </option>
                  ))}
                </select>
              </div>
              <div>
                <label className="block text-sm font-medium text-slate-700 mb-1">Tipo de Documento</label>
                <select 
                  value={tipoDoc} 
                  onChange={e => setTipoDoc(e.target.value)}
                  className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500"
                >
                  <option>Relatório Cirúrgico</option>
                  <option>Nota Fiscal</option>
                  <option>Relatório + Nota Fiscal</option>
                </select>
              </div>
            </div>
            <div className="p-4 border-t border-slate-100 bg-slate-50 flex justify-end gap-2">
              <button onClick={() => setModalOpen(false)} className="px-4 py-2 text-sm font-medium text-slate-600">Cancelar</button>
              <button onClick={handleCobrar} className="px-4 py-2 bg-primary-600 text-white rounded text-sm font-medium hover:bg-primary-700">Confirmar</button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
}
