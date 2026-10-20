import { Calendar, MapPin, User, Clock, Download } from 'lucide-react';
import { useState } from 'react';
import { useStore } from '../../store/useStore';
import { format, parseISO } from 'date-fns';

export default function Confirmados() {
  const [selectedCirurgiaId, setSelectedCirurgiaId] = useState<number | null>(null);
  const { demandas, instrumentadores } = useStore();

  const confirmados = demandas.filter(d => ['confirmado', 'realizado'].includes(d.status));
  const selectedCirurgia = confirmados.find(c => c.id === selectedCirurgiaId);
  
  const getInstName = (id?: number | null) => {
    if (!id) return 'Não alocado';
    return instrumentadores.find(i => i.id === id)?.nome || 'Desconhecido';
  };

  const formatDate = (dateStr: string) => {
    try {
      return format(parseISO(dateStr), 'dd/MM/yyyy');
    } catch {
      return dateStr;
    }
  };

  const handleDownload = () => {
    if (!selectedCirurgia) return;
    const content = `CARTÃO DE ACIONAMENTO\n\nProcedimento: ${selectedCirurgia.procedimento}\nData: ${formatDate(selectedCirurgia.data)}\nHora: ${selectedCirurgia.hora}\nHospital: ${selectedCirurgia.hospital}\nMédico: ${selectedCirurgia.medico}\nInstrumentador: ${getInstName(selectedCirurgia.instrumentadorId)}\n\nDocumento gerado para fins de demonstração na plataforma Conecta Cirúrgica.`;
    const blob = new Blob([content], { type: 'text/plain;charset=utf-8' });
    const url = URL.createObjectURL(blob);
    const a = document.createElement('a');
    a.href = url;
    a.download = `cartao_acionamento_${selectedCirurgia.id}.txt`;
    document.body.appendChild(a);
    a.click();
    document.body.removeChild(a);
    URL.revokeObjectURL(url);
  };

  return (
    <div className="space-y-6">
      <div className="flex justify-between items-end flex-wrap gap-4">
        <div>
          <h1 className="text-2xl font-bold text-slate-900">Agenda Confirmada</h1>
          <p className="text-slate-500">Acompanhe os acionamentos com aceite confirmado.</p>
        </div>
        <div className="flex gap-2 w-full md:w-auto">
          <input type="date" className="border-slate-300 rounded-md shadow-sm text-sm p-2 border flex-1" />
          <button className="bg-white border border-slate-300 hover:bg-slate-50 text-slate-700 px-4 py-2 rounded-md font-medium text-sm transition-colors">
            Filtrar
          </button>
        </div>
      </div>

      <div className="grid grid-cols-1 lg:grid-cols-3 gap-6">
        {/* Lista */}
        <div className="lg:col-span-2 space-y-4">
          {confirmados.length === 0 && (
            <div className="bg-white p-8 text-center rounded-xl border border-slate-200 text-slate-500">
              Nenhuma cirurgia confirmada no momento.
            </div>
          )}
          {confirmados.map(c => (
            <div 
              key={c.id} 
              className={`bg-white rounded-xl p-5 border cursor-pointer transition-all ${selectedCirurgiaId === c.id ? 'border-primary-500 shadow-md ring-1 ring-primary-500' : 'border-slate-200 shadow-sm hover:border-primary-300'}`}
              onClick={() => setSelectedCirurgiaId(c.id)}
            >
              <div className="flex justify-between items-start mb-4">
                <div>
                  <h3 className="text-lg font-bold text-slate-900">{c.procedimento}</h3>
                  <p className="text-sm text-slate-500">Cirurgião: {c.medico}</p>
                </div>
                <span className={`px-2.5 py-1 text-xs font-bold uppercase rounded-full ${
                  c.status === 'realizado' ? 'bg-blue-100 text-blue-700' : 'bg-emerald-100 text-emerald-700'
                }`}>
                  {c.status}
                </span>
              </div>
              
              <div className="grid grid-cols-2 md:grid-cols-4 gap-4 bg-slate-50 p-3 rounded-lg">
                <div>
                  <p className="text-xs text-slate-500 flex items-center gap-1 mb-1"><Calendar className="w-3 h-3"/> Data</p>
                  <p className="font-semibold text-sm text-slate-800">{formatDate(c.data)}</p>
                </div>
                <div>
                  <p className="text-xs text-slate-500 flex items-center gap-1 mb-1"><Clock className="w-3 h-3"/> Horário</p>
                  <p className="font-semibold text-sm text-slate-800">{c.hora}</p>
                </div>
                <div className="md:col-span-2">
                  <p className="text-xs text-slate-500 flex items-center gap-1 mb-1"><MapPin className="w-3 h-3"/> Local</p>
                  <p className="font-semibold text-sm text-slate-800 truncate" title={c.hospital}>{c.hospital}</p>
                </div>
              </div>
              
              <div className="mt-4 flex items-center justify-between border-t border-slate-100 pt-4">
                <div className="flex items-center gap-2">
                  <div className="w-8 h-8 bg-primary-100 rounded-full flex items-center justify-center text-primary-700 font-bold text-xs">
                    {getInstName(c.instrumentadorId).substring(0,2).toUpperCase()}
                  </div>
                  <div>
                    <p className="text-xs text-slate-500">Instrumentador</p>
                    <p className="text-sm font-bold text-slate-800">{getInstName(c.instrumentadorId)}</p>
                  </div>
                </div>
                <button className="text-primary-600 text-sm font-medium hover:text-primary-800">Ver Cartão</button>
              </div>
            </div>
          ))}
        </div>

        {/* Cartão Lateral (Demonstrativo) */}
        {selectedCirurgia && (
          <div className="bg-slate-800 rounded-2xl p-6 text-white shadow-xl relative overflow-hidden h-fit lg:sticky lg:top-6 mt-6 lg:mt-0">
            <div className="absolute top-0 right-0 w-32 h-32 bg-primary-500/20 rounded-bl-full -mr-8 -mt-8"></div>
            
            <div className="flex justify-between items-start relative z-10 mb-6">
              <h2 className="text-lg font-bold text-slate-100">Cartão de Acionamento</h2>
              <button onClick={handleDownload} title="Baixar Demonstrativo" className="p-1 hover:bg-slate-700 rounded-full transition-colors">
                <Download className="w-5 h-5 text-emerald-400" />
              </button>
            </div>

            <div className="space-y-6 relative z-10">
              <div>
                <p className="text-slate-400 text-xs uppercase font-bold tracking-wider mb-1">Procedimento</p>
                <p className="text-xl font-bold">{selectedCirurgia.procedimento}</p>
              </div>
              
              <div className="grid grid-cols-2 gap-4 border-y border-slate-700 py-4">
                <div>
                  <p className="text-slate-400 text-xs uppercase font-bold tracking-wider mb-1">Data</p>
                  <p className="font-medium">{formatDate(selectedCirurgia.data)}</p>
                </div>
                <div>
                  <p className="text-slate-400 text-xs uppercase font-bold tracking-wider mb-1">Chegada</p>
                  <p className="font-medium">{selectedCirurgia.hora}</p>
                </div>
              </div>

              <div>
                <p className="text-slate-400 text-xs uppercase font-bold tracking-wider mb-1">Local</p>
                <p className="font-medium mb-1">{selectedCirurgia.hospital}</p>
                <p className="text-sm text-slate-300">Endereço Confidencial</p>
              </div>

              <div>
                <p className="text-slate-400 text-xs uppercase font-bold tracking-wider mb-1">Equipe Médica</p>
                <p className="font-medium">{selectedCirurgia.medico}</p>
              </div>

              <div className="bg-slate-700/50 p-4 rounded-xl">
                <p className="text-slate-400 text-xs uppercase font-bold tracking-wider mb-2 flex items-center gap-2"><User className="w-4 h-4"/> Instrumentador Alocado</p>
                <p className="font-bold text-lg text-emerald-400">{getInstName(selectedCirurgia.instrumentadorId)}</p>
              </div>
            </div>
            
            <div className="mt-8 pt-4 border-t border-slate-700 relative z-10 text-center flex flex-col gap-2 items-center">
              <button onClick={handleDownload} className="w-full bg-emerald-600 hover:bg-emerald-700 text-white py-2 rounded-lg text-sm font-medium transition-colors flex justify-center items-center gap-2">
                <Download className="w-4 h-4" /> Download Demonstrativo
              </button>
              <p className="text-[10px] text-slate-500 uppercase tracking-widest mt-2">Documento Fictício para Demonstração</p>
            </div>
          </div>
        )}
      </div>
    </div>
  );
}
