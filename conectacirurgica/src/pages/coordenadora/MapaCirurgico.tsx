import { FileSpreadsheet, AlertTriangle, CheckCircle, Download, FileType } from 'lucide-react';
import { useState, useRef } from 'react';
import Papa from 'papaparse';
import * as XLSX from 'xlsx';
import type { Demanda } from '../../store/useStore';
import { useStore } from '../../store/useStore';

export default function MapaCirurgico() {
  const { addDemandas, demandas, updateDemanda } = useStore();
  const [step, setStep] = useState<'upload' | 'mapeamento' | 'verificacao' | 'sucesso'>('upload');
  const [parsedData, setParsedData] = useState<any[]>([]);
  const [csvHeaders, setCsvHeaders] = useState<string[]>([]);
  const [erros, setErros] = useState<string[]>([]);
  const [alertas, setAlertas] = useState<string[]>([]);
  const fileInputRef = useRef<HTMLInputElement>(null);

  // Mapeamento configurável para lidar com Meditec e outros
  const [fieldMapping, setFieldMapping] = useState<Record<string, string>>({});

  const dbFields = [
    { key: 'mc', label: 'Código MC (Num Cirurgia)' },
    { key: 'status', label: 'Status da Demanda' },
    { key: 'dataHora', label: 'Data e Hora (Planilha)' },
    { key: 'paciente', label: 'Paciente' },
    { key: 'medico', label: 'Médico Responsável' },
    { key: 'convenio', label: 'Convênio' },
    { key: 'hospital', label: 'Hospital' },
    { key: 'procedimento', label: 'Procedimento' },
    { key: 'produtos', label: 'Produtos' },
    { key: 'produtosDoacao', label: 'Produtos p/ Doação' },
    { key: 'equipamentos', label: 'Servicos/equipamentos' },
    { key: 'representante', label: 'Representante' },
    { key: 'emergencia', label: 'Emergencia' },
    { key: 'obs', label: 'Obs' },
    { key: 'retornoOp', label: 'Retorno OF' }
  ];

  const handleFileUpload = async (e: React.ChangeEvent<HTMLInputElement>) => {
    const file = e.target.files?.[0];
    if (!file) return;

    const fileExt = file.name.split('.').pop()?.toLowerCase();

    if (fileExt === 'csv') {
      Papa.parse(file, {
        header: true,
        skipEmptyLines: true,
        complete: (results) => {
          if (results.meta.fields) {
            setupMappingAndData(results.meta.fields, results.data);
          }
        },
        error: (error: any) => {
          setErros([`Erro ao ler arquivo CSV: ${error.message}`]);
          setStep('mapeamento');
        }
      });
    } else if (fileExt === 'xlsx' || fileExt === 'xls') {
      try {
        const data = await file.arrayBuffer();
        const workbook = XLSX.read(data, { type: 'array', cellDates: true });
        
        // Remove espaços e ignora acentos na hora de procurar a aba
        const normalize = (str: string) => str.toLowerCase().normalize("NFD").replace(/[\u0300-\u036f]/g, "").trim();
        
        let sheetName = workbook.SheetNames.find(n => normalize(n) === 'usuarios') || workbook.SheetNames[0];
        const worksheet = workbook.Sheets[sheetName];
        
        const jsonData = XLSX.utils.sheet_to_json(worksheet, { 
          defval: '',
          raw: false,
          dateNF: 'dd/mm/yyyy hh:mm:ss'
        });

        if (jsonData && jsonData.length > 0) {
          const headers = Object.keys(jsonData[0] as object);
          setupMappingAndData(headers, jsonData);
        } else {
          setErros([`A aba "${sheetName}" está vazia ou os dados não puderam ser lidos.`]);
          setStep('mapeamento');
        }
      } catch (err: any) {
        console.error(err);
        setErros([`Erro crítico ao ler arquivo Excel: ${err?.message || 'Erro desconhecido'}`]);
        setStep('mapeamento');
      }
    } else {
      alert('Formato de arquivo não suportado. Use CSV ou XLSX.');
    }
    
    // Reset file input
    if (fileInputRef.current) fileInputRef.current.value = '';
  };

  const setupMappingAndData = (headers: string[], data: any[]) => {
    setCsvHeaders(headers);
    
    // Auto-mapeamento focado na planilha MEDITEC
    const initialMapping: Record<string, string> = {};
    const meditecMap: Record<string, string> = {
      'Num Cirurgia': 'mc',
      'Status': 'status',
      'Data': 'dataHora',
      'Paciente': 'paciente',
      'Médico': 'medico',
      'Convênio': 'convenio',
      'Hospital': 'hospital',
      'Procedimento': 'procedimento',
      'Produtos': 'produtos',
      'Produtos p/ Doação': 'produtosDoacao',
      'Servicos/equipamentos': 'equipamentos',
      'Representante': 'representante',
      'Emergencia': 'emergencia',
      'Obs': 'obs',
      'Retorno OF': 'retornoOp'
    };

    headers.forEach(header => {
      const matchKey = Object.keys(meditecMap).find(k => k.toLowerCase() === header.toLowerCase());
      if (matchKey) {
        initialMapping[header] = meditecMap[matchKey];
      }
    });

    setFieldMapping(initialMapping);
    setParsedData(data);
    setStep('mapeamento');
  };

  const isSentinel = (val: any) => {
    return val === null || val === undefined || String(val).trim() === '' || String(val).trim() === '31';
  };

  const parseDataHora = (val: string) => {
    if (!val || isSentinel(val)) return { dataStr: '', horaStr: '' };
    
    // Caso venha como DD/MM/AAAA HH:MM:SS ou similar
    const parts = val.split(' ');
    let dataStr = '';
    let horaStr = '';

    if (parts.length > 0) {
      const datePart = parts[0];
      if (datePart.includes('/')) {
        const [d, m, y] = datePart.split('/');
        dataStr = `${y}-${m.padStart(2, '0')}-${d.padStart(2, '0')}`;
      } else {
        dataStr = datePart; // assumindo que pode estar em YYYY-MM-DD
      }
    }
    if (parts.length > 1) {
      // Extrai apenas HH:MM
      const timeParts = parts[1].split(':');
      if (timeParts.length >= 2) {
        horaStr = `${timeParts[0].padStart(2, '0')}:${timeParts[1].padStart(2, '0')}`;
      } else {
        horaStr = parts[1];
      }
    }
    
    return { dataStr, horaStr };
  };

  const handleGoToVerification = () => {
    validarDados(parsedData);
    setStep('verificacao');
  };

  const validarDados = (data: any[]) => {
    const novosErros: string[] = [];
    const novosAlertas: string[] = [];
    
    if (data.length === 0) {
      novosErros.push('O arquivo está vazio.');
    } else {
      const colMc = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'mc');
      const colDataHora = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'dataHora');
      const colStatus = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'status');
      const colProcedimento = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'procedimento');

      if (!colMc || !colDataHora || !colProcedimento) {
        novosErros.push('Mapeamento inválido: MC (Num Cirurgia), Data e Procedimento são obrigatórios para a importação.');
      } else {
        data.forEach((row, index) => {
          const rawMc = row[colMc];
          const rawDataHora = row[colDataHora];
          const rawProcedimento = row[colProcedimento];
          const rawStatus = colStatus ? row[colStatus] : '';

          if (isSentinel(rawMc) || isSentinel(rawDataHora) || isSentinel(rawProcedimento)) {
            novosErros.push(`Linha ${index + 2}: Faltam dados essenciais (Num Cirurgia, Data ou Procedimento).`);
          } else {
            // Verificar status
            const statusUpper = String(rawStatus).toUpperCase();
            if (statusUpper.includes('CANCELADO') || statusUpper.includes('CANCELAMENTO')) {
              novosAlertas.push(`Linha ${index + 2}: MC ${rawMc} está com status de CANCELADO na planilha.`);
            }

            // Verificar duplicidade
            const stringMc = String(rawMc).trim();
            const exists = demandas.find(d => d.mc === stringMc);
            if (exists) {
              if (statusUpper.includes('CANCELADO') || statusUpper.includes('CANCELAMENTO')) {
                 novosAlertas.push(`Linha ${index + 2}: MC ${stringMc} já existe e será marcado para cancelamento se prosseguir.`);
              } else {
                 novosAlertas.push(`Linha ${index + 2}: MC ${stringMc} já existe no sistema. Suas informações serão mantidas/atualizadas dependendo da regra de negócio.`);
              }
            }
          }
        });
      }
    }
    setErros(novosErros);
    setAlertas(novosAlertas);
  };

  const handleImport = () => {
    if (erros.length > 0) {
      alert('Corrija os erros críticos antes de importar.');
      return;
    }

    const colMc = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'mc')!;
    const colDataHora = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'dataHora')!;
    const colStatus = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'status');
    const colPaciente = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'paciente');
    const colMedico = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'medico');
    const colConvenio = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'convenio');
    const colHospital = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'hospital');
    const colProcedimento = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'procedimento')!;
    const colProdutos = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'produtos');
    const colProdutosDoacao = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'produtosDoacao');
    const colEquipamentos = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'equipamentos');
    const colRepresentante = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'representante');
    const colEmergencia = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'emergencia');
    const colObs = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'obs');
    const colRetornoOp = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'retornoOp');

    const novasDemandasParaAdicionar: Omit<Demanda, 'id' | 'status'>[] = [];

    parsedData.forEach(row => {
      const rawMc = String(row[colMc]).trim();
      const rawDataHora = row[colDataHora];
      const rawStatus = colStatus ? String(row[colStatus] || '').trim().toUpperCase() : '';
      
      const isCancelado = rawStatus.includes('CANCELADO') || rawStatus.includes('CANCELAMENTO');
      
      const { dataStr, horaStr } = parseDataHora(String(rawDataHora));
      
      const getValue = (colName?: string) => {
        if (!colName) return undefined;
        const val = row[colName];
        return isSentinel(val) ? undefined : String(val).trim();
      };

      const obsText = [
        getValue(colObs),
        getValue(colProdutosDoacao) ? `Produtos p/ Doação: ${getValue(colProdutosDoacao)}` : null
      ].filter(Boolean).join('\n\n');

      const isEmergencia = colEmergencia ? String(row[colEmergencia]).toUpperCase() === 'SIM' : false;

      const existingDemanda = demandas.find(d => d.mc === rawMc);

      if (existingDemanda) {
        // Atualizar demanda existente se for cancelada ou algo similar
        // Não vamos subscrever demandas ativas com os dados do excel de forma destrutiva 
        // a não ser que o status mude para cancelado
        if (isCancelado && existingDemanda.status !== 'cancelado') {
          updateDemanda(existingDemanda.id, { 
            status: 'cancelado',
            motivoCancelamento: 'Cancelado via importação de planilha'
          });
        }
      } else {
        if (!isCancelado) {
          novasDemandasParaAdicionar.push({
            mc: rawMc,
            data: dataStr,
            hora: horaStr,
            hospital: getValue(colHospital) || 'Não informado',
            procedimento: getValue(colProcedimento) || '',
            medico: getValue(colMedico) || 'Não informado',
            paciente: getValue(colPaciente) || '',
            empresa: 'MEDITEC', // Baseado no contexto do fixture, mas deve ser parametrizado no futuro
            convenio: getValue(colConvenio) || '',
            representante: getValue(colRepresentante) || '',
            produtos: getValue(colProdutos) || '',
            equipamentos: getValue(colEquipamentos) || '',
            produtosLista: [],
            equipamentosLista: [],
            confirmacao: 'SEM DADOS',
            retornoOp: getValue(colRetornoOp) || 'Não retornado',
            emergencia: isEmergencia,
            observacoes: obsText || undefined,
            tipoEvento: rawStatus.includes('REAGENDADO') ? 'REAGENDAMENTO' : 'AGENDAMENTO'
          });
        }
      }
    });

    if (novasDemandasParaAdicionar.length > 0) {
      addDemandas(novasDemandasParaAdicionar);
    }
    
    setStep('sucesso');
    setTimeout(() => {
      setStep('upload');
      setParsedData([]);
      setErros([]);
      setAlertas([]);
      setFieldMapping({});
      setCsvHeaders([]);
    }, 5000);
  };

  const baixarModelo = () => {
    const csvContent = "Num Cirurgia,Status,Data,Paciente,Médico,Convênio,Hospital,Procedimento,Produtos,Produtos p/ Doação,Servicos/equipamentos,Representante,Instrumentador,Emergencia,Obs,Retorno OF\n12345,Agendado,25/10/2026 08:00,João Silva,Dr. Paulo,Bradesco,Hospital Central,Artroplastia,Parafusos,,Motor,Carlos,,Nao,Ligar antes,Sem retorno";
    const blob = new Blob([csvContent], { type: 'text/csv;charset=utf-8;' });
    const link = document.createElement("a");
    const url = URL.createObjectURL(blob);
    link.setAttribute("href", url);
    link.setAttribute("download", "modelo_mapa_meditec.csv");
    link.style.visibility = 'hidden';
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
  };

  return (
    <div className="space-y-6 max-w-5xl mx-auto">
      <div>
        <h1 className="text-2xl font-bold text-slate-900">Importação de Mapa Cirúrgico</h1>
        <p className="text-slate-500">Importe a planilha (XLSX, XLS ou CSV) para gerar demandas automaticamente e prevenir duplicidades.</p>
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-100 overflow-hidden">
        {/* Progress Bar */}
        <div className="flex border-b border-slate-100 bg-slate-50">
          <div className={`flex-1 text-center py-3 text-sm font-bold ${step === 'upload' ? 'text-primary-600 border-b-2 border-primary-600' : 'text-slate-400'}`}>
            1. Upload do Arquivo
          </div>
          <div className={`flex-1 text-center py-3 text-sm font-bold ${step === 'mapeamento' ? 'text-primary-600 border-b-2 border-primary-600' : 'text-slate-400'}`}>
            2. Mapeamento de Colunas
          </div>
          <div className={`flex-1 text-center py-3 text-sm font-bold ${step === 'verificacao' ? 'text-primary-600 border-b-2 border-primary-600' : 'text-slate-400'}`}>
            3. Verificação de Dados
          </div>
        </div>

        <div className="p-8">
          {step === 'upload' && (
            <div className="text-center space-y-6">
              <input 
                type="file" 
                accept=".csv, .xls, .xlsx, application/vnd.ms-excel, application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
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
                    <FileSpreadsheet className="w-8 h-8 text-primary-500" />
                  </div>
                </div>
                <h3 className="text-lg font-bold text-slate-700 mb-1">Clique para selecionar a planilha de mapa cirúrgico</h3>
                <p className="text-slate-500 text-sm">Formatos suportados: XLSX, XLS, CSV. O sistema irá buscar prioritariamente a aba "Usuários".</p>
              </div>
              
              <div className="flex items-center justify-center gap-2 text-sm text-slate-600">
                <FileType className="w-4 h-4" />
                Precisa do formato padrão? <button onClick={baixarModelo} className="text-primary-600 font-medium hover:underline flex items-center gap-1"><Download className="w-3 h-3"/> Baixe o CSV de exemplo</button>
              </div>
            </div>
          )}

          {step === 'mapeamento' && (
            <div className="space-y-6">
              <div className="bg-blue-50 border border-blue-200 text-blue-800 p-4 rounded-lg text-sm">
                <strong>Associe as colunas do arquivo aos campos do sistema.</strong> O sistema tentou mapear automaticamente com base no padrão MEDITEC. Valores em branco ou "31" serão tratados como "Sem informação".
              </div>
              <div className="space-y-4 max-h-[50vh] overflow-y-auto pr-4">
                {dbFields.map(field => {
                  const isRequired = ['mc', 'dataHora', 'procedimento'].includes(field.key);
                  return (
                    <div key={field.key} className="flex items-center gap-4 border-b border-slate-100 pb-4">
                      <div className="w-1/2">
                        <label className="font-bold text-slate-700 text-sm">{field.label} {isRequired && <span className="text-red-500">*</span>}</label>
                      </div>
                      <div className="w-1/2">
                        <select 
                          className="w-full border border-slate-300 rounded p-2 text-sm bg-white"
                          value={Object.keys(fieldMapping).find(k => fieldMapping[k] === field.key) || ''}
                          onChange={(e) => {
                            const newMapping = { ...fieldMapping };
                            Object.keys(newMapping).forEach(k => { if(newMapping[k] === field.key) delete newMapping[k]; });
                            if (e.target.value) {
                              newMapping[e.target.value] = field.key;
                            }
                            setFieldMapping(newMapping);
                          }}
                        >
                          <option value="">-- Ignorar (Não importar) --</option>
                          {csvHeaders.map(h => <option key={h} value={h}>{h}</option>)}
                        </select>
                      </div>
                    </div>
                  );
                })}
              </div>
              <div className="flex justify-between items-center pt-4 border-t border-slate-200">
                {erros.length > 0 && (
                  <div className="text-red-600 text-sm font-medium">{erros[0]}</div>
                )}
                <div className="flex gap-3 ml-auto">
                  <button onClick={() => setStep('upload')} className="px-6 py-2 border border-slate-300 rounded-lg text-slate-700 font-medium hover:bg-slate-50">
                    Cancelar
                  </button>
                  <button onClick={handleGoToVerification} className="px-6 py-2 bg-primary-600 text-white rounded-lg font-medium hover:bg-primary-700 flex items-center gap-2">
                    Avançar para Verificação
                  </button>
                </div>
              </div>
            </div>
          )}

          {step === 'verificacao' && (
            <div className="space-y-6">
              <div className="grid grid-cols-2 gap-4">
                <div className="bg-slate-50 rounded-lg p-4 flex items-start gap-4 border border-slate-200">
                  <FileSpreadsheet className="w-8 h-8 text-slate-400" />
                  <div className="flex-1">
                    <h4 className="font-bold text-slate-800">Planilha carregada</h4>
                    <p className="text-sm text-slate-500">{parsedData.length} registros encontrados para análise</p>
                  </div>
                </div>
                
                <div className="bg-slate-50 rounded-lg p-4 flex items-start gap-4 border border-slate-200">
                  <div className="flex-1">
                    <h4 className="font-bold text-slate-800">Resumo da Ação</h4>
                    <p className="text-sm text-slate-500">Demandas novas serão criadas. Demandas canceladas serão atualizadas. Demandas existentes ativas serão ignoradas para evitar sobrescrita.</p>
                  </div>
                </div>
              </div>

              {erros.length > 0 && (
                <div className="bg-red-50 rounded-lg p-4 border border-red-200">
                  <h4 className="font-bold text-red-800 flex items-center gap-2 mb-2">
                    <AlertTriangle className="w-5 h-5" /> Erros que impedem a importação
                  </h4>
                  <ul className="list-disc list-inside text-sm text-red-700 space-y-1 ml-5">
                    {erros.map((erro, i) => <li key={i}>{erro}</li>)}
                  </ul>
                </div>
              )}

              {alertas.length > 0 && (
                <div className="bg-amber-50 rounded-lg p-4 border border-amber-200 max-h-40 overflow-y-auto">
                  <h4 className="font-bold text-amber-800 flex items-center gap-2 mb-2">
                    <AlertTriangle className="w-5 h-5" /> Alertas (Verifique antes de confirmar)
                  </h4>
                  <ul className="list-disc list-inside text-sm text-amber-700 space-y-1 ml-5">
                    {alertas.map((alerta, i) => <li key={i}>{alerta}</li>)}
                  </ul>
                </div>
              )}

              {erros.length === 0 && alertas.length === 0 && (
                <div className="bg-emerald-50 rounded-lg p-4 border border-emerald-200">
                  <h4 className="font-bold text-emerald-800 flex items-center gap-2">
                    <CheckCircle className="w-5 h-5" /> Planilha verificada com sucesso! Pronto para importar.
                  </h4>
                </div>
              )}

              <div className="border border-slate-200 rounded-lg overflow-x-auto">
                <table className="min-w-full divide-y divide-slate-200 text-sm">
                  <thead className="bg-slate-50">
                    <tr>
                      <th className="px-4 py-2 text-left font-medium text-slate-500">Num Cirurgia</th>
                      <th className="px-4 py-2 text-left font-medium text-slate-500">Data e Hora</th>
                      <th className="px-4 py-2 text-left font-medium text-slate-500">Paciente</th>
                      <th className="px-4 py-2 text-left font-medium text-slate-500">Procedimento</th>
                      <th className="px-4 py-2 text-left font-medium text-slate-500">Status</th>
                    </tr>
                  </thead>
                  <tbody className="divide-y divide-slate-200">
                    {parsedData.slice(0, 5).map((row, i) => {
                      const colMc = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'mc') || '';
                      const colDataHora = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'dataHora') || '';
                      const colPaciente = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'paciente') || '';
                      const colProcedimento = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'procedimento') || '';
                      const colStatus = Object.keys(fieldMapping).find(k => fieldMapping[k] === 'status') || '';
                      
                      const val = (k: string) => isSentinel(row[k]) ? '-' : String(row[k]);

                      return (
                        <tr key={i} className="hover:bg-slate-50">
                          <td className="px-4 py-2 text-slate-800 font-medium">{val(colMc)}</td>
                          <td className="px-4 py-2 text-slate-800">{val(colDataHora)}</td>
                          <td className="px-4 py-2 text-slate-800">{val(colPaciente)}</td>
                          <td className="px-4 py-2 text-slate-800">{val(colProcedimento)}</td>
                          <td className="px-4 py-2 text-slate-800">
                            {val(colStatus).toUpperCase().includes('CANCELADO') ? (
                              <span className="text-red-600 font-semibold">{val(colStatus)}</span>
                            ) : val(colStatus)}
                          </td>
                        </tr>
                      );
                    })}
                    {parsedData.length > 5 && (
                      <tr>
                        <td colSpan={5} className="px-4 py-2 text-center text-slate-500 italic bg-slate-50">
                          ... e mais {parsedData.length - 5} registros não exibidos na prévia
                        </td>
                      </tr>
                    )}
                  </tbody>
                </table>
              </div>

              <div className="flex justify-between items-center pt-4 border-t border-slate-200">
                <button onClick={() => setStep('mapeamento')} className="px-6 py-2 border border-slate-300 rounded-lg text-slate-700 font-medium hover:bg-slate-50">
                  Voltar ao Mapeamento
                </button>
                <button 
                  onClick={handleImport} 
                  disabled={erros.length > 0}
                  className="px-6 py-2 bg-primary-600 text-white rounded-lg font-medium hover:bg-primary-700 disabled:opacity-50 disabled:cursor-not-allowed flex items-center gap-2"
                >
                  <CheckCircle className="w-5 h-5"/> Confirmar e Importar
                </button>
              </div>
            </div>
          )}

          {step === 'sucesso' && (
            <div className="text-center py-12">
              <div className="w-16 h-16 bg-emerald-100 rounded-full flex items-center justify-center mx-auto mb-4">
                <CheckCircle className="w-8 h-8 text-emerald-600" />
              </div>
              <h2 className="text-2xl font-bold text-slate-900 mb-2">Importação Concluída com Sucesso!</h2>
              <p className="text-slate-500 mb-6">O mapa cirúrgico foi processado. As novas demandas já estão disponíveis no painel de acionamentos.</p>
              <button onClick={() => setStep('upload')} className="px-6 py-2 border border-slate-300 rounded-lg text-slate-700 font-medium hover:bg-slate-50">
                Fazer nova importação
              </button>
            </div>
          )}
        </div>
      </div>
    </div>
  );
}

