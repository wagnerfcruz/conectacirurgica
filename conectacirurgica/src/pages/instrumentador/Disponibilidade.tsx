import { useState } from 'react';
import { format, parseISO, addDays } from 'date-fns';
import { Check, X, Calendar as CalendarIcon, Trash2 } from 'lucide-react';
import clsx from 'clsx';
import { useStore } from '../../store/useStore';

export default function Disponibilidade() {
  const currentUserId = 1;
  const { instrumentadores, updateDisponibilidadeRange } = useStore();
  const currentUser = instrumentadores.find(i => i.id === currentUserId);

  const [tipoData, setTipoData] = useState<'hoje' | 'amanha' | 'outra'>('hoje');
  const [dataOutra, setDataOutra] = useState(format(new Date(), 'yyyy-MM-dd'));

  const [statusDisp, setStatusDisp] = useState<'livre' | 'indisponivel' | null>(null);
  
  const [periodo, setPeriodo] = useState<'manha' | 'tarde' | 'noite' | 'integral' | null>(null);

  const [saveSuccess, setSaveSuccess] = useState(false);
  const [errorMsg, setErrorMsg] = useState('');

  const getDataSelecionada = () => {
    const hoje = new Date();
    if (tipoData === 'hoje') return format(hoje, 'yyyy-MM-dd');
    if (tipoData === 'amanha') return format(addDays(hoje, 1), 'yyyy-MM-dd');
    return dataOutra;
  };

  const handleSave = () => {
    setErrorMsg('');
    const dataSelecionada = getDataSelecionada();
    
    if (!statusDisp) {
      setErrorMsg('Selecione como está sua disponibilidade.');
      return;
    }

    if (statusDisp === 'livre' && !periodo) {
      setErrorMsg('Selecione o período em que pode atender.');
      return;
    }

    let periodosFormatados: string[] = [];
    
    if (statusDisp === 'indisponivel') {
      periodosFormatados = ['indisponivel'];
    } else {
      if (periodo === 'integral') periodosFormatados = ['integral', 'manha', 'tarde', 'noite'];
      else if (periodo) periodosFormatados = [periodo];
    }

    updateDisponibilidadeRange(currentUserId, [dataSelecionada], periodosFormatados);
    setSaveSuccess(true);
    setTimeout(() => setSaveSuccess(false), 3000);
  };

  const dispMap = currentUser?.disponibilidade || {};
  const datasRegistradas = Object.keys(dispMap).sort();

  return (
    <div className="p-4 space-y-6 max-w-lg mx-auto pb-24">
      <div className="text-center mb-6">
        <h1 className="text-2xl font-bold text-slate-900 mb-1">Registrar minha disponibilidade</h1>
        <p className="text-sm text-slate-500">Informe quando você pode ser acionado.</p>
      </div>

      <div className="bg-white rounded-2xl shadow-sm border border-slate-100 overflow-hidden">
        <div className="p-5 space-y-6">
          
          {errorMsg && (
            <div className="bg-red-50 text-red-700 p-3 rounded-lg text-sm font-medium border border-red-200">
              {errorMsg}
            </div>
          )}

          {/* Qual a data? */}
          <div className="space-y-3">
            <label className="block text-sm font-bold text-slate-800">Qual a data?</label>
            <div className="flex flex-col gap-2">
              <button 
                onClick={() => setTipoData('hoje')}
                className={clsx("p-3 rounded-xl border flex items-center gap-3 transition-all", tipoData === 'hoje' ? "border-primary-500 bg-primary-50 text-primary-900 ring-1 ring-primary-500" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
              >
                <CalendarIcon className="w-5 h-5" /> Hoje
              </button>
              <button 
                onClick={() => setTipoData('amanha')}
                className={clsx("p-3 rounded-xl border flex items-center gap-3 transition-all", tipoData === 'amanha' ? "border-primary-500 bg-primary-50 text-primary-900 ring-1 ring-primary-500" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
              >
                <CalendarIcon className="w-5 h-5" /> Amanhã
              </button>
              <div className={clsx("rounded-xl border flex flex-col transition-all overflow-hidden", tipoData === 'outra' ? "border-primary-500 bg-primary-50 text-primary-900 ring-1 ring-primary-500" : "border-slate-200 text-slate-600 hover:bg-slate-50")}>
                <button 
                  onClick={() => setTipoData('outra')}
                  className="p-3 flex items-center gap-3 w-full text-left"
                >
                  <CalendarIcon className="w-5 h-5" /> Outra data
                </button>
                {tipoData === 'outra' && (
                  <div className="px-3 pb-3">
                    <input 
                      type="date" 
                      value={dataOutra}
                      onChange={e => setDataOutra(e.target.value)}
                      className="w-full border border-primary-200 rounded-md p-2 text-sm focus:ring-primary-500 bg-white"
                    />
                  </div>
                )}
              </div>
            </div>
          </div>

          {/* Como está sua disponibilidade? */}
          <div className="space-y-3 pt-2">
            <label className="block text-sm font-bold text-slate-800">Como está sua disponibilidade?</label>
            <div className="flex flex-col gap-2">
              <button 
                onClick={() => setStatusDisp('livre')}
                className={clsx("p-3 rounded-xl border flex items-center gap-3 transition-all", statusDisp === 'livre' ? "border-emerald-500 bg-emerald-50 text-emerald-900 ring-1 ring-emerald-500" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
              >
                <div className={clsx("w-6 h-6 rounded-full flex items-center justify-center text-white", statusDisp === 'livre' ? "bg-emerald-500" : "bg-emerald-200")}>
                  <Check className="w-4 h-4" />
                </div>
                <div className="text-left">
                  <div className="font-bold text-sm">Estou livre</div>
                  <div className="text-xs opacity-80">Posso assumir uma cirurgia.</div>
                </div>
              </button>
              <button 
                onClick={() => setStatusDisp('indisponivel')}
                className={clsx("p-3 rounded-xl border flex items-center gap-3 transition-all", statusDisp === 'indisponivel' ? "border-red-500 bg-red-50 text-red-900 ring-1 ring-red-500" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
              >
                <div className={clsx("w-6 h-6 rounded-full flex items-center justify-center text-white", statusDisp === 'indisponivel' ? "bg-red-500" : "bg-red-200")}>
                  <X className="w-4 h-4" />
                </div>
                <div className="text-left">
                  <div className="font-bold text-sm">Indisponível</div>
                  <div className="text-xs opacity-80">Não posso assumir freelance nesta data.</div>
                </div>
              </button>
            </div>
          </div>

          {/* Período */}
          {statusDisp === 'livre' && (
            <div className="space-y-3 pt-2 animate-in fade-in slide-in-from-bottom-2">
              <label className="block text-sm font-bold text-slate-800">Período em que pode atender</label>
              <div className="grid grid-cols-2 gap-2">
                <button 
                  onClick={() => setPeriodo('manha')}
                  className={clsx("p-3 rounded-xl border flex flex-col items-center justify-center transition-all text-center", periodo === 'manha' ? "border-primary-500 bg-primary-50 text-primary-900 ring-1 ring-primary-500 font-bold" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
                >
                  <span className="text-sm">Somente Manhã</span>
                </button>
                <button 
                  onClick={() => setPeriodo('tarde')}
                  className={clsx("p-3 rounded-xl border flex flex-col items-center justify-center transition-all text-center", periodo === 'tarde' ? "border-primary-500 bg-primary-50 text-primary-900 ring-1 ring-primary-500 font-bold" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
                >
                  <span className="text-sm">Somente Tarde</span>
                </button>
                <button 
                  onClick={() => setPeriodo('integral')}
                  className={clsx("p-3 rounded-xl border flex flex-col items-center justify-center transition-all text-center col-span-2", periodo === 'integral' ? "border-primary-500 bg-primary-50 text-primary-900 ring-1 ring-primary-500 font-bold" : "border-slate-200 text-slate-600 hover:bg-slate-50")}
                >
                  <span className="text-sm">Manhã e Tarde (Qualquer horário)</span>
                </button>
              </div>
            </div>
          )}

          <div className="pt-4">
            <button onClick={handleSave} className="w-full bg-primary-600 text-white py-4 rounded-xl font-bold text-base hover:bg-primary-700 shadow-md shadow-primary-500/20">
              Confirmar Disponibilidade
            </button>
          </div>

          {saveSuccess && (
            <div className="bg-emerald-50 text-emerald-800 text-sm font-bold p-3 rounded-lg flex justify-center items-center gap-2 border border-emerald-200 mt-2">
              <Check className="w-5 h-5 text-emerald-500" /> Disponibilidade registrada com sucesso!
            </div>
          )}
        </div>
      </div>

      <div className="bg-white rounded-2xl shadow-sm border border-slate-100 p-5 mt-6">
        <h2 className="font-bold text-slate-800 mb-4 border-b border-slate-100 pb-2">Registros Recentes</h2>
        <div className="space-y-2 max-h-60 overflow-y-auto">
          {datasRegistradas.length === 0 ? (
            <p className="text-sm text-slate-500 text-center py-4">Nenhuma disponibilidade informada.</p>
          ) : (
            datasRegistradas.map(date => {
              const periodos = dispMap[date];
              return (
                <div key={date} className="flex justify-between items-center p-3 border border-slate-100 rounded-xl bg-slate-50">
                  <div>
                    <div className="font-bold text-slate-800 text-sm flex items-center gap-2">
                      <CalendarIcon className="w-4 h-4 text-primary-500" />
                      {format(parseISO(date), "dd/MM/yyyy")}
                    </div>
                    <div className="text-xs text-slate-500 mt-1 capitalize">
                      {periodos.includes('indisponivel') ? (
                        <span className="text-red-600 font-bold">Indisponível</span>
                      ) : periodos.includes('integral') ? (
                        <span className="text-emerald-600 font-bold">Qualquer horário</span>
                      ) : (
                        periodos.join(', ')
                      )}
                    </div>
                  </div>
                  <button 
                    onClick={() => updateDisponibilidadeRange(currentUserId, [date], ['indisponivel'])}
                    title="Marcar como indisponível"
                    className="p-2 text-slate-400 hover:text-red-500 hover:bg-red-50 rounded-full transition-colors"
                  >
                    <Trash2 className="w-4 h-4" />
                  </button>
                </div>
              );
            })
          )}
        </div>
      </div>

    </div>
  );
}
