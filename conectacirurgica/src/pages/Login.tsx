import { useNavigate } from 'react-router-dom';
import { Stethoscope, Building2, Lock, Mail, ArrowRight } from 'lucide-react';
import { useState } from 'react';

export default function Login() {
  const navigate = useNavigate();

  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');

  const handleLogin = (e: React.FormEvent) => {
    e.preventDefault();
    // Demonstração: qualquer login entra. Roteia para gestor se email tiver 'gestor', senão freelancer.
    if (email.toLowerCase().includes('gestor')) {
      navigate('/coordenadora');
    } else {
      navigate('/instrumentador');
    }
  };

  return (
    <div className="min-h-screen bg-slate-50 flex flex-col justify-center py-12 sm:px-6 lg:px-8 font-sans">
      <div className="sm:mx-auto sm:w-full sm:max-w-md text-center">
        <div className="flex justify-center mb-6">
          <div className="w-16 h-16 bg-slate-900 rounded-2xl flex items-center justify-center shadow-lg">
            <Stethoscope className="w-8 h-8 text-cyan-400" />
          </div>
        </div>
        <h2 className="text-3xl font-black text-slate-900 tracking-tight">Conecta Cirúrgica</h2>
        <p className="mt-2 text-sm text-slate-500 font-medium">
          Acesso ao portal
        </p>
      </div>

      <div className="mt-8 sm:mx-auto sm:w-full sm:max-w-md">
        <div className="bg-white py-8 px-4 shadow-sm sm:rounded-2xl sm:px-10 border border-slate-100">
          <form onSubmit={handleLogin} className="space-y-5">
            <div>
              <label className="block text-sm font-bold text-slate-700 mb-1">E-mail</label>
              <div className="relative">
                <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
                  <Mail className="h-5 w-5 text-slate-400" />
                </div>
                <input 
                  type="email" 
                  value={email}
                  onChange={(e) => setEmail(e.target.value)}
                  placeholder="seu@email.com"
                  className="w-full pl-10 border-slate-300 rounded-xl shadow-sm focus:border-cyan-500 focus:ring-cyan-500 text-sm p-3 border bg-slate-50 transition-colors"
                />
              </div>
            </div>

            <div>
              <label className="block text-sm font-bold text-slate-700 mb-1">Senha</label>
              <div className="relative">
                <div className="absolute inset-y-0 left-0 pl-3 flex items-center pointer-events-none">
                  <Lock className="h-5 w-5 text-slate-400" />
                </div>
                <input 
                  type="password" 
                  value={password}
                  onChange={(e) => setPassword(e.target.value)}
                  placeholder="••••••••"
                  className="w-full pl-10 border-slate-300 rounded-xl shadow-sm focus:border-cyan-500 focus:ring-cyan-500 text-sm p-3 border bg-slate-50 transition-colors"
                />
              </div>
            </div>

            <button
              type="submit"
              className="w-full flex items-center justify-center gap-2 px-4 py-3.5 border border-transparent rounded-xl shadow-md text-base font-bold text-white bg-slate-900 hover:bg-slate-800 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-slate-900 transition-colors"
            >
              Acessar
              <ArrowRight className="w-5 h-5" />
            </button>
          </form>

          <div className="mt-8 relative">
            <div className="absolute inset-0 flex items-center">
              <div className="w-full border-t border-slate-200" />
            </div>
            <div className="relative flex justify-center text-sm">
              <span className="px-3 bg-white text-slate-400 font-medium tracking-wide text-xs uppercase">Ambiente de Demonstração</span>
            </div>
          </div>

          <div className="mt-6 grid grid-cols-2 gap-3">
            <button
              onClick={() => navigate('/instrumentador')}
              className="w-full flex flex-col items-center justify-center gap-2 p-3 border-2 border-slate-100 rounded-xl hover:border-cyan-500 hover:bg-cyan-50 transition-all text-slate-600 hover:text-cyan-700"
            >
              <Stethoscope className="w-6 h-6" />
              <span className="text-xs font-bold text-center leading-tight">Simular Freelancer</span>
            </button>

            <button
              onClick={() => navigate('/coordenadora')}
              className="w-full flex flex-col items-center justify-center gap-2 p-3 border-2 border-slate-100 rounded-xl hover:border-indigo-500 hover:bg-indigo-50 transition-all text-slate-600 hover:text-indigo-700"
            >
              <Building2 className="w-6 h-6" />
              <span className="text-xs font-bold text-center leading-tight">Simular Gestão</span>
            </button>
          </div>
        </div>
      </div>
    </div>
  );
}
