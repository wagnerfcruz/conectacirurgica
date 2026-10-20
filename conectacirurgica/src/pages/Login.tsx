import { useNavigate } from 'react-router-dom';
import { Stethoscope, Building2 } from 'lucide-react';
import { useStore } from '../store/useStore';

export default function Login() {
  const navigate = useNavigate();
  const { empresaConfig } = useStore();

  return (
    <div className="min-h-screen bg-slate-50 flex flex-col justify-center py-12 sm:px-6 lg:px-8">
      <div className="sm:mx-auto sm:w-full sm:max-w-md text-center">
        <div className="flex justify-center mb-6">
          {empresaConfig.logoUrl ? (
            <img src={empresaConfig.logoUrl} alt="Logo da Empresa" className="h-16 object-contain" />
          ) : (
            <div className="w-16 h-16 bg-primary-900 rounded-xl flex items-center justify-center shadow-lg">
              <Stethoscope className="w-8 h-8 text-white" />
            </div>
          )}
        </div>
        <h2 className="text-3xl font-extrabold text-slate-900">{empresaConfig.nome || 'Conecta Cirúrgica'}</h2>
        <p className="mt-2 text-sm text-slate-600">
          Acesse a plataforma
        </p>
      </div>

      <div className="mt-8 sm:mx-auto sm:w-full sm:max-w-md">
        <div className="bg-white py-8 px-4 shadow-sm sm:rounded-xl sm:px-10 border border-slate-100">
          <div className="space-y-6">
            <div>
              <label className="block text-sm font-medium text-slate-700 mb-2">Empresa Contratante (Freelancer)</label>
              <select className="w-full border-slate-300 rounded-md shadow-sm focus:border-primary-500 focus:ring-primary-500 text-sm p-3 border bg-white mb-4">
                <option value="meditec">Meditec</option>
                <option value="outra">Outra Empresa</option>
              </select>

              <button
                onClick={() => navigate('/instrumentador')}
                className="w-full flex items-center justify-center gap-3 px-4 py-4 border border-transparent rounded-lg shadow-sm text-base font-medium text-white bg-primary-600 hover:bg-primary-700 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-primary-500 transition-colors"
              >
                <Stethoscope className="w-5 h-5" />
                Sou Instrumentador
              </button>
              <p className="mt-2 text-xs text-center text-slate-500">
                Acessar visão mobile-first de agendamento
              </p>
            </div>

            <div className="relative">
              <div className="absolute inset-0 flex items-center">
                <div className="w-full border-t border-slate-200" />
              </div>
              <div className="relative flex justify-center text-sm">
                <span className="px-2 bg-white text-slate-500">ou</span>
              </div>
            </div>

            <div>
              <button
                onClick={() => navigate('/coordenadora')}
                className="w-full flex items-center justify-center gap-3 px-4 py-4 border border-slate-300 rounded-lg shadow-sm text-base font-medium text-slate-700 bg-white hover:bg-slate-50 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-primary-500 transition-colors"
              >
                <Building2 className="w-5 h-5 text-slate-500" />
                Painel de Gestão
              </button>
              <p className="mt-2 text-xs text-center text-slate-500">
                Acessar visão desktop de gestão
              </p>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}
