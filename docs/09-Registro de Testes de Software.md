# Registro de Testes de Software

## Login do usuário com sucesso 


| Caso de Teste      | CT-01 -  Teste de Login de Usuarios (Candidato ou Empresa)                                                                                |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-02; RF-07 -  O site deve permitir o login ao usuário e permitir o login da empresa.                                    |
| Objetivo do Teste      | Verificar se o login de usuarios Candidatos e Empresa ja cadastrados no Banco de Dados é realizado com sucesso.            |
| Passos                 | 1) Acessar o site https://greenpath.azurewebsites.net/ <br>2) Realizar o Login se ja houver o cadastro existente.  <br>3) Verificar a validação das informações <br>4) Permitir o acesso e verificar dados no Banco de Dados.   |
| Critérios de Êxito     | Acesso ao painel de Usuario <br> Comunicação correta entre o Banco de Dados e aplicação.  |
| Dados de entrada   | 1) Acesso ao site https://greenpath.azurewebsites.net/ com sucesso, <br>2) Acesso ao campo "Entre" direciona com sucesso à área de Login <br>3)  Utilizando os dados de acesso já registrados UserName: teste111@yahoo.com.br <br>4) Senha: Green3421#@!77                                 | 
| Resultado Obtido   |   Foi garantido com sucesso o acesso ao perfíl do usuário teste111@yahoo.com.br         |         


![Teste 1 Sucesso](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/d357336066a60178ebd055b5918b1380acf9e4e6/docs/img/Teste01_login.gif)


