import { create } from 'zustand';
import { persist } from 'zustand/middleware';

export type StatusDemanda = 'pendente' | 'alocando' | 'convite_enviado' | 'confirmado' | 'realizado' | 'cancelado' | 'documentacao_pendente' | 'cancelamento_solicitado';
export type StatusConvite = 'aguardando' | 'aceito' | 'recusado' | 'expirado' | 'cancelado';

export interface Instrumentador {
  id: number;
  nome: string; // Nome completo
  celular?: string; // Celular/telefone
  regiao: string; // Cidade/região
  funcao?: string; // Função ou categoria profissional
  nivel?: string; // Nível profissional
  especialidades: string[]; // Especialidades e tipos de cirurgia
  competenciasDeclaradas?: string[]; // Competências declaradas
  competenciasValidadas?: string[]; // Competências validadas
  statusCadastro?: string; // Status do cadastro
  dadosComplementares?: string; // Dados complementares
  transporte?: string; // Transporte
  validado: boolean;
  atuacoes: number;
  nota: string;
  disponibilidade: Record<string, string[]>;
  cpf?: string;
}

export interface ProdutoMaterial {
  id: string;
  descricao: string;
  quantidade: string;
  observacoes?: string;
  codigoReferencia?: string;
}

export interface EquipamentoServico {
  id: string;
  tipo: 'equipamento' | 'servico';
  descricao: string;
  quantidade?: string;
  observacoes?: string;
}

export interface Demanda {
  id: number;
  data: string; // yyyy-MM-dd
  hora: string; // HH:mm
  hospital: string;
  unidadeLocal?: string; // Unidade/local complementar
  procedimento: string;
  medico: string;
  tipoEvento?: string; // agendamento, reagendamento, etc
  status: StatusDemanda;
  instrumentadorId?: number | null;
  valorFreelancer?: string; // Valor do freelancer em reais (numérico formata em BRL na UI ou string formatada)
  motivoCancelamento?: string;
  emergencia?: boolean; // Indicador de emergência
  observacoes?: string; // Observações
  confirmacao?: string; // Confirmação

  // Novos campos baseados no Card Oficial
  mc?: string;
  paciente?: string;
  empresa?: string;
  convenio?: string;
  produtosLista?: ProdutoMaterial[];
  equipamentosLista?: EquipamentoServico[];
  produtos?: string; // Mantendo para retrocompatibilidade provisória
  equipamentos?: string; // Mantendo para retrocompatibilidade provisória
  representante?: string;
  retornoOp?: string;
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

export interface EmpresaConfig {
  logoUrl?: string;
  nome: string;
  tagline?: string;
  headerTitleLine1?: string;
  headerTitleLine2?: string;
}

interface AppState {
  instrumentadores: Instrumentador[];
  demandas: Demanda[];
  convites: Convite[];
  relatorios: Relatorio[];
  empresaConfig: EmpresaConfig;
  
  // Actions
  updateEmpresaLogo: (url: string) => void;
  updateEmpresaConfig: (config: Partial<EmpresaConfig>) => void;
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
  { id: 1, nome: 'João Silva', funcao: 'Instrumentador', nivel: 'Nível 1', especialidades: ['Ortopedia', 'Coluna'], regiao: 'SP - Centro, Sul', validado: true, atuacoes: 45, nota: 'A', disponibilidade: {}, celular: '(11) 99999-9999', transporte: 'carro', competenciasValidadas: ['Instrumentação Cirúrgica Básica'], statusCadastro: 'Ativo' },
  { id: 2, nome: 'Ana Costa', funcao: 'Instrumentador', nivel: 'Nível 2', especialidades: ['Crânio', 'Neurologia'], regiao: 'SP - Todas', validado: true, atuacoes: 128, nota: 'A+', disponibilidade: {}, celular: '(11) 98888-8888', transporte: 'moto', statusCadastro: 'Ativo' },
  { id: 3, nome: 'Carlos Mendes', funcao: 'Instrumentador', nivel: 'Nível 1', especialidades: ['Ortopedia'], regiao: 'SP - Leste', validado: false, atuacoes: 0, nota: '-', disponibilidade: {}, transporte: 'nao_informado', statusCadastro: 'Pendente' },
  { id: 4, nome: 'Mariana Souza', funcao: 'Instrumentador', nivel: 'Nível 3', especialidades: ['Coluna'], regiao: 'SP - Sul', validado: true, atuacoes: 12, nota: 'B', disponibilidade: {}, transporte: 'outro', statusCadastro: 'Ativo' },
];

const initialDemandas: Demanda[] = [
  { 
    id: 1, data: '2026-10-22', hora: '08:00', hospital: 'Hosp. Santa Catarina', procedimento: 'Artroplastia Total de Joelho', medico: 'Dr. Roberto Almeida', status: 'alocando', 
    valorFreelancer: 'R$ 250,00', mc: '896', paciente: 'João da Silva', empresa: 'MEDITEC', convenio: 'Bradesco', 
    representante: 'Jonathan', retornoOp: 'Não retornado', tipoEvento: 'AGENDAMENTO', confirmacao: 'SEM DADOS', emergencia: false,
    produtosLista: [
      { id: '1', descricao: 'KIT P/ BLOQUEIO * (Enviar todos os tamanhos)', quantidade: '1', codigoReferencia: 'EDGE PAIN' }
    ],
    equipamentosLista: []
  },
  { 
    id: 2, data: '2026-10-24', hora: '14:30', hospital: 'Hosp. Sírio-Libanês', procedimento: 'Hérnia de Disco', medico: 'Dra. Fernanda Lima', status: 'pendente', 
    valorFreelancer: 'R$ 300,00', produtosLista: [], equipamentosLista: []
  },
  { 
    id: 3, data: '2026-10-18', hora: '10:00', hospital: 'Hosp. das Clínicas', procedimento: 'Ligamento Cruzado', medico: 'Dr. Carlos Souza', status: 'realizado', 
    instrumentadorId: 1, valorFreelancer: 'R$ 200,00', produtosLista: [], equipamentosLista: []
  },
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
      empresaConfig: { 
        nome: 'CONECTA', 
        tagline: 'CIRÚRGICA',
        headerTitleLine1: 'AGENDAMENTO',
        headerTitleLine2: 'FREELANCE'
      },

      updateEmpresaLogo: (url) => set((state) => ({
        empresaConfig: { ...state.empresaConfig, logoUrl: url }
      })),

      updateEmpresaConfig: (config) => set((state) => ({
        empresaConfig: { ...state.empresaConfig, ...config }
      })),

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
        if (!convite || convite.status !== 'aguardando') return state;
        
        const demanda = state.demandas.find(d => d.id === convite.demandaId);
        if (resposta === 'aceito' && demanda && demanda.instrumentadorId) {
            // Se já tem alguém alocado (outra pessoa aceitou simultaneamente), forçamos recusar este convite
            return {
                convites: state.convites.map(c => c.id === conviteId ? { ...c, status: 'recusado' } : c)
            };
        }

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
