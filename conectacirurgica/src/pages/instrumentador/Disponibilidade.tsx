import { useState } from 'react';
import { format, addDays, startOfWeek, addWeeks } from 'date-fns';
import { ptBR } from 'date-fns/locale';
import { Check, X, Calendar as CalendarIcon } from 'lucide-react';
import clsx from 'clsx';

type Periodo = 'manha' | 'tarde' | 'noite';

export default function Disponibilidade() {
  const today = new Date();
  const [selectedDate, setSelectedDate] = useState<Date>(today);
  
  // Estado mock para disponibilidades do dia selecionado
  const [disponibilidade, setDisponibilidade] = useState({
    diaInteiro: false,
    periodos: {
      manha: true,
      tarde: false,
      noite: false
    },
    indisponivel: false
  });

  const [saved, setSaved] = useState(false);

  // Gera dias da semana atual
  const start = startOfWeek(today, { weekStartsOn: 1 });
  const weekDays = Array.from({ length: 7 }).map((_, i) => addDays(start, i));

  const handlePeriodoToggle = (periodo: Periodo) => {
    if (disponibilidade.indisponivel || disponibilidade.diaInteiro) return;
    
    setDisponibilidade(prev => ({
      ...prev,
      periodos: {
        ...prev.periodos,
        [periodo]: !prev.periodos[periodo]
      }
    }));
    setSaved(false);
  };

  const handleDiaInteiro = () => {
    setDisponibilidade({
      diaInteiro: true,
      periodos: { manha: true, tarde: true, noite: true },
      indisponivel: false
    });
    setSaved(false);
  };

  const handleIndisponivel = () => {
    setDisponibilidade({
      diaInteiro: false,
      periodos: { manha: false, tarde: false, noite: false },
      indisponivel: true
    });
    setSaved(false);
  };

  const handleSave = () => {
    setSaved(true);
    setTimeout(() => setSaved(false), 3000);
  };

  return (
    <div className="p-4 space-y-6">
      <header className="mb-2">
        <h2 className="text-xl font-bold text-slate-900">Disponibilidade</h2>
        <p className="text-sm text-slate-500">Informe seus horários para receber convites</p>
      </header>

      {/* Calendário Simplificado (Semanal) */}
      <section className="bg-white p-4 rounded-xl shadow-sm border border-slate-100">
        <div className="flex items-center justify-between mb-4">
          <span className="text-sm font-semibold capitalize text-slate-700">
            {format(start, "MMMM 'de' yyyy", { locale: ptBR })}
          </span>
          <CalendarIcon className="w-5 h-5 text-slate-400" />
        </div>
        
        <div className="flex justify-between">
          {weekDays.map(day => {
            const isSelected = format(day, 'yyyy-MM-dd') === format(selectedDate, 'yyyy-MM-dd');
            const isToday = format(day, 'yyyy-MM-dd') === format(today, 'yyyy-MM-dd');
            
            return (
              <button
                key={day.toISOString()}
                onClick={() => setSelectedDate(day)}
                className={clsx(
                  'flex flex-col items-center p-2 rounded-lg min-w-[40px]',
                  isSelected ? 'bg-primary-600 text-white shadow-md' : 'text-slate-600 hover:bg-slate-50',
                  isToday && !isSelected && 'text-primary-600 font-bold'
                )}
              >
                <span className="text-xs mb-1 uppercase">{format(day, 'EEE', { locale: ptBR }).substring(0, 3)}</span>
                <span className={clsx('text-lg', isSelected ? 'font-bold' : 'font-medium')}>
                  {format(day, 'd')}
                </span>
              </button>
            )
          })}
        </div>
      </section>

      {/* Seleção de Horários */}
      <section className="space-y-4">
        <div className="flex items-center justify-between">
          <h3 className="text-sm font-bold text-slate-700">
            {format(selectedDate, "EEEE, d 'de' MMMM", { locale: ptBR })}
          </h3>
        </div>

        <div className="grid grid-cols-2 gap-3">
          <button
            onClick={handleDiaInteiro}
            className={clsx(
              'p-4 rounded-xl border flex flex-col items-center justify-center gap-2 transition-all',
              disponibilidade.diaInteiro 
                ? 'bg-emerald-50 border-emerald-500 text-emerald-700 ring-1 ring-emerald-500' 
                : 'bg-white border-slate-200 text-slate-600 hover:border-emerald-300'
            )}
          >
            <Check className={clsx("w-6 h-6", disponibilidade.diaInteiro ? "text-emerald-600" : "text-slate-400")} />
            <span className="font-medium">Dia Inteiro</span>
          </button>

          <button
            onClick={handleIndisponivel}
            className={clsx(
              'p-4 rounded-xl border flex flex-col items-center justify-center gap-2 transition-all',
              disponibilidade.indisponivel 
                ? 'bg-red-50 border-red-500 text-red-700 ring-1 ring-red-500' 
                : 'bg-white border-slate-200 text-slate-600 hover:border-red-300'
            )}
          >
            <X className={clsx("w-6 h-6", disponibilidade.indisponivel ? "text-red-600" : "text-slate-400")} />
            <span className="font-medium">Indisponível</span>
          </button>
        </div>

        <div className="bg-white p-1 rounded-xl border border-slate-200 overflow-hidden mt-4">
          <div className="grid grid-cols-3 divide-x divide-slate-100">
            {[
              { id: 'manha', label: 'Manhã', time: '06h - 12h' },
              { id: 'tarde', label: 'Tarde', time: '12h - 18h' },
              { id: 'noite', label: 'Noite', time: '18h - 00h' }
            ].map((periodo) => (
              <button
                key={periodo.id}
                onClick={() => handlePeriodoToggle(periodo.id as Periodo)}
                disabled={disponibilidade.indisponivel || disponibilidade.diaInteiro}
                className={clsx(
                  'py-3 px-1 flex flex-col items-center justify-center transition-colors',
                  disponibilidade.periodos[periodo.id as Periodo]
                    ? 'bg-primary-50 text-primary-700'
                    : 'bg-white text-slate-600',
                  (disponibilidade.indisponivel || disponibilidade.diaInteiro) && 'opacity-50 cursor-not-allowed'
                )}
              >
                <div className={clsx(
                  'w-5 h-5 rounded-full border flex items-center justify-center mb-1',
                  disponibilidade.periodos[periodo.id as Periodo]
                    ? 'bg-primary-600 border-primary-600 text-white'
                    : 'border-slate-300'
                )}>
                  {disponibilidade.periodos[periodo.id as Periodo] && <Check className="w-3 h-3" />}
                </div>
                <span className="text-sm font-medium">{periodo.label}</span>
                <span className="text-[10px] text-slate-400">{periodo.time}</span>
              </button>
            ))}
          </div>
        </div>
      </section>

      {/* Action Area */}
      <div className="pt-4">
        <button
          onClick={handleSave}
          className={clsx(
            'w-full py-4 rounded-xl font-bold text-lg shadow-sm transition-all',
            saved 
              ? 'bg-emerald-500 text-white' 
              : 'bg-primary-600 hover:bg-primary-700 text-white'
          )}
        >
          {saved ? 'Disponibilidade Salva!' : 'Confirmar Horários'}
        </button>
        {saved && (
          <p className="text-center text-xs text-slate-500 mt-2">
            Última atualização: {format(new Date(), "HH:mm")}
          </p>
        )}
      </div>
    </div>
  );
}
