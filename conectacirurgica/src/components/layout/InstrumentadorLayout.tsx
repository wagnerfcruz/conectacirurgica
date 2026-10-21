import { Outlet, NavLink, useNavigate } from 'react-router-dom';
import { CalendarDays, History, LogOut, User, Clock } from 'lucide-react';

import clsx from 'clsx';
import { useStore } from '../../store/useStore';

export default function InstrumentadorLayout() {
  const navigate = useNavigate();
    const { instrumentadores } = useStore();
  const currentUser = instrumentadores.find(i => i.id === 1);

  const navItems = [
    { to: '/instrumentador', icon: CalendarDays, label: 'Minha Agenda', end: true },
    { to: '/instrumentador/disponibilidade', icon: Clock, label: 'Disponibilidade' },
    { to: '/instrumentador/historico', icon: History, label: 'Histórico' },
    { to: '/instrumentador/perfil', icon: User, label: 'Meu Perfil' },
  ];

  

  return (
    <div className="flex h-screen bg-slate-50 overflow-hidden font-sans pb-[70px] lg:pb-0">
      
      {/* Sidebar (Desktop Only) */}
      <aside className="hidden lg:flex inset-y-0 left-0 w-64 bg-slate-900 flex-col transition-transform duration-300 ease-in-out z-50">
        <div className="h-16 flex items-center justify-between px-6 border-b border-slate-800 shrink-0">
          <h1 className="text-white font-bold text-lg">Área do Freelancer</h1>
        </div>
        
        <div className="flex-1 py-6 flex flex-col gap-1 px-3 overflow-y-auto">
          {navItems.map((item) => (
            <NavLink
              key={item.to}
              to={item.to}
              end={item.end}
              className={({ isActive }) => clsx(
                "flex items-center gap-3 px-3 py-2.5 rounded-lg text-sm font-medium transition-colors",
                isActive 
                  ? "bg-cyan-600 text-white shadow-md shadow-cyan-900/20" 
                  : "text-slate-300 hover:bg-slate-800 hover:text-white"
              )}
            >
              <item.icon className={clsx("w-5 h-5")} />
              {item.label}
            </NavLink>
          ))}
        </div>

        <div className="p-4 border-t border-slate-800 shrink-0">
          <div className="flex items-center gap-3 px-3 py-2 mb-4">
            <div className="w-8 h-8 rounded-full bg-slate-700 flex items-center justify-center text-sm font-bold text-white">
              {currentUser?.nome?.substring(0,2).toUpperCase()}
            </div>
            <div className="overflow-hidden">
              <p className="text-sm font-medium text-white truncate">{currentUser?.nome}</p>
              <p className="text-xs text-slate-400 truncate">{currentUser?.nivel}</p>
            </div>
          </div>
          <div className="space-y-1">
            <button 
              onClick={() => navigate('/')}
              className="w-full flex items-center gap-3 px-3 py-2 text-sm font-medium text-slate-400 hover:text-red-400 hover:bg-slate-800 rounded-lg transition-colors"
            >
              <LogOut className="w-5 h-5 text-slate-500" /> Sair
            </button>
          </div>
        </div>
      </aside>

      {/* Main Content */}
      <main className="flex-1 flex flex-col min-w-0 h-screen overflow-hidden relative">
        {/* Top Header */}
        <header className="h-16 bg-white border-b border-slate-200 flex items-center justify-between px-4 lg:px-8 shrink-0 z-10 relative lg:hidden">
          <div className="flex items-center gap-4">
            <h2 className="text-lg font-semibold text-slate-800">Painel do Instrumentador</h2>
          </div>
        </header>

        {/* Scrollable Content */}
        <div className="flex-1 overflow-y-auto p-4 lg:p-8">
          <Outlet />
        </div>
      </main>

      {/* Bottom Navigation (Mobile Only) */}
      <nav className="lg:hidden fixed bottom-0 left-0 right-0 bg-white border-t border-slate-200 flex items-center justify-around px-2 pb-safe pt-1 z-50 h-[70px]">
        {navItems.map((item) => (
          <NavLink
            key={item.to}
            to={item.to}
            end={item.end}
            className={({ isActive }) => clsx(
              "flex flex-col items-center justify-center w-full h-full py-1",
              isActive ? "text-cyan-600" : "text-slate-500 hover:text-slate-900"
            )}
          >
            <item.icon className="w-6 h-6 mb-1" />
            <span className="text-[10px] font-medium leading-none truncate w-full text-center">{item.label}</span>
          </NavLink>
        ))}
      </nav>
    </div>
  );
}
