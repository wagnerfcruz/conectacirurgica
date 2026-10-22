import { Calendar, MapPin, Clock, Download, Copy, Check } from 'lucide-react';
import { useState, useRef } from 'react';
import { useStore } from '../../store/useStore';
import { format, parseISO } from 'date-fns';
import clsx from 'clsx';
import CartaoAcionamento from '../../components/CartaoAcionamento';
import CardResponsiveWrapper from '../../components/CardResponsiveWrapper';
import DemandaFormModal from '../../components/DemandaFormModal';
import { exportElementAsPng } from '../../utils/exportElementAsPng';
import type { Demanda } from '../../store/useStore';

export default function Confirmados() {
  const [selectedCirurgiaId, setSelectedCirurgiaId] = useState<number | null>(null);
  const [isEditModalOpen, setIsEditModalOpen] = useState(false);
  const { demandas, instrumentadores, updateDemanda } = useStore();
  const [copySuccess, setCopySuccess] = useState(false);
  const [downloadSuccess, setDownloadSuccess] = useState(false);
  const cardRef = useRef<HTMLDivElement>(null);

  const confirmados = demandas.filter(d => ['confirmado', 'realizado'].includes(d.status));
  const selectedCirurgia = confirmados.find(c => c.id === selectedCirurgiaId);
  
  const getInstName = (id?: number | null) => {
    if (!id) return 'Não alocado';
    return instrumentadores.find(i => i.id === id)?.nome || 'Desconhecido';
  };

  const getInstData = (id?: number | null) => {
    if (!id) return null;
    return instrumentadores.find(i => i.id === id);
  };

  const formatDate = (dateStr: string) => {
    try {
      return format(parseISO(dateStr), 'dd/MM/yyyy');
    } catch {
      return dateStr;
    }
  };

  const handleCopyText = () => {
    if (!selectedCirurgia) return;
    const inst = getInstData(selectedCirurgia.instrumentadorId);
    
    const text = `*CARTÃO DE ACIONAMENTO*\n\n` +
      `*Procedimento:* ${selectedCirurgia.procedimento}\n` +
      `*Data:* ${formatDate(selectedCirurgia.data)}\n` +
      `*Hora:* ${selectedCirurgia.hora}\n` +
      `*Hospital:* ${selectedCirurgia.hospital}\n` +
      `*Médico:* ${selectedCirurgia.medico}\n` +
      `*Valor:* ${selectedCirurgia.valorFreelancer || 'A combinar'}\n\n` +
      `*Profissional Alocado:* ${inst?.nome}\n` +
      `*Contato:* ${inst?.celular || 'Não informado'}\n`;
      
    navigator.clipboard.writeText(text).then(() => {
      setCopySuccess(true);
      setTimeout(() => setCopySuccess(false), 2000);
    });
  };

  const handleSaveDemanda = (d: Partial<Demanda>) => {
    if (d.id) {
      updateDemanda(d.id, d);
    }
    setIsEditModalOpen(false);
  };

  const handleDownloadImage = async () => {
    if (!cardRef.current || !selectedCirurgia) return;
    
    try {
      await exportElementAsPng(
        cardRef.current,
        `Acionamento_${selectedCirurgia.procedimento.replace(/\s+/g, '_')}_${selectedCirurgia.data}.png`,
        '#11223F'
      );
      
      setDownloadSuccess(true);
      setTimeout(() => setDownloadSuccess(false), 2000);
    } catch (error) {
      console.error('Error generating image:', error);
      alert('Houve um erro ao gerar a imagem.');
    }
  };

  return (
    <div className="space-y-6">
      <div className="flex justify-between items-end flex-wrap gap-4">
        <div>
          <h1 className="text-2xl font-bold text-slate-900">Agenda Confirmada</h1>
          <p className="text-slate-500">Acompanhe os acionamentos com aceite confirmado e gere cartões de acesso.</p>
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
                <button onClick={(e) => { e.stopPropagation(); setSelectedCirurgiaId(c.id); setIsEditModalOpen(true); }} className="text-primary-600 text-sm font-medium hover:text-primary-800 flex items-center gap-1 border border-primary-100 bg-primary-50 px-3 py-1 rounded-md">Editar / Detalhes</button>
              </div>
            </div>
          ))}
        </div>

        {/* Cartão Lateral (Demonstrativo) */}
        {selectedCirurgia && (
          <div className="space-y-4 h-fit lg:sticky lg:top-6 mt-6 lg:mt-0 flex flex-col items-center">
            {/* Visual card for UI (Responsive) */}
            <div className="w-full max-w-[400px] rounded-2xl shadow-2xl bg-transparent overflow-hidden">
              <CardResponsiveWrapper>
                <CartaoAcionamento 
                  demanda={selectedCirurgia} 
                  instrumentador={getInstData(selectedCirurgia.instrumentadorId) || { id: 0, nome: 'Não alocado', especialidades: [], regiao: '', validado: false, atuacoes: 0, nota: '', disponibilidade: {} }} 
                />
              </CardResponsiveWrapper>
            </div>

            {/* Hidden card for Perfect Export */}
            <div style={{ position: 'fixed', left: '200vw', top: 0, pointerEvents: 'none', zIndex: -1 }}>
              <CartaoAcionamento 
                ref={cardRef} 
                demanda={selectedCirurgia} 
                instrumentador={getInstData(selectedCirurgia.instrumentadorId) || { id: 0, nome: 'Não alocado', especialidades: [], regiao: '', validado: false, atuacoes: 0, nota: '', disponibilidade: {} }} 
              />
            </div>

            {/* Ações */}
            <div className="flex flex-col gap-2 w-full max-w-[450px]">
              <button 
                onClick={handleCopyText} 
                className={clsx(
                  "w-full py-2.5 rounded-xl text-sm font-medium transition-colors flex justify-center items-center gap-2 border",
                  copySuccess ? "bg-emerald-50 text-emerald-700 border-emerald-200" : "bg-white text-slate-700 hover:bg-slate-50 border-slate-200"
                )}
              >
                {copySuccess ? <Check className="w-4 h-4" /> : <Copy className="w-4 h-4" />}
                {copySuccess ? 'Copiado para área de transferência' : 'Copiar Texto para WhatsApp'}
              </button>

              <button 
                onClick={handleDownloadImage} 
                className={clsx(
                  "w-full py-2.5 rounded-xl text-sm font-medium transition-colors flex justify-center items-center gap-2 shadow-sm",
                  downloadSuccess ? "bg-emerald-600 hover:bg-emerald-700 text-white" : "bg-primary-600 hover:bg-primary-700 text-white"
                )}
              >
                {downloadSuccess ? <Check className="w-4 h-4" /> : <Download className="w-4 h-4" />}
                {downloadSuccess ? 'Imagem salva!' : 'Baixar Cartão (PNG)'}
              </button>
            </div>
          </div>
        )}
      </div>
      {isEditModalOpen && selectedCirurgia && (
        <DemandaFormModal
          isOpen={isEditModalOpen}
          onClose={() => setIsEditModalOpen(false)}
          demanda={selectedCirurgia}
          onSave={handleSaveDemanda}
        />
      )}
    </div>
  );
}
