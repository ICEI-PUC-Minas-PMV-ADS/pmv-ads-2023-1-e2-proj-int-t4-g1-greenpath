# Registro de Testes de Software

| Caso de Teste      | CT-01 -  Teste de Login de Usuarios (Candidato ou Empresa)                                                                                |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-02; RF-07 -  O site deve permitir o login ao usuário e permitir o login da empresa.                                    |
| Objetivo do Teste      | Verificar se o login de usuarios Candidatos e Empresa ja cadastrados no Banco de Dados é realizado com sucesso.            |
| Passos                 | 1) Acessar o site https://greenpath.azurewebsites.net/ <br>2) Realizar o Login se ja houver o cadastro existente.  <br>3) Verificar a validação das informações <br>4) Permitir o acesso e verificar dados no Banco de Dados.   |
| Critérios de Êxito     | Acesso ao painel de Usuario <br> Comunicação correta entre o Banco de Dados e aplicação.  |
| Dados de entrada   | 1) Acesso ao site https://greenpath.azurewebsites.net/ com sucesso, <br>2) Acesso ao campo "Entre" direciona com sucesso à área de Login <br>3)  Utilizando os dados de acesso já registrados UserName: teste111@yahoo.com.br Senha: Green3421#@!77 <br>4) Os dados foram verificados no sucesso pelo Banco de Dados.                                 | 
| Resultado Obtido   |   Foi garantido com sucesso o acesso ao perfíl do usuário teste111@yahoo.com.br         |         

## Login do usuário com sucesso 

![Teste 1 Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/d357336066a60178ebd055b5918b1380acf9e4e6/docs/img/Teste01_login.gif)


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




