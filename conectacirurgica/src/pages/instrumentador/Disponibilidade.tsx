import { useState, useMemo } from 'react';
import { format, parseISO, addDays, eachDayOfInterval, getDay, isBefore, startOfDay, isValid } from 'date-fns';
import { Check, Calendar as CalendarIcon, Trash2, Clock, X, RefreshCw, AlertCircle, ChevronUp, ChevronDown } from 'lucide-react';
import clsx from 'clsx';
import { useStore } from '../../store/useStore';

const DIAS_SEMANA = [
  { id: 0, label: 'Dom', full: 'Domingo' },
  { id: 1, label: 'Seg', full: 'Segunda-feira' },
  { id: 2, label: 'Ter', full: 'Terça-feira' },
  { id: 3, label: 'Qua', full: 'Quarta-feira' },
  { id: 4, label: 'Qui', full: 'Quinta-feira' },
  { id: 5, label: 'Sex', full: 'Sexta-feira' },
  { id: 6, label: 'Sáb', full: 'Sábado' },
];

export default function Disponibilidade() {
  const currentUserId = 1;
  const { instrumentadores, updateDisponibilidadeRange } = useStore();
  const currentUser = instrumentadores.find(i => i.id === currentUserId);

  const [modo, setModo] = useState<'A' | 'B'>('A');
  const [atalhoA, setAtalhoA] = useState<'hoje' | 'amanha' | '7dias' | 'datas'>('hoje');
  
  const hojeStr = format(new Date(), 'yyyy-MM-dd');
  const [dataInicio, setDataInicio] = useState(() => format(new Date(), 'yyyy-MM-dd'));
  const [dataFim, setDataFim] = useState(() => format(new Date(), 'yyyy-MM-dd'));
  
  const [diasSelecionados, setDiasSelecionados] = useState<number[]>([0,1,2,3,4,5,6]);
  const [periodos, setPeriodos] = useState<string[]>([]);

  const [step, setStep] = useState<'form' | 'revisao'>('form');
  const [expandedGroup, setExpandedGroup] = useState<string | null>(null);
  const [saveSuccess, setSaveSuccess] = useState(false);
  const [errorMsg, setErrorMsg] = useState('');

  const today = startOfDay(new Date());

  // Derive dates based on mode
  const derivedDates = useMemo(() => {
    let start = hojeStr;
    let end = hojeStr;
    let activeDays = diasSelecionados;

    if (modo === 'A') {
      if (atalhoA === 'hoje') {
        start = hojeStr;
        end = hojeStr;
        activeDays = [getDay(new Date())];
      } else if (atalhoA === 'amanha') {
        const amh = format(addDays(new Date(), 1), 'yyyy-MM-dd');
        start = amh;
        end = amh;
        activeDays = [getDay(addDays(new Date(), 1))];
      } else if (atalhoA === '7dias') {
        start = hojeStr;
        end = format(addDays(new Date(), 6), 'yyyy-MM-dd');
      } else {
        start = dataInicio;
        end = dataFim;
      }
    } else {
      start = dataInicio;
      end = dataFim;
    }

    return { start, end, activeDays };
  }, [modo, atalhoA, dataInicio, dataFim, diasSelecionados, hojeStr]);

  const datesToApply = useMemo(() => {
    const s = parseISO(derivedDates.start);
    const e = parseISO(derivedDates.end);
    
    if (!isValid(s) || !isValid(e) || isBefore(e, s)) return [];
    
    const allDays = eachDayOfInterval({ start: s, end: e });
    return allDays
      .filter(d => derivedDates.activeDays.includes(getDay(d)))
      .map(d => format(d, 'yyyy-MM-dd'));
  }, [derivedDates]);

  const handleReview = () => {
    setErrorMsg('');
    
    if (modo === 'B' && diasSelecionados.length === 0) {
      setErrorMsg('Selecione pelo menos um dia da semana.');
      return;
    }

    if ((modo === 'B' || (modo === 'A' && atalhoA === 'datas')) && (!dataInicio || !dataFim)) {
      setErrorMsg('Informe a data inicial e final.');
      return;
    }

    const s = parseISO(derivedDates.start);
    const e = parseISO(derivedDates.end);
    if (isValid(s) && isValid(e) && isBefore(e, s)) {
      setErrorMsg('A data final não pode ser anterior à data inicial.');
      return;
    }

    if (datesToApply.length === 0) {
      setErrorMsg('O intervalo selecionado não contém nenhum dia válido com a regra atual.');
      return;
    }

    if (periodos.length === 0) {
      setErrorMsg('Selecione pelo menos um período (Manhã, Tarde, Noite ou Dia Inteiro).');
      return;
    }

    setStep('revisao');
  };

  const handleSave = () => {
    let finalPeriods = [...periodos];
    if (finalPeriods.includes('integral')) {
      finalPeriods = ['manha', 'tarde', 'noite', 'integral'];
    }

    updateDisponibilidadeRange(currentUserId, datesToApply, finalPeriods);
    setSaveSuccess(true);
    setStep('form');
    setPeriodos([]);
    setTimeout(() => setSaveSuccess(false), 3000);
  };

  const toggleDia = (id: number) => {
    setDiasSelecionados(prev => 
      prev.includes(id) ? prev.filter(d => d !== id) : [...prev, id].sort()
    );
  };

  const setDiasUteis = () => setDiasSelecionados([1,2,3,4,5]);
    const setTodosDias = () => setDiasSelecionados([0,1,2,3,4,5,6]);

  const togglePeriodo = (p: string) => {
    setPeriodos(prev => {
      if (p === 'integral') {
        return prev.includes('integral') ? [] : ['integral'];
      }
      const newP = prev.includes(p) ? prev.filter(x => x !== p) : [...prev, p];
      return newP.filter(x => x !== 'integral'); // remove integral if specific period selected
    });
  };

  const dispMap = currentUser?.disponibilidade || {};
  const datasRegistradas = Object.keys(dispMap).sort().filter(d => !isBefore(parseISO(d), today));

  return (
    <div className="p-4 space-y-6 max-w-lg mx-auto pb-8">
      <div className="text-center mb-6">
        <h1 className="text-2xl font-bold text-slate-900 mb-1">Informar disponibilidade</h1>
        <p className="text-sm text-slate-500">Defina quando você pode realizar atendimentos.</p>
      </div>

      {step === 'form' && (
        <div className="bg-white rounded-2xl shadow-sm border border-slate-100 overflow-hidden">
          <div className="p-5 space-y-6">
            
            {errorMsg && (
              <div className="bg-red-50 text-red-700 p-3 rounded-lg text-sm font-medium border border-red-200 flex gap-2 items-start">
                <AlertCircle className="w-5 h-5 shrink-0 mt-0.5" />
                <span>{errorMsg}</span>
              </div>
            )}

            {/* Como informar */}
            <div className="space-y-3">
              <label className="block text-sm font-bold text-slate-800">Como deseja informar?</label>
              <div className="grid grid-cols-2 gap-3">
                <button 
                  onClick={() => { setModo('A'); setAtalhoA('hoje'); setTodosDias(); }}
                  className={clsx("p-3 rounded-xl border text-sm font-medium flex flex-col items-center gap-2 transition-all", modo === 'A' ? "border-primary-500 bg-primary-50 text-primary-900 ring-1 ring-primary-500" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
                >
                  <CalendarIcon className="w-5 h-5" />
                  Datas específicas
                </button>
                <button 
                  onClick={() => { setModo('B'); setDataInicio(hojeStr); setDataFim(format(addDays(new Date(), 30), 'yyyy-MM-dd')); }}
                  className={clsx("p-3 rounded-xl border text-sm font-medium flex flex-col items-center gap-2 transition-all", modo === 'B' ? "border-primary-500 bg-primary-50 text-primary-900 ring-1 ring-primary-500" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
                >
                  <RefreshCw className="w-5 h-5" />
                  Repetir semanalmente
                </button>
              </div>
            </div>

            {modo === 'A' && (
              <div className="space-y-4 animate-in fade-in slide-in-from-bottom-2">
                <div className="space-y-2">
                  <label className="block text-sm font-bold text-slate-800">Selecione o período</label>
                  <div className="grid grid-cols-2 gap-2">
                    {['hoje', 'amanha', '7dias', 'datas'].map((op) => (
                      <button 
                        key={op}
                        onClick={() => { setAtalhoA(op as any); if(op !== 'datas') setTodosDias(); }}
                        className={clsx("p-2.5 rounded-lg border text-sm font-medium transition-all text-center", atalhoA === op ? "border-primary-500 bg-primary-50 text-primary-900" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
                      >
                        {op === 'hoje' ? 'Hoje' : op === 'amanha' ? 'Amanhã' : op === '7dias' ? 'Próximos 7 dias' : 'Escolher datas'}
                      </button>
                    ))}
                  </div>
                </div>

                {atalhoA === 'datas' && (
                  <div className="grid grid-cols-2 gap-3 p-3 bg-slate-50 rounded-xl border border-slate-100">
                    <div>
                      <label className="block text-xs font-bold text-slate-600 mb-1">Data Inicial</label>
                      <input type="date" value={dataInicio} onChange={e => setDataInicio(e.target.value)} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 bg-white" />
                    </div>
                    <div>
                      <label className="block text-xs font-bold text-slate-600 mb-1">Data Final</label>
                      <input type="date" value={dataFim} onChange={e => setDataFim(e.target.value)} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 bg-white" />
                    </div>
                  </div>
                )}
              </div>
            )}

            {modo === 'B' && (
              <div className="space-y-4 animate-in fade-in slide-in-from-bottom-2">
                 <div className="grid grid-cols-2 gap-3 p-3 bg-slate-50 rounded-xl border border-slate-100">
                    <div>
                      <label className="block text-xs font-bold text-slate-600 mb-1">Vigência Inicial</label>
                      <input type="date" value={dataInicio} onChange={e => setDataInicio(e.target.value)} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 bg-white" />
                    </div>
                    <div>
                      <label className="block text-xs font-bold text-slate-600 mb-1">Vigência Final</label>
                      <input type="date" value={dataFim} onChange={e => setDataFim(e.target.value)} className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 bg-white" />
                    </div>
                  </div>
              </div>
            )}

            {((modo === 'A' && (atalhoA === '7dias' || atalhoA === 'datas')) || modo === 'B') && (
              <div className="space-y-3 pt-2 animate-in fade-in">
                <div className="flex justify-between items-center">
                  <label className="block text-sm font-bold text-slate-800">Dias da semana</label>
                  <div className="text-xs flex gap-2">
                    <button onClick={setDiasUteis} className="text-primary-600 font-medium hover:underline">Dias úteis</button>
                    <button onClick={setTodosDias} className="text-primary-600 font-medium hover:underline">Todos</button>
                  </div>
                </div>
                <div className="flex justify-between gap-1">
                  {DIAS_SEMANA.map(dia => (
                    <button
                      key={dia.id}
                      onClick={() => toggleDia(dia.id)}
                      className={clsx(
                        "w-10 h-10 rounded-full flex items-center justify-center text-sm font-bold transition-all shrink-0",
                        diasSelecionados.includes(dia.id)
                          ? "bg-primary-600 text-white shadow-md shadow-primary-500/20"
                          : "bg-slate-100 text-slate-600 hover:bg-slate-200"
                      )}
                    >
                      {dia.label[0]}
                    </button>
                  ))}
                </div>
              </div>
            )}

            {/* Período */}
            <div className="space-y-3 pt-2">
              <label className="block text-sm font-bold text-slate-800">Horários disponíveis</label>
              <div className="grid grid-cols-2 gap-2">
                <button 
                  onClick={() => togglePeriodo('manha')}
                  className={clsx("p-3 rounded-xl border flex items-center justify-center gap-2 transition-all", periodos.includes('manha') ? "border-primary-500 bg-primary-50 text-primary-900 ring-1 ring-primary-500 font-bold" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
                >
                  <Clock className="w-4 h-4" /> Manhã
                </button>
                <button 
                  onClick={() => togglePeriodo('tarde')}
                  className={clsx("p-3 rounded-xl border flex items-center justify-center gap-2 transition-all", periodos.includes('tarde') ? "border-primary-500 bg-primary-50 text-primary-900 ring-1 ring-primary-500 font-bold" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
                >
                  <Clock className="w-4 h-4" /> Tarde
                </button>
                <button 
                  onClick={() => togglePeriodo('noite')}
                  className={clsx("p-3 rounded-xl border flex items-center justify-center gap-2 transition-all", periodos.includes('noite') ? "border-primary-500 bg-primary-50 text-primary-900 ring-1 ring-primary-500 font-bold" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
                >
                  <Clock className="w-4 h-4" /> Noite
                </button>
                <button 
                  onClick={() => togglePeriodo('integral')}
                  className={clsx("p-3 rounded-xl border flex items-center justify-center gap-2 transition-all", periodos.includes('integral') ? "border-primary-500 bg-primary-50 text-primary-900 ring-1 ring-primary-500 font-bold" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
                >
                  <Clock className="w-4 h-4" /> Dia Inteiro
                </button>
              </div>
            </div>

            <div className="pt-4">
              <button onClick={handleReview} className="w-full bg-primary-600 text-white py-4 rounded-xl font-bold text-base hover:bg-primary-700 shadow-md shadow-primary-500/20 flex items-center justify-center gap-2">
                Revisar disponibilidade
              </button>
            </div>

            {saveSuccess && (
              <div className="bg-emerald-50 text-emerald-800 text-sm font-bold p-3 rounded-lg flex justify-center items-center gap-2 border border-emerald-200 mt-2">
                <Check className="w-5 h-5 text-emerald-500" /> Disponibilidade salva!
              </div>
            )}
          </div>
        </div>
      )}

      {step === 'revisao' && (
        <div className="bg-white rounded-2xl shadow-sm border border-slate-100 overflow-hidden animate-in fade-in slide-in-from-right-4">
          <div className="p-5 space-y-6">
            <h2 className="text-lg font-bold text-slate-800 border-b border-slate-100 pb-3">Resumo da Disponibilidade</h2>
            
            <div className="space-y-4 text-sm">
              <div className="flex justify-between items-start py-2 border-b border-slate-50">
                <span className="text-slate-500">Período</span>
                <span className="font-bold text-slate-800 text-right">
                  {format(parseISO(derivedDates.start), 'dd/MM/yyyy')} 
                  {derivedDates.start !== derivedDates.end && ` até ${format(parseISO(derivedDates.end), 'dd/MM/yyyy')}`}
                </span>
              </div>
              
              <div className="flex justify-between items-start py-2 border-b border-slate-50">
                <span className="text-slate-500">Dias</span>
                <span className="font-bold text-slate-800 text-right">
                  {modo === 'A' && (atalhoA === 'hoje' || atalhoA === 'amanha') 
                    ? '1 dia' 
                    : derivedDates.activeDays.length === 7 
                      ? 'Todos os dias' 
                      : DIAS_SEMANA.filter(d => derivedDates.activeDays.includes(d.id)).map(d => d.label).join(', ')}
                  <div className="text-xs text-slate-400 font-normal mt-0.5">({datesToApply.length} datas afetadas)</div>
                </span>
              </div>

              <div className="flex justify-between items-start py-2 border-b border-slate-50">
                <span className="text-slate-500">Horários</span>
                <span className="font-bold text-primary-700 capitalize text-right">
                  {periodos.includes('integral') ? 'Dia Inteiro' : periodos.join(', ')}
                </span>
              </div>
            </div>

            <div className="flex gap-3 pt-4">
              <button 
                onClick={() => setStep('form')}
                className="flex-1 px-4 py-3 rounded-xl font-bold text-slate-600 bg-slate-100 hover:bg-slate-200 transition-colors"
              >
                Voltar
              </button>
              <button 
                onClick={handleSave}
                className="flex-[2] bg-emerald-600 text-white px-4 py-3 rounded-xl font-bold text-base hover:bg-emerald-700 shadow-md shadow-emerald-500/20"
              >
                Salvar disponibilidade
              </button>
            </div>
          </div>
        </div>
      )}

      {/* Registros Recentes */}
      <div className="bg-white rounded-2xl shadow-sm border border-slate-100 p-5 mt-6">
        <h2 className="font-bold text-slate-800 mb-4 border-b border-slate-100 pb-2">Minha Agenda</h2>
        <div className="space-y-2 max-h-64 overflow-y-auto pr-1">
          
          {(() => {
            if (datasRegistradas.length === 0) {
              return <p className="text-sm text-slate-500 text-center py-4">Nenhuma disponibilidade futura.</p>;
            }

            const grupos: Record<string, string[]> = {};
            datasRegistradas.forEach(date => {
              const rule = [...dispMap[date]].sort().join(',');
              if (!grupos[rule]) grupos[rule] = [];
              grupos[rule].push(date);
            });

            return Object.entries(grupos).map(([rule, dates]) => {
              const isIndisponivel = rule.includes('indisponivel');
              const isIntegral = rule.includes('integral');
              const ruleLabel = isIndisponivel ? 'Indisponível' : isIntegral ? 'Dia Inteiro' : rule.split(',').join(', ');
              const isExpanded = expandedGroup === rule;

              return (
                <div key={rule} className="border border-slate-200 rounded-xl overflow-hidden mb-3">
                  <div 
                    onClick={() => setExpandedGroup(isExpanded ? null : rule)}
                    className={clsx("p-3 flex justify-between items-center cursor-pointer transition-colors", isIndisponivel ? "bg-red-50 hover:bg-red-100" : "bg-slate-50 hover:bg-slate-100")}
                  >
                    <div>
                      <div className="font-bold text-sm text-slate-800 capitalize flex items-center gap-2">
                        {isIndisponivel ? <X className="w-4 h-4 text-red-500" /> : <Clock className="w-4 h-4 text-primary-500" />}
                        {ruleLabel}
                      </div>
                      <div className="text-xs text-slate-500 mt-0.5">{dates.length} {dates.length === 1 ? 'data programada' : 'datas programadas'}</div>
                    </div>
                    <div className="flex gap-2 items-center">
                       {isExpanded ? <ChevronUp className="w-5 h-5 text-slate-400" /> : <ChevronDown className="w-5 h-5 text-slate-400" />}
                    </div>
                  </div>
                  
                  {isExpanded && (
                    <div className="p-2 border-t border-slate-200 bg-white grid grid-cols-1 sm:grid-cols-2 gap-2">
                      {dates.map(date => (
                        <div key={date} className="flex justify-between items-center p-2 bg-slate-50 rounded-lg text-sm border border-slate-100">
                          <div>
                            <span className="font-semibold text-slate-700">{format(parseISO(date), "dd/MM/yyyy")}</span>
                            <span className="text-xs text-slate-500 ml-2">({DIAS_SEMANA.find(d => d.id === getDay(parseISO(date)))?.label})</span>
                          </div>
                          <div className="flex gap-1">
                            {!isIndisponivel && (
                              <button 
                                onClick={(e) => { e.stopPropagation(); updateDisponibilidadeRange(currentUserId, [date], ['indisponivel']); }}
                                title="Indisponível"
                                className="p-1.5 text-slate-400 hover:text-red-600 hover:bg-red-100 rounded-md transition-colors"
                              >
                                <X className="w-3.5 h-3.5" />
                              </button>
                            )}
                            <button 
                              onClick={(e) => { e.stopPropagation(); updateDisponibilidadeRange(currentUserId, [date], []); }}
                              title="Remover"
                              className="p-1.5 text-slate-400 hover:text-slate-600 hover:bg-slate-200 rounded-md transition-colors"
                            >
                              <Trash2 className="w-3.5 h-3.5" />
                            </button>
                          </div>
                        </div>
                      ))}
                    </div>
                  )}
                </div>
              );
            });
          })()}

        </div>
      </div>

    </div>
  );
}
