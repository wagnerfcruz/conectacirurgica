import { Search, Filter, ShieldCheck, ShieldAlert, X, Plus } from 'lucide-react';
import { useStore } from '../../store/useStore';
import type { Instrumentador } from '../../store/useStore';
import { useState } from 'react';

export default function Profissionais() {
  const { instrumentadores, updatePerfil, addInstrumentador } = useStore();
  const [editingProf, setEditingProf] = useState<Instrumentador | null | 'new'>(null);
  const [formData, setFormData] = useState<Partial<Instrumentador>>({});

  const [searchTerm, setSearchTerm] = useState('');

  const handleEditClick = (prof: Instrumentador) => {
    setEditingProf(prof);
    setFormData(prof);
  };

  const handleNewClick = () => {
    setEditingProf('new');
    setFormData({ especialidades: [], regiao: '', validado: false });
  };

  const handleSave = () => {
    if (editingProf === 'new') {
      addInstrumentador({
        nome: formData.nome || 'Novo Profissional',
        especialidades: formData.especialidades || [],
        regiao: formData.regiao || '',
        validado: formData.validado || false,
        celular: formData.celular,
        cpf: formData.cpf,
        transporte: formData.transporte,
        competenciasValidadas: formData.competenciasValidadas || []
      });
    } else if (editingProf) {
      updatePerfil(editingProf.id, formData);
    }
    setEditingProf(null);
  };

  const filtered = instrumentadores.filter(prof => {
    const term = searchTerm.toLowerCase();
    return (
      prof.nome.toLowerCase().includes(term) ||
      prof.cpf?.toLowerCase().includes(term) ||
      prof.especialidades.some(e => e.toLowerCase().includes(term))
    );
  });

  return (
    <div className="space-y-6">
      <div className="flex justify-between items-end flex-wrap gap-4">
        <div>
          <h1 className="text-2xl font-bold text-slate-900">Carteira de Profissionais</h1>
          <p className="text-slate-500">Gerencie instrumentadores e valide suas competências.</p>
        </div>
        <button onClick={handleNewClick} className="bg-primary-600 hover:bg-primary-700 text-white px-4 py-2 rounded-md font-medium text-sm transition-colors flex items-center gap-2">
          <Plus className="w-4 h-4" /> Cadastrar Profissional
        </button>
      </div>

      <div className="bg-white rounded-xl p-4 shadow-sm border border-slate-100 flex flex-wrap md:flex-nowrap gap-4">
        <div className="flex-1 w-full relative">
          <Search className="w-5 h-5 absolute left-3 top-2.5 text-slate-400" />
          <input 
            type="text" 
            placeholder="Buscar por nome, especialidade ou CPF..." 
            value={searchTerm}
            onChange={e => setSearchTerm(e.target.value)}
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
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Nome / Contato</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Especialidades</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Região / Transporte</th>
              <th scope="col" className="px-6 py-3 text-left text-xs font-medium text-slate-500 uppercase tracking-wider">Status Validação</th>
              <th scope="col" className="relative px-6 py-3"><span className="sr-only">Ações</span></th>
            </tr>
          </thead>
          <tbody className="bg-white divide-y divide-slate-200">
            {filtered.map((prof) => (
              <tr key={prof.id} className="hover:bg-slate-50 transition-colors">
                <td className="px-6 py-4 whitespace-nowrap">
                  <div className="flex items-center">
                    <div className="flex-shrink-0 h-10 w-10 bg-slate-200 rounded-full flex items-center justify-center text-slate-600 font-bold">
                      {prof.nome.substring(0,2).toUpperCase()}
                    </div>
                    <div className="ml-4">
                      <div className="text-sm font-bold text-slate-900">{prof.nome}</div>
                      <div className="text-xs text-slate-500">{prof.celular || 'Sem celular'}</div>
                    </div>
                  </div>
                </td>
                <td className="px-6 py-4">
                  <div className="text-sm text-slate-900">{prof.especialidades.join(', ')}</div>
                  {prof.competenciasValidadas && prof.competenciasValidadas.length > 0 && (
                    <div className="text-xs text-primary-600 font-medium mt-1">
                      {prof.competenciasValidadas.length} comp. validada(s)
                    </div>
                  )}
                </td>
                <td className="px-6 py-4 whitespace-nowrap">
                  <div className="text-sm text-slate-900">{prof.regiao}</div>
                  <div className="text-xs text-slate-500 capitalize">{prof.transporte?.replace('_', ' ') || 'Não informado'}</div>
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
                <td className="px-6 py-4 whitespace-nowrap text-right text-sm font-medium">
                  <button onClick={() => handleEditClick(prof)} className="text-primary-600 hover:text-primary-900 font-semibold border border-primary-200 px-3 py-1 rounded hover:bg-primary-50">Editar / Ver Perfil</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>

      {editingProf && (
        <div className="fixed inset-0 z-50 flex items-center justify-center p-4 bg-slate-900/50 backdrop-blur-sm overflow-y-auto pt-10">
          <div className="bg-white rounded-xl shadow-xl w-full max-w-2xl overflow-hidden flex flex-col my-auto">
            <div className="flex justify-between items-center p-6 border-b border-slate-100 shrink-0">
              <h2 className="text-xl font-bold text-slate-900">{editingProf === 'new' ? 'Cadastrar Profissional' : 'Editar Perfil'}</h2>
              <button onClick={() => setEditingProf(null)} className="text-slate-400 hover:text-slate-600">
                <X className="w-6 h-6" />
              </button>
            </div>
            
            <div className="p-6 overflow-y-auto flex-1 space-y-6 max-h-[70vh]">
              
              <div className="grid grid-cols-1 md:grid-cols-2 gap-4">
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
                  <label className="block text-sm font-medium text-slate-700 mb-1">CPF (Opcional - Requer sigilo)</label>
                  <input 
                    type="text" 
                    placeholder="000.000.000-00"
                    value={formData.cpf || ''} 
                    onChange={e => setFormData({...formData, cpf: e.target.value})}
                    className="w-full border border-slate-300 rounded-md p-2 text-sm focus:border-primary-500 focus:ring-1 focus:ring-primary-500"
                  />
                </div>
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Celular</label>
                  <input 
                    type="text" 
                    value={formData.celular || ''} 
                    onChange={e => setFormData({...formData, celular: e.target.value})}
                    className="w-full border border-slate-300 rounded-md p-2 text-sm focus:border-primary-500 focus:ring-1 focus:ring-primary-500"
                  />
                </div>
                <div>
                  <label className="block text-sm font-medium text-slate-700 mb-1">Região/Cidade de Atuação</label>
                  <input 
                    type="text" 
                    value={formData.regiao || ''} 
                    onChange={e => setFormData({...formData, regiao: e.target.value})}
                    className="w-full border border-slate-300 rounded-md p-2 text-sm focus:border-primary-500 focus:ring-1 focus:ring-primary-500"
                  />
                </div>
              </div>

              <div>
                <label className="block text-sm font-medium text-slate-700 mb-1">Especialidades (separadas por vírgula)</label>
                <input 
                  type="text" 
                  value={formData.especialidades?.join(', ') || ''} 
                  onChange={e => setFormData({...formData, especialidades: e.target.value.split(',').map(s => s.trim()).filter(s => s !== '')})}
                  className="w-full border border-slate-300 rounded-md p-2 text-sm focus:border-primary-500 focus:ring-1 focus:ring-primary-500"
                  placeholder="Ortopedia, Coluna, Neuro..."
                />
              </div>

              <div>
                <label className="block text-sm font-medium text-slate-700 mb-1">Competências Validadas (separadas por vírgula)</label>
                <input 
                  type="text" 
                  value={formData.competenciasValidadas?.join(', ') || ''} 
                  onChange={e => setFormData({...formData, competenciasValidadas: e.target.value.split(',').map(s => s.trim()).filter(s => s !== '')})}
                  className="w-full border border-slate-300 rounded-md p-2 text-sm focus:border-primary-500 focus:ring-1 focus:ring-primary-500"
                  placeholder="Ex: Treinamento Sistema X, Certificação Y..."
                />
              </div>

              <div>
                <label className="block text-sm font-medium text-slate-700 mb-1">Transporte</label>
                <select 
                  value={formData.transporte || 'nao_informado'}
                  onChange={e => setFormData({...formData, transporte: e.target.value})}
                  className="w-full border border-slate-300 rounded-md p-2 text-sm focus:border-primary-500 focus:ring-1 focus:ring-primary-500"
                >
                  <option value="nao_informado">Não informado</option>
                  <option value="carro">Carro próprio</option>
                  <option value="moto">Moto</option>
                  <option value="outro">Outro (App, Público)</option>
                </select>
              </div>

              <div className="flex items-center gap-3 pt-2 pb-4">
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

            <div className="p-6 border-t border-slate-100 bg-slate-50 flex justify-end gap-3 shrink-0">
              <button onClick={() => setEditingProf(null)} className="px-4 py-2 border border-slate-300 rounded-md text-sm font-medium text-slate-700 bg-white hover:bg-slate-50 transition-colors">
                Cancelar
              </button>
              <button onClick={handleSave} className="px-4 py-2 rounded-md text-sm font-medium text-white bg-primary-600 hover:bg-primary-700 transition-colors">
                {editingProf === 'new' ? 'Salvar Cadastro' : 'Salvar Alterações'}
              </button>
            </div>
          </div>
        </div>
      )}
    </div>
  );
}
