import { useState, useEffect } from 'react';
import { format, addDays, startOfWeek, subWeeks, addWeeks, isSameDay } from 'date-fns';
import { ptBR } from 'date-fns/locale';
import { Check, X, Calendar as CalendarIcon, ChevronLeft, ChevronRight } from 'lucide-react';
import clsx from 'clsx';
import { useStore } from '../../store/useStore';

type Periodo = 'manha' | 'tarde' | 'noite';

export default function Disponibilidade() {
  const currentUserId = 1;
  const { instrumentadores, updateDisponibilidade } = useStore();
  const currentUser = instrumentadores.find(i => i.id === currentUserId);

  const [currentWeekStart, setCurrentWeekStart] = useState(startOfWeek(new Date(), { weekStartsOn: 0 }));
  const [selectedDate, setSelectedDate] = useState<Date>(new Date());
  
  const [disponibilidadeLocal, setDisponibilidadeLocal] = useState<{diaInteiro: boolean, periodos: Record<Periodo, boolean>, indisponivel: boolean}>({
    diaInteiro: false,
    periodos: { manha: false, tarde: false, noite: false },
    indisponivel: true
  });
  
  const [hasChanges, setHasChanges] = useState(false);
  const [saveSuccess, setSaveSuccess] = useState(false);

  // Sync component state with global store when selected date changes
  useEffect(() => {
    if (!currentUser) return;
    const dateStr = format(selectedDate, 'yyyy-MM-dd');
    const disp = currentUser.disponibilidade[dateStr];
    
    if (disp) {
      if (disp.includes('indisponivel')) {
        setDisponibilidadeLocal({
          diaInteiro: false,
          periodos: { manha: false, tarde: false, noite: false },
          indisponivel: true
        });
      } else if (disp.includes('integral')) {
        setDisponibilidadeLocal({
          diaInteiro: true,
          periodos: { manha: true, tarde: true, noite: true },
          indisponivel: false
        });
      } else {
        setDisponibilidadeLocal({
          diaInteiro: false,
          periodos: {
            manha: disp.includes('manha'),
            tarde: disp.includes('tarde'),
            noite: disp.includes('noite')
          },
          indisponivel: false
        });
      }
    } else {
      // Default: Sem informação preenchida
      setDisponibilidadeLocal({
        diaInteiro: false,
        periodos: { manha: false, tarde: false, noite: false },
        indisponivel: false
      });
    }
    setHasChanges(false);
    setSaveSuccess(false);
  }, [selectedDate, currentUser]);

  const weekDays = [...Array(7)].map((_, i) => addDays(currentWeekStart, i));

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
    setHasChanges(true);
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
    setHasChanges(true);
  };

  const handleIndisponivelToggle = () => {
    setDisponibilidadeLocal({
      indisponivel: true,
      diaInteiro: false,
      periodos: { manha: false, tarde: false, noite: false }
    });
    setHasChanges(true);
  };

  const handleSave = () => {
    const dateStr = format(selectedDate, 'yyyy-MM-dd');
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

    updateDisponibilidade(currentUserId, dateStr, periodosFormatados);
    setHasChanges(false);
    setSaveSuccess(true);
    setTimeout(() => setSaveSuccess(false), 3000);
  };

  return (
    <div className="p-4 space-y-6 max-w-lg mx-auto pb-24">
      <div>
        <h1 className="text-xl font-bold text-slate-900 mb-1">Disponibilidade</h1>
        <p className="text-sm text-slate-500">Informe quando você pode ser acionado para cirurgias.</p>
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-100 overflow-hidden">
        <div className="flex justify-between items-center p-4 border-b border-slate-100 bg-slate-50">
          <button onClick={() => setCurrentWeekStart(subWeeks(currentWeekStart, 1))} className="p-1 hover:bg-slate-200 rounded">
            <ChevronLeft className="w-5 h-5 text-slate-600" />
          </button>
          <span className="font-semibold text-slate-800 capitalize">
            {format(currentWeekStart, 'MMMM yyyy', { locale: ptBR })}
          </span>
          <button onClick={() => setCurrentWeekStart(addWeeks(currentWeekStart, 1))} className="p-1 hover:bg-slate-200 rounded">
            <ChevronRight className="w-5 h-5 text-slate-600" />
          </button>
        </div>
        
        <div className="p-4">
          <div className="flex justify-between gap-1 overflow-x-auto snap-x hide-scrollbar pb-2">
            {weekDays.map(date => {
              const isSelected = isSameDay(date, selectedDate);
              const isToday = isSameDay(date, new Date());
              return (
                <button
                  key={date.toString()}
                  onClick={() => setSelectedDate(date)}
                  className={clsx(
                    "flex flex-col items-center p-2 rounded-xl min-w-[50px] snap-center transition-colors border",
                    isSelected ? "bg-primary-600 text-white border-primary-600 shadow-md" : 
                    isToday ? "bg-slate-50 border-primary-200 text-slate-900" : "bg-white border-slate-100 text-slate-600 hover:border-primary-200"
                  )}
                >
                  <span className="text-[10px] uppercase font-medium opacity-80">
                    {format(date, 'eee', { locale: ptBR }).substring(0, 3)}
                  </span>
                  <span className={clsx("text-lg font-bold mt-1", isSelected ? "text-white" : "text-slate-900")}>
                    {format(date, 'd')}
                  </span>
                </button>
              );
            })}
          </div>
        </div>
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-100 p-5 space-y-6">
        <div className="flex items-center gap-2 text-slate-800 font-semibold mb-2">
          <CalendarIcon className="w-5 h-5 text-primary-500" />
          {format(selectedDate, "EEEE, d 'de' MMMM", { locale: ptBR })}
        </div>

        <div className="space-y-3">
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
              <span className={clsx("font-bold", disponibilidadeLocal.indisponivel ? "text-red-900" : "text-slate-700")}>Indisponível</span>
              <span className="text-xs text-slate-500">Não poderei ser acionado neste dia</span>
            </div>
            <div className={clsx("w-6 h-6 rounded-full border-2 flex items-center justify-center", disponibilidadeLocal.indisponivel ? "border-red-500 bg-red-500 text-white" : "border-slate-300 text-transparent")}>
              <X className="w-4 h-4" />
            </div>
          </button>
        </div>

        {hasChanges && (
          <div className="pt-4 border-t border-slate-100 flex gap-3">
            <button className="flex-1 bg-white border border-slate-300 text-slate-700 py-3 rounded-xl font-bold text-sm hover:bg-slate-50">
              Desfazer
            </button>
            <button onClick={handleSave} className="flex-1 bg-primary-600 text-white py-3 rounded-xl font-bold text-sm hover:bg-primary-700 shadow-md shadow-primary-500/20">
              Salvar Alterações
            </button>
          </div>
        )}

        {saveSuccess && (
          <div className="bg-emerald-50 text-emerald-800 text-sm font-bold p-3 rounded-lg flex justify-center items-center gap-2 border border-emerald-200">
            <Check className="w-4 h-4" /> Atualizado com sucesso!
          </div>
        )}
      </div>
    </div>
  );
}
