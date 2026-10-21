import { useState } from 'react';
import { useStore } from '../../store/useStore';
import { Save } from 'lucide-react';

export default function Configuracoes() {
  const { empresaConfig, updateEmpresaConfig } = useStore();
  const [formData, setFormData] = useState({
    nome: empresaConfig.nome || '',
    tagline: empresaConfig.tagline || '',
    headerTitleLine1: empresaConfig.headerTitleLine1 || '',
    headerTitleLine2: empresaConfig.headerTitleLine2 || '',
    logoUrl: empresaConfig.logoUrl || '/meditec_logo.png'
  });
  const [saved, setSaved] = useState(false);

  const handleSave = () => {
    updateEmpresaConfig(formData);
    setSaved(true);
    setTimeout(() => setSaved(false), 3000);
  };

  return (
    <div className="p-6 max-w-2xl">
      <div className="mb-6">
        <h1 className="text-2xl font-bold text-slate-900">Configurações da Empresa</h1>
        <p className="text-slate-500">Ajuste os dados que aparecem no Cartão de Acionamento.</p>
      </div>

      <div className="bg-white rounded-xl shadow-sm border border-slate-200 p-6 space-y-6">
        
        <div className="space-y-4">
          <div>
            <label className="block text-sm font-medium text-slate-700 mb-1">Logo URL (ou caminho local)</label>
            <div className="flex gap-3">
              <input
                type="text"
                value={formData.logoUrl}
                onChange={e => setFormData({ ...formData, logoUrl: e.target.value })}
                className="flex-1 rounded-lg border-slate-300 shadow-sm focus:border-primary-500 focus:ring-primary-500"
                placeholder="Ex: /meditec_logo.png ou https://..."
              />
            </div>
            <p className="text-xs text-slate-500 mt-1">
              O arquivo `meditec_logo.png` já está disponível na pasta public. Se quiser usar outra imagem, adicione a URL aqui.
            </p>
          </div>

          <div className="grid grid-cols-2 gap-4">
            <div>
              <label className="block text-sm font-medium text-slate-700 mb-1">Nome da Empresa</label>
              <input
                type="text"
                value={formData.nome}
                onChange={e => setFormData({ ...formData, nome: e.target.value })}
                className="w-full rounded-lg border-slate-300 shadow-sm focus:border-primary-500 focus:ring-primary-500"
              />
            </div>
            <div>
              <label className="block text-sm font-medium text-slate-700 mb-1">Tagline</label>
              <input
                type="text"
                value={formData.tagline}
                onChange={e => setFormData({ ...formData, tagline: e.target.value })}
                className="w-full rounded-lg border-slate-300 shadow-sm focus:border-primary-500 focus:ring-primary-500"
              />
            </div>
          </div>

          <div className="grid grid-cols-2 gap-4">
            <div>
              <label className="block text-sm font-medium text-slate-700 mb-1">Título Linha 1</label>
              <input
                type="text"
                value={formData.headerTitleLine1}
                onChange={e => setFormData({ ...formData, headerTitleLine1: e.target.value })}
                className="w-full rounded-lg border-slate-300 shadow-sm focus:border-primary-500 focus:ring-primary-500"
              />
            </div>
            <div>
              <label className="block text-sm font-medium text-slate-700 mb-1">Título Linha 2</label>
              <input
                type="text"
                value={formData.headerTitleLine2}
                onChange={e => setFormData({ ...formData, headerTitleLine2: e.target.value })}
                className="w-full rounded-lg border-slate-300 shadow-sm focus:border-primary-500 focus:ring-primary-500"
              />
            </div>
          </div>
        </div>

        <div className="pt-4 border-t border-slate-100 flex items-center justify-between">
          <p className="text-sm text-green-600 font-medium">{saved ? 'Configurações salvas!' : ''}</p>
          <button
            onClick={handleSave}
            className="flex items-center gap-2 px-4 py-2 bg-primary-600 text-white rounded-lg hover:bg-primary-700 font-medium"
          >
            <Save className="w-4 h-4" />
            Salvar Alterações
          </button>
        </div>

      </div>
    </div>
  );
}
