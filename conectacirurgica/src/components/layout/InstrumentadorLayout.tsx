import { Outlet, NavLink, useNavigate } from 'react-router-dom';
import { CalendarDays, History, LogOut, User, Menu, X } from 'lucide-react';
import { useState } from 'react';
import clsx from 'clsx';
import { useStore } from '../../store/useStore';

export default function InstrumentadorLayout() {
  const navigate = useNavigate();
  const [menuOpen, setMenuOpen] = useState(false);
  const { instrumentadores } = useStore();
  const currentUser = instrumentadores.find(i => i.id === 1);

  const navItems = [
    { to: '/instrumentador', icon: CalendarDays, label: 'Minha Agenda' },
    { to: '/instrumentador/disponibilidade', icon: CalendarDays, label: 'Disponibilidade' },
    { to: '/instrumentador/historico', icon: History, label: 'Histórico' },
    { to: '/instrumentador/perfil', icon: User, label: 'Meu Perfil' },
  ];

  return (
    <div className="min-h-screen bg-slate-50 flex flex-col max-w-md mx-auto relative shadow-2xl overflow-hidden">
      {/* Header */}
      <header className="bg-primary-900 text-white px-4 py-4 flex items-center justify-between z-20 shadow-md">
        <div 
          onClick={() => navigate('/instrumentador/perfil')}
          className="flex items-center gap-3 cursor-pointer"
        >
          <div className="w-10 h-10 bg-white/10 rounded-full flex items-center justify-center font-bold">
            {currentUser?.nome?.substring(0,2).toUpperCase() || <User className="w-6 h-6 text-white" />}
          </div>
          <div>
            <h1 className="font-semibold leading-tight">{currentUser?.nome || 'Instrumentador'}</h1>
            <p className="text-xs text-primary-200 truncate max-w-[200px]">{currentUser?.especialidades.join(', ') || 'Nenhuma especialidade'}</p>
          </div>
        </div>
        <button onClick={() => setMenuOpen(!menuOpen)} className="p-2">
          {menuOpen ? <X className="w-6 h-6" /> : <Menu className="w-6 h-6" />}
        </button>
      </header>

      {/* Mobile Menu */}
      {menuOpen && (
        <div className="absolute inset-0 top-18 bg-primary-900 z-10 flex flex-col pt-4 px-4 transition-all">
          <nav className="flex flex-col gap-2">
            {navItems.map((item) => (
              <NavLink
                key={item.to}
                to={item.to}
                onClick={() => setMenuOpen(false)}
                end={item.to === '/instrumentador'}
                className={({ isActive }) =>
                  clsx(
                    'flex items-center gap-4 px-4 py-3 rounded-lg text-sm font-medium transition-colors',
                    isActive ? 'bg-primary-800 text-white' : 'text-primary-200 hover:bg-primary-800/50 hover:text-white'
                  )
                }
              >
                <item.icon className="w-5 h-5" />
                {item.label}
              </NavLink>
            ))}
            <button
              onClick={() => navigate('/')}
              className="flex items-center gap-4 px-4 py-3 rounded-lg text-sm font-medium text-red-300 hover:bg-red-900/30 mt-auto mb-8"
            >
              <LogOut className="w-5 h-5" />
              Sair
            </button>
          </nav>
        </div>
      )}

      {/* Main Content */}
      <main className="flex-1 overflow-y-auto pb-20 relative z-0">
        <Outlet />
      </main>

      {/* Bottom Navigation */}
      <nav className="bg-white border-t border-slate-200 fixed bottom-0 w-full max-w-md flex justify-around px-2 py-2 pb-safe z-20">
        {navItems.map((item) => (
          <NavLink
            key={item.to}
            to={item.to}
            end={item.to === '/instrumentador'}
            className={({ isActive }) =>
              clsx(
                'flex flex-col items-center p-2 rounded-lg min-w-[72px] transition-colors',
                isActive ? 'text-primary-600' : 'text-slate-500 hover:text-slate-900'
              )
            }
          >
            <item.icon className={clsx('w-6 h-6 mb-1', 'transition-transform')} />
            <span className="text-[10px] font-medium leading-none">{item.label.split(' ')[0]}</span>
          </NavLink>
        ))}
      </nav>
    </div>
  );
}
