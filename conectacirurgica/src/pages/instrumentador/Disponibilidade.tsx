import { useState } from 'react';
import { format, parseISO, isBefore, eachDayOfInterval, addDays } from 'date-fns';
import { Check, X, Calendar as CalendarIcon, Trash2 } from 'lucide-react';
import clsx from 'clsx';
import { useStore } from '../../store/useStore';

type Periodo = 'manha' | 'tarde' | 'noite';

export default function Disponibilidade() {
  const currentUserId = 1;
  const { instrumentadores, updateDisponibilidadeRange } = useStore();
  const currentUser = instrumentadores.find(i => i.id === currentUserId);

  const [dataInicial, setDataInicial] = useState(format(new Date(), 'yyyy-MM-dd'));
  const [dataFinal, setDataFinal] = useState(format(addDays(new Date(), 7), 'yyyy-MM-dd'));
  
  const [diasSemana, setDiasSemana] = useState<number[]>([1, 2, 3, 4, 5]); // Seg a Sex
  
  const [disponibilidadeLocal, setDisponibilidadeLocal] = useState<{diaInteiro: boolean, periodos: Record<Periodo, boolean>, indisponivel: boolean}>({
    diaInteiro: true,
    periodos: { manha: true, tarde: true, noite: true },
    indisponivel: false
  });
  
  const [saveSuccess, setSaveSuccess] = useState(false);
  const [errorMsg, setErrorMsg] = useState('');

  const diasOptions = [
    { id: 0, label: 'Dom' },
    { id: 1, label: 'Seg' },
    { id: 2, label: 'Ter' },
    { id: 3, label: 'Qua' },
    { id: 4, label: 'Qui' },
    { id: 5, label: 'Sex' },
    { id: 6, label: 'Sáb' },
  ];

  const handlePeriodoToggle = (periodo: Periodo) => {
    setDisponibilidadeLocal(prev => {
      const novosPeriodos = { ...prev.periodos, [periodo]: !prev.periodos[periodo] };
      const isDiaInteiro = novosPeriodos.manha && novosPeriodos.tarde && novosPeriodos.noite;
      return {
        ...prev,
        indisponivel: false,
        periodos: novosPeriodos,
        diaInteiro: isDiaInteiro
      };
    });
  };

  const handleDiaInteiroToggle = () => {
    setDisponibilidadeLocal(prev => {
      const novoValor = !prev.diaInteiro;
      return {
        indisponivel: false,
        diaInteiro: novoValor,
        periodos: { manha: novoValor, tarde: novoValor, noite: novoValor }
      };
    });
  };

  const handleIndisponivelToggle = () => {
    setDisponibilidadeLocal({
      indisponivel: true,
      diaInteiro: false,
      periodos: { manha: false, tarde: false, noite: false }
    });
  };

  const toggleDiaSemana = (diaId: number) => {
    setDiasSemana(prev => 
      prev.includes(diaId) ? prev.filter(d => d !== diaId) : [...prev, diaId]
    );
  };

  const handleSave = () => {
    setErrorMsg('');
    const dInit = parseISO(dataInicial);
    const dEnd = parseISO(dataFinal);
    
    if (isBefore(dEnd, dInit)) {
      setErrorMsg('A data final não pode ser antes da data inicial.');
      return;
    }
    
    if (diasSemana.length === 0) {
      setErrorMsg('Selecione pelo menos um dia da semana.');
      return;
    }

    if (!disponibilidadeLocal.indisponivel && !disponibilidadeLocal.diaInteiro && !disponibilidadeLocal.periodos.manha && !disponibilidadeLocal.periodos.tarde && !disponibilidadeLocal.periodos.noite) {
      setErrorMsg('Selecione pelo menos um período ou marque como indisponível.');
      return;
    }

    const allDays = eachDayOfInterval({ start: dInit, end: dEnd });
    const datesToUpdate = allDays
      .filter(d => diasSemana.includes(d.getDay()))
      .map(d => format(d, 'yyyy-MM-dd'));

    let periodosFormatados: string[] = [];
    
    if (disponibilidadeLocal.indisponivel) {
      periodosFormatados = ['indisponivel'];
    } else if (disponibilidadeLocal.diaInteiro) {
      periodosFormatados = ['integral', 'manha', 'tarde', 'noite'];
    } else {
      if (disponibilidadeLocal.periodos.manha) periodosFormatados.push('manha');
      if (disponibilidadeLocal.periodos.tarde) periodosFormatados.push('tarde');
      if (disponibilidadeLocal.periodos.noite) periodosFormatados.push('noite');
    }

    updateDisponibilidadeRange(currentUserId, datesToUpdate, periodosFormatados);
    setSaveSuccess(true);
    setTimeout(() => setSaveSuccess(false), 3000);
  };

  // Mostrar as disponibilidades atuais registradas
  const dispMap = currentUser?.disponibilidade || {};
  const datasRegistradas = Object.keys(dispMap).sort();

  return (
    <div className="p-4 space-y-6 max-w-lg mx-auto pb-24">
      <div>
        <h1 className="text-xl font-bold text-slate-900 mb-1">Disponibilidade</h1>
        <p className="text-sm text-slate-500">Informe quando você pode ser acionado para cirurgias informando um período de datas.</p>
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-100 p-5 space-y-6">
        <h2 className="font-bold text-slate-800 border-b border-slate-100 pb-2">Nova Disponibilidade</h2>
        
        {errorMsg && (
          <div className="bg-red-50 text-red-700 p-3 rounded-lg text-sm font-medium border border-red-200">
            {errorMsg}
          </div>
        )}

        <div className="grid grid-cols-2 gap-4">
          <div>
            <label className="block text-sm font-medium text-slate-700 mb-1">Data Inicial</label>
            <input 
              type="date" 
              value={dataInicial}
              onChange={e => setDataInicial(e.target.value)}
              className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500"
            />
          </div>
          <div>
            <label className="block text-sm font-medium text-slate-700 mb-1">Data Final</label>
            <input 
              type="date" 
              value={dataFinal}
              onChange={e => setDataFinal(e.target.value)}
              className="w-full border border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500"
            />
          </div>
        </div>

        <div>
          <label className="block text-sm font-medium text-slate-700 mb-2">Dias da Semana</label>
          <div className="flex flex-wrap gap-2">
            {diasOptions.map(dia => (
              <button
                key={dia.id}
                onClick={() => toggleDiaSemana(dia.id)}
                className={clsx(
                  "px-3 py-1.5 rounded-full text-xs font-bold border transition-colors",
                  diasSemana.includes(dia.id) ? "bg-primary-600 text-white border-primary-600" : "bg-white text-slate-600 border-slate-300"
                )}
              >
                {dia.label}
              </button>
            ))}
          </div>
        </div>

        <div className="space-y-3 pt-2">
          <label className="block text-sm font-medium text-slate-700">Turnos Disponíveis</label>
          
          <button 
            onClick={handleDiaInteiroToggle}
            className={clsx(
              "w-full flex items-center justify-between p-4 rounded-xl border-2 transition-all",
              disponibilidadeLocal.diaInteiro ? "border-primary-500 bg-primary-50" : "border-slate-100 hover:border-primary-200"
            )}
          >
            <div className="flex flex-col text-left">
              <span className={clsx("font-bold", disponibilidadeLocal.diaInteiro ? "text-primary-900" : "text-slate-700")}>Dia Inteiro</span>
              <span className="text-xs text-slate-500">Disponível em todos os turnos</span>
            </div>
            <div className={clsx("w-6 h-6 rounded-full border-2 flex items-center justify-center", disponibilidadeLocal.diaInteiro ? "border-primary-500 bg-primary-500 text-white" : "border-slate-300 text-transparent")}>
              <Check className="w-4 h-4" />
            </div>
          </button>

          <div className="grid grid-cols-3 gap-3">
            {[
              { id: 'manha', label: 'Manhã', desc: '06h-12h' },
              { id: 'tarde', label: 'Tarde', desc: '12h-18h' },
              { id: 'noite', label: 'Noite', desc: '18h-24h' }
            ].map((turno) => (
              <button
                key={turno.id}
                onClick={() => handlePeriodoToggle(turno.id as Periodo)}
                className={clsx(
                  "flex flex-col items-center justify-center p-3 rounded-xl border-2 transition-all",
                  disponibilidadeLocal.periodos[turno.id as Periodo] ? "border-primary-500 bg-primary-50" : "border-slate-100 hover:border-primary-200"
                )}
              >
                <span className={clsx("font-bold text-sm", disponibilidadeLocal.periodos[turno.id as Periodo] ? "text-primary-900" : "text-slate-700")}>
                  {turno.label}
                </span>
                <span className="text-[10px] text-slate-500 mt-1">{turno.desc}</span>
              </button>
            ))}
          </div>

          <div className="relative flex items-center py-2">
            <div className="flex-grow border-t border-slate-100"></div>
            <span className="flex-shrink-0 mx-4 text-slate-400 text-xs font-medium uppercase">OU</span>
            <div className="flex-grow border-t border-slate-100"></div>
          </div>

          <button 
            onClick={handleIndisponivelToggle}
            className={clsx(
              "w-full flex items-center justify-between p-4 rounded-xl border-2 transition-all",
              disponibilidadeLocal.indisponivel ? "border-red-500 bg-red-50" : "border-slate-100 hover:border-red-200"
            )}
          >
            <div className="flex flex-col text-left">
              <span className={clsx("font-bold", disponibilidadeLocal.indisponivel ? "text-red-900" : "text-slate-700")}>Indisponível (Exceção)</span>
              <span className="text-xs text-slate-500">Marque para bloquear dias específicos</span>
            </div>
            <div className={clsx("w-6 h-6 rounded-full border-2 flex items-center justify-center", disponibilidadeLocal.indisponivel ? "border-red-500 bg-red-500 text-white" : "border-slate-300 text-transparent")}>
              <X className="w-4 h-4" />
            </div>
          </button>
        </div>

        <div className="pt-4 flex">
          <button onClick={handleSave} className="w-full bg-primary-600 text-white py-3 rounded-xl font-bold text-sm hover:bg-primary-700 shadow-md shadow-primary-500/20">
            Salvar Período
          </button>
        </div>

        {saveSuccess && (
          <div className="bg-emerald-50 text-emerald-800 text-sm font-bold p-3 rounded-lg flex justify-center items-center gap-2 border border-emerald-200 mt-2">
            <Check className="w-4 h-4" /> Período salvo com sucesso!
          </div>
        )}
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-100 p-5">
        <h2 className="font-bold text-slate-800 mb-4 border-b border-slate-100 pb-2">Datas Registradas</h2>
        <div className="space-y-2 max-h-60 overflow-y-auto">
          {datasRegistradas.length === 0 ? (
            <p className="text-sm text-slate-500 text-center py-4">Nenhuma disponibilidade informada.</p>
          ) : (
            datasRegistradas.map(date => {
              const periodos = dispMap[date];
              return (
                <div key={date} className="flex justify-between items-center p-3 border border-slate-100 rounded-lg">
                  <div>
                    <div className="font-medium text-slate-800 text-sm flex items-center gap-2">
                      <CalendarIcon className="w-4 h-4 text-primary-500" />
                      {format(parseISO(date), "dd/MM/yyyy")}
                    </div>
                    <div className="text-xs text-slate-500 mt-1 capitalize">
                      {periodos.includes('indisponivel') ? (
                        <span className="text-red-600 font-bold">Indisponível</span>
                      ) : periodos.includes('integral') ? (
                        <span className="text-emerald-600 font-bold">Dia Inteiro</span>
                      ) : (
                        periodos.join(', ')
                      )}
                    </div>
                  </div>
                  <button 
                    onClick={() => updateDisponibilidadeRange(currentUserId, [date], ['indisponivel'])}
                    title="Excluir/Marcar como indisponível"
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
