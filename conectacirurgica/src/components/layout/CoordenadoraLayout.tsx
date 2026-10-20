import { Outlet, NavLink, useNavigate } from 'react-router-dom';
import { LayoutDashboard, Users, Map, Bell, CheckCircle, FileText, Search, LogOut, Settings, BellRing } from 'lucide-react';
import clsx from 'clsx';

export default function CoordenadoraLayout() {
  const navigate = useNavigate();

  const navItems = [
    { to: '/coordenadora', icon: LayoutDashboard, label: 'Dashboard' },
    { to: '/coordenadora/disponibilidade', icon: Search, label: 'Disponibilidade' },
    { to: '/coordenadora/mapa', icon: Map, label: 'Mapa Cirúrgico' },
    { to: '/coordenadora/acionamentos', icon: Bell, label: 'Acionamentos' },
    { to: '/coordenadora/confirmados', icon: CheckCircle, label: 'Confirmados' },
    { to: '/coordenadora/profissionais', icon: Users, label: 'Profissionais' },
    { to: '/coordenadora/documentos', icon: FileText, label: 'Documentos' },
  ];

  return (
    <div className="flex h-screen bg-slate-50 overflow-hidden font-sans">
      {/* Sidebar */}
      <aside className="w-64 bg-primary-950 text-slate-300 flex flex-col transition-all duration-300 shadow-xl z-20">
        <div className="h-16 flex items-center px-6 border-b border-primary-900 bg-primary-950">
          <div className="flex items-center gap-2 text-white">
            <div className="w-8 h-8 bg-primary-600 rounded flex items-center justify-center">
              <Users className="w-5 h-5 text-white" />
            </div>
            <span className="font-bold text-lg tracking-tight">Conecta Cirúrgica</span>
          </div>
        </div>

        <div className="px-6 py-4 flex items-center gap-3 border-b border-primary-900">
          <div className="w-10 h-10 rounded-full bg-primary-800 flex items-center justify-center text-white font-medium shadow-inner">
            MC
          </div>
          <div className="flex-1 overflow-hidden">
            <p className="text-sm font-medium text-white truncate">Maria Coordenadora</p>
            <p className="text-xs text-primary-400 truncate">Hospital Exemplo</p>
          </div>
        </div>

        <nav className="flex-1 overflow-y-auto py-4 px-3 space-y-1">
          {navItems.map((item) => (
            <NavLink
              key={item.to}
              to={item.to}
              end={item.to === '/coordenadora'}
              className={({ isActive }) =>
                clsx(
                  'flex items-center gap-3 px-3 py-2.5 rounded-md text-sm font-medium transition-colors',
                  isActive
                    ? 'bg-primary-800 text-white shadow-sm'
                    : 'hover:bg-primary-900 hover:text-white'
                )
              }
            >
              <item.icon className={clsx('w-5 h-5 flex-shrink-0')} />
              {item.label}
            </NavLink>
          ))}
        </nav>

        <div className="p-4 border-t border-primary-900 space-y-1">
          <button className="flex items-center gap-3 px-3 py-2 w-full rounded-md text-sm font-medium hover:bg-primary-900 transition-colors">
            <Settings className="w-5 h-5 flex-shrink-0" />
            Configurações
          </button>
          <button
            onClick={() => navigate('/')}
            className="flex items-center gap-3 px-3 py-2 w-full rounded-md text-sm font-medium text-red-300 hover:bg-red-900/40 hover:text-red-200 transition-colors"
          >
            <LogOut className="w-5 h-5 flex-shrink-0" />
            Sair
          </button>
        </div>
      </aside>

      {/* Main Content Area */}
      <main className="flex-1 flex flex-col min-w-0 overflow-hidden">
        {/* Topbar */}
        <header className="h-16 bg-white border-b border-slate-200 flex items-center justify-between px-8 z-10">
          <h2 className="text-xl font-semibold text-slate-800">Painel de Controle</h2>
          
          <div className="flex items-center gap-4">
            <button className="relative p-2 text-slate-400 hover:text-slate-600 rounded-full hover:bg-slate-100 transition-colors">
              <BellRing className="w-5 h-5" />
              <span className="absolute top-1.5 right-1.5 w-2 h-2 bg-red-500 rounded-full border-2 border-white"></span>
            </button>
          </div>
        </header>

        {/* Page Content */}
        <div className="flex-1 overflow-auto bg-slate-50 p-8">
          <div className="max-w-6xl mx-auto">
            <Outlet />
          </div>
        </div>
      </main>
    </div>
  );
}
