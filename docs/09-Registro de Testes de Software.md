# Registro de Testes de Software

| Caso de Teste      | CT-01 -  Teste de Login de Usuarios (Candidato ou Empresa)                                                                                |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-02; RF-07 -  O site deve permitir o login ao usuário e permitir o login da empresa.                                    |
| Objetivo do Teste      | Verificar se o login de usuarios Candidatos e Empresa ja cadastrados no Banco de Dados é realizado com sucesso.            |
| Passos                 | 1) Acessar o site https://greenpath.azurewebsites.net/ <br>2) Realizar o Login se ja houver o cadastro existente.  <br>3) Verificar a validação das informações <br>4) Permitir o acesso e verificar dados no Banco de Dados.   |
| Critérios de Êxito     | Acesso ao painel de Usuario <br> Comunicação correta entre o Banco de Dados e aplicação.  |
| Dados de entrada   | 1) Acesso ao site https://greenpath.azurewebsites.net/ com sucesso, <br>2) Acesso ao campo "Entre" direciona com sucesso à área de Login <br>3)  Utilizando os dados de acesso já registrados UserName: teste111@yahoo.com.br Senha: Green3421#@!77 <br>4) Os dados foram verificados no sucesso pelo Banco de Dados.                                 | 
| Resultado Obtido   |   Foi garantido com sucesso o acesso ao perfíl do usuário teste111@yahoo.com.br         |         

## Login do usuário com sucesso - Candidato (Pessoa Física)

![Teste 1 Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/d357336066a60178ebd055b5918b1380acf9e4e6/docs/img/Teste01_login.gif)

## Login do usuário com sucesso - Empresa (Pessoa Jurídica)

![Teste 1 Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/523e4e64a4306075a4e045eabdba1839ca04667e/docs/img/Teste01_login_EmpresaPJ.gif)

## Login do usuário sem sucesso - dados incorretos

![Teste 1 Sem Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/c5393a46da86137d1545cca06370d95bdd030a93/docs/img/Teste01_login_incorreto.gif)

| Caso de Teste      | CT-02 - Registro de Novo Usuario - Candidato (Usuário Pessoa Física)                                                                                |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-01 - O site deve permitir que o usuário crie o seu perfil.                                    |
| Objetivo do Teste      | Verificar se os campos de entrada de dados do Perfíl de usuarios Candidatos estão funcionando corretamente e alimentando o Banco de Dados.            |
| Passos                 | 1) Acessar o site https://greenpath.azurewebsites.net/ <br>2) Fazer o cadastro (Novo Usuario) e Cadastrar as demais informações do Perfíl de usuário Pessoa Física (CPF).  <br>3) Verificar a validação das informações <br>4) Permitir o acesso e verificar dados no Banco de Dados.   |
| Critérios de Êxito     | Acesso ao painel de Perfil de Usuario - Candidato (Usuário Pessoa Física) <br> Comunicação correta entre o Banco de Dados e aplicação.  |
| Dados de entrada   | 1) Acesso ao site https://greenpath.azurewebsites.net/ com sucesso, <br>2) Acesso ao campo "Cadastre-se" direciona com sucesso à área de Criar novo Cadastro <br>3)  Utilizando os dados de acesso UserName: teste333@hotmail.com Senha: Green3421#@!77 <br>4) Os dados foram cadastrados com sucesso no Banco de Dados. <br>5) Seleção "Candidato" feita com sucesso. <br>6) Dados foram inseridos nos campos: Nome; Sobrenome; Profissão; Curriculo; CPF; Email de Contato; Telefone; País; Estado; Cidade; Rua; e links para Instagram, Facebook, Github e Pinterest - todos inseridos com sucesso.                                  | 
| Resultado Obtido   |   Foi garantido com sucesso a criação do novo usuário Candidato na tabela dbo.Pessoa_Fisica do Banco de Dados e todos os campos preenchidos apresentados nesta tabela para o perfíl do usuário teste333@hotmail.com.         |         

## Registro de Novo Usuario com Sucesso - Candidato (Usuário Pessoa Física)

![Teste 2 Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/f275707ef0dd72a6364988596e94b645c6c1bae7/docs/img/Teste02_cadastro_PF.gif)


| Caso de Teste      | CT-03 - Registro de Novo Usuario - Empresa (Usuário Pessoa Jurídica)                                                                                |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-06 -  O site deve permitir que o usuário Empresa crie o seu perfil.                                    |
| Objetivo do Teste      | Verificar se os campos de entrada de dados do Perfíl de usuarios Empresas estão funcionando corretamente e alimentando o Banco de Dados.            |
| Passos                 | 1) Acessar o site https://greenpath.azurewebsites.net/ <br>2) Fazer o cadastro (Novo Usuario) e Cadastrar as demais informações do Perfíl de usuário Pessoa Jurídica (CNPJ).  <br>3) Verificar a validação das informações <br>4) Permitir o acesso e verificar dados no Banco de Dados.   |
| Critérios de Êxito     | Acesso ao painel de Perfil de Usuario - Empresa (Usuário Pessoa Jurídica) <br> Comunicação correta entre o Banco de Dados e aplicação.  |
| Dados de entrada   | 1) Acesso ao site https://greenpath.azurewebsites.net/ com sucesso, <br>2) Acesso ao campo "Cadastre-se" direciona com sucesso à área de Criar novo Cadastro <br>3)  Utilizando os dados de acesso UserName: testeEmpresa22@gmail.com Senha: Green3421#@!77 <br>4) Os dados foram cadastrados com sucesso no Banco de Dados. <br>5) Seleção "Empresa" feita com sucesso abre o ficheiro com os campos para usuário Empresa. <br>6) Dados foram inseridos nos campos: Razão Social; CNPJ; Área de Atuação; Seletor de Certificações; Email de Contato; Telefone; País; Estado; Cidade; Rua; e links para Instagram, Facebook, Github e Pinterest - todos inseridos com sucesso.                                  | 
| Resultado Obtido   |   Foi garantido com sucesso a criação do novo usuário Empresa na tabela dbo.Pessoa_Juri do Banco de Dados e todos os campos preenchidos apresentados nesta tabela para o perfíl do usuário testeEmpresa22@gmail.com.         |         

## Registro de Novo Usuario com Sucesso - Candidato (Usuário Pessoa Física) 

![Teste 3 Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/209c54f68321c5b90bca01089a6c86d686f3b188/docs/img/Teste03_cadastro_PJ.gif)

## Registro de Novo Usuario sem Sucesso - PK Chave Primária já cadastrada no BD 

![Teste 3 sem Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/5546c7acbb702314d9458d5723b2ad0acbedcf49/docs/img/Teste02_cadastro_sem_Sucesso_PK.gif)


| Caso de Teste      | CT-04 – Teste de funcionalidade de Vagas - Empresa (Usuário Pessoa Jurídica)                  |
|--------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  | RF-008 - O site deve permitir que a empresa possa publicar vagas de trabalho; RF-011 - O site deve exibir vagas de trabalho disponíveis; & RF-004 - O site deve permitir que o usuário demonstre interesse por uma vaga de trabalho publicada e se candidate para a mesma.  |
| Objetivo do Teste      | Verificar se o aplicativo está dando o retorno esperado na barra de busca considerando as palavras chaves dos usuários. Garantir que a candidatura do usuário seja fácil e intuitiva, permitindo que os usuários tenham pelo acesso ao status da sua candidatura                                                               |
| Passos                 | 1) Acessar o site por um navegador. <br> 2) Fazer login de uma empresa. <br>3) Acessar o campo "Publicar Vaga".  <br>4) Preencher os campos: Cargo na Empresa; Salário Oferecido; Carga Horária; Área; Selecionar a data de fechamento da vaga; descrição e local. <br>5) Publicar a Vaga. <br>6) Verificar se a vaga foi publicada com sucesso.                                              |
| Critérios de Êxito     |   A Vaga deve ser publicada com sucesso apresentando todos os campos preenchidos na área de vagas do Site.                                                       |                                      
| Dados de entrada   |  1) Acesso ao site https://greenpath.azurewebsites.net/ com sucesso, <br>2) Login de Empresa garantido com sucesso utilizando os dados de acesso UserName: testeEmpresa22@gmail.com Senha: Green3421#@!77  <br>3) Acesso ao campo "Publicar Vaga" redireciona para o ficheiro de cadastro de vaga para uma empresa.  <br>4) Preenchidos todos os campos que seguem com sucesso: Cargo na Empresa; Salário Oferecido; Carga Horária; Área; Selecionar a data de fechamento da vaga; descrição e local. <br>5) Publicar a Vaga. <br>6) Vaga verificada em publicaãço na área de vagas     | 
| Resultado Obtido   | Todo o processo desde o login com dados pré cadastrados de uma empresa, até a publicação de todos os dados referentes à vaga e a posterior verificação da vaga pubicada foram realizadas e verificadas com sucesso.    |     


## Registro de Nova Vaga de Trabalho - Usuario Empresa (Pessoa Jurídica) 

![Teste 4 Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/aff155bf660a2c966b605c81bd54f02ddc550f2a/docs/img/Teste04_vaga_PJ.gif)

| Caso de Teste      | CT-05 – Teste de funcionalidade de Vagas - Candidato (Usuário Pessoa Física)                  |
|--------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  | RF-011 - O site deve exibir vagas de trabalho disponíveis & RF-004 - O site deve permitir que o usuário demonstre interesse por uma vaga de trabalho publicada e se candidate para a mesma.  |
| Objetivo do Teste      | Verificar se o aplicativo está dando o retorno esperado na barra de busca considerando as palavras chaves dos usuários. Garantir que a candidatura do usuário seja fácil e intuitiva, permitindo que os usuários tenham pelo acesso ao status da sua candidatura                                                               |
| Passos                 | 1) Acessar o site por um navegador. <br> 2) Fazer login de usuário Candidato. <br> 4) Acessar a área Vagas. <br> 5) Inserir palavras chaves na barra de pesquisa do site <br>6) Avaliar os resultados da pesquisa <br> 7) Acessar "Ver mais+" para acessar detalhes da vaga. <br> 7) Cadastrar-se na vaga. <br> 8) Verificar se a vaga em questão aparece na lista de "Meus Processos"do usuário logado.                           |
| Critérios de Êxito     |   Deve apresentar resposta rápidas com uma flexibilidade ampla no sistema de pesquisa usando as palavras chaves de cada usuário.                                                       |                                      
| Dados de entrada   | 1) Acesso ao site https://greenpath.azurewebsites.net/ com sucesso, <br>2) Login de Candidato garantido com sucesso utilizando os dados de acesso UserName: teste111@yahoo.com.br Senha: Green3421#@!77  <br>3) Acesso ao campo "Vagas" redireciona para o ficheiro de vagas e busca de vagas disponíveis para os Candidatos.  <br>4) Acessar "Ver mais+" para acessar detalhes da vaga com sucesso. <br>5) Foi verificado que para uma vaga que o candidato já esta cadastrado o botão "Cadastrar-se" não é apresentado. <br>6) Em detalhes de outra vaga que o Candidato não esta cadastrado foi possível cadastrar-se com sucesso. <br>7) Na lista "Meus Processos" foram verificadas ambas as vagas que o Candidato esta cadastrado.              | 
| Resultado Obtido   |  Todo o processo desde o login com dados pré cadastrados de um Candidato, processo de busca de vagas, disponibilidade para cadastrar-se na vaga e indexação da vaga ao perfíl do Candidato foram verificadas com sucesso. Sendo ainda um processo simples e intuitivo.                     |              

![Teste 5 Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/01719b3511fa48cdfaf541903cc1ddc4ed4bf6a8/docs/img/Teste05_vaga_PF.gif)

| Caso de Teste      | CT-06 – Teste de funcionalidade de geolocalização   |
|--------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |      RF-011; RF-012; RF-13 - Precisão da localização: é importante verificar se a aplicação está fornecendo informações precisas sobre a localização      do usuário e das vagas mais proximas.  |
| Objetivo do Teste      | Verificar se a aplicação está respondendo corretamente a mudanças na localização do usuário..                                                                                                                               |
| Passos                     | 1) Acessar o site por um navegador  <br> 2) Entrar na barra de filtragem <br>  3) selecionar o estado e a cidade desejado                                                                                                    |
| Critérios de Êxito     |   Exibição das vagas mais proximas da localização desejada do usuario.                                                                                                                                                      |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |  Não foi possível realizar o teste, pois, os filtros dos sistemas de busca ainda estão em desenvolvimento.                                    | 

| Caso de Teste      | CT-07 -   Teste de Segurança                                       |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-01; RF-02; RF-03; RF-06; RF-015 - Criptografia: Garantir que as informações dos usuários, como senhas e dados pessoais, estejam criptografadas e protegidas de possíveis invasões.                                    |
| Objetivo do Teste      |  Verificar todas as brechas de possiveis ataques contra o site visando roubar informações dos usuarios.                                                                                  |
| Passos                     | 1) Analisar o codigo fonte <br> 2) Verificar qual tipo de criptografia esta sendo utilizado no site <br> 3) Realizar testes de penetração <br> 4) Corrigir todas as brechas encontradas   |
| Critérios de Êxito     |   Plena segurança dos dados pessoais dos usuarios.                  |
| Dados de entrada   |   https://greenpath.azurewebsites.net/                                   | 
| Resultado Obtido   | O Site obteve ótimos resultados de Segurança através de testes automatizados de renomadas empresas. Abaixo são demonstrados os resultados.     | 

## Teste Automatizado de Segurança com Wormly
O Web Server Tester by Wormly verifica mais de 65 métricas e fornece um status de cada uma, incluindo pontuações gerais. O relatório contém uma visão geral do certificado (CN, detalhes da expiração, cadeia de confiança), detalhes das Cifras de Criptografia, tamanho da chave pública, renegociação segura, protocolos como SSLv3 / v2, TLSv1 / 1.2. 

https://www.wormly.com/test_ssl/h/greenpath.azurewebsites.net/i/20.206.176.4/p/443

![Teste 7 Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/351ef1ec6b584655965885c28df7599b3d7fe347/docs/img/Teste07_Seguranca.gif)

## Teste Automatizado de Segurança com Mozilla Observatory
O Observatory by Mozilla verifica várias métricas, como detalhes da cifra TLS, detalhes do certificado, cabeçalhos seguros recomendados pela OWASP e muito mais.

Ele também tem uma opção para mostrar resultados de varredura de terceiros dos SSL Labs, ImmuniWeb, Pré-carregamento HSTS, Cabeçalhos seguros e CryptCheck.

https://observatory.mozilla.org/analyze/greenpath.azurewebsites.net

![Teste 7 Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/351ef1ec6b584655965885c28df7599b3d7fe347/docs/img/Teste07_Mozila_Sguranca.png)

## Teste Automatizado de Segurança com Sucuri SiteCheker

https://sitecheck.sucuri.net/results/https/greenpath.azurewebsites.net

![Teste 7 Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/351ef1ec6b584655965885c28df7599b3d7fe347/docs/img/Teste07_Sukuri_Seguranca.png)
