import { forwardRef } from 'react';
import { format, parseISO } from 'date-fns';
import { ptBR } from 'date-fns/locale';
import { User, Calendar, Clock, MapPin, Activity, CheckCircle, FileText, AlertTriangle, Building, Briefcase, Phone, DollarSign, RefreshCw } from 'lucide-react';
import type { Demanda, Instrumentador, ProdutoMaterial, EquipamentoServico } from '../store/useStore';

interface CartaoAcionamentoProps {
  demanda: Demanda;
  instrumentador: Instrumentador;
}

const CartaoAcionamento = forwardRef<HTMLDivElement, CartaoAcionamentoProps>(({ demanda, instrumentador }, ref) => {
  const formatDateString = (dateStr: string) => {
    try {
      return format(parseISO(dateStr), "dd/MM/yyyy - eeee", { locale: ptBR }).toUpperCase();
    } catch {
      return dateStr;
    }
  };

  const isReagendamento = demanda.tipoEvento?.toUpperCase() === 'REAGENDAMENTO';

  return (
    <div ref={ref} className="w-[450px] bg-white text-slate-900 border-4 border-slate-900 shadow-2xl relative overflow-hidden shrink-0 mx-auto" style={{ fontFamily: 'Inter, sans-serif' }}>
      
      {/* HEADER */}
      <div className="flex justify-between items-center p-6 border-b-2 border-cyan-100">
        <div className="flex flex-col">
          <h1 className="text-4xl font-black tracking-tighter text-slate-900 leading-none">CONECTA</h1>
          <p className="text-[10px] tracking-[0.2em] text-slate-500 font-bold uppercase mt-1">CIRÚRGICA</p>
        </div>
        <div className="text-right border-l-2 border-slate-300 pl-4 py-1">
          <p className="text-xs uppercase text-slate-500 font-semibold">{demanda.tipoEvento || 'AGENDAMENTO'}</p>
          <p className="text-xl font-black text-slate-900 uppercase">FREELANCE</p>
        </div>
      </div>

      {/* TOP ROW: Instrumentador & MC */}
      <div className="px-6 py-4 flex gap-4">
        <div className="flex-1 bg-cyan-100 rounded-xl p-4 flex items-center gap-4 border border-cyan-200">
          <div className="w-10 h-10 bg-cyan-700 text-white rounded-full flex items-center justify-center shrink-0">
            <User className="w-6 h-6" />
          </div>
          <div>
            <p className="text-xs text-cyan-800 font-bold uppercase">INSTRUMENTADOR(A)</p>
            <p className="font-black text-slate-900 text-lg uppercase leading-tight">{instrumentador.nome}</p>
            <p className="text-xs font-bold text-slate-700 uppercase">({instrumentador.nivel || 'NÍVEL NÃO INFORMADO'})</p>
          </div>
        </div>
        
        <div className="w-32 bg-slate-900 rounded-xl p-4 flex flex-col items-center justify-center text-white shrink-0 shadow-inner">
          <p className="text-xs text-slate-300 font-bold uppercase">MC:</p>
          <p className="text-3xl font-black">{demanda.mc || '---'}</p>
        </div>
      </div>

      {/* PACIENTE */}
      <div className="px-6 py-3 border-y border-cyan-100 flex items-center gap-4">
        <div className="w-8 h-8 rounded-full border border-slate-300 flex items-center justify-center shrink-0 text-slate-500">
          <User className="w-5 h-5" />
        </div>
        <div>
          <p className="text-[10px] text-slate-500 font-bold uppercase">PACIENTE</p>
          <p className="font-black text-slate-900 uppercase text-sm">{demanda.paciente || 'NÃO INFORMADO'}</p>
        </div>
      </div>

      {/* EMPRESA & CONVENIO */}
      <div className="grid grid-cols-2">
        <div className="px-6 py-3 border-b border-r border-cyan-100 flex items-center gap-4">
          <div className="w-8 h-8 rounded-full border border-slate-300 flex items-center justify-center shrink-0 text-slate-500">
            <Building className="w-5 h-5" />
          </div>
          <div className="truncate">
            <p className="text-[10px] text-slate-500 font-bold uppercase">EMPRESA</p>
            <p className="font-black text-slate-900 uppercase text-sm truncate">{demanda.empresa || 'NÃO INFORMADA'}</p>
          </div>
        </div>
        <div className="px-6 py-3 border-b border-cyan-100 flex items-center gap-4">
          <div className="w-8 h-8 rounded-full border border-slate-300 flex items-center justify-center shrink-0 text-slate-500">
            <Briefcase className="w-5 h-5" />
          </div>
          <div className="truncate">
            <p className="text-[10px] text-slate-500 font-bold uppercase">CONVÊNIO</p>
            <p className="font-black text-slate-900 uppercase text-sm truncate">{demanda.convenio || 'NÃO INFORMADO'}</p>
          </div>
        </div>
      </div>

      {/* HOSPITAL */}
      <div className="px-6 py-3 border-b border-cyan-100 flex items-center gap-4">
        <div className="w-8 h-8 rounded-full border border-slate-300 flex items-center justify-center shrink-0 text-slate-500">
          <MapPin className="w-5 h-5" />
        </div>
        <div>
          <p className="text-[10px] text-slate-500 font-bold uppercase">HOSPITAL</p>
          <p className="font-black text-slate-900 uppercase text-sm">{demanda.hospital} {demanda.unidadeLocal ? `- ${demanda.unidadeLocal}` : ''}</p>
        </div>
      </div>

      {/* DATA E HORA */}
      <div className="grid grid-cols-5">
        <div className="col-span-3 px-6 py-3 border-b border-r border-cyan-100 flex items-center gap-4">
          <div className="w-8 h-8 rounded-full border border-slate-300 flex items-center justify-center shrink-0 text-slate-500">
            <Calendar className="w-5 h-5" />
          </div>
          <div>
            <p className="text-[10px] text-slate-500 font-bold uppercase">DATA</p>
            <p className="font-black text-slate-900 uppercase text-sm">{formatDateString(demanda.data)}</p>
          </div>
        </div>
        <div className="col-span-2 px-4 py-3 border-b border-cyan-100 flex items-center gap-3">
          <div className="w-8 h-8 rounded-full border border-slate-300 flex items-center justify-center shrink-0 text-slate-500">
            <Clock className="w-5 h-5" />
          </div>
          <div>
            <p className="text-[10px] text-slate-500 font-bold uppercase">HORÁRIO DA CIRURGIA</p>
            <p className="font-black text-slate-900 uppercase text-sm">{demanda.hora}</p>
          </div>
        </div>
      </div>

      {/* REAGENDAMENTO BANNER */}
      {isReagendamento && (
        <div className="bg-yellow-300 text-slate-900 px-6 py-1.5 border-b border-cyan-100">
          <p className="font-black text-sm uppercase tracking-wider flex items-center gap-2">
            <RefreshCw className="w-4 h-4" /> REAGENDAMENTO
          </p>
        </div>
      )}

      {/* MÉDICO */}
      <div className="px-6 py-3 border-b border-cyan-100 flex items-center gap-4">
        <div className="w-8 h-8 rounded-full border border-slate-300 flex items-center justify-center shrink-0 text-slate-500">
          <User className="w-5 h-5" />
        </div>
        <div>
          <p className="text-[10px] text-slate-500 font-bold uppercase">MÉDICO</p>
          <p className="font-black text-slate-900 uppercase text-sm">{demanda.medico}</p>
        </div>
      </div>

      {/* PROCEDIMENTO */}
      <div className="px-6 py-3 border-b border-cyan-100 flex items-center gap-4">
        <div className="w-8 h-8 rounded-full border border-slate-300 flex items-center justify-center shrink-0 text-slate-500">
          <Activity className="w-5 h-5" />
        </div>
        <div>
          <p className="text-[10px] text-slate-500 font-bold uppercase">PROCEDIMENTO</p>
          <p className="font-black text-slate-900 uppercase text-sm">{demanda.procedimento}</p>
        </div>
      </div>

      {/* PRODUTOS */}
      <div className="mx-6 my-4 border border-cyan-200 rounded-xl overflow-hidden">
        <div className="bg-cyan-100 px-4 py-2 flex items-center gap-2 border-b border-cyan-200">
          <div className="w-6 h-6 rounded-full border border-cyan-400 flex items-center justify-center text-cyan-800">
            <div className="w-3 h-3 bg-cyan-700 rounded-[1px]" />
          </div>
          <p className="font-black text-sm text-slate-900 uppercase tracking-wide">PRODUTOS / MATERIAIS</p>
        </div>
        <div className="bg-slate-50 p-4 text-sm text-slate-700 whitespace-pre-wrap">
          {demanda.produtosLista && demanda.produtosLista.length > 0 ? (
            demanda.produtosLista.map((p: ProdutoMaterial, i: number) => (
              <div key={i}><strong>{p.descricao}</strong> Qtd: {p.quantidade} {p.codigoReferencia ? `Ref: ${p.codigoReferencia}` : ''}</div>
            ))
          ) : demanda.produtos ? (
            demanda.produtos
          ) : (
            'Sem dados'
          )}
        </div>
      </div>

      {/* EQUIPAMENTOS */}
      <div className="mx-6 my-4 border border-cyan-200 rounded-xl overflow-hidden">
        <div className="bg-cyan-100 px-4 py-2 flex items-center gap-2 border-b border-cyan-200">
          <div className="w-6 h-6 rounded-full border border-cyan-400 flex items-center justify-center text-cyan-800">
            <div className="w-3 h-3 bg-cyan-700 rounded-full" />
          </div>
          <p className="font-black text-sm text-slate-900 uppercase tracking-wide">EQUIPAMENTOS / SERVIÇOS</p>
        </div>
        <div className="bg-slate-50 p-4 text-sm text-slate-700 whitespace-pre-wrap">
          {demanda.equipamentosLista && demanda.equipamentosLista.length > 0 ? (
            demanda.equipamentosLista.map((e: EquipamentoServico, i: number) => (
              <div key={i}><strong>{e.descricao}</strong> {e.quantidade ? `Qtd: ${e.quantidade}` : ''}</div>
            ))
          ) : demanda.equipamentos ? (
             demanda.equipamentos
          ) : (
            'Serviço: Sem dados'
          )}
        </div>
      </div>

      {/* FOOTER GRID */}
      <div className="px-6 py-4 border-t border-cyan-100 grid grid-cols-2 gap-4 pb-8">
        
        {/* LEFT COL */}
        <div className="space-y-4">
          <div className="flex items-start gap-3">
            <div className="w-8 h-8 rounded-full border border-slate-300 flex items-center justify-center shrink-0 text-slate-500 mt-1">
              <Phone className="w-4 h-4" />
            </div>
            <div>
              <p className="text-[10px] text-slate-500 font-bold uppercase">REPRESENTANTE</p>
              <p className="font-black text-slate-900 uppercase text-sm leading-tight">{demanda.representante || 'NÃO INFORMADO'}</p>
            </div>
          </div>

          <div className="border rounded-xl p-3 flex items-center gap-3 mt-4" style={{ borderColor: '#d1f4f9' }}>
            <div className="w-10 h-10 rounded-full border-2 border-slate-900 flex items-center justify-center shrink-0 text-slate-900">
              <DollarSign className="w-6 h-6" />
            </div>
            <div>
              <p className="text-[10px] text-slate-500 font-bold uppercase">VALOR DO FREE</p>
              <p className="font-black text-xl text-slate-900">{demanda.valorFreelancer || 'A COMBINAR'}</p>
            </div>
          </div>

          <div className="flex items-start gap-3 pt-2">
            <div className="w-8 h-8 rounded-full border border-slate-300 flex items-center justify-center shrink-0 text-slate-500 mt-1">
              <FileText className="w-4 h-4" />
            </div>
            <div>
              <p className="text-[10px] text-slate-500 font-bold uppercase">RETORNO OF</p>
              <p className="font-black text-slate-900 uppercase text-sm leading-tight">{demanda.retornoOp || 'NÃO RETORNADO'}</p>
            </div>
          </div>
        </div>

        {/* RIGHT COL */}
        <div className="space-y-4">
          <div className="flex items-start gap-3">
            <div className="w-8 h-8 rounded-full border border-slate-300 flex items-center justify-center shrink-0 text-slate-500 mt-1">
              <CheckCircle className="w-4 h-4" />
            </div>
            <div>
              <p className="text-[10px] text-slate-500 font-bold uppercase">CONFIRMAÇÃO</p>
              <p className="font-black text-slate-900 uppercase text-sm leading-tight">{demanda.confirmacao || 'SEM DADOS'}</p>
            </div>
          </div>

          <div className="flex items-start gap-3">
            <div className="w-8 h-8 rounded-full border border-slate-300 flex items-center justify-center shrink-0 text-slate-500 mt-1">
              <FileText className="w-4 h-4" />
            </div>
            <div>
              <p className="text-[10px] text-slate-500 font-bold uppercase">OBSERVAÇÕES</p>
              <p className="font-black text-slate-900 uppercase text-sm leading-tight">{demanda.observacoes || 'SEM DADOS'}</p>
            </div>
          </div>

          <div className="flex items-start gap-3">
            <div className="w-8 h-8 rounded-full border border-slate-300 flex items-center justify-center shrink-0 text-slate-500 mt-1">
              <AlertTriangle className="w-4 h-4" />
            </div>
            <div>
              <p className="text-[10px] text-slate-500 font-bold uppercase">EMERGÊNCIA</p>
              <p className="font-black text-slate-900 uppercase text-sm leading-tight">{demanda.emergencia ? 'SIM' : 'NÃO'}</p>
            </div>
          </div>
        </div>

      </div>

    </div>
  );
});

CartaoAcionamento.displayName = 'CartaoAcionamento';
export default CartaoAcionamento;
