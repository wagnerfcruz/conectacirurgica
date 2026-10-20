# Pacote de descoberta de produto — versão 0.3

## O que mudou nesta versão
A documentação foi atualizada com as novas informações da cliente e separa duas etapas de produto:

1. **Ferramenta privada da coordenadora:** organizar a carteira curada, estruturar o conhecimento sobre competências e contexto, filtrar candidatos e acompanhar convites e atendimentos.
2. **Possível plataforma multiempresa:** validar se outras coordenadoras/empresas querem usar a solução, com segregação de dados, compartilhamento autorizado e regras de responsabilidade próprias.

A expansão para marketplace não é considerada aprovada. É uma hipótese de produto/negócio que precisa ser testada antes de investimento maior.

## Arquivos do pacote
- `PRD_Plataforma_Instrumentadores_v0.3.docx`: documento editável, para converter/abrir no Google Docs e compartilhar com comentários.
- `PRD_Plataforma_Instrumentadores_v0.3.pdf`: versão de apresentação.
- `Base_Descoberta_Instrumentadores_v0.3.xlsx`: planilha de trabalho com as abas de freelancers, competências, restrições, histórico, disponibilidade, demandas, convites, perguntas, decisões e backlog. As linhas marcadas como exemplo são fictícias; substitua ou exclua antes de uso operacional.
- `Criar_Google_Form_v0.3.gs`: script para gerar o formulário online (39 perguntas em 8 seções) e sua planilha de respostas na sua conta Google. A aba `Perguntas discovery` no Excel é um roteiro resumido para workshop, não uma cópia literal das perguntas do formulário.
- Este arquivo: instruções e recomendações de uso.

## Como converter o DOCX para Google Docs
1. Acesse Google Drive.
2. Faça upload do DOCX.
3. Clique com o botão direito e escolha **Abrir com > Documentos Google**.
4. Revise a conversão e compartilhe o link com permissão de comentar.
5. Use o PDF como versão fixa para apresentação, não como lugar principal de edição.

## Como criar o Google Forms
1. Entre em `https://script.google.com/` com a conta que será dona do formulário.
2. Crie um projeto novo.
3. Abra `Criar_Google_Form_v0.3.gs`, copie o conteúdo e cole em `Code.gs`.
4. Salve e selecione `criarFormularioDescobertaInstrumentadoresV03`.
5. Clique em Executar e autorize os acessos solicitados pelo Google.
6. Abra o registro da execução. Copie o link para responder, o link de edição e o link da planilha de respostas.
7. Abra o formulário em modo de edição, confira as perguntas/opções e faça uma resposta de teste.
8. Compartilhe com a cliente **somente** o link de resposta. Guarde o link de edição para a equipe.

O script cria uma nova cópia do Form e da planilha a cada execução. Execute uma vez, salvo se desejar duplicar o formulário.

## Como começar a usar a planilha
- Não comece cadastrando toda a carteira de uma vez. Selecione uma amostra pequena de profissionais conhecidos e casos típicos.
- Uma linha em `Competências` significa uma combinação específica de profissional, procedimento/material/contexto e validação.
- A aba `Restrições - restrito` pode conter informações reputacionais ou contextuais delicadas. Não compartilhe a planilha inteira sem definir permissões. Evite opiniões vagas; registre fatos, escopo, validade e quem pode ver.
- Use dados fictícios ou anonimizados nos testes de matching; não inclua dados de pacientes.
- Antes de copiar contatos, fotos ou histórico de um sistema corporativo para um projeto independente, confirme autorização, finalidade e direitos de uso com as pessoas responsáveis.

## Recomendações de uso
- **Google Docs** é o documento de referência para ler e comentar.
- **Google Forms** coleta as respostas do workshop de descoberta.
- **Excel/Sheets** ajuda a organizar o inventário inicial e registrar decisões.
- **PDF** serve como material de apresentação/versão fechada.

## O que ainda não está aprovado
O cadastro exato, a taxonomia de competência, as regras de restrição, a estratégia de convite/aceite, as integrações de WhatsApp, as responsabilidades por empresa, o modelo comercial e a forma de compartilhar perfis entre empresas continuam pendentes de validação.
