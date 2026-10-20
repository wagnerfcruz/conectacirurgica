# Contexto e Histórico do Projeto: Conecta Cirúrgica

Este arquivo mantém o registro de tudo o que foi implementado, decisões técnicas e o estado atual do projeto para que qualquer nova sessão ou desenvolvedor possa continuar o trabalho exatamente de onde parou.

## Status Atual: Fase de Protótipo Funcional (Front-end)
A aplicação é atualmente um protótipo navegável de alta fidelidade.
- **Tecnologias:** React, TypeScript, Vite, Tailwind CSS, Zustand (para estado global simulando um banco de dados).
- **Armazenamento:** `localStorage` (os dados persistem no navegador, mas não há backend ou banco de dados real configurado ainda).
- **Integrações Externas:** Nenhuma (sem WhatsApp real, sem autenticação, sem envio real de e-mails/SMS).

## O que já foi entregue e validado (Checklist Completo)

### 1. Estado Global (Zustand - `src/store/useStore.ts`)
- Estruturas de dados complexas para `Instrumentador` e `Demanda`.
- Ações para criar, editar e excluir demandas.
- Ações para registrar disponibilidade, atualizar perfil, enviar e responder convites.
- Ações para solicitar cancelamentos e cobrar/anexar documentos.

### 2. Visão do Instrumentador (Freelancer)
- **Meu Perfil:** Leitura e edição de dados (Nome, Celular, CPF, Região, Transporte). Visualização de Especialidades e Competências Validadas pela gestão.
- **Dashboard Principal:**
  - Status atual de disponibilidade ("Ativo").
  - Visão rápida de "Minha Agenda" (cirurgias confirmadas).
  - Gestão de "Novos Convites" (visualizar hospital, hora, procedimento, valor e Aceitar/Recusar).
  - Pendências de Documentos com fluxo de anexo de arquivo simulado.
  - Solicitação de Cancelamento de cirurgias confirmadas (exige motivo).
- **Disponibilidade:** Formulário robusto permitindo selecionar Data Inicial/Final, múltiplos dias da semana e turnos (Manhã, Tarde, Noite).
- **Histórico:** Lê os dados reais do Zustand (`realizado` ou `cancelado`).

### 3. Painel de Gestão (Coordenadora)
- **Dashboard:** Visão geral de métricas. Sino de notificações que alerta sobre *Cancelamentos Solicitados* e *Documentos Pendentes*.
- **Profissionais:** Lista, busca e modal de cadastro/edição (CRUD completo na memória local).
- **Pesquisa de Disponibilidade:** Busca por intervalo de datas e especialidades para encontrar quem está livre.
- **Acionamentos (Match e Convites):** 
  - Criação manual de demandas (com valor do freelancer).
  - Algoritmo de *Match* que cruza especialidades, disponibilidade do dia e conflitos de agenda.
  - Modal de **Prévia do Convite** antes de enviar, garantindo a omissão do nome do paciente.
- **Confirmados:** Listagem de cirurgias com profissional alocado. Geração de "Cartão de Acionamento" com botão para copiar texto formatado para WhatsApp e download de PNG (usando `html2canvas`).
- **Documentos:** Painel para "Cobrar Documento" (NF ou Relatório) das cirurgias confirmadas, o que gera uma pendência imediata no painel do respectivo instrumentador.
- **Mapa Cirúrgico:** Interface de upload de planilha (lógica de validação visual feita, aguardando planilha real da Meditec para plugar a injeção automática de demandas).

## Limitações Atuais (Conhecidas)
- Por não ter autenticação, o fluxo do Instrumentador assume um "usuário logado falso" (ID 1 - João Silva) para demonstração de rotas.
- O "Upload" de documentos pega o nome do arquivo, mas não envia o binário para nenhum lugar (simulação de sucesso).
- O PDF/Imagem gerado não é um documento com valor legal, é uma renderização do DOM em PNG.
- Alterações no perfil são salvas localmente apenas.

## Próximos Passos (Roadmap sugerido)
1. Receber e mapear o arquivo Excel oficial para o `MapaCirurgico.tsx`.
2. Validar o fluxo completo com a equipe/cliente (apresentação do protótipo).
3. Iniciar a arquitetura do Backend (Node.js/NestJS ou Firebase/Supabase) para substituir o Zustand.
4. Implementar Autenticação Real (JWT).
