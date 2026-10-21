import { forwardRef } from 'react';
import { format, parseISO } from 'date-fns';
import { ptBR } from 'date-fns/locale';
import { 
  User, Calendar, Clock, Building, 
  Phone, DollarSign, Stethoscope, 
  ClipboardList, Package, Settings, CheckCircle2, 
  AlertTriangle, FileText, CreditCard
} from 'lucide-react';
import type { Demanda, Instrumentador } from '../store/useStore';
import { useStore } from '../store/useStore';

interface CartaoAcionamentoProps {
  demanda: Demanda;
  instrumentador: Instrumentador;
}

const CartaoAcionamento = forwardRef<HTMLDivElement, CartaoAcionamentoProps>(({ demanda, instrumentador }, ref) => {
  const { empresaConfig } = useStore();
  
  const formatDateString = (dateStr: string) => {
    try {
      if (!dateStr || dateStr === 'SEM DADOS') return 'SEM DADOS';
      // Assume dateStr is yyyy-MM-dd
      return format(parseISO(dateStr), "dd/MM/yyyy - eeee", { locale: ptBR }).toUpperCase();
    } catch {
      return dateStr || 'SEM DADOS';
    }
  };

  const isReagendamento = demanda.tipoEvento?.toUpperCase() === 'REAGENDAMENTO';
  
  const fallback = (val: any, fallbackStr = 'SEM DADOS') => {
    if (!val || val === '') return fallbackStr;
    return val;
  };

  const borderColor = '#E0F2FE'; // ciano claro para bordas e divisórias
  const textColor = '#0F2133'; // texto azul escuro principal
  const cyanBg = '#E0F2FE'; // fundo do instrumentador e icones
  const darkBlue = '#013951'; // caixas escuras e ícones
  const labelColor = '#64748B'; // cinza azulado para labels

  return (
    <div 
      ref={ref} 
      className="w-[700px] h-[1180px] relative flex items-center justify-center p-6 shrink-0 mx-auto" 
      style={{ fontFamily: 'Montserrat, Inter, sans-serif', boxSizing: 'border-box', backgroundColor: '#11223F' }}
    >
      {/* Outer Card with curved white background */}
      <div className="w-full h-full bg-white flex flex-col relative" style={{ borderRadius: '24px', overflow: 'hidden' }}>
        
        {/* Curva decorativa superior esquerda (opcional/simplificada com border radius maior na div interna) */}
        
        {/* CABEÇALHO */}
        <div className="flex justify-between items-center px-8 py-5">
          <div className="flex items-center gap-4">
            <img src={empresaConfig.logoUrl && empresaConfig.logoUrl !== "/meditec_logo.png" ? empresaConfig.logoUrl : `${import.meta.env.BASE_URL}meditec_logo.png`.replace("//", "/")} alt="Logo" className="w-auto h-16" onError={(e) => { e.currentTarget.style.display = 'none'; }} />
            <div className="flex flex-col">
              <h1 className="text-[42px] font-black tracking-tighter leading-none" style={{ color: textColor }}>
                {empresaConfig.nome || 'MEDITEC'}
              </h1>
              <p className="text-[12px] font-bold tracking-[0.05em] mt-1" style={{ color: '#2FA8CA' }}>
                {empresaConfig.tagline || 'MEDICINA COM TECNOLOGIA'}
              </p>
            </div>
          </div>
          <div className="text-right border-l-[3px] pl-4 py-1 flex flex-col items-start" style={{ borderColor: '#000' }}>
            <p className="text-[14px] uppercase font-bold leading-none" style={{ color: '#2FA8CA' }}>
              {empresaConfig.headerTitleLine1 || 'AGENDAMENTO'}
            </p>
            <p className="text-[24px] font-black uppercase leading-tight mt-1" style={{ color: textColor }}>
              {empresaConfig.headerTitleLine2 || 'FREELANCE'}
            </p>
          </div>
        </div>

        {/* BLOCO INSTRUMENTADOR (Banner) */}
        <div className="mx-8 py-4 px-5 flex items-center gap-5 relative rounded-2xl mb-4" style={{ backgroundColor: cyanBg }}>
          <div style={{ color: darkBlue }}>
            <User size={40} strokeWidth={2.5} />
          </div>
          <div className="flex-1">
            <p className="text-[12px] font-bold uppercase" style={{ color: labelColor }}>INSTRUMENTADOR(A)</p>
            <p className="font-black text-[22px] uppercase leading-none mt-1" style={{ color: darkBlue }}>
              {fallback(instrumentador?.nome, 'NÃO INFORMADO')}
            </p>
            <p className="text-[14px] font-bold uppercase mt-1" style={{ color: darkBlue }}>
              ({fallback(instrumentador?.nivel, 'NÍVEL 1')})
            </p>
          </div>
          
          <div className="w-[130px] h-[75px] rounded-xl flex flex-col items-center justify-center absolute right-4" style={{ backgroundColor: darkBlue }}>
            <p className="text-[12px] font-bold text-white uppercase">MC:</p>
            <p className="text-[38px] font-black text-white leading-none">{fallback(demanda?.mc, '---')}</p>
          </div>
        </div>

        {/* CORPO PRINCIPAL */}
        <div className="flex-1 flex flex-col px-8">
          
          {/* Paciente */}
          <div className="py-3 flex items-center gap-4">
            <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
              <User size={20} strokeWidth={2.5} />
            </div>
            <div className="flex-1 min-w-0">
              <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>PACIENTE</p>
              <p className="font-black uppercase text-[18px] leading-tight" style={{ color: textColor }}>
                {fallback(demanda?.paciente, 'NÃO INFORMADO')}
              </p>
            </div>
          </div>
          <div className="border-b" style={{ borderColor }}></div>

          {/* Empresa / Convenio */}
          <div className="py-3 grid grid-cols-2">
            <div className="flex items-center gap-4 border-r pr-4" style={{ borderColor }}>
              <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
                <Building size={20} strokeWidth={2.5} />
              </div>
              <div className="min-w-0">
                <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>EMPRESA</p>
                <p className="font-black uppercase text-[16px] leading-tight" style={{ color: textColor }}>
                  {fallback(demanda?.empresa, 'NÃO INFORMADO')}
                </p>
              </div>
            </div>
            <div className="flex items-center gap-4 pl-4">
              <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
                <CreditCard size={20} strokeWidth={2.5} />
              </div>
              <div className="min-w-0">
                <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>CONVÊNIO</p>
                <p className="font-black uppercase text-[16px] leading-tight" style={{ color: textColor }}>
                  {fallback(demanda?.convenio, 'NÃO INFORMADO')}
                </p>
              </div>
            </div>
          </div>
          <div className="border-b" style={{ borderColor }}></div>

          {/* Hospital */}
          <div className="py-3 flex items-center gap-4">
            <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
              <Building size={20} strokeWidth={2.5} />
            </div>
            <div className="flex-1 min-w-0">
              <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>HOSPITAL</p>
              <p className="font-black uppercase text-[18px] leading-tight" style={{ color: textColor }}>
                {fallback(demanda?.hospital, 'NÃO INFORMADO')}
              </p>
            </div>
          </div>
          <div className="border-b" style={{ borderColor }}></div>

          {/* Data / Horario */}
          <div className="py-3 grid grid-cols-2">
            <div className="flex items-center gap-4 border-r pr-4" style={{ borderColor }}>
              <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
                <Calendar size={20} strokeWidth={2.5} />
              </div>
              <div className="min-w-0">
                <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>DATA</p>
                <p className="font-black uppercase text-[15px] leading-tight" style={{ color: textColor }}>
                  {formatDateString(demanda?.data)}
                </p>
              </div>
            </div>
            <div className="flex items-center gap-4 pl-4">
              <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
                <Clock size={20} strokeWidth={2.5} />
              </div>
              <div className="min-w-0">
                <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>HORÁRIO DA CIRURGIA</p>
                <p className="font-black uppercase text-[18px] leading-tight" style={{ color: textColor }}>
                  {fallback(demanda?.hora, '---')}H
                </p>
              </div>
            </div>
          </div>
          
          {/* Reagendamento Banner */}
          {isReagendamento && (
            <div className="bg-yellow-400 -mx-8 py-2 px-8 my-2">
              <p className="font-black text-[18px] uppercase text-black">REAGENDAMENTO</p>
            </div>
          )}
          {!isReagendamento && <div className="border-b" style={{ borderColor }}></div>}

          {/* Médico */}
          <div className="py-3 flex items-center gap-4">
            <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
              <Stethoscope size={20} strokeWidth={2.5} />
            </div>
            <div className="flex-1 min-w-0">
              <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>MÉDICO</p>
              <p className="font-black uppercase text-[18px] leading-tight" style={{ color: textColor }}>
                {fallback(demanda?.medico, 'NÃO INFORMADO')}
              </p>
            </div>
          </div>
          <div className="border-b" style={{ borderColor }}></div>

          {/* Procedimento */}
          <div className="py-3 flex items-center gap-4">
            <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
              <ClipboardList size={20} strokeWidth={2.5} />
            </div>
            <div className="flex-1 min-w-0">
              <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>PROCEDIMENTO</p>
              <p className="font-black uppercase text-[18px] leading-tight" style={{ color: textColor }}>
                {fallback(demanda?.procedimento, 'NÃO INFORMADO')}
              </p>
            </div>
          </div>
          <div className="border-b" style={{ borderColor }}></div>

          {/* Produtos / Materiais */}
          <div className="py-3 flex flex-col gap-2">
            <div className="flex items-center gap-4">
              <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
                <Package size={20} strokeWidth={2.5} />
              </div>
              <p className="font-black uppercase text-[16px]" style={{ color: textColor }}>PRODUTOS / MATERIAIS</p>
            </div>
            <div className="ml-14 bg-slate-50 rounded-xl p-3 text-[12px] font-medium" style={{ color: textColor }}>
              {demanda?.produtosLista && demanda.produtosLista.length > 0 ? (
                demanda.produtosLista.map((p, i) => (
                  <p key={i} className="mb-1 last:mb-0">
                    <span className="font-bold">Produto:</span> {p.descricao} <span className="font-bold">Qtd:</span> {p.quantidade} {p.codigoReferencia ? `Lbl4: ${p.codigoReferencia}` : ''}
                  </p>
                ))
              ) : demanda?.produtos && demanda.produtos.trim() !== '' ? (
                <div className="whitespace-pre-wrap">{demanda.produtos}</div>
              ) : (
                <p>Sem dados</p>
              )}
            </div>
          </div>
          <div className="border-b" style={{ borderColor }}></div>

          {/* Equipamentos / Serviços */}
          <div className="py-3 flex flex-col gap-2">
            <div className="flex items-center gap-4">
              <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
                <Settings size={20} strokeWidth={2.5} />
              </div>
              <p className="font-black uppercase text-[16px]" style={{ color: textColor }}>EQUIPAMENTOS / SERVIÇOS</p>
            </div>
            <div className="ml-14 bg-slate-50 rounded-xl p-3 text-[12px] font-medium" style={{ color: textColor }}>
              {demanda?.equipamentosLista && demanda.equipamentosLista.length > 0 ? (
                demanda.equipamentosLista.map((e, i) => (
                  <p key={i} className="mb-1 last:mb-0">
                    <span className="font-bold">Serviço:</span> {e.descricao}
                  </p>
                ))
              ) : demanda?.equipamentos && demanda.equipamentos.trim() !== '' ? (
                <div className="whitespace-pre-wrap">{demanda.equipamentos}</div>
              ) : (
                <p>Sem dados</p>
              )}
            </div>
          </div>
          <div className="border-b" style={{ borderColor }}></div>

          {/* SEÇÃO INFERIOR */}
          <div className="py-4 flex flex-col gap-4">
            
            {/* Top Row: Rep & Confirmacao */}
            <div className="grid grid-cols-2">
              <div className="flex items-center gap-4 border-r pr-4" style={{ borderColor }}>
                <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
                  <Phone size={20} strokeWidth={2.5} />
                </div>
                <div className="min-w-0">
                  <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>REPRESENTANTE</p>
                  <p className="font-black uppercase text-[16px] leading-tight" style={{ color: textColor }}>
                    {fallback(demanda?.representante, 'NÃO INFORMADO')}
                  </p>
                </div>
              </div>
              <div className="flex items-center gap-4 pl-4">
                <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
                  <CheckCircle2 size={20} strokeWidth={2.5} />
                </div>
                <div className="min-w-0">
                  <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>CONFIRMAÇÃO</p>
                  <p className="font-black uppercase text-[16px] leading-tight" style={{ color: textColor }}>
                    {fallback(demanda?.confirmacao, 'SEM DADOS')}
                  </p>
                </div>
              </div>
            </div>

            {/* Bottom Row: 2 Cols with Borders */}
            <div className="grid grid-cols-2 gap-4 mt-2 h-full pb-4">
              
              {/* Left Column */}
              <div className="flex flex-col gap-4 h-full">
                {/* Valor do Free - Borda destacada */}
                <div className="rounded-xl border-[2px] p-4 flex items-center gap-4" style={{ borderColor }}>
                  <div className="w-12 h-12 rounded-full flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
                    <DollarSign size={28} strokeWidth={3} />
                  </div>
                  <div>
                    <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>VALOR DO FREE</p>
                    <p className="font-black text-[28px] leading-none mt-1" style={{ color: textColor }}>
                      {fallback(demanda?.valorFreelancer, 'R$ 0,00')}
                    </p>
                  </div>
                </div>

                {/* Retorno OF */}
                <div className="flex items-center gap-4 mt-auto">
                  <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
                    <ClipboardList size={20} strokeWidth={2.5} />
                  </div>
                  <div>
                    <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>RETORNO OF</p>
                    <p className="font-black uppercase text-[16px] leading-tight" style={{ color: textColor }}>
                      {fallback(demanda?.retornoOp, 'NÃO RETORNADO')}
                    </p>
                  </div>
                </div>
              </div>

              {/* Right Column - Big bordered block */}
              <div className="rounded-xl border-[2px] p-4 flex flex-col" style={{ borderColor }}>
                {/* Observacoes */}
                <div className="flex items-start gap-4 pb-4 border-b" style={{ borderColor }}>
                  <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
                    <FileText size={20} strokeWidth={2.5} />
                  </div>
                  <div className="flex-1">
                    <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>OBSERVAÇÕES</p>
                    <p className="font-black uppercase text-[14px] leading-snug mt-1 text-wrap break-words" style={{ color: textColor }}>
                      {fallback(demanda?.observacoes, 'SEM DADOS')}
                    </p>
                  </div>
                </div>
                {/* Emergencia */}
                <div className="flex items-center gap-4 pt-4 mt-auto">
                  <div className="w-10 h-10 rounded-xl flex items-center justify-center shrink-0" style={{ backgroundColor: cyanBg, color: darkBlue }}>
                    <AlertTriangle size={20} strokeWidth={2.5} />
                  </div>
                  <div>
                    <p className="text-[11px] font-bold uppercase" style={{ color: labelColor }}>EMERGÊNCIA</p>
                    <p className="font-black uppercase text-[18px] leading-tight mt-1" style={{ color: textColor }}>
                      {demanda?.emergencia ? 'SIM' : 'NAO'}
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
