import { forwardRef } from 'react';
import { format, parseISO } from 'date-fns';
import { ptBR } from 'date-fns/locale';
import { 
  User, Calendar, Clock, MapPin, Activity, 
  CheckCircle, FileText, AlertTriangle, Building, 
  Briefcase, Phone, DollarSign 
} from 'lucide-react';
import type { Demanda, Instrumentador, EquipamentoServico } from '../store/useStore';
import useStore from '../store/useStore';

interface CartaoAcionamentoProps {
  demanda: Demanda;
  instrumentador: Instrumentador;
  scale?: number;
}

const CartaoAcionamento = forwardRef<HTMLDivElement, CartaoAcionamentoProps>(({ demanda, instrumentador, scale = 0.5 }, ref) => {
  const { empresaConfig } = useStore();
  
  const formatDateString = (dateStr: string) => {
    try {
      return format(parseISO(dateStr), "dd/MM/yyyy - eeee", { locale: ptBR }).toUpperCase();
    } catch {
      return dateStr || 'SEM DADOS';
    }
  };

  const isReagendamento = demanda.tipoEvento?.toUpperCase() === 'REAGENDAMENTO';
  
  const fallback = (val: any, fallbackStr = 'SEM DADOS') => {
    if (!val || val.trim() === '') return fallbackStr;
    return val;
  };

  return (
    <div style={{ width: 700 * scale, height: 1280 * scale, overflow: 'hidden' }}>
      <div style={{ transform: `scale(${scale})`, transformOrigin: 'top left', width: 700, height: 1280 }}>
        <div 
          ref={ref} 
          className="w-[700px] h-[1280px] bg-[#1C3259] relative flex items-center justify-center p-8 shrink-0 mx-auto" 
          style={{ fontFamily: 'Inter, sans-serif', boxSizing: 'border-box' }}
        >
          <div className="w-full h-full bg-white rounded-3xl border-4 border-[#2ABFCF] flex flex-col overflow-hidden relative shadow-2xl">
            
            {/* CABEÇALHO */}
            <div className="flex justify-between items-center px-10 py-8 border-b-4 border-[#AFEAF8]">
              <div className="flex items-center gap-4">
                {empresaConfig.logoUrl ? (
                  <img src={empresaConfig.logoUrl} alt="Logo" className="w-16 h-16 object-contain" />
                ) : null}
                <div className="flex flex-col">
                  <h1 className="text-5xl font-black tracking-tighter text-[#1C3259] leading-none">
                    {empresaConfig.nome || 'CONECTA'}
                  </h1>
                  <p className="text-sm tracking-[0.2em] text-slate-500 font-bold uppercase mt-1">
                    {empresaConfig.tagline || 'CIRÚRGICA'}
                  </p>
                </div>
              </div>
              <div className="text-right border-l-4 border-slate-200 pl-6 py-2">
                <p className="text-lg uppercase text-slate-500 font-bold tracking-wide">
                  {demanda.tipoEvento || empresaConfig.headerTitleLine1 || 'AGENDAMENTO'}
                </p>
                <p className="text-3xl font-black text-[#1C3259] uppercase tracking-tight">
                  {empresaConfig.headerTitleLine2 || 'FREELANCE'}
                </p>
              </div>
            </div>

            {/* TOP ROW: Instrumentador & MC */}
            <div className="px-10 py-8 flex gap-6">
              <div className="flex-1 bg-[#E3F6FD] rounded-2xl p-6 flex items-center gap-6 border-2 border-[#AFEAF8]">
                <div className="w-16 h-16 bg-[#013A55] text-white rounded-full flex items-center justify-center shrink-0 shadow-md">
                  <User className="w-8 h-8" />
                </div>
                <div>
                  <p className="text-sm text-[#013A55] font-bold uppercase mb-1 tracking-wider">INSTRUMENTADOR(A)</p>
                  <p className="font-black text-[#1C3259] text-3xl uppercase leading-tight line-clamp-2">
                    {fallback(instrumentador.nome, 'NÃO INFORMADO')}
                  </p>
                  <p className="text-sm font-bold text-slate-600 uppercase mt-1">
                    ({fallback(instrumentador.nivel, 'NÍVEL NÃO INFORMADO')})
                  </p>
                </div>
              </div>
              
              <div className="w-48 bg-[#1C3259] rounded-2xl p-6 flex flex-col items-center justify-center text-white shrink-0 shadow-xl">
                <p className="text-sm text-slate-300 font-bold uppercase mb-1 tracking-widest">MC:</p>
                <p className="text-5xl font-black truncate w-full text-center">{fallback(demanda.mc, '---')}</p>
              </div>
            </div>

            {/* DADOS PRINCIPAIS */}
            <div className="flex-1 flex flex-col">
              {/* PACIENTE */}
              <div className="px-10 py-5 border-y-2 border-[#AFEAF8] flex items-center gap-6">
                <div className="w-12 h-12 rounded-full border-2 border-slate-300 flex items-center justify-center shrink-0 text-slate-500">
                  <User className="w-6 h-6" />
                </div>
                <div className="flex-1 min-w-0">
                  <p className="text-sm text-slate-500 font-bold uppercase mb-1">PACIENTE</p>
                  <p className="font-black text-[#1C3259] uppercase text-xl truncate">
                    {fallback(demanda.paciente, 'NÃO INFORMADO')}
                  </p>
                </div>
              </div>

              {/* EMPRESA & CONVENIO */}
              <div className="grid grid-cols-2">
                <div className="px-10 py-5 border-b-2 border-r-2 border-[#AFEAF8] flex items-center gap-6">
                  <div className="w-12 h-12 rounded-full border-2 border-slate-300 flex items-center justify-center shrink-0 text-slate-500">
                    <Building className="w-6 h-6" />
                  </div>
                  <div className="flex-1 min-w-0">
                    <p className="text-sm text-slate-500 font-bold uppercase mb-1">EMPRESA</p>
                    <p className="font-black text-[#1C3259] uppercase text-xl truncate">
                      {fallback(demanda.empresa, 'NÃO INFORMADA')}
                    </p>
                  </div>
                </div>
                <div className="px-10 py-5 border-b-2 border-[#AFEAF8] flex items-center gap-6">
                  <div className="w-12 h-12 rounded-full border-2 border-slate-300 flex items-center justify-center shrink-0 text-slate-500">
                    <Briefcase className="w-6 h-6" />
                  </div>
                  <div className="flex-1 min-w-0">
                    <p className="text-sm text-slate-500 font-bold uppercase mb-1">CONVÊNIO</p>
                    <p className="font-black text-[#1C3259] uppercase text-xl truncate">
                      {fallback(demanda.convenio, 'NÃO INFORMADO')}
                    </p>
                  </div>
                </div>
              </div>

              {/* HOSPITAL */}
              <div className="px-10 py-5 border-b-2 border-[#AFEAF8] flex items-center gap-6 bg-slate-50">
                <div className="w-12 h-12 rounded-full border-2 border-[#2ABFCF] bg-white flex items-center justify-center shrink-0 text-[#013A55] shadow-sm">
                  <MapPin className="w-6 h-6" />
                </div>
                <div className="flex-1 min-w-0">
                  <p className="text-sm text-slate-500 font-bold uppercase mb-1">HOSPITAL</p>
                  <p className="font-black text-[#1C3259] uppercase text-2xl truncate">
                    {fallback(demanda.hospital, 'NÃO INFORMADO')}
                  </p>
                </div>
              </div>

              {/* DATA & HORA */}
              <div className="grid grid-cols-2">
                <div className="px-10 py-5 border-b-2 border-r-2 border-[#AFEAF8] flex items-center gap-6 bg-[#E3F6FD]">
                  <div className="w-12 h-12 rounded-full border-2 border-[#2ABFCF] bg-white flex items-center justify-center shrink-0 text-[#013A55] shadow-sm">
                    <Calendar className="w-6 h-6" />
                  </div>
                  <div className="flex-1 min-w-0">
                    <p className="text-sm text-[#013A55] font-bold uppercase mb-1">DATA DA CIRURGIA</p>
                    <p className="font-black text-[#1C3259] uppercase text-xl truncate">
                      {demanda.data ? formatDateString(demanda.data) : 'SEM DADOS'}
                    </p>
                  </div>
                </div>
                <div className="px-10 py-5 border-b-2 border-[#AFEAF8] flex items-center gap-6 bg-[#E3F6FD]">
                  <div className="w-12 h-12 rounded-full border-2 border-[#2ABFCF] bg-white flex items-center justify-center shrink-0 text-[#013A55] shadow-sm">
                    <Clock className="w-6 h-6" />
                  </div>
                  <div className="flex-1 min-w-0">
                    <p className="text-sm text-[#013A55] font-bold uppercase mb-1">HORÁRIO</p>
                    <p className="font-black text-[#1C3259] uppercase text-3xl truncate">
                      {fallback(demanda.hora, '--:--')}
                    </p>
                  </div>
                </div>
              </div>

              {/* FAIXA AMARELA DE EVENTO (REAGENDAMENTO) */}
              {isReagendamento && (
                <div className="bg-amber-400 text-amber-900 font-black text-center py-3 uppercase text-lg tracking-widest shadow-inner border-y border-amber-500">
                  ATENÇÃO: ESTA CIRURGIA FOI REAGENDADA
                </div>
              )}

              {/* PROCEDIMENTO */}
              <div className="px-10 py-5 border-b-2 border-[#AFEAF8] flex items-center gap-6">
                <div className="w-12 h-12 rounded-full border-2 border-slate-300 flex items-center justify-center shrink-0 text-slate-500">
                  <Activity className="w-6 h-6" />
                </div>
                <div className="flex-1 min-w-0">
                  <p className="text-sm text-slate-500 font-bold uppercase mb-1">PROCEDIMENTO</p>
                  <p className="font-black text-[#1C3259] uppercase text-xl line-clamp-2 leading-tight">
                    {fallback(demanda.procedimento, 'NÃO INFORMADO')}
                  </p>
                </div>
              </div>

              {/* MÉDICO */}
              <div className="px-10 py-5 flex items-center gap-6">
                <div className="w-12 h-12 rounded-full border-2 border-slate-300 flex items-center justify-center shrink-0 text-slate-500">
                  <User className="w-6 h-6" />
                </div>
                <div className="flex-1 min-w-0">
                  <p className="text-sm text-slate-500 font-bold uppercase mb-1">MÉDICO</p>
                  <p className="font-black text-[#1C3259] uppercase text-xl truncate">
                    {fallback(demanda.medico, 'NÃO INFORMADO')}
                  </p>
                </div>
              </div>

              {/* PRODUTOS E MATERIAIS */}
              <div className="mx-10 mt-2 mb-4 border-2 border-[#AFEAF8] rounded-2xl overflow-hidden flex-1 flex flex-col shadow-sm">
                <div className="bg-[#E3F6FD] px-6 py-4 flex items-center gap-3 border-b-2 border-[#AFEAF8] shrink-0">
                  <div className="w-8 h-8 rounded-full border-2 border-[#2ABFCF] flex items-center justify-center text-[#013A55] bg-white">
                    <div className="w-4 h-4 bg-[#013A55] rounded-full" />
                  </div>
                  <p className="font-black text-lg text-[#1C3259] uppercase tracking-wide">PRODUTOS E MATERIAIS</p>
                </div>
                <div className="bg-white p-6 text-lg text-slate-700 whitespace-pre-wrap overflow-y-auto flex-1 font-medium leading-relaxed">
                  {demanda.produtosLista && demanda.produtosLista.length > 0 ? (
                    demanda.produtosLista.map((p, i) => (
                      <div key={i} className="mb-2"><strong>{p.quantidade}x</strong> {p.descricao}</div>
                    ))
                  ) : demanda.produtos ? (
                    demanda.produtos
                  ) : (
                    'SEM DADOS'
                  )}
                </div>
              </div>

              {/* EQUIPAMENTOS */}
              <div className="mx-10 mb-6 border-2 border-[#AFEAF8] rounded-2xl overflow-hidden shrink-0 shadow-sm">
                <div className="bg-[#E3F6FD] px-6 py-4 flex items-center gap-3 border-b-2 border-[#AFEAF8]">
                  <div className="w-8 h-8 rounded-full border-2 border-[#2ABFCF] flex items-center justify-center text-[#013A55] bg-white">
                    <div className="w-4 h-4 bg-[#013A55] rounded-full" />
                  </div>
                  <p className="font-black text-lg text-[#1C3259] uppercase tracking-wide">EQUIPAMENTOS / SERVIÇOS</p>
                </div>
                <div className="bg-white p-6 text-lg text-slate-700 whitespace-pre-wrap font-medium leading-relaxed">
                  {demanda.equipamentosLista && demanda.equipamentosLista.length > 0 ? (
                    demanda.equipamentosLista.map((e: EquipamentoServico, i: number) => (
                      <div key={i} className="mb-1"><strong>{e.descricao}</strong> {e.quantidade ? `Qtd: ${e.quantidade}` : ''}</div>
                    ))
                  ) : demanda.equipamentos ? (
                     demanda.equipamentos
                  ) : (
                    'SEM DADOS'
                  )}
                </div>
              </div>

            </div>

            {/* FOOTER GRID */}
            <div className="px-10 py-6 border-t-4 border-[#AFEAF8] bg-[#F8FAFC] grid grid-cols-2 gap-8 shrink-0">
              
              {/* LEFT COL */}
              <div className="space-y-6">
                <div className="flex items-start gap-4">
                  <div className="w-10 h-10 rounded-full border-2 border-slate-300 flex items-center justify-center shrink-0 text-slate-500 bg-white">
                    <Phone className="w-5 h-5" />
                  </div>
                  <div className="flex-1 min-w-0">
                    <p className="text-sm text-slate-500 font-bold uppercase mb-1">REPRESENTANTE</p>
                    <p className="font-black text-[#1C3259] uppercase text-lg leading-tight truncate">
                      {fallback(demanda.representante)}
                    </p>
                  </div>
                </div>

                <div className="border-2 rounded-2xl p-4 flex items-center gap-4 bg-white shadow-sm" style={{ borderColor: '#AFEAF8' }}>
                  <div className="w-12 h-12 rounded-full border-2 border-[#1C3259] bg-[#E3F6FD] flex items-center justify-center shrink-0 text-[#1C3259]">
                    <DollarSign className="w-6 h-6" />
                  </div>
                  <div className="flex-1 min-w-0">
                    <p className="text-sm text-slate-500 font-bold uppercase mb-1">VALOR DO FREE</p>
                    <p className="font-black text-2xl text-[#1C3259] truncate">
                      {fallback(demanda.valorFreelancer, 'A COMBINAR')}
                    </p>
                  </div>
                </div>

                <div className="flex items-start gap-4">
                  <div className="w-10 h-10 rounded-full border-2 border-slate-300 flex items-center justify-center shrink-0 text-slate-500 bg-white">
                    <FileText className="w-5 h-5" />
                  </div>
                  <div className="flex-1 min-w-0">
                    <p className="text-sm text-slate-500 font-bold uppercase mb-1">RETORNO OF</p>
                    <p className="font-black text-[#1C3259] uppercase text-lg leading-tight truncate">
                      {fallback(demanda.retornoOp)}
                    </p>
                  </div>
                </div>
              </div>

              {/* RIGHT COL */}
              <div className="space-y-6">
                <div className="flex items-start gap-4">
                  <div className="w-10 h-10 rounded-full border-2 border-[#2ABFCF] bg-[#E3F6FD] flex items-center justify-center shrink-0 text-[#013A55]">
                    <CheckCircle className="w-5 h-5" />
                  </div>
                  <div className="flex-1 min-w-0">
                    <p className="text-sm text-[#013A55] font-bold uppercase mb-1">CONFIRMAÇÃO</p>
                    <p className="font-black text-[#1C3259] uppercase text-lg leading-tight truncate">
                      {fallback(demanda.confirmacao)}
                    </p>
                  </div>
                </div>

                <div className="flex items-start gap-4">
                  <div className="w-10 h-10 rounded-full border-2 border-slate-300 flex items-center justify-center shrink-0 text-slate-500 bg-white">
                    <FileText className="w-5 h-5" />
                  </div>
                  <div className="flex-1 min-w-0">
                    <p className="text-sm text-slate-500 font-bold uppercase mb-1">OBSERVAÇÕES</p>
                    <p className="font-black text-[#1C3259] uppercase text-lg leading-tight line-clamp-3">
                      {fallback(demanda.observacoes)}
                    </p>
                  </div>
                </div>

                <div className="flex items-start gap-4">
                  <div className="w-10 h-10 rounded-full border-2 border-red-300 bg-red-50 flex items-center justify-center shrink-0 text-red-500">
                    <AlertTriangle className="w-5 h-5" />
                  </div>
                  <div className="flex-1 min-w-0">
                    <p className="text-sm text-red-500 font-bold uppercase mb-1">EMERGÊNCIA</p>
                    <p className="font-black text-red-600 uppercase text-xl leading-tight truncate">
                      {demanda.emergencia ? 'SIM - URGENTE' : 'NÃO'}
                    </p>
                  </div>
                </div>
              </div>

            </div>

          </div>
        </div>
      </div>
    </div>
  );
});

CartaoAcionamento.displayName = 'CartaoAcionamento';
export default CartaoAcionamento;
