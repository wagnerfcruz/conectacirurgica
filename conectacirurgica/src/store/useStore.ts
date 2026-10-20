import { create } from 'zustand';
import { persist } from 'zustand/middleware';

export type StatusDemanda = 'pendente' | 'alocando' | 'convite_enviado' | 'confirmado' | 'realizado' | 'cancelado' | 'documentacao_pendente' | 'cancelamento_solicitado';
export type StatusConvite = 'aguardando' | 'aceito' | 'recusado' | 'expirado' | 'cancelado';

export interface Instrumentador {
  id: number;
  nome: string;
  especialidades: string[];
  regiao: string;
  validado: boolean;
  atuacoes: number;
  nota: string;
  disponibilidade: Record<string, string[]>; // yyyy-MM-dd -> ['manha', 'tarde']
  celular?: string;
  cpf?: string;
  transporte?: string; // 'carro', 'moto', 'outro', 'nao_informado'
  competenciasDeclaradas?: string[];
  competenciasValidadas?: string[];
}

export interface Demanda {
  id: number;
  data: string; // yyyy-MM-dd
  hora: string; // HH:mm
  hospital: string;
  procedimento: string;
  medico: string;
  status: StatusDemanda;
  instrumentadorId?: number | null;
  valorFreelancer?: string;
  motivoCancelamento?: string;
}

export interface Convite {
  id: number;
  demandaId: number;
  instrumentadorId: number;
  status: StatusConvite;
  enviadoEm: string;
}

export interface Relatorio {
  id: number;
  demandaId: number;
  instrumentadorId: number;
  tipo: string;
  status: 'pendente' | 'recebido';
  dataSolicitacao: string;
}

interface AppState {
  instrumentadores: Instrumentador[];
  demandas: Demanda[];
  convites: Convite[];
  relatorios: Relatorio[];
  
  // Actions
  updateDisponibilidade: (id: number, date: string, periodos: string[]) => void;
  updateDisponibilidadeRange: (id: number, dates: string[], periodos: string[]) => void;
  enviarConvite: (demandaId: number, instrumentadorId: number) => void;
  responderConvite: (conviteId: number, resposta: 'aceito' | 'recusado') => void;
  solicitarCancelamento: (demandaId: number, motivo: string) => void;
  updatePerfil: (id: number, data: Partial<Instrumentador>) => void;
  addInstrumentador: (data: Omit<Instrumentador, 'id' | 'atuacoes' | 'nota' | 'disponibilidade'>) => void;
  addDemandas: (novasDemandas: Omit<Demanda, 'id' | 'status'>[]) => void;
  addDemandaManual: (demanda: Omit<Demanda, 'id' | 'status'>) => void;
  updateDemanda: (id: number, data: Partial<Demanda>) => void;
  deleteDemanda: (id: number) => void;
  cobrarDocumento: (instrumentadorId: number, demandaId: number, tipo: string) => void;
  updateRelatorio: (id: number, status: 'recebido') => void;
  resetStore: () => void;
}

const initialInstrumentadores: Instrumentador[] = [
  { id: 1, nome: 'João Silva', especialidades: ['Ortopedia', 'Coluna'], regiao: 'SP - Centro, Sul', validado: true, atuacoes: 45, nota: 'A', disponibilidade: {}, celular: '(11) 99999-9999', transporte: 'carro', competenciasValidadas: ['Instrumentação Cirúrgica Básica'] },
  { id: 2, nome: 'Ana Costa', especialidades: ['Crânio', 'Neurologia'], regiao: 'SP - Todas', validado: true, atuacoes: 128, nota: 'A+', disponibilidade: {}, celular: '(11) 98888-8888', transporte: 'moto' },
  { id: 3, nome: 'Carlos Mendes', especialidades: ['Ortopedia'], regiao: 'SP - Leste', validado: false, atuacoes: 0, nota: '-', disponibilidade: {}, transporte: 'nao_informado' },
  { id: 4, nome: 'Mariana Souza', especialidades: ['Coluna'], regiao: 'SP - Sul', validado: true, atuacoes: 12, nota: 'B', disponibilidade: {}, transporte: 'outro' },
];

const initialDemandas: Demanda[] = [
  { id: 1, data: '2026-10-22', hora: '08:00', hospital: 'Hosp. Santa Catarina', procedimento: 'Artroplastia Total de Joelho', medico: 'Dr. Roberto Almeida', status: 'alocando', valorFreelancer: 'R$ 250,00' },
  { id: 2, data: '2026-10-24', hora: '14:30', hospital: 'Hosp. Sírio-Libanês', procedimento: 'Hérnia de Disco', medico: 'Dra. Fernanda Lima', status: 'pendente', valorFreelancer: 'R$ 300,00' },
  { id: 3, data: '2026-10-18', hora: '10:00', hospital: 'Hosp. das Clínicas', procedimento: 'Ligamento Cruzado', medico: 'Dr. Carlos Souza', status: 'realizado', instrumentadorId: 1, valorFreelancer: 'R$ 200,00' },
];

const initialConvites: Convite[] = [
  { id: 1, demandaId: 1, instrumentadorId: 1, status: 'aguardando', enviadoEm: new Date().toISOString() }
];

const initialRelatorios: Relatorio[] = [
  { id: 1, demandaId: 3, instrumentadorId: 1, tipo: 'Relatório Cirúrgico', status: 'recebido', dataSolicitacao: '2026-10-19' }
];

export const useStore = create<AppState>()(
  persist(
    (set) => ({
      instrumentadores: initialInstrumentadores,
      demandas: initialDemandas,
      convites: initialConvites,
      relatorios: initialRelatorios,

      updateDisponibilidade: (id, date, periodos) => set((state) => ({
        instrumentadores: state.instrumentadores.map(inst => 
          inst.id === id 
            ? { ...inst, disponibilidade: { ...inst.disponibilidade, [date]: periodos } }
            : inst
        )
      })),

      updateDisponibilidadeRange: (id, dates, periodos) => set((state) => {
        const updates: Record<string, string[]> = {};
        dates.forEach(d => { updates[d] = periodos; });
        return {
          instrumentadores: state.instrumentadores.map(inst => 
            inst.id === id 
              ? { ...inst, disponibilidade: { ...inst.disponibilidade, ...updates } }
              : inst
          )
        };
      }),

      enviarConvite: (demandaId, instrumentadorId) => set((state) => {
        const novoConvite: Convite = {
          id: Date.now(),
          demandaId,
          instrumentadorId,
          status: 'aguardando',
          enviadoEm: new Date().toISOString()
        };
        return {
          convites: [...state.convites, novoConvite],
          demandas: state.demandas.map(d => d.id === demandaId ? { ...d, status: 'convite_enviado' } : d)
        };
      }),

      responderConvite: (conviteId, resposta) => set((state) => {
        const convite = state.convites.find(c => c.id === conviteId);
        if (!convite) return state;

        const updatedConvites = state.convites.map(c => c.id === conviteId ? { ...c, status: resposta } : c);
        
        if (resposta === 'aceito') {
          const finalConvites = updatedConvites.map(c => 
            (c.demandaId === convite.demandaId && c.id !== conviteId && c.status === 'aguardando') 
              ? { ...c, status: 'recusado' as StatusConvite } 
              : c
          );
          return {
            convites: finalConvites,
            demandas: state.demandas.map(d => 
              d.id === convite.demandaId 
                ? { ...d, status: 'confirmado', instrumentadorId: convite.instrumentadorId } 
                : d
            )
          };
        } else {
          // Verify if there are other pending invites
          const hasOtherPending = updatedConvites.some(c => c.demandaId === convite.demandaId && c.status === 'aguardando');
          return {
            convites: updatedConvites,
            demandas: state.demandas.map(d => 
              d.id === convite.demandaId 
                ? { ...d, status: hasOtherPending ? 'convite_enviado' : 'alocando' } 
                : d
            )
          };
        }
      }),

      solicitarCancelamento: (demandaId, motivo) => set((state) => ({
        demandas: state.demandas.map(d => 
          d.id === demandaId 
            ? { ...d, status: 'cancelamento_solicitado', motivoCancelamento: motivo } 
            : d
        )
      })),

      updatePerfil: (id, data) => set((state) => ({
        instrumentadores: state.instrumentadores.map(inst => 
          inst.id === id ? { ...inst, ...data } : inst
        )
      })),

      addInstrumentador: (data) => set((state) => ({
        instrumentadores: [...state.instrumentadores, {
          ...data,
          id: Date.now(),
          atuacoes: 0,
          nota: '-',
          disponibilidade: {}
        }]
      })),

      addDemandas: (novas) => set((state) => {
        const novasDemandas = novas.map((d, i) => ({
          ...d,
          id: Date.now() + i,
          status: 'pendente' as StatusDemanda
        }));
        return { demandas: [...state.demandas, ...novasDemandas] };
      }),

      addDemandaManual: (demanda) => set((state) => ({
        demandas: [...state.demandas, { ...demanda, id: Date.now(), status: 'pendente' }]
      })),

      updateDemanda: (id, data) => set((state) => ({
        demandas: state.demandas.map(d => d.id === id ? { ...d, ...data } : d)
      })),

      deleteDemanda: (id) => set((state) => {
        const demanda = state.demandas.find(d => d.id === id);
        if (demanda && (demanda.status === 'pendente' || demanda.status === 'alocando')) {
          return { demandas: state.demandas.filter(d => d.id !== id) };
        }
        return state;
      }),

      cobrarDocumento: (instrumentadorId, demandaId, tipo) => set((state) => ({
        relatorios: [...state.relatorios, {
          id: Date.now(),
          instrumentadorId,
          demandaId,
          tipo,
          status: 'pendente',
          dataSolicitacao: new Date().toISOString()
        }]
      })),

      updateRelatorio: (id, status) => set((state) => ({
        relatorios: state.relatorios.map(r => r.id === id ? { ...r, status } : r)
      })),

      resetStore: () => set({
        instrumentadores: initialInstrumentadores,
        demandas: initialDemandas,
        convites: initialConvites,
        relatorios: initialRelatorios
      })
    }),
    {
      name: 'conecta-cirurgica-storage',
    }
  )
);
