import { Outlet, NavLink, useNavigate } from 'react-router-dom';
import { LayoutDashboard, Users, Map, Bell, CheckCircle, FileText, Search, LogOut, Settings, BellRing, Menu, X } from 'lucide-react';
import { useState } from 'react';
import clsx from 'clsx';

export default function CoordenadoraLayout() {
  const navigate = useNavigate();
  const [isMobileMenuOpen, setIsMobileMenuOpen] = useState(false);

  const navItems = [
    { to: '/coordenadora', icon: LayoutDashboard, label: 'Dashboard', end: true },
    { to: '/coordenadora/disponibilidade', icon: Search, label: 'Disponibilidade' },
    { to: '/coordenadora/mapa', icon: Map, label: 'Mapa Cirúrgico' },
    { to: '/coordenadora/acionamentos', icon: Bell, label: 'Acionamentos' },
    { to: '/coordenadora/confirmados', icon: CheckCircle, label: 'Confirmados' },
    { to: '/coordenadora/profissionais', icon: Users, label: 'Profissionais' },
    { to: '/coordenadora/documentos', icon: FileText, label: 'Documentos' },
  ];

  const toggleMenu = () => setIsMobileMenuOpen(!isMobileMenuOpen);
  const closeMenu = () => setIsMobileMenuOpen(false);

  return (
    <div className="flex h-screen bg-slate-50 overflow-hidden font-sans">
      
      {/* Mobile Overlay */}
      {isMobileMenuOpen && (
        <div 
          className="fixed inset-0 bg-slate-900/50 z-20 lg:hidden"
          onClick={closeMenu}
        />
      )}

      {/* Sidebar */}
      <aside className={clsx(
        "fixed inset-y-0 left-0 z-30 w-64 bg-primary-950 text-slate-300 flex flex-col transition-transform duration-300 shadow-xl lg:static lg:translate-x-0",
        isMobileMenuOpen ? "translate-x-0" : "-translate-x-full"
      )}>
        <div className="h-16 flex items-center justify-between px-6 border-b border-primary-900 bg-primary-950 shrink-0">
          <div className="flex items-center gap-2 text-white">
            <div className="w-8 h-8 bg-primary-600 rounded flex items-center justify-center">
              <Users className="w-5 h-5 text-white" />
            </div>
            <span className="font-bold tracking-tight">Conecta Cirúrgica</span>
          </div>
          <button onClick={closeMenu} className="lg:hidden text-slate-400 hover:text-white">
            <X className="w-6 h-6" />
          </button>
        </div>

        <div className="p-4 mb-2 shrink-0">
          <div className="text-xs uppercase tracking-wider font-bold text-primary-400 mb-4 px-2">Menu Principal</div>
          <nav className="space-y-1">
            {navItems.map((item) => (
              <NavLink
                key={item.to}
                to={item.to}
                end={item.end}
                onClick={closeMenu}
                className={({ isActive }) => clsx(
                  "flex items-center gap-3 px-3 py-2.5 rounded-lg text-sm font-medium transition-colors group",
                  isActive 
                    ? "bg-primary-900 text-white" 
                    : "text-slate-400 hover:bg-primary-900/50 hover:text-slate-200"
                )}
              >
                {({ isActive }) => (
                  <>
                    <item.icon className={clsx("w-5 h-5", isActive ? "text-primary-400" : "text-slate-500 group-hover:text-slate-400")} />
                    {item.label}
                  </>
                )}
              </NavLink>
            ))}
          </nav>
        </div>

        <div className="mt-auto p-4 border-t border-primary-900 shrink-0">
          <div className="flex items-center gap-3 px-2 py-3">
            <div className="w-10 h-10 rounded-full bg-primary-800 flex items-center justify-center text-primary-100 font-bold border border-primary-700">
              CC
            </div>
            <div className="flex-1 min-w-0">
              <p className="text-sm font-medium text-white truncate">Coordenação</p>
              <p className="text-xs text-primary-400 truncate">Hosp. Central</p>
            </div>
          </div>
          <div className="mt-4 space-y-1">
            <button className="w-full flex items-center gap-3 px-3 py-2 text-sm font-medium text-slate-400 hover:text-slate-200 hover:bg-primary-900/50 rounded-lg transition-colors">
              <Settings className="w-5 h-5 text-slate-500" /> Configurações
            </button>
            <button 
              onClick={() => navigate('/')}
              className="w-full flex items-center gap-3 px-3 py-2 text-sm font-medium text-slate-400 hover:text-red-400 hover:bg-primary-900/50 rounded-lg transition-colors"
            >
              <LogOut className="w-5 h-5 text-slate-500" /> Sair
            </button>
          </div>
        </div>
      </aside>

      {/* Main Content */}
      <main className="flex-1 flex flex-col min-w-0 h-screen overflow-hidden">
        {/* Top Header */}
        <header className="h-16 bg-white border-b border-slate-200 flex items-center justify-between px-4 lg:px-8 shrink-0 z-10">
          <div className="flex items-center gap-4">
            <button onClick={toggleMenu} className="lg:hidden p-2 -ml-2 text-slate-500 hover:bg-slate-100 rounded-md">
              <Menu className="w-6 h-6" />
            </button>
            <h2 className="text-lg font-semibold text-slate-800 hidden sm:block">Painel da Coordenadora</h2>
          </div>
          
          <div className="flex items-center gap-4">
            <div className="relative">
              <button className="p-2 text-slate-400 hover:text-slate-600 hover:bg-slate-100 rounded-full transition-colors relative">
                <BellRing className="w-5 h-5" />
                <span className="absolute top-1.5 right-1.5 w-2 h-2 bg-red-500 rounded-full ring-2 ring-white"></span>
              </button>
            </div>
          </div>
        </header>

        {/* Scrollable Content */}
        <div className="flex-1 overflow-y-auto p-4 lg:p-8">
          <Outlet />
        </div>
      </main>
    </div>
  );
}
