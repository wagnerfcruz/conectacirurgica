# Contexto do Projeto: Conecta Cirúrgica

Este arquivo mantém o registro do que está sendo feito, das tecnologias utilizadas e do status atual do projeto. O objetivo é preservar o contexto em caso de perda de sessão ou para futuras interações com agentes de IA (como o Antigravity).

## Objetivo da Etapa Atual
Construir um **protótipo visual e navegável (front-end)** para uma plataforma de gestão de disponibilidade, competências e acionamento de instrumentadores cirúrgicos freelancers. Nesta fase, não haverá back-end real, banco de dados ou autenticação. Tudo funciona com estado local e dados fictícios (mockados).

## Stack Tecnológico
- **Framework:** React com TypeScript
- **Build Tool:** Vite
- **Estilização:** Tailwind CSS (v4)
- **Roteamento:** React Router DOM
- **Ícones:** Lucide React
- **Utilitários:** `clsx`, `tailwind-merge`, `date-fns`
- **Hospedagem:** GitHub Pages (via GitHub Actions)

## O Que Já Foi Feito

### 1. Configuração Inicial e Deploy
- [x] Correção do deploy no GitHub Pages (Criação de `.github/workflows/deploy.yml`).
- [x] Configuração da propriedade `base: '/conectacirurgica/'` no `vite.config.ts`.
- [x] Instalação do Tailwind CSS v4 e configuração no `index.css`.
- [x] Instalação do React Router e dependências de ícones e utilitários.

### 2. Estrutura de Roteamento (App.tsx)
- [x] Rota inicial `/` (Tela de Login/Seleção de Perfil demonstrativa).
- [x] Rotas `/instrumentador/*` utilizando `InstrumentadorLayout`.
- [x] Rotas `/coordenadora/*` utilizando `CoordenadoraLayout`.

### 3. Visão do Instrumentador (Mobile-First)
- [x] **Layout Base:** Header com informações do usuário, navegação bottom-bar (Minha Agenda, Disponibilidade, Histórico) e menu sanduíche.
- [x] **Dashboard:** Exibe próximos compromissos e convites pendentes (com botões visuais de aceitar/recusar).
- [x] **Disponibilidade:** Interface de seleção de dias da semana (date-fns) e turnos (Manhã, Tarde, Noite, Dia Inteiro, Indisponível) simulando o salvamento.
- [x] **Histórico:** Timeline de procedimentos realizados, cancelados ou pendentes.

### 4. Visão da Coordenadora (Desktop)
- [x] **Layout Base:** Sidebar lateral com navegação completa, topbar e área principal expansiva.
- [x] **Dashboard:** Cards de métricas principais (profissionais disponíveis, demandas, etc.), painéis de atenção e histórico de atividades.
- [x] **Pesquisa de Disponibilidade:** Filtros por data, período e especialidade e listagem em tabela.
- [x] **Mapa Cirúrgico:** Interface de simulação de drag-and-drop para importação de CSV/XLSX com preview de tabela para identificar duplicidades.
- [x] **Acionamentos:** Visão em duas colunas. Seleciona-se uma demanda na esquerda e a direita mostra os "Matches" com porcentagem de compatibilidade, permitindo simular o envio de um convite.
- [x] **Confirmados (Cartão de Acionamento):** Lista de procedimentos confirmados e exibição de um "cartão" lateral com detalhes da cirurgia, hospital, médico e instrumentador.
- [x] **Profissionais:** Carteira (diretório) com status de validação, especialidades, nota e atuações.
- [x] **Documentos:** Painel de controle de relatórios pós-cirúrgicos e cobrança (recebidos vs pendentes).

## Próximos Passos (Backlog)
- [ ] Refinar UX/UI baseada no feedback do protótipo navegável.
- [ ] Melhorar responsividade de componentes específicos, se necessário.
- [ ] Transição para etapa de Backend (quando autorizado): Setup de Banco de Dados, Autenticação Real, API de persistência.

---
*Última atualização: 20 de Outubro de 2026.*
