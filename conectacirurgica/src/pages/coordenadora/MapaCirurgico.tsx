import { Upload, FileSpreadsheet, AlertTriangle, CheckCircle, Download } from 'lucide-react';
import { useState, useRef } from 'react';
import Papa from 'papaparse';
import { useStore } from '../../store/useStore';

export default function MapaCirurgico() {
  const { addDemandas, demandas } = useStore();
  const [step, setStep] = useState<'upload' | 'verificacao' | 'sucesso'>('upload');
  const [parsedData, setParsedData] = useState<any[]>([]);
  const [erros, setErros] = useState<string[]>([]);
  const fileInputRef = useRef<HTMLInputElement>(null);

  const handleFileUpload = (e: React.ChangeEvent<HTMLInputElement>) => {
    const file = e.target.files?.[0];
    if (!file) return;

    Papa.parse(file, {
      header: true,
      skipEmptyLines: true,
      complete: (results) => {
        setParsedData(results.data);
        setStep('verificacao');
        validarDados(results.data);
      },
      error: (error) => {
        setErros([`Erro ao ler arquivo: ${error.message}`]);
        setStep('verificacao');
      }
    });
  };

  const validarDados = (data: any[]) => {
    const novosErros: string[] = [];
    
    if (data.length === 0) {
      novosErros.push('O arquivo está vazio.');
    } else {
      data.forEach((row, index) => {
        if (!row.Data || !row.Hora || !row.Hospital || !row.Procedimento || !row.Medico) {
          novosErros.push(`Linha ${index + 1}: Faltam campos obrigatórios. Use o modelo!`);
        } else {
          // Check duplicate
          const isDuplicado = demandas.some(d => 
            d.data === row.Data && d.hora === row.Hora && d.procedimento === row.Procedimento && d.medico === row.Medico
          );
          if (isDuplicado) {
            novosErros.push(`Linha ${index + 1}: Possível cirurgia duplicada identificada (${row.Procedimento}).`);
          }
        }
      });
    }
    setErros(novosErros);
  };

  const handleImport = () => {
    if (erros.length > 0 && erros.some(e => e.includes('vazio') || e.includes('obrigatórios'))) {
      alert('Corrija os erros críticos antes de importar.');
      return;
    }

    const novasDemandas = parsedData.map(row => ({
      data: row.Data,
      hora: row.Hora,
      hospital: row.Hospital,
      procedimento: row.Procedimento,
      medico: row.Medico,
    }));

    addDemandas(novasDemandas);
    setStep('sucesso');
    setTimeout(() => {
      setStep('upload');
      setParsedData([]);
      setErros([]);
    }, 3000);
  };

  const baixarModelo = () => {
    const csvContent = "Data,Hora,Hospital,Procedimento,Medico\n2026-10-25,08:00,Hospital das Clínicas,Artroplastia de Quadril,Dr. João Paulo\n2026-10-26,14:00,Sírio-Libanês,Laminectomia,Dra. Clara Santos";
    const blob = new Blob([csvContent], { type: 'text/csv;charset=utf-8;' });
    const link = document.createElement("a");
    const url = URL.createObjectURL(blob);
    link.setAttribute("href", url);
    link.setAttribute("download", "modelo_mapa_cirurgico.csv");
    link.style.visibility = 'hidden';
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
  };

  return (
    <div className="space-y-6 max-w-4xl mx-auto">
      <div>
        <h1 className="text-2xl font-bold text-slate-900">Mapa Cirúrgico</h1>
        <p className="text-slate-500">Importe a planilha do hospital para gerar demandas automaticamente.</p>
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-100 overflow-hidden">
        {/* Progress Bar */}
        <div className="flex border-b border-slate-100 bg-slate-50">
          <div className={`flex-1 text-center py-3 text-sm font-bold ${step === 'upload' ? 'text-primary-600 border-b-2 border-primary-600' : 'text-slate-400'}`}>
            1. Upload de Arquivo
          </div>
          <div className={`flex-1 text-center py-3 text-sm font-bold ${step === 'verificacao' ? 'text-primary-600 border-b-2 border-primary-600' : 'text-slate-400'}`}>
            2. Verificação
          </div>
        </div>

        <div className="p-8">
          {step === 'upload' && (
            <div className="text-center space-y-6">
              <input 
                type="file" 
                accept=".csv"
                className="hidden" 
                ref={fileInputRef}
                onChange={handleFileUpload}
              />
              <div 
                className="border-2 border-dashed border-slate-300 rounded-xl p-12 bg-slate-50 hover:bg-slate-100 hover:border-primary-400 transition-colors cursor-pointer"
                onClick={() => fileInputRef.current?.click()}
              >
                <div className="flex justify-center mb-4">
                  <div className="p-4 bg-white rounded-full shadow-sm">
                    <Upload className="w-8 h-8 text-primary-500" />
                  </div>
                </div>
                <h3 className="text-lg font-bold text-slate-700 mb-1">Clique para selecionar ou arraste o arquivo</h3>
                <p className="text-slate-500 text-sm">Formato suportado: CSV</p>
              </div>
              
              <div className="flex items-center justify-center gap-2 text-sm text-slate-600">
                <FileSpreadsheet className="w-4 h-4" />
                Precisa de ajuda? <button onClick={baixarModelo} className="text-primary-600 font-medium hover:underline flex items-center gap-1"><Download className="w-3 h-3"/> Baixe o modelo da planilha</button>
              </div>
            </div>
          )}

          {step === 'verificacao' && (
            <div className="space-y-6">
              <div className="bg-slate-50 rounded-lg p-4 flex items-start gap-4">
                <FileSpreadsheet className="w-8 h-8 text-slate-400" />
                <div className="flex-1">
                  <h4 className="font-bold text-slate-800">arquivo_mapa.csv</h4>
                  <p className="text-sm text-slate-500">{parsedData.length} registros encontrados</p>
                </div>
                <button onClick={() => setStep('upload')} className="text-sm font-medium text-primary-600">
                  Trocar Arquivo
                </button>
              </div>

              {erros.length > 0 && (
                <div className="bg-amber-50 rounded-lg p-4 border border-amber-200">
                  <h4 className="font-bold text-amber-800 flex items-center gap-2 mb-2">
                    <AlertTriangle className="w-5 h-5" /> Alertas encontrados na verificação
                  </h4>
                  <ul className="list-disc list-inside text-sm text-amber-700 space-y-1 ml-5">
                    {erros.map((erro, i) => <li key={i}>{erro}</li>)}
                  </ul>
                </div>
              )}

              {erros.length === 0 && (
                <div className="bg-emerald-50 rounded-lg p-4 border border-emerald-200">
                  <h4 className="font-bold text-emerald-800 flex items-center gap-2">
                    <CheckCircle className="w-5 h-5" /> Planilha verificada com sucesso! Sem erros ou duplicidades.
                  </h4>
                </div>
              )}

              <div className="border border-slate-200 rounded-lg overflow-x-auto">
                <table className="min-w-full divide-y divide-slate-200 text-sm">
                  <thead className="bg-slate-50">
                    <tr>
                      <th className="px-4 py-2 text-left font-medium text-slate-500">Data</th>
                      <th className="px-4 py-2 text-left font-medium text-slate-500">Horário</th>
                      <th className="px-4 py-2 text-left font-medium text-slate-500">Hospital</th>
                      <th className="px-4 py-2 text-left font-medium text-slate-500">Procedimento</th>
                      <th className="px-4 py-2 text-left font-medium text-slate-500">Médico</th>
                    </tr>
                  </thead>
                  <tbody className="divide-y divide-slate-200">
                    {parsedData.slice(0, 3).map((row, i) => (
                      <tr key={i} className="hover:bg-slate-50">
                        <td className="px-4 py-2 text-slate-800">{row.Data}</td>
                        <td className="px-4 py-2 text-slate-800">{row.Hora}</td>
                        <td className="px-4 py-2 text-slate-800">{row.Hospital}</td>
                        <td className="px-4 py-2 text-slate-800">{row.Procedimento}</td>
                        <td className="px-4 py-2 text-slate-800">{row.Medico}</td>
                      </tr>
                    ))}
                    {parsedData.length > 3 && (
                      <tr>
                        <td colSpan={5} className="px-4 py-2 text-center text-slate-500 italic">
                          ... e mais {parsedData.length - 3} registros
                        </td>
                      </tr>
                    )}
                  </tbody>
                </table>
              </div>

              <div className="flex justify-end gap-3 pt-4">
                <button onClick={() => setStep('upload')} className="px-6 py-2 border border-slate-300 rounded-lg text-slate-700 font-medium hover:bg-slate-50">
                  Cancelar
                </button>
                <button onClick={handleImport} className="px-6 py-2 bg-primary-600 text-white rounded-lg font-medium hover:bg-primary-700 flex items-center gap-2">
                  Confirmar Importação
                </button>
              </div>
            </div>
          )}

          {step === 'sucesso' && (
            <div className="text-center py-12">
              <div className="w-16 h-16 bg-emerald-100 rounded-full flex items-center justify-center mx-auto mb-4">
                <CheckCircle className="w-8 h-8 text-emerald-600" />
              </div>
              <h2 className="text-2xl font-bold text-slate-900 mb-2">Importação Concluída!</h2>
              <p className="text-slate-500 mb-6">As demandas foram geradas e já estão disponíveis no painel.</p>
            </div>
          )}
        </div>
      </div>
    </div>
  );
}
