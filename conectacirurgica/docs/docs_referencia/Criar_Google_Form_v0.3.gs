/**
 * Google Forms de descoberta v0.3 — Plataforma de Gestão de Instrumentadores Cirúrgicos.
 *
 * Como usar:
 * 1) Entre em https://script.google.com/ usando a conta Google proprietária.
 * 2) Crie um projeto novo e cole este arquivo em Code.gs.
 * 3) Salve e execute criarFormularioDescobertaInstrumentadoresV03().
 * 4) Autorize os acessos solicitados pelo Google.
 * 5) Abra Executions / Registro de execução para obter o link público de resposta,
 *    o link de edição do formulário e a planilha de respostas.
 *
 * Cria um formulário + planilha de respostas por execução. Execute uma única vez,
 * a menos que deseje criar uma nova cópia. Revise as perguntas antes de compartilhar.
 * Não inclua dados reais de pacientes ou documentos clínicos no formulário.
 */
function criarFormularioDescobertaInstrumentadoresV03() {
  const form = FormApp.create('Descoberta de produto | Plataforma de instrumentadores cirúrgicos | v0.3');
  form.setDescription(
    'Objetivo: validar o problema atual da coordenadora, a matriz de competências e contexto dos freelancers, as regras de matching e a possível evolução para uma plataforma multiempresa. ' +
    'Responda com base na operação real. Se algo ainda não estiver decidido, indique isso. ' +
    'Não inclua nomes de pacientes, dados clínicos reais, documentos médicos, dados pessoais de freelancers ou informações confidenciais da empresa neste formulário.'
  );
  form.setConfirmationMessage('Obrigado! As respostas serão consolidadas no documento de produto. As decisões e hipóteses pendentes serão revisadas antes do desenvolvimento.');
  form.setCollectEmail(false);
  form.setProgressBar(true);
  form.setShuffleQuestions(false);

  const mc = (title, choices, required, help) => {
    const item = form.addMultipleChoiceItem().setTitle(title).setChoiceValues(choices).setRequired(!!required);
    if (help) item.setHelpText(help);
    item.showOtherOption(true);
    return item;
  };
  const cb = (title, choices, required, help, maxSelections) => {
    const item = form.addCheckboxItem().setTitle(title).setChoiceValues(choices).setRequired(!!required);
    if (help) item.setHelpText(help);
    if (maxSelections) {
      const validation = FormApp.createCheckboxValidation().requireSelectAtMost(maxSelections).build();
      item.setValidation(validation);
    }
    item.showOtherOption(true);
    return item;
  };
  const short = (title, required, help) => {
    const item = form.addTextItem().setTitle(title).setRequired(!!required);
    if (help) item.setHelpText(help);
    return item;
  };
  const para = (title, required, help) => {
    const item = form.addParagraphTextItem().setTitle(title).setRequired(!!required);
    if (help) item.setHelpText(help);
    return item;
  };
  const section = (title, help) => {
    const item = form.addPageBreakItem().setTitle(title);
    if (help) item.setHelpText(help);
    return item;
  };

  section('1. Operação atual e volume', 'Números aproximados são suficientes nesta etapa.');
  short('1. Quantos freelancers existem na carteira? Quantos estão ativos e quantos são usados com frequência?', false, 'A estimativa inicial foi de cerca de 100 profissionais conhecidos, ainda a confirmar.');
  short('2. Quantas cirurgias são coordenadas por mês? Quantas são emergências?', false, 'Foi relatado um volume aproximado de 336 cirurgias por mês; confirmar período e definição.');
  para('3. Quais etapas hoje mais consomem tempo da coordenadora, além de gerar os cartões?', false, 'Ex.: busca por competência, conferir disponibilidade, ligar, treinar, substituir, cobrar pós-operatório.');
  mc('4. Qual deve ser a primeira entrega do projeto?', ['Organizar uma base/planilha confiável de profissionais e competências', 'Criar uma ferramenta privada para buscar e convocar freelancers', 'Começar diretamente por uma plataforma para várias empresas', 'Ainda não definido'], true, 'A recomendação inicial é estruturar a base antes de desenvolver o sistema.');

  section('2. Competências, materiais e validação', 'O foco é registrar o que cada pessoa realmente domina, e em qual contexto.');
  para('5. Quais categorias devem compor a matriz técnica?', true, 'Liste a taxonomia conhecida: especialidade, procedimento específico, material/sistema, fabricante, versão/kit e outras categorias relevantes.');
  cb('6. Como a coordenadora sabe que um freelancer domina um procedimento/material?', ['Observação do trabalho em campo', 'Histórico confirmado de atendimentos', 'Treinamento/avaliação prática', 'Referência de outra pessoa confiável', 'Combinação de evidências', 'Ainda não existe um critério consistente'], true, 'Selecione todos os tipos de evidência utilizados e complemente em “Outro”, se necessário.');
  mc('7. Quais níveis de competência seriam úteis?', ['Validado para atuar de forma independente', 'Pode atuar com suporte/treinamento', 'Conhecimento introdutório', 'Autodeclarado, ainda não validado', 'Validado pela empresa para contexto específico', 'Ainda não definido'], true, 'O sistema não deve tratar autodeclaração como competência automaticamente validada.');
  para('8. Quem pode validar, rever ou retirar o status de competência? Com que evidência e frequência?', true, 'Informe responsáveis, critérios, validade e situações que exigem nova validação.');
  para('9. A familiaridade com materiais/sistemas e os procedimentos é igual em todas as empresas? O que varia por empresa?', true, 'Diferencie competência transferível de treinamento, suporte ou aprovação específicos de uma empresa.');

  section('3. Contexto, restrições e histórico', 'Esta seção exige cuidado: registros devem ser factuais, contextualizados, restritos e revisáveis.');
  cb('10. Em quais contextos pode existir uma restrição ou condição de compatibilidade?', ['Empresa', 'Médico/contexto do atendimento', 'Hospital/local', 'Procedimento', 'Material/sistema', 'Disponibilidade/logística', 'Treinamento/suporte necessário', 'Outro contexto'], true, 'Marque os tipos que realmente existem na operação.');
  para('11. Como uma restrição deve ser registrada e quem pode vê-la?', true, 'Sugestão: categoria, escopo, motivo factual mínimo, fonte, responsável, vigência, próxima revisão e nível de acesso.');
  para('12. Que informações de histórico pós-atendimento devem atualizar a ficha do freelancer?', false, 'Prefira fatos observáveis e critérios estruturados a comentários vagos.');
  mc('13. O freelancer deve ter um caminho para solicitar correção de informação factual?', ['Sim, com revisão pela coordenadora/administrador', 'Sim, com revisão por alguém independente', 'Não definido', 'Outra regra'], true, 'A política precisa evitar tanto erros permanentes quanto alterações sem validação.');

  section('4. Cadastro e direitos de uso dos dados', 'Antes de reaproveitar bases corporativas, valide permissões e finalidade.');
  mc('14. Quem pode incluir um freelancer na base curada?', ['Somente a coordenadora/administração', 'A coordenadora convida e o freelancer completa campos limitados', 'Qualquer freelancer pode se candidatar, mas depende de aprovação', 'Cadastro aberto sem aprovação', 'Ainda não definido'], true, 'A hipótese inicial é uma rede curada por convite/aprovação.');
  mc('15. De onde vêm os contatos, fotos e históricos que seriam cadastrados?', ['Base construída pela coordenadora fora dos sistemas corporativos', 'Sistema interno da empresa atual', 'WhatsApp/contatos pessoais', 'Múltiplas fontes', 'Ainda precisamos mapear'], true, 'Não importe dados de sistemas corporativos para um negócio independente sem verificar autorização e direitos de uso.');
  para('16. Que autorização, contrato ou consentimento existe para usar e compartilhar esses dados fora da empresa atual?', true, 'Se não souber, escreva “precisa validar”.');
  mc('17. O freelancer deve autorizar o compartilhamento do perfil com outras empresas?', ['Sim, por empresa/finalidade específica', 'Sim, opt-in para uma lista de empresas autorizadas', 'Perfil só visível para a coordenadora até novo aceite', 'Perfil aberto a todos', 'Ainda não definido'], true, 'A autorização para receber convites não significa necessariamente autorização para tornar todo o histórico público.');
  para('18. Quais informações devem ficar privadas por empresa e quais poderiam ser compartilhadas?', true, 'Ex.: perfil profissional, competências validadas, disponibilidade, demanda, notas internas, restrições, histórico, documentos.');

  section('5. Disponibilidade, demanda e matching', 'Definir o mínimo necessário para produzir uma lista curta confiável.');
  mc('19. Quem atualiza a disponibilidade e como ela expira?', ['O freelancer atualiza; confirmar novamente ao receber convite', 'A coordenadora atualiza', 'Ambos atualizam com trilha de auditoria', 'A disponibilidade é perguntada a cada demanda', 'Ainda não definido'], true, null);
  cb('20. Que critérios são obrigatórios para recomendar alguém?', ['Competência validada no procedimento/material', 'Disponibilidade para data/hora', 'Localização/raio de atendimento', 'Duração e deslocamento', 'Ausência de conflito de agenda', 'Compatibilidade com empresa/hospital/médico', 'Documentação/qualificação vigente', 'Experiência contextual', 'Outro critério'], true, 'Separe critérios eliminatórios de critérios usados apenas para ordenar candidatos.');
  para('21. Quais campos devem existir na prévia de agendamento antes de convidar um profissional?', true, 'Não incluir nome do paciente na abordagem inicial, salvo se houver necessidade autorizada e validada.');
  mc('22. Como deve funcionar a convocação?', ['Um candidato por vez', 'Vários candidatos em paralelo', 'Estratégia definida pela coordenadora para cada caso', 'Sequencial em casos comuns e paralela em emergências', 'Ainda não definido'], true, 'Definir prazo de resposta e tratamento de dois aceites simultâneos.');
  mc('23. Quem confirma a alocação?', ['Primeiro aceite válido confirma automaticamente', 'A coordenadora aprova depois do aceite', 'Automático em casos comuns e aprovação em exceções', 'Ainda não definido'], true, null);
  para('24. O que acontece quando ninguém aceita uma emergência, quando há mudança ou quando um profissional desiste?', true, 'Defina prazos, escalada, substituição e pessoa de contingência.');
  para('25. Como o sistema identifica uma mesma cirurgia em novas exportações Excel?', false, 'Informe ID/código único, colunas ou procedimento atual para detectar duplicidade, alteração e cancelamento.');

  section('6. Cartões, mensagens e pós-operatório', 'Preservar processos que já funcionam e validar integrações antes de prometer automação.');
  mc('26. O gerador atual de cartões deve ser mantido durante a primeira versão?', ['Sim, preservar e integrar se viável', 'Não, incorporar depois à plataforma', 'Ainda não sabemos; comparar esforço/custo'], true, null);
  mc('27. Qual canal é usado hoje para convites e documentos?', ['WhatsApp pessoal', 'WhatsApp Business aplicativo', 'API/plataforma oficial', 'E-mail ou outro sistema', 'Ainda não sei'], true, null);
  cb('28. Por onde os documentos finais devem ser encaminhados?', ['WhatsApp individual', 'Grupo de WhatsApp (validar suporte técnico)', 'E-mail', 'Área segura do sistema', 'Outro canal'], true, 'A possibilidade de envio automático para grupos precisa ser tecnicamente validada.');
  para('29. Qual formato tem o relatório pós-operatório? Quem o confere? O cartão e o relatório precisam formar um único PDF?', true, 'Inclua destinatários por função/área, não nomes de pacientes.');
  mc('30. O sistema deve calcular ou liberar pagamentos?', ['Não; apenas organizar e encaminhar documentos/dados', 'Preparar dados para conferência/exportação', 'Calcular conforme regras definidas', 'Autorizar/liberar pagamento', 'Ainda não definido'], true, 'Não presumir autorização financeira ou integração com aprovação corporativa.');

  section('7. Oportunidade multiempresa e modelo de negócio', 'Esta seção trata de hipóteses futuras, não do escopo obrigatório do primeiro MVP.');
  mc('31. Outras coordenadoras/empresas aceitariam testar uma ferramenta externa para encontrar freelancers?', ['Sim, já existe interesse concreto', 'Talvez; precisamos entrevistar e validar', 'Ainda não conversei com possíveis clientes', 'Não parece viável neste momento'], true, null);
  cb('32. Que proposta de valor parece mais relevante para outras empresas?', ['Buscar profissionais por competência técnica específica', 'Encontrar cobertura urgente mais rápido', 'Acessar uma rede curada e validada', 'Organizar disponibilidade e convites', 'Reduzir risco de incompatibilidade', 'Histórico de atendimento/qualificação', 'Outro benefício'], true, null);
  mc('33. Quem poderia pagar pela solução?', ['Empresa por assinatura', 'Por coordenador/usuário', 'Por demanda/alocação confirmada', 'Serviço gerenciado de matching', 'Modelo híbrido', 'Ainda não definido'], true, 'Tratar como hipótese de pesquisa; não escolher preço com base apenas nesta resposta.');
  mc('34. Qual modelo de acesso à rede parece aceitável?', ['Rede fechada por convite e validação', 'Empresas autorizadas consultam perfis compartilhados', 'Marketplace aberto com candidatura controlada', 'Modelo diferente por tipo de empresa', 'Ainda não definido'], true, 'A recomendação inicial é manter uma rede controlada e curada.');
  para('35. Quais responsabilidades devem continuar com cada empresa (autorização da cirurgia, materiais, treinamento, decisão final, pagamento)?', true, 'A plataforma não deve presumir que substitui processos corporativos independentes.');
  para('36. Quais seriam os critérios para autorizar um piloto multiempresa?', false, 'Ex.: consentimento, contrato, segregação de dados, responsáveis, suporte e indicadores.');

  section('8. Prioridades e revisão final', 'Use esta seção para confirmar o que deve entrar primeiro e registrar o que falta.');
  cb('37. Quais três entregas devem ser priorizadas para a primeira versão?', ['Base curada e matriz de competências', 'Filtro e lista de candidatos explicável', 'Disponibilidade', 'Importação da demanda/Excel', 'Convite e aceite', 'Cartão de agendamento', 'Emergências e escalada', 'Histórico/feedback', 'Pós-operatório e PDF', 'Acesso multiempresa'], true, 'Escolha no máximo três.', 3);
  para('38. Quais ferramentas, limites de custo, requisitos de suporte ou integrações precisam ser considerados?', false, 'Ex.: Google Workspace, app atual de cartões, hospedagem e custo mensal.');
  para('39. O que está faltando, incorreto ou precisa ser alterado nesta proposta?', true, 'Use esta resposta para acrescentar requisitos não contemplados.');

  const responseSheet = SpreadsheetApp.create('Respostas | Descoberta Instrumentadores | v0.3');
  form.setDestination(FormApp.DestinationType.SPREADSHEET, responseSheet.getId());
  Logger.log('FORMULÁRIO PARA RESPONDER: ' + form.getPublishedUrl());
  Logger.log('FORMULÁRIO PARA EDITAR: ' + form.getEditUrl());
  Logger.log('PLANILHA DE RESPOSTAS: ' + responseSheet.getUrl());
  Logger.log('Criados: 39 perguntas em 8 seções. Revise o formulário antes de compartilhar.');
}
