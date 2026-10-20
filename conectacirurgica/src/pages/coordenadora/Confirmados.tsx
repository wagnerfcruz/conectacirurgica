import { Calendar, MapPin, User, Clock, CheckCircle } from 'lucide-react';
import { useState } from 'react';

export default function Confirmados() {
  const [selectedCirurgia, setSelectedCirurgia] = useState<number | null>(null);

  const confirmados = [
    { id: 1, data: '22/10/2026', hora: '08:00', hospital: 'Hosp. Santa Catarina', proc: 'Artroplastia Joelho', medico: 'Dr. Roberto Almeida', inst: 'João Silva', status: 'confirmado' },
    { id: 2, data: '22/10/2026', hora: '14:30', hospital: 'Hosp. Sírio-Libanês', proc: 'Hérnia Disco', medico: 'Dra. Fernanda Lima', inst: 'Ana Costa', status: 'em andamento' },
    { id: 3, data: '23/10/2026', hora: '10:00', hospital: 'Hosp. das Clínicas', proc: 'Ligamento Cruzado', medico: 'Dr. Carlos Souza', inst: 'João Silva', status: 'confirmado' },
  ];

  return (
    <div className="space-y-6">
      <div className="flex justify-between items-end">
        <div>
          <h1 className="text-2xl font-bold text-slate-900">Agenda Confirmada</h1>
          <p className="text-slate-500">Acompanhe os acionamentos com aceite confirmado.</p>
        </div>
        <div className="flex gap-2">
          <input type="date" className="border-slate-300 rounded-md shadow-sm text-sm p-2 border" defaultValue="2026-10-22" />
          <button className="bg-white border border-slate-300 hover:bg-slate-50 text-slate-700 px-4 py-2 rounded-md font-medium text-sm transition-colors">
            Filtrar
          </button>
        </div>
      </div>

      <div className="grid grid-cols-1 lg:grid-cols-3 gap-6">
        {/* Lista */}
        <div className="lg:col-span-2 space-y-4">
          {confirmados.map(c => (
            <div 
              key={c.id} 
              className={`bg-white rounded-xl p-5 border cursor-pointer transition-all ${selectedCirurgia === c.id ? 'border-primary-500 shadow-md ring-1 ring-primary-500' : 'border-slate-200 shadow-sm hover:border-primary-300'}`}
              onClick={() => setSelectedCirurgia(c.id)}
            >
              <div className="flex justify-between items-start mb-4">
                <div>
                  <h3 className="text-lg font-bold text-slate-900">{c.proc}</h3>
                  <p className="text-sm text-slate-500">Cirurgião: {c.medico}</p>
                </div>
                <span className={`px-2.5 py-1 text-xs font-bold uppercase rounded-full ${
                  c.status === 'em andamento' ? 'bg-blue-100 text-blue-700' : 'bg-emerald-100 text-emerald-700'
                }`}>
                  {c.status}
                </span>
              </div>
              
              <div className="grid grid-cols-2 md:grid-cols-4 gap-4 bg-slate-50 p-3 rounded-lg">
                <div>
                  <p className="text-xs text-slate-500 flex items-center gap-1 mb-1"><Calendar className="w-3 h-3"/> Data</p>
                  <p className="font-semibold text-sm text-slate-800">{c.data}</p>
                </div>
                <div>
                  <p className="text-xs text-slate-500 flex items-center gap-1 mb-1"><Clock className="w-3 h-3"/> Horário</p>
                  <p className="font-semibold text-sm text-slate-800">{c.hora}</p>
                </div>
                <div className="md:col-span-2">
                  <p className="text-xs text-slate-500 flex items-center gap-1 mb-1"><MapPin className="w-3 h-3"/> Local</p>
                  <p className="font-semibold text-sm text-slate-800 truncate">{c.hospital}</p>
                </div>
              </div>
              
              <div className="mt-4 flex items-center justify-between border-t border-slate-100 pt-4">
                <div className="flex items-center gap-2">
                  <div className="w-8 h-8 bg-primary-100 rounded-full flex items-center justify-center text-primary-700 font-bold text-xs">
                    {c.inst.substring(0,2).toUpperCase()}
                  </div>
                  <div>
                    <p className="text-xs text-slate-500">Instrumentador</p>
                    <p className="text-sm font-bold text-slate-800">{c.inst}</p>
                  </div>
                </div>
                <button className="text-primary-600 text-sm font-medium hover:text-primary-800">Ver Cartão</button>
              </div>
            </div>
          ))}
        </div>

        {/* Cartão Lateral (Demonstrativo) */}
        {selectedCirurgia && (
          <div className="bg-slate-800 rounded-2xl p-6 text-white shadow-xl relative overflow-hidden h-fit sticky top-6">
            <div className="absolute top-0 right-0 w-32 h-32 bg-primary-500/20 rounded-bl-full -mr-8 -mt-8"></div>
            
            <div className="flex justify-between items-start relative z-10 mb-6">
              <h2 className="text-lg font-bold text-slate-100">Cartão de Acionamento</h2>
              <CheckCircle className="w-6 h-6 text-emerald-400" />
            </div>

            <div className="space-y-6 relative z-10">
              <div>
                <p className="text-slate-400 text-xs uppercase font-bold tracking-wider mb-1">Procedimento</p>
                <p className="text-xl font-bold">{confirmados.find(c => c.id === selectedCirurgia)?.proc}</p>
              </div>
              
              <div className="grid grid-cols-2 gap-4 border-y border-slate-700 py-4">
                <div>
                  <p className="text-slate-400 text-xs uppercase font-bold tracking-wider mb-1">Data</p>
                  <p className="font-medium">{confirmados.find(c => c.id === selectedCirurgia)?.data}</p>
                </div>
                <div>
                  <p className="text-slate-400 text-xs uppercase font-bold tracking-wider mb-1">Chegada</p>
                  <p className="font-medium">{confirmados.find(c => c.id === selectedCirurgia)?.hora}</p>
                </div>
              </div>

              <div>
                <p className="text-slate-400 text-xs uppercase font-bold tracking-wider mb-1">Local</p>
                <p className="font-medium mb-1">{confirmados.find(c => c.id === selectedCirurgia)?.hospital}</p>
                <p className="text-sm text-slate-300">Rua Exemplo, 123 - Centro</p>
              </div>

              <div>
                <p className="text-slate-400 text-xs uppercase font-bold tracking-wider mb-1">Equipe Médica</p>
                <p className="font-medium">{confirmados.find(c => c.id === selectedCirurgia)?.medico}</p>
              </div>

              <div className="bg-slate-700/50 p-4 rounded-xl">
                <p className="text-slate-400 text-xs uppercase font-bold tracking-wider mb-2 flex items-center gap-2"><User className="w-4 h-4"/> Instrumentador Alocado</p>
                <p className="font-bold text-lg text-emerald-400">{confirmados.find(c => c.id === selectedCirurgia)?.inst}</p>
              </div>
            </div>
            
            <div className="mt-8 pt-4 border-t border-slate-700 relative z-10 text-center">
              <p className="text-[10px] text-slate-500 uppercase tracking-widest">Documento Fictício para Demonstração</p>
            </div>
          </div>
        )}
      </div>
    </div>
  );
}
