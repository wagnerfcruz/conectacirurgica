import { Search, Filter, ShieldCheck, ShieldAlert, X } from 'lucide-react';
import { useStore } from '../../store/useStore';
import type { Instrumentador } from '../../store/useStore';
import { useState } from 'react';

export default function Profissionais() {
  const { instrumentadores, updatePerfil } = useStore();
  const [editingProf, setEditingProf] = useState<Instrumentador | null>(null);
  const [formData, setFormData] = useState<Partial<Instrumentador>>({});

  const handleEditClick = (prof: Instrumentador) => {
    setEditingProf(prof);
    setFormData(prof);
  };

  const handleSave = () => {
    if (editingProf) {
      updatePerfil(editingProf.id, formData);
      setEditingProf(null);
    }
  };

  return (
    <div className="space-y-6">
      <div className="flex justify-between items-end flex-wrap gap-4">
        <div>
          <h1 className="text-2xl font-bold text-slate-900">Carteira de Profissionais</h1>
          <p className="text-slate-500">Gerencie instrumentadores e valide suas competências.</p>
        </div>
        <button className="bg-primary-600 hover:bg-primary-700 text-white px-4 py-2 rounded-md font-medium text-sm transition-colors">
          + Convidar Profissional
        </button>
      </div>

      <div className="bg-white rounded-xl p-4 shadow-sm border border-slate-100 flex flex-wrap md:flex-nowrap gap-4">
        <div className="flex-1 w-full relative">
          <Search className="w-5 h-5 absolute left-3 top-2.5 text-slate-400" />
          <input 
            type="text" 
            placeholder="Buscar por nome ou CPF..." 
            className="w-full pl-10 pr-4 py-2 border border-slate-300 rounded-md shadow-sm focus:border-primary-500 focus:ring-primary-500 text-sm"
          />
        </div>
        <button className="w-full md:w-auto bg-white border border-slate-300 hover:bg-slate-50 text-slate-700 px-4 py-2 rounded-md font-medium text-sm flex items-center justify-center gap-2 transition-colors">
          <Filter className="w-4 h-4" /> Filtros Avançados
        </button>
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-100 overflow-x-auto">
        <table className="min-w-full divide-y divide-slate-200">
          <thead className="bg-slate-50">
            <tr>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Nome</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Especialidades</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Região</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Status Validação</th>
              <th scope="col" className="px-6 py-3 text-center text-xs font-medium text-slate-500 uppercase tracking-wider">Atuações</th>
              <th scope="col" className="relative px-6 py-3"><span className="sr-only">Ações</span></th>
            </tr>
          </thead>
          <tbody className="bg-white divide-y divide-slate-200">
            {instrumentadores.map((prof) => (
              <tr key={prof.id} className="hover:bg-slate-50 transition-colors">
                <td className="px-6 py-4 whitespace-nowrap">
                  <div className="flex items-center">
                    <div className="flex-shrink-0 h-10 w-10 bg-slate-200 rounded-full flex items-center justify-center text-slate-600 font-bold">
                      {prof.nome.substring(0,2).toUpperCase()}
                    </div>
                    <div className="ml-4">
                      <div className="text-sm font-bold text-slate-900">{prof.nome}</div>
                      <div className="text-xs text-slate-500">ID: {2000 + prof.id}</div>
                    </div>
                  </div>
                </td>
                <td className="px-6 py-4">
                  <div className="text-sm text-slate-900">{prof.especialidades.join(', ')}</div>
                </td>
                <td className="px-6 py-4 whitespace-nowrap">
                  <span className="text-sm text-slate-500">{prof.regiao}</span>
                </td>
                <td className="px-6 py-4 whitespace-nowrap">
                  {prof.validado ? (
                    <span className="inline-flex items-center gap-1 px-2.5 py-1 rounded-full text-xs font-medium bg-emerald-100 text-emerald-800">
                      <ShieldCheck className="w-3.5 h-3.5" /> Validado
                    </span>
                  ) : (
                    <span className="inline-flex items-center gap-1 px-2.5 py-1 rounded-full text-xs font-medium bg-amber-100 text-amber-800">
                      <ShieldAlert className="w-3.5 h-3.5" /> Em Análise
                    </span>
                  )}
                </td>
                <td className="px-6 py-4 whitespace-nowrap text-center text-sm text-slate-500">
                  {prof.atuacoes}
                </td>
                <td className="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                  <button onClick={() => handleEditClick(prof)} className="text-primary-600 hover:text-primary-900 font-semibold">Editar Perfil</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>

      {editingProf && (
        <div className="fixed inset-0 z-50 flex items-center justify-center p-4 bg-slate-900/50 backdrop-blur-sm">
          <div className="bg-white rounded-xl shadow-xl w-full max-w-lg overflow-hidden flex flex-col max-h-[90vh]">
            <div className="flex justify-between items-center p-6 border-b border-slate-100">
              <h2 className="text-xl font-bold text-slate-900">Editar Perfil</h2>
              <button onClick={() => setEditingProf(null)} className="text-slate-400 hover:text-slate-600">
                <X className="w-6 h-6" />
              </button>
            </div>
            
            <div className="p-6 overflow-y-auto flex-1 space-y-4">
              <div>
                <label className="block text-sm font-medium text-slate-700 mb-1">Nome Completo</label>
                <input 
                  type="text" 
                  value={formData.nome || ''} 
                  onChange={e => setFormData({...formData, nome: e.target.value})}
                  className="w-full border border-slate-300 rounded-md p-2 text-sm focus:border-primary-500 focus:ring-1 focus:ring-primary-500"
                />
              </div>
              
              <div>
                <label className="block text-sm font-medium text-slate-700 mb-1">Região de Atuação</label>
                <input 
                  type="text" 
                  value={formData.regiao || ''} 
                  onChange={e => setFormData({...formData, regiao: e.target.value})}
                  className="w-full border border-slate-300 rounded-md p-2 text-sm focus:border-primary-500 focus:ring-1 focus:ring-primary-500"
                />
              </div>

              <div>
                <label className="block text-sm font-medium text-slate-700 mb-1">Especialidades (separadas por vírgula)</label>
                <input 
                  type="text" 
                  value={formData.especialidades?.join(', ') || ''} 
                  onChange={e => setFormData({...formData, especialidades: e.target.value.split(',').map(s => s.trim()).filter(s => s !== '')})}
                  className="w-full border border-slate-300 rounded-md p-2 text-sm focus:border-primary-500 focus:ring-1 focus:ring-primary-500"
                />
              </div>

              <div className="flex items-center gap-3 pt-2">
                <input 
                  type="checkbox" 
                  id="validado"
                  checked={formData.validado || false}
                  onChange={e => setFormData({...formData, validado: e.target.checked})}
                  className="w-4 h-4 text-primary-600 border-slate-300 rounded focus:ring-primary-500"
                />
                <label htmlFor="validado" className="text-sm font-medium text-slate-700">Profissional Validado (Documentação OK)</label>
              </div>
            </div>

            <div className="p-6 border-t border-slate-100 bg-slate-50 flex justify-end gap-3">
              <button onClick={() => setEditingProf(null)} className="px-4 py-2 border border-slate-300 rounded-md text-sm font-medium text-slate-700 bg-white hover:bg-slate-50 transition-colors">
                Cancelar
              </button>
              <button onClick={handleSave} className="px-4 py-2 rounded-md text-sm font-medium text-white bg-primary-600 hover:bg-primary-700 transition-colors">
                Salvar Alterações
              </button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
}
