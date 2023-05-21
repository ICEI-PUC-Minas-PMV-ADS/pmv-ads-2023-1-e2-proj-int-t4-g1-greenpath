# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| Caso de Teste      | CT-01 – Teste de funcionalidade de pesquisa                                                                                                                                    |
|--------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  | RF-011 - Exibição de resultados: o site deve exibir os resultados de pesquisa de maneira clara e fácil de entender, fornecendo informações relevantes sobre os itens encontrados.   |
| Objetivo do Teste      | Verificar se o aplicativo está dando o retorno esperado na barra de busca considerando as palavras chaves dos usuários.                                                                |
| Passos                     | 1) Acessar o site por um navegador <br> 2) Inserir palavras chaves na barra de pesquisa do site <br>3) Avaliar os resultados da pesquisa                                               |
| Critérios de Êxito     |   Deve apresentar resposta rápidas com uma flexibilidade ampla no sistema de pesquisa usando as palavras chaves de cada usuário.                                                       |                                      
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           |                             

| Caso de Teste      | CT-02 –  Teste de funcionalidade de filtragem                                                                                                                                                                                            |
|--------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-012, RF-013 - Personalização: o site deve permitir que os usuários personalizem suas preferências de filtragem e salve-as para uso futuro.                                                                                                    |
| Objetivo do Teste      | Garantir que a filtragem de dados esteja funcionando corretamente atendendo as expectativas do usuário.                                                                                                                                          |
| Passos                     |  1)Acessar o site por um navegador. <br> 2) Localizar a opção de filtragem perto da barra de pesquisa. <br>  3) Selecionar algumas das opções de filtragem disponibilizadas pelo site.  <br> 4) Observar e avaliar os resultados exibidos.   |
| Critérios de Êxito     |   Deve apresentar diversas opções de filtragem para o usuário; exibir resultados rápidos e precisos.                                                                                                                                             |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           | 

| Caso de Teste      | CT-03 – Teste de funcionalidade de candidatura                                                                                                                                                                                                                                               |
|--------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  | RF-04; RF-05 - Facilidade de uso: o processo de candidatura deve ser fácil de usar e intuitivo, permitindo que os usuários enviem sua candidatura sem esforço e que permita que os usuários acompanhem o status de sua candidatura, fornecendo informações sobre o andamento do processo de seleção.    |
| Objetivo do Teste      | Garantir que a candidatura do usuário seja fácil e intuitiva, permitindo que os usuários tenham pelo acesso ao status da sua candidatura e que se comuniquem e recebam feedbacks das empresas contratantes.                                                                                              |
| Passos                     | 1)Acessar o site por um navegador <br> 2)Navegar pelo site <br>  3)Ir na opção de cadastramento e inserir todas as informações pessoais <br> 4)Aplicar para as vagas disponíveis                                                                                                                           |
| Critérios de Êxito     |   O site deve apresentar um sistema de cadastramento fácil dando espaço para conter todas as informações pessoais e até anexo e ter uma facilidade de comunicação entre candidato e empresa.                                                                                 |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           | 


| Caso de Teste      | CT-04 – Teste de funcionalidade de geolocalização                                                                                                                                                                   |
|--------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |      RF-011; RF-012; RF-13 - Precisão da localização: é importante verificar se a aplicação está fornecendo informações precisas sobre a localização      do usuário e das vagas mais proximas.  |
| Objetivo do Teste      | Verificar se a aplicação está respondendo corretamente a mudanças na localização do usuário..                                                                                                                               |
| Passos                     | 1) Acessar o site por um navegador  <br> 2) Entrar na barra de filtragem <br>  3) selecionar o estado e a cidade desejado                                                                                                    |
| Critérios de Êxito     |   Exibição das vagas mais proximas da localização desejada do usuario.                                                                                                                                                      |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           | 


| Caso de Teste      | CT-05 -   Teste de Segurança                                                                                                                                                     |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-01; RF-02; RF-03; RF-06; RF-015 - Criptografia: Garantir que as informações dos usuários, como senhas e dados pessoais, estejam criptografadas e protegidas de possíveis invasões.                                    |
| Objetivo do Teste      |  Verificar todas as brechas de possiveis ataques contra o site visando roubar informações dos usuarios.                                                                                  |
| Passos                     | 1) Analisar o codigo fonte <br> 2) Verificar qual tipo de criptografia esta sendo utilizado no site <br> 3) Realizar testes de penetração <br> 4) Corrigir todas as brechas encontradas   |
| Critérios de Êxito     |   Plena segurança dos dados pessoais dos usuarios.                  |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           | 


| Caso de Teste      | CT-06 -      Teste de Avaliação e Ranking das Empresas                                                                                                                                                |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-014 O site possibilitar a avaliação do Usuario sobre a empresa interessada e a visualização do Ranking da mesma em relação a outras empresas.                                    |
| Objetivo do Teste      |  Verificar se o Usuario consegue visualizar todas as avaliações de candidatos e contratados no passado da empresa interessada.                                                                                  |
| Passos                     | 1) Acessar o site <br> 2) Realizar login <br> 3) Pesquisar e selecionar uma empresa <br> 4) Acessar a o historico de avaliações <br> 5) Ver a colocação da empresa no Ranking Universal.    |
| Critérios de Êxito     |   Exebição do historico de avaliçoes e possibilidade de avaliar a empresa <br>Exibição da colocação da empresa no Ranking.  |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           | 

| Caso de Teste      | CT-07 -      Teste do Processo Seletivo                                                                                                                                                 |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-010 O site deve exibir o andamento do processo seletivo da vaga publicada pela empresa .                                    |
| Objetivo do Teste      |  Verificar se o Usuario tem acesso ao processo seletivo da vaga aplicada.                                                                                  |
| Passos                     | 1) Acessar o site <br> 2) Realizar login <br> 3) Ir em configuraçoes( Candidaturas)<br> 4) Selecionar o processo seletivo da empresa que aplicou.    |
| Critérios de Êxito     |    Visualização de todo o andamento do processo seletivo da vaga.  |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           | 

| Caso de Teste      | CT-08 -      Teste de Login e Cadastramento de Usuarios/Empresa                                                                                                                                                 |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-01; RF-02; RF-03; RF-06; RF-015 -  O site deve exercer a possibilidade de login e cadastro de novos usuarios.                                    |
| Objetivo do Teste      | Verificar se o login de usuarios/empresa ja cadastrados e se o cadastramento de novos usuarios/empresas estão funcionando corretamente.                                                                                  |
| Passos                     | 1) Acessar o site  <br>2) Fazer o cadastro (Novo Usuario/Empresa) ou Realizar o Login se ja houver o cadastro existente.  <br>3) Verificar a validação das informações <br>4) Permitir o acesso e realizar o Logout.    |
| Critérios de Êxito     |    Acesso ao painel de Usuario/Empresa <br> Comunicação correta entre o Banco de Dados e aplicação.  |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           | 




> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
