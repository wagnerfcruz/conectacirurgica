import { forwardRef } from 'react';
import { format, parseISO } from 'date-fns';
import { ptBR } from 'date-fns/locale';
import { 
  User, Calendar, Clock, Building, 
  Briefcase, Phone, DollarSign, Stethoscope, 
  ClipboardList, Package, Settings, CheckCircle2, 
  AlertTriangle, FileText
} from 'lucide-react';
import type { Demanda, Instrumentador, EquipamentoServico } from '../store/useStore';
import { useStore } from '../store/useStore';

interface CartaoAcionamentoProps {
  demanda: Demanda;
  instrumentador: Instrumentador;
  scale?: number;
}

const CartaoAcionamento = forwardRef<HTMLDivElement, CartaoAcionamentoProps>(({ demanda, instrumentador, scale = 1 }, ref) => {
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

  const borderColor = '#9CD7E8';
  const textColor = '#0F2133';
  const cyanBg = '#B2EBF5';
  const darkBlue = '#013951';
  const labelColor = '#3A4C62';

  // SVG Logo Spine (approximating MEDITEC spine logo)
  const SpineLogo = () => (
    <svg width="28" height="60" viewBox="0 0 28 60" fill="none" xmlns="http://www.w3.org/2000/svg">
      <path d="M22 4C22 4 10 12 10 30C10 48 22 56 22 56" stroke="#0F2133" strokeWidth="4" strokeLinecap="round"/>
      <path d="M14 12L4 12M12 20L2 20M10 28L0 28M10 36L0 36M12 44L2 44M14 52L4 52" stroke="#2FA8CA" strokeWidth="3" strokeLinecap="round"/>
    </svg>
  );

  return (
    <div style={{ width: 700 * scale, height: 1280 * scale, overflow: 'hidden' }}>
      <div style={{ transform: `scale(${scale})`, transformOrigin: 'top left', width: 700, height: 1280 }}>
        <div 
          ref={ref} 
          className="w-[700px] h-[1280px] relative flex items-center justify-center p-6 shrink-0 mx-auto" 
          style={{ fontFamily: 'Montserrat, Inter, sans-serif', boxSizing: 'border-box', backgroundColor: '#11223F' }}
        >
          <div className="w-full h-full bg-white rounded-[1.5rem] flex flex-col relative overflow-hidden" style={{ border: `4px solid ${borderColor}` }}>
            
            {/* CABEÇALHO */}
            <div className="flex justify-between items-center px-8 py-5">
              <div className="flex items-center gap-3">
                {empresaConfig.logoUrl ? (
                  <img src={empresaConfig.logoUrl} alt="Logo" className="w-auto h-14" />
                ) : (
                  <SpineLogo />
                )}
                <div className="flex flex-col mt-1">
                  <h1 className="text-[52px] font-black tracking-tighter leading-none" style={{ color: textColor }}>
                    {empresaConfig.nome || 'MEDITEC'}
                  </h1>
                  <p className="text-[11px] font-bold tracking-[0.1em] mt-1" style={{ color: '#2FA8CA' }}>
                    {empresaConfig.tagline || 'MEDICINA COM TECNOLOGIA'}
                  </p>
                </div>
              </div>
              <div className="text-left border-l-[3px] pl-4 py-1" style={{ borderColor: textColor }}>
                <p className="text-[14px] uppercase font-medium leading-none" style={{ color: textColor }}>
                  {empresaConfig.headerTitleLine1 || 'AGENDAMENTO'}
                </p>
                <p className="text-[26px] font-black uppercase leading-tight mt-1" style={{ color: textColor }}>
                  {empresaConfig.headerTitleLine2 || 'FREELANCE'}
                </p>
              </div>
            </div>

            {/* INSTRUMENTADOR & MC */}
            <div className="relative px-8 py-5 flex items-center gap-5 border-y-[3px]" style={{ backgroundColor: cyanBg, borderColor }}>
              <div className="text-[#013951]">
                <User size={38} strokeWidth={2.5} />
              </div>
              <div className="flex-1 mt-1">
                <p className="text-[12px] font-medium uppercase" style={{ color: '#013951' }}>INSTRUMENTADOR(A)</p>
                <p className="font-black text-[24px] uppercase leading-none mt-1" style={{ color: '#013951' }}>
                  {fallback(instrumentador.nome, 'NÃO INFORMADO')}
                </p>
                <p className="text-[14px] font-bold uppercase mt-1" style={{ color: '#013951' }}>
                  ({fallback(instrumentador.nivel, 'NÍVEL 1')})
                </p>
              </div>
              
              <div className="w-[140px] rounded-[14px] flex flex-col items-center justify-center shadow-md absolute right-8" style={{ backgroundColor: darkBlue, height: '85px' }}>
                <p className="text-[12px] font-bold text-white uppercase mt-1">MC:</p>
                <p className="text-[40px] font-black text-white leading-none mt-0">{fallback(demanda.mc, '---')}</p>
              </div>
            </div>

            {/* PACIENTE */}
            <div className="px-8 py-[14px] flex items-center gap-6">
              <div className="w-10 h-10 rounded-full border-[2.5px] flex items-center justify-center shrink-0" style={{ borderColor, color: textColor }}>
                <User size={20} strokeWidth={2} />
              </div>
              <div className="flex-1 min-w-0">
                <p className="text-[12px] font-medium uppercase" style={{ color: labelColor }}>PACIENTE</p>
                <p className="font-black uppercase text-[20px] mt-0.5" style={{ color: textColor }}>
                  {fallback(demanda.paciente, 'NÃO INFORMADO')}
                </p>
              </div>
            </div>

            {/* EMPRESA & CONVENIO */}
            <div className="grid grid-cols-2 border-t-[2px]" style={{ borderColor }}>
              <div className="px-8 py-[14px] border-r-[2px] flex items-center gap-6" style={{ borderColor }}>
                <div className="w-10 h-10 rounded-[10px] border-[2.5px] flex items-center justify-center shrink-0" style={{ borderColor, color: textColor }}>
                  <Building size={20} strokeWidth={2} />
                </div>
                <div className="flex-1 min-w-0">
                  <p className="text-[12px] font-medium uppercase" style={{ color: labelColor }}>EMPRESA</p>
                  <p className="font-black uppercase text-[20px] mt-0.5" style={{ color: textColor }}>
                    {fallback(demanda.empresa, 'NÃO INFORMADA')}
                  </p>
                </div>
              </div>
              <div className="px-8 py-[14px] flex items-center gap-6">
                <div className="w-10 h-10 rounded-xl border-[2.5px] flex items-center justify-center shrink-0" style={{ borderColor, color: textColor }}>
                  <Briefcase size={20} strokeWidth={2} />
                </div>
                <div className="flex-1 min-w-0">
                  <p className="text-[12px] font-medium uppercase" style={{ color: labelColor }}>CONVÊNIO</p>
                  <p className="font-black uppercase text-[20px] truncate mt-0.5" style={{ color: textColor }}>
                    {fallback(demanda.convenio, 'NÃO INFORMADO')}
                  </p>
                </div>
              </div>
            </div>

            {/* HOSPITAL */}
            <div className="px-8 py-[14px] border-t-[2px] flex items-center gap-6" style={{ borderColor }}>
              <div className="w-10 h-10 rounded-[10px] border-[2.5px] flex items-center justify-center shrink-0" style={{ borderColor, color: textColor }}>
                <Building size={20} strokeWidth={2} />
              </div>
              <div className="flex-1 min-w-0">
                <p className="text-[12px] font-medium uppercase" style={{ color: labelColor }}>HOSPITAL</p>
                <p className="font-black uppercase text-[20px] mt-0.5" style={{ color: textColor }}>
                  {fallback(demanda.hospital, 'NÃO INFORMADO')}
                </p>
              </div>
            </div>

            {/* DATA & HORA */}
            <div className="grid grid-cols-[1.5fr_1fr] border-t-[2px]" style={{ borderColor }}>
              <div className="px-8 py-[14px] border-r-[2px] flex items-center gap-5" style={{ borderColor }}>
                <div className="w-10 h-10 rounded-[10px] border-[2.5px] flex items-center justify-center shrink-0" style={{ borderColor, color: textColor, backgroundColor: cyanBg }}>
                  <Calendar size={20} strokeWidth={2} />
                </div>
                <div className="flex-1 min-w-0">
                  <p className="text-[12px] font-medium uppercase" style={{ color: labelColor }}>DATA</p>
                  <p className="font-black uppercase text-[18px] mt-0.5 tracking-tight" style={{ color: textColor }}>
                    {demanda.data ? formatDateString(demanda.data) : 'SEM DADOS'}
                  </p>
                </div>
              </div>
              <div className="px-6 py-[14px] flex items-center gap-4">
                <div className="w-10 h-10 rounded-full border-[2.5px] flex items-center justify-center shrink-0" style={{ borderColor, color: textColor, backgroundColor: cyanBg }}>
                  <Clock size={20} strokeWidth={2} />
                </div>
                <div className="flex-1 min-w-0">
                  <p className="text-[11px] font-medium uppercase leading-[1.1]" style={{ color: labelColor }}>HORÁRIO DA<br/>CIRURGIA</p>
                  <p className="font-black uppercase text-[20px] mt-0.5" style={{ color: textColor }}>
                    {fallback(demanda.hora, '--:--')}
                  </p>
                </div>
              </div>
            </div>

            {/* FAIXA AMARELA (REAGENDAMENTO) */}
            {isReagendamento && (
              <div className="w-full py-2.5 flex items-center px-8 border-t-[2px] border-b-[2px]" style={{ backgroundColor: '#FDF152', borderColor }}>
                <p className="font-black text-[18px] text-black uppercase tracking-wide">
                  REAGENDAMENTO
                </p>
              </div>
            )}

            {/* MEDICO */}
            <div className="px-8 py-[14px] border-t-[2px] flex items-center gap-6" style={{ borderColor }}>
              <div className="w-10 h-10 rounded-full border-[2.5px] flex items-center justify-center shrink-0" style={{ borderColor, color: textColor }}>
                <Stethoscope size={20} strokeWidth={2} />
              </div>
              <div className="flex-1 min-w-0">
                <p className="text-[12px] font-medium uppercase" style={{ color: labelColor }}>MÉDICO</p>
                <p className="font-black uppercase text-[20px] mt-0.5" style={{ color: textColor }}>
                  {fallback(demanda.medico, 'NÃO INFORMADO')}
                </p>
              </div>
            </div>

            {/* PROCEDIMENTO */}
            <div className="px-8 py-[14px] border-t-[2px] flex items-center gap-6" style={{ borderColor }}>
              <div className="w-10 h-10 rounded-md border-[2.5px] flex items-center justify-center shrink-0" style={{ borderColor, color: textColor }}>
                <ClipboardList size={20} strokeWidth={2} />
              </div>
              <div className="flex-1 min-w-0">
                <p className="text-[12px] font-medium uppercase" style={{ color: labelColor }}>PROCEDIMENTO</p>
                <p className="font-black uppercase text-[20px] line-clamp-1 mt-0.5" style={{ color: textColor }}>
                  {fallback(demanda.procedimento, 'NÃO INFORMADO')}
                </p>
              </div>
            </div>

            {/* PRODUTOS / MATERIAIS */}
            <div className="px-8 py-[14px] border-t-[2px] flex items-start gap-6" style={{ borderColor }}>
              <div className="w-10 h-10 rounded-[10px] border-[2.5px] flex items-center justify-center shrink-0 mt-1" style={{ borderColor, color: textColor }}>
                <Package size={20} strokeWidth={2} />
              </div>
              <div className="flex-1 min-w-0">
                <p className="font-black uppercase text-[19px]" style={{ color: textColor }}>PRODUTOS / MATERIAIS</p>
                <div className="text-[16px] font-medium mt-1 leading-snug" style={{ color: textColor }}>
                  {demanda.produtosLista && demanda.produtosLista.length > 0 ? (
                    demanda.produtosLista.map((p, i) => (
                      <span key={i}><strong>{p.quantidade}x</strong> {p.descricao}{i < demanda.produtosLista!.length - 1 ? '; ' : ''}</span>
                    ))
                  ) : demanda.produtos ? (
                    demanda.produtos
                  ) : (
                    'Sem dados'
                  )}
                </div>
              </div>
            </div>

            {/* EQUIPAMENTOS / SERVICOS */}
            <div className="px-8 py-[14px] border-t-[2px] flex items-start gap-6" style={{ borderColor }}>
              <div className="w-10 h-10 rounded-[10px] border-[2.5px] flex items-center justify-center shrink-0 mt-1" style={{ borderColor, color: textColor }}>
                <Settings size={20} strokeWidth={2} />
              </div>
              <div className="flex-1 min-w-0">
                <p className="font-black uppercase text-[19px]" style={{ color: textColor }}>EQUIPAMENTOS / SERVIÇOS</p>
                <div className="text-[16px] font-medium mt-1 leading-snug" style={{ color: textColor }}>
                  {demanda.equipamentosLista && demanda.equipamentosLista.length > 0 ? (
                    demanda.equipamentosLista.map((e: EquipamentoServico, i: number) => (
                      <span key={i}><strong>{e.descricao}</strong> {e.quantidade ? `Qtd: ${e.quantidade}` : ''}{i < demanda.equipamentosLista!.length - 1 ? '; ' : ''}</span>
                    ))
                  ) : demanda.equipamentos ? (
                     demanda.equipamentos
                  ) : (
                    'Sem dados'
                  )}
                </div>
              </div>
            </div>

            {/* FOOTER */}
            <div className="flex-1 border-t-[2px] grid grid-cols-2" style={{ borderColor }}>
              
              {/* LEFT COL */}
              <div className="border-r-[2px] flex flex-col" style={{ borderColor }}>
                {/* Representante */}
                <div className="px-8 py-5 flex items-center gap-4">
                  <div className="w-9 h-9 rounded-xl border-[2.5px] flex items-center justify-center shrink-0" style={{ borderColor, color: textColor }}>
                    <Phone size={18} strokeWidth={2} />
                  </div>
                  <div>
                    <p className="text-[11px] font-medium uppercase" style={{ color: labelColor }}>REPRESENTANTE</p>
                    <p className="font-black uppercase text-[16px] leading-tight mt-0.5" style={{ color: textColor }}>
                      {fallback(demanda.representante)}
                    </p>
                  </div>
                </div>

                {/* Valor do Free */}
                <div className="px-8 flex-1 flex items-center gap-4 pb-2">
                  <div className="w-12 h-12 rounded-full border-[2.5px] flex items-center justify-center shrink-0" style={{ borderColor: darkBlue, color: darkBlue, backgroundColor: cyanBg }}>
                    <DollarSign size={24} strokeWidth={2.5} />
                  </div>
                  <div>
                    <p className="text-[11px] font-medium uppercase" style={{ color: labelColor }}>VALOR DO FREE</p>
                    <p className="font-black text-[26px] tracking-tight mt-0.5 leading-none" style={{ color: textColor }}>
                      {fallback(demanda.valorFreelancer, 'R$ 0,00')}
                    </p>
                  </div>
                </div>

                {/* Retorno OF */}
                <div className="px-8 py-5 flex items-center gap-4 border-t-[2px]" style={{ borderColor }}>
                  <div className="w-9 h-9 rounded-md border-[2.5px] flex items-center justify-center shrink-0" style={{ borderColor, color: textColor }}>
                    <ClipboardList size={18} strokeWidth={2} />
                  </div>
                  <div>
                    <p className="text-[11px] font-medium uppercase" style={{ color: labelColor }}>RETORNO OF</p>
                    <p className="font-black uppercase text-[16px] leading-tight mt-0.5" style={{ color: textColor }}>
                      {fallback(demanda.retornoOp)}
                    </p>
                  </div>
                </div>
              </div>

              {/* RIGHT COL */}
              <div className="flex flex-col">
                {/* Confirmação */}
                <div className="px-6 py-5 flex items-center gap-4 border-b-[2px]" style={{ borderColor }}>
                  <div className="w-9 h-9 rounded-full border-[2.5px] flex items-center justify-center shrink-0" style={{ borderColor, color: textColor }}>
                    <CheckCircle2 size={18} strokeWidth={2} />
                  </div>
                  <div>
                    <p className="text-[11px] font-medium uppercase" style={{ color: labelColor }}>CONFIRMAÇÃO</p>
                    <p className="font-black uppercase text-[16px] leading-tight mt-0.5" style={{ color: textColor }}>
                      {fallback(demanda.confirmacao)}
                    </p>
                  </div>
                </div>

                {/* Observações */}
                <div className="px-6 py-5 flex-1 flex items-start gap-4 border-b-[2px]" style={{ borderColor }}>
                  <div className="w-9 h-9 rounded-md border-[2.5px] flex items-center justify-center shrink-0 mt-0.5" style={{ borderColor, color: textColor }}>
                    <FileText size={18} strokeWidth={2} />
                  </div>
                  <div>
                    <p className="text-[11px] font-medium uppercase" style={{ color: labelColor }}>OBSERVAÇÕES</p>
                    <p className="font-black uppercase text-[16px] leading-tight mt-0.5" style={{ color: textColor }}>
                      {fallback(demanda.observacoes)}
                    </p>
                  </div>
                </div>

                {/* Emergência */}
                <div className="px-6 py-5 flex items-center gap-4">
                  <div className="w-9 h-9 rounded-full border-[2.5px] flex items-center justify-center shrink-0" style={{ borderColor, color: textColor }}>
                    <AlertTriangle size={18} strokeWidth={2} />
                  </div>
                  <div>
                    <p className="text-[11px] font-medium uppercase" style={{ color: labelColor }}>EMERGÊNCIA</p>
                    <p className="font-black uppercase text-[16px] leading-tight mt-0.5" style={{ color: textColor }}>
                      {demanda.emergencia ? 'SIM' : 'NAO'}
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
