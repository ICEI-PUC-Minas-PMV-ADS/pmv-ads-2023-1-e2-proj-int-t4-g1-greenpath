# Plano de Testes de Software

Os requisitos para realização dos testes de software são:
- Site publicado na Internet https://greenpath.azurewebsites.net/
- Navegador da Internet - Chrome, Firefox ou Edge 
- Conectividade de Internet para acesso às plataformas (APISs) 


## Testes de Navegabilidade
Automatizado:

Tem por objetivo verificar se todos os links são navegáveis, estão corretos e levam o usuário a uma outra tela existente na aplicação.

Foram feitos testes automatizados e testes manuais, como seguem os resultados abaixo.

Os Testes automatizados foram realizados através de: https://datayze.com/site-navigability-analyzer

Resultado:
![Datayze](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/da54cc1be16a28f67cf67a9056415704e008486e/docs/img/Navigability_Test.png)

Também foi feito teste de forma manual navegando pela aplicação somente para exemplificar o procedimento manual, visto que, os testes automatizados foram positivos e não apresentaram problemas de navegabilidade na aplicação.

## Testes de Navegabilidade
Manual:

### Tela Inicial / Homepage:
Na tela de Inicio existem os seguintes links para outras telas desta aplicação

- No cabeçalho, à esquerda, existem os links: "Logomarca" e “Inicio”, que ligam a página á homepage; “Empresas” que liga a aplicação à área de busca e resultados de busca de conteúdos de Empresas cadastradas na aplicação; “Vagas” que liga a aplicação à área de busca e resultados de busca de conteúdos de Vagas disponíveis cadastradas na aplicação;
- No cabeçalho à direita, existe área para a foto do usuário logado com seu nome. Ao clicar sobre a foto é aberto menu de navegação com as opções: “Perfil” ou “Sair”. Ao clicar em sair é direcionado à tela inicial de login. Ao clicar em “Perfil” é direcionado à tela de perfil de usuário;
- Logo abaixo do cabeçalho existe a área central da aplicação com publicidade da empresa GreenPath e informações sobre a área de atuaçao da empresa e informações da mesma com o intuito de esclarecer aos potenciais novos usuários os campos de atuação da empresa.
- No rodapé existem informações de Copyright da empresa e link para a Politica de Privacidade de dados da empresa GreenPath, este link liga ao texto Legal expandido; 

Resultado: 
Todos os links levam à área ou tela esperada.


## Teste de Responsividade

Os testes de responsividade foram automatizados por Google: Teste de compatibilidade com dispositivos móveis
https://search.google.com/test/mobile-friendly?hl=pt

Link para os resultados:
https://search.google.com/test/mobile-friendly/result?id=5Ok-5SsJAPACr_AADYfJ3w

![Google](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/855517a66609bf4424711da0607326660ae29d87/docs/img/Responsividade_Test.png)




## Teste de Funcionalidades

Os testes funcionais a serem realizados no aplicativo são descritos a seguir.

| Caso de Teste      | CT-01 -      Teste de Login de Usuarios (Candidato ou Empresa)                                                                                                                                                 |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  | RF-02; RF-07 -  O site deve permitir o login de usuário, candidatos ou empresas.                                    |
| Objetivo do Teste      | Verificar se o login de usuarios Candidatos e Empresa ja cadastrados no Banco de Dados é realizado com sucesso.                                                                                   |
| Passos                 | 1) Acessar o site  <br>2) Realizar o Login se ja houver o cadastro existente.  <br>3) Verificar a validação das informações <br>4) Permitir o acesso e verificar dados no Banco de Dados.    |
| Critérios de Êxito     |    Acesso ao painel de Usuario <br> Comunicação correta entre o Banco de Dados e aplicação.  |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           | 
 
| Caso de Teste      | CT-02 -      Registro de Novo Usuario - Candidato (Usuário Pessoa Física)                                                                                                                                                 |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  | RF-01 -  O site deve permitir que o usuário crie o seu perfil.                                    |
| Objetivo do Teste      | Verificar se os campos de entrada de dados do Perfíl de usuarios Candidatos estão funcionando corretamente e alimentando o Banco de Dados. |
| Passos                 | 1) Acessar o site  <br>2) Fazer o cadastro (Novo Usuario) e Cadastrar as demais informações do Perfíl de usuário Pessoa Física (CPF).  <br>3) Verificar a validação das informações <br>4) Permitir o acesso e verificar dados no Banco de Dados.    |
| Critérios de Êxito     |    Acesso ao painel de Perfil de Usuario - Candidato (Usuário Pessoa Física) <br> Comunicação correta entre o Banco de Dados e aplicação.  |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           |  


| Caso de Teste      | CT-03 -      Registro de Novo Usuario - Empresa (Usuário Pessoa Jurídica)                                   |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-06 -  O site deve permitir que o usuário Empresa crie o seu perfil; & RF-15 - Permitir um mecanismo de selos, onde é possível a empresa ter selos em seu perfil representando quais comprovações de responsabilidade social, ambiental e/ou sustentabilidade, ela possui.  |
| Objetivo do Teste      | Verificar se os campos de entrada de dados do Perfíl de usuarios Empresas estão funcionando corretamente e alimentando o Banco de Dados.   |
| Passos                 | 1) Acessar o site  <br>2) Fazer o cadastro (Novo Usuario) e Cadastrar as demais informações do Perfíl de usuário Pessoa Jurídica (CNPJ).  <br>3) Verificar a validação das informações <br>4) Permitir o acesso e verificar dados no Banco de Dados.    |
| Critérios de Êxito     |    Acesso ao painel de Perfil de Usuario - Empresa (Usuário Pessoa Jurídica) <br> Comunicação correta entre o Banco de Dados e aplicação.  |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           | 
 
| Caso de Teste      | CT-04 – Teste de funcionalidade de Vagas - Empresa (Usuário Pessoa Jurídica)                  |
|--------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  | RF-008 - O site deve permitir que a empresa possa publicar vagas de trabalho; RF-011 - O site deve exibir vagas de trabalho disponíveis; & RF-004 - O site deve permitir que o usuário demonstre interesse por uma vaga de trabalho publicada e se candidate para a mesma.  |
| Objetivo do Teste      | Verificar se o aplicativo está dando o retorno esperado na barra de busca considerando as palavras chaves dos usuários. Garantir que a candidatura do usuário seja fácil e intuitiva, permitindo que os usuários tenham pelo acesso ao status da sua candidatura                                                               |
| Passos                 | 1) Acessar o site por um navegador. <br> 2) Fazer login de uma empresa. <br>3) Acessar o campo "Publicar Vaga".  <br>4) Preencher os campos: Cargo na Empresa; Salário Oferecido; Carga Horária; Área; Selecionar a data de fechamento da vaga; descrição e local. <br>5) Publicar a Vaga. <br>6) Verificar se a vaga foi publicada com sucesso.                                              |
| Critérios de Êxito     |   A Vaga deve ser publicada com sucesso apresentando todos os campos preenchidos na área de vagas do Site.                                                       |                                      
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                             |                             


| Caso de Teste      | CT-05 – Teste de funcionalidade de Vagas - Candidato (Usuário Pessoa Física)                  |
|--------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  | RF-011 - O site deve exibir vagas de trabalho disponíveis & RF-004 - O site deve permitir que o usuário demonstre interesse por uma vaga de trabalho publicada e se candidate para a mesma.  |
| Objetivo do Teste      | Verificar se o aplicativo está dando o retorno esperado na barra de busca considerando as palavras chaves dos usuários. Garantir que a candidatura do usuário seja fácil e intuitiva, permitindo que os usuários tenham pelo acesso ao status da sua candidatura                                                               |
| Passos                 | 1) Acessar o site por um navegador. <br> 2) Fazer login de usuário Candidato. <br> 4) Acessar a área Vagas. <br> 5) Inserir palavras chaves na barra de pesquisa do site <br>6) Avaliar os resultados da pesquisa <br> 7) Acessar "Ver mais+" para acessar detalhes da vaga. <br> 7) Cadastrar-se na vaga. <br> 8) Verificar se a vaga em questão aparece na lista de "Meus Processos"do usuário logado.                           |
| Critérios de Êxito     |   Deve apresentar resposta rápidas com uma flexibilidade ampla no sistema de pesquisa usando as palavras chaves de cada usuário.                                                       |                                      
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                             |              


| Caso de Teste      | CT-06 – Teste de funcionalidade de geolocalização   |
|--------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |      RF-011; RF-012; RF-13 - Precisão da localização: é importante verificar se a aplicação está fornecendo informações precisas sobre a localização      do usuário e das vagas mais proximas.  |
| Objetivo do Teste      | Verificar se a aplicação está respondendo corretamente a mudanças na localização do usuário..                                                                                                                               |
| Passos                     | 1) Acessar o site por um navegador  <br> 2) Entrar na barra de filtragem <br>  3) selecionar o estado e a cidade desejado                                                                                                    |
| Critérios de Êxito     |   Exibição das vagas mais proximas da localização desejada do usuario.                                                                                                                                                      |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           | 




| Caso de Teste      | CT-07 -   Teste de Segurança                                       |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-01; RF-02; RF-03; RF-06; RF-015 - Criptografia: Garantir que as informações dos usuários, como senhas e dados pessoais, estejam criptografadas e protegidas de possíveis invasões.                                    |
| Objetivo do Teste      |  Verificar todas as brechas de possiveis ataques contra o site visando roubar informações dos usuarios.                                                                                  |
| Passos                     | 1) Analisar o codigo fonte <br> 2) Verificar qual tipo de criptografia esta sendo utilizado no site <br> 3) Realizar testes de penetração <br> 4) Corrigir todas as brechas encontradas   |
| Critérios de Êxito     |   Plena segurança dos dados pessoais dos usuarios.                  |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                  | 




