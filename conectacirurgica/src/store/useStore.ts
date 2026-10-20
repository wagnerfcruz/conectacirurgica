import { create } from 'zustand';
import { persist } from 'zustand/middleware';

export type StatusDemanda = 'pendente' | 'alocando' | 'convite_enviado' | 'confirmado' | 'realizado' | 'cancelado' | 'documentacao_pendente';
export type StatusConvite = 'aguardando' | 'aceito' | 'recusado' | 'expirado';

export interface Instrumentador {
  id: number;
  nome: string;
  especialidades: string[];
  regiao: string;
  validado: boolean;
  atuacoes: number;
  nota: string;
  disponibilidade: Record<string, string[]>; // yyyy-MM-dd -> ['manha', 'tarde']
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
  status: 'pendente' | 'recebido';
}

interface AppState {
  instrumentadores: Instrumentador[];
  demandas: Demanda[];
  convites: Convite[];
  relatorios: Relatorio[];
  
  // Actions
  updateDisponibilidade: (id: number, date: string, periodos: string[]) => void;
  enviarConvite: (demandaId: number, instrumentadorId: number) => void;
  responderConvite: (conviteId: number, resposta: 'aceito' | 'recusado') => void;
  updatePerfil: (id: number, data: Partial<Instrumentador>) => void;
  addDemandas: (novasDemandas: Omit<Demanda, 'id' | 'status'>[]) => void;
  resetStore: () => void;
}

const initialInstrumentadores: Instrumentador[] = [
  { id: 1, nome: 'João Silva', especialidades: ['Ortopedia', 'Coluna'], regiao: 'SP - Centro, Sul', validado: true, atuacoes: 45, nota: 'A', disponibilidade: {} },
  { id: 2, nome: 'Ana Costa', especialidades: ['Crânio', 'Neurologia'], regiao: 'SP - Todas', validado: true, atuacoes: 128, nota: 'A+', disponibilidade: {} },
  { id: 3, nome: 'Carlos Mendes', especialidades: ['Ortopedia'], regiao: 'SP - Leste', validado: false, atuacoes: 0, nota: '-', disponibilidade: {} },
  { id: 4, nome: 'Mariana Souza', especialidades: ['Coluna'], regiao: 'SP - Sul', validado: true, atuacoes: 12, nota: 'B', disponibilidade: {} },
];

const initialDemandas: Demanda[] = [
  { id: 1, data: '2026-10-22', hora: '08:00', hospital: 'Hosp. Santa Catarina', procedimento: 'Artroplastia Total de Joelho', medico: 'Dr. Roberto Almeida', status: 'alocando' },
  { id: 2, data: '2026-10-24', hora: '14:30', hospital: 'Hosp. Sírio-Libanês', procedimento: 'Hérnia de Disco', medico: 'Dra. Fernanda Lima', status: 'pendente' },
  { id: 3, data: '2026-10-18', hora: '10:00', hospital: 'Hosp. das Clínicas', procedimento: 'Ligamento Cruzado', medico: 'Dr. Carlos Souza', status: 'realizado', instrumentadorId: 1 },
];

const initialConvites: Convite[] = [
  { id: 1, demandaId: 1, instrumentadorId: 1, status: 'aguardando', enviadoEm: new Date().toISOString() }
];

const initialRelatorios: Relatorio[] = [
  { id: 1, demandaId: 3, status: 'recebido' }
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
        
        // Se aceitou, cancela outros convites pendentes para a mesma demanda e confirma a demanda
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
          // Se recusou, volta a demanda para alocando (se não houver outro aceito)
          return {
            convites: updatedConvites,
            demandas: state.demandas.map(d => 
              d.id === convite.demandaId 
                ? { ...d, status: 'alocando' } 
                : d
            )
          };
        }
      }),

      updatePerfil: (id, data) => set((state) => ({
        instrumentadores: state.instrumentadores.map(inst => 
          inst.id === id ? { ...inst, ...data } : inst
        )
      })),

      addDemandas: (novas) => set((state) => {
        const novasDemandas = novas.map((d, i) => ({
          ...d,
          id: Date.now() + i,
          status: 'pendente' as StatusDemanda
        }));
        return { demandas: [...state.demandas, ...novasDemandas] };
      }),

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
