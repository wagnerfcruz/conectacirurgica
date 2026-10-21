import { Outlet, NavLink, useNavigate } from 'react-router-dom';
import { LayoutDashboard, Users, Map, Bell, CheckCircle, FileText, Search, LogOut, Settings, BellRing, Menu, X, AlertTriangle } from 'lucide-react';
import { useState } from 'react';
import clsx from 'clsx';
import { useStore } from '../../store/useStore';

export default function CoordenadoraLayout() {
  const navigate = useNavigate();
  const [isMobileMenuOpen, setIsMobileMenuOpen] = useState(false);
  const [showNotifications, setShowNotifications] = useState(false);

  const { demandas, relatorios } = useStore();

  // Pendencias
  const cancelamentosSolicitados = demandas.filter(d => d.status === 'cancelamento_solicitado');
  const documentosPendentes = relatorios.filter(r => r.status === 'pendente');

  const notificationsCount = cancelamentosSolicitados.length + documentosPendentes.length;

  const navItems = [
    { to: '/coordenadora', icon: LayoutDashboard, label: 'Dashboard', end: true },
    { to: '/coordenadora/disponibilidade', icon: Search, label: 'Disponibilidade' },
    { to: '/coordenadora/mapa', icon: Map, label: 'Mapa Cirúrgico' },
    { to: '/coordenadora/acionamentos', icon: Bell, label: 'Acionamentos' },
    { to: '/coordenadora/confirmados', icon: CheckCircle, label: 'Confirmados' },
    { to: '/coordenadora/profissionais', icon: Users, label: 'Profissionais' },
    { to: '/coordenadora/documentos', icon: FileText, label: 'Documentos' },
    { to: '/coordenadora/configuracoes', icon: Settings, label: 'Configurações' },
  ];

  const toggleMenu = () => setIsMobileMenuOpen(!isMobileMenuOpen);
  const closeMenu = () => setIsMobileMenuOpen(false);

  return (
    <div className="flex h-screen bg-slate-50 overflow-hidden font-sans">
      
      {/* Mobile Menu Overlay */}
      {isMobileMenuOpen && (
        <div className="fixed inset-0 bg-slate-900/50 z-40 lg:hidden" onClick={closeMenu}></div>
      )}

      {/* Sidebar */}
      <aside className={clsx(
        "fixed lg:static inset-y-0 left-0 w-64 bg-slate-900 flex flex-col transition-transform duration-300 ease-in-out z-50",
        isMobileMenuOpen ? "translate-x-0" : "-translate-x-full lg:translate-x-0"
      )}>
        <div className="h-16 flex items-center justify-between px-6 border-b border-slate-800 shrink-0">
          <h1 className="text-white font-bold text-lg">Conecta Cirúrgica</h1>
          <button onClick={closeMenu} className="lg:hidden text-slate-400 hover:text-white">
            <X className="w-6 h-6" />
          </button>
        </div>
        
        <div className="flex-1 py-6 flex flex-col gap-1 px-3 overflow-y-auto">
          {navItems.map((item) => (
            <NavLink
              key={item.to}
              to={item.to}
              end={item.end}
              onClick={closeMenu}
              className={({ isActive }) => clsx(
                "flex items-center gap-3 px-3 py-2.5 rounded-lg text-sm font-medium transition-colors",
                isActive 
                  ? "bg-primary-600 text-white shadow-md shadow-primary-900/20" 
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
              C
            </div>
            <div>
              <p className="text-sm font-medium text-white">Coordenadora</p>
              <p className="text-xs text-slate-400">Admin</p>
            </div>
          </div>
          <div className="space-y-1">
            <button className="w-full flex items-center gap-3 px-3 py-2 text-sm font-medium text-slate-400 hover:text-white hover:bg-slate-800 rounded-lg transition-colors">
              <Settings className="w-5 h-5 text-slate-500" /> Configurações
            </button>
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
        <header className="h-16 bg-white border-b border-slate-200 flex items-center justify-between px-4 lg:px-8 shrink-0 z-10 relative">
          <div className="flex items-center gap-4">
            <button onClick={toggleMenu} className="lg:hidden p-2 -ml-2 text-slate-500 hover:bg-slate-100 rounded-md">
              <Menu className="w-6 h-6" />
            </button>
            <h2 className="text-lg font-semibold text-slate-800 hidden sm:block">Painel de Gestão</h2>
          </div>
          
          <div className="flex items-center gap-4">
            <div className="relative">
              <button 
                onClick={() => setShowNotifications(!showNotifications)}
                className="p-2 text-slate-400 hover:text-slate-600 hover:bg-slate-100 rounded-full transition-colors relative"
              >
                <BellRing className="w-5 h-5" />
                {notificationsCount > 0 && (
                  <span className="absolute top-1.5 right-1.5 w-2 h-2 bg-red-500 rounded-full ring-2 ring-white"></span>
                )}
              </button>

              {showNotifications && (
                <div className="absolute right-0 mt-2 w-80 bg-white rounded-xl shadow-xl border border-slate-100 z-50 overflow-hidden">
                  <div className="p-3 border-b border-slate-100 flex justify-between items-center bg-slate-50">
                    <h3 className="font-bold text-sm text-slate-800">Notificações</h3>
                    <span className="text-xs bg-slate-200 text-slate-600 px-2 py-0.5 rounded-full">{notificationsCount}</span>
                  </div>
                  <div className="max-h-80 overflow-y-auto">
                    {notificationsCount === 0 ? (
                      <div className="p-4 text-center text-sm text-slate-500">Nenhuma notificação nova.</div>
                    ) : (
                      <div className="divide-y divide-slate-100">
                        {cancelamentosSolicitados.map(d => (
                          <div 
                            key={`nc_${d.id}`} 
                            onClick={() => { setShowNotifications(false); navigate('/coordenadora/acionamentos'); }}
                            className="p-3 hover:bg-red-50 cursor-pointer flex gap-3 transition-colors"
                          >
                            <AlertTriangle className="w-5 h-5 text-red-500 shrink-0 mt-0.5" />
                            <div>
                              <p className="text-sm font-bold text-slate-800 leading-tight">Cancelamento Solicitado</p>
                              <p className="text-xs text-slate-500 mt-1">{d.procedimento} - {d.data}</p>
                            </div>
                          </div>
                        ))}
                        {documentosPendentes.map(r => (
                          <div 
                            key={`nr_${r.id}`} 
                            onClick={() => { setShowNotifications(false); navigate('/coordenadora/documentos'); }}
                            className="p-3 hover:bg-blue-50 cursor-pointer flex gap-3 transition-colors"
                          >
                            <FileText className="w-5 h-5 text-blue-500 shrink-0 mt-0.5" />
                            <div>
                              <p className="text-sm font-bold text-slate-800 leading-tight">Documento Pendente</p>
                              <p className="text-xs text-slate-500 mt-1">O instrumentador ainda não enviou {r.tipo}</p>
                            </div>
                          </div>
                        ))}
                      </div>
                    )}
                  </div>
                </div>
              )}
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
