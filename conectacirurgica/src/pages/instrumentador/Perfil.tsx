import { useState } from 'react';
import { useStore } from '../../store/useStore';
import { User, ShieldCheck, AlertCircle, Phone, MapPin } from 'lucide-react';

export default function Perfil() {
  const currentUserId = 1; 
  const { instrumentadores, updatePerfil } = useStore();
  const currentUser = instrumentadores.find(i => i.id === currentUserId);

  const [isEditing, setIsEditing] = useState(false);
  const [formData, setFormData] = useState({
    nome: currentUser?.nome || '',
    celular: currentUser?.celular || '',
    regiao: currentUser?.regiao || '',
    transporte: currentUser?.transporte || 'nao_informado',
    cpf: currentUser?.cpf || '',
  });

  const [message, setMessage] = useState('');

  const handleSave = () => {
    updatePerfil(currentUserId, formData);
    setIsEditing(false);
    setMessage('Perfil atualizado com sucesso!');
    setTimeout(() => setMessage(''), 3000);
  };

  if (!currentUser) return null;

  return (
    <div className="p-4 space-y-6 max-w-lg mx-auto pb-24">
      <div className="text-center py-4">
        <div className="w-20 h-20 bg-primary-100 rounded-full flex items-center justify-center mx-auto mb-3 shadow-inner">
          <User className="w-10 h-10 text-primary-600" />
        </div>
        <h1 className="text-2xl font-bold text-slate-900">{currentUser.nome}</h1>
        <p className="text-sm text-slate-500">{currentUser.especialidades.join(', ')}</p>
        <div className="mt-2 flex justify-center">
          {currentUser.validado ? (
            <span className="inline-flex items-center gap-1 px-3 py-1 rounded-full text-xs font-bold bg-emerald-100 text-emerald-800">
              <ShieldCheck className="w-4 h-4" /> Documentação Validada
            </span>
          ) : (
            <span className="inline-flex items-center gap-1 px-3 py-1 rounded-full text-xs font-bold bg-amber-100 text-amber-800">
              <AlertCircle className="w-4 h-4" /> Pendente de Validação
            </span>
          )}
        </div>
      </div>

      {message && (
        <div className="bg-emerald-50 text-emerald-700 p-3 rounded-xl text-sm font-bold text-center border border-emerald-200">
          {message}
        </div>
      )}

      <div className="bg-white rounded-2xl p-5 shadow-sm border border-slate-100">
        <div className="flex justify-between items-center mb-4 border-b border-slate-100 pb-2">
          <h2 className="font-bold text-slate-800">Dados Pessoais</h2>
          {!isEditing && (
            <button onClick={() => setIsEditing(true)} className="text-primary-600 text-sm font-bold hover:underline">
              Editar
            </button>
          )}
        </div>

        {isEditing ? (
          <div className="space-y-4">
            <div>
              <label className="block text-xs font-medium text-slate-500 mb-1">Nome Completo</label>
              <input 
                type="text" 
                value={formData.nome}
                onChange={e => setFormData({...formData, nome: e.target.value})}
                className="w-full border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 focus:border-primary-500 border"
              />
            </div>
            <div>
              <label className="block text-xs font-medium text-slate-500 mb-1">Celular</label>
              <input 
                type="tel" 
                value={formData.celular}
                onChange={e => setFormData({...formData, celular: e.target.value})}
                className="w-full border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 focus:border-primary-500 border"
              />
            </div>
            <div>
              <label className="block text-xs font-medium text-slate-500 mb-1">CPF (Opcional - Visualização Privada)</label>
              <input 
                type="text" 
                value={formData.cpf}
                onChange={e => setFormData({...formData, cpf: e.target.value})}
                className="w-full border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 focus:border-primary-500 border"
              />
            </div>
            <div>
              <label className="block text-xs font-medium text-slate-500 mb-1">Região Principal</label>
              <input 
                type="text" 
                value={formData.regiao}
                onChange={e => setFormData({...formData, regiao: e.target.value})}
                className="w-full border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 focus:border-primary-500 border"
              />
            </div>
            <div>
              <label className="block text-xs font-medium text-slate-500 mb-1">Meio de Transporte</label>
              <select 
                value={formData.transporte}
                onChange={e => setFormData({...formData, transporte: e.target.value})}
                className="w-full border-slate-300 rounded-md p-2 text-sm focus:ring-primary-500 focus:border-primary-500 border bg-white"
              >
                <option value="nao_informado">Não informado</option>
                <option value="carro">Carro Próprio</option>
                <option value="moto">Moto</option>
                <option value="outro">Outro (Público/App)</option>
              </select>
            </div>

            <div className="flex gap-3 pt-2">
              <button 
                onClick={() => setIsEditing(false)}
                className="flex-1 px-4 py-2 border border-slate-300 rounded-xl text-sm font-bold text-slate-600 hover:bg-slate-50"
              >
                Cancelar
              </button>
              <button 
                onClick={handleSave}
                className="flex-1 px-4 py-2 bg-primary-600 rounded-xl text-sm font-bold text-white hover:bg-primary-700"
              >
                Salvar
              </button>
            </div>
          </div>
        ) : (
          <div className="space-y-4">
            <div className="flex items-center gap-3">
              <Phone className="w-5 h-5 text-slate-400" />
              <div>
                <p className="text-xs text-slate-500">Celular</p>
                <p className="text-sm font-medium text-slate-800">{currentUser.celular || 'Não informado'}</p>
              </div>
            </div>
            <div className="flex items-center gap-3">
              <MapPin className="w-5 h-5 text-slate-400" />
              <div>
                <p className="text-xs text-slate-500">Região de Atuação</p>
                <p className="text-sm font-medium text-slate-800">{currentUser.regiao || 'Não informado'}</p>
              </div>
            </div>
          </div>
        )}
      </div>

      <div className="bg-white rounded-2xl p-5 shadow-sm border border-slate-100">
        <h2 className="font-bold text-slate-800 mb-4 border-b border-slate-100 pb-2">Competências</h2>
        <div className="space-y-3">
          <div>
            <p className="text-xs font-bold text-slate-500 uppercase tracking-wider mb-2">Especialidades</p>
            <div className="flex flex-wrap gap-2">
              {currentUser.especialidades.map(esp => (
                <span key={esp} className="bg-slate-100 text-slate-700 px-3 py-1 rounded-full text-xs font-medium">
                  {esp}
                </span>
              ))}
            </div>
          </div>
          <div className="pt-2">
            <p className="text-xs font-bold text-slate-500 uppercase tracking-wider mb-2">Validadas pela Gestão</p>
            <div className="flex flex-wrap gap-2">
              {currentUser.competenciasValidadas && currentUser.competenciasValidadas.length > 0 ? (
                currentUser.competenciasValidadas.map(comp => (
                  <span key={comp} className="bg-emerald-50 text-emerald-700 border border-emerald-200 px-3 py-1 rounded-full text-xs font-bold flex items-center gap-1">
                    <ShieldCheck className="w-3 h-3" /> {comp}
                  </span>
                ))
              ) : (
                <span className="text-sm text-slate-500 italic">Nenhuma competência validada ainda.</span>
              )}
            </div>
          </div>
        </div>
      </div>

    </div>
  );
}
