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

| ###Caso de Teste      | ###CT-01 -      Teste de Login e Cadastramento de Usuarios/Empresa                                                                                                                                                 |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  |  RF-01; RF-02; RF-03; RF-015 -  O site deve exercer a possibilidade de login e cadastro de novos usuarios.                                    |
| Objetivo do Teste      | Verificar se o login de usuarios/empresa ja cadastrados e se o cadastramento de novos usuarios/empresas estão funcionando corretamente.                                                                                  |
| Passos                 | 1) Acessar o site  <br>2) Fazer o cadastro (Novo Usuario/Empresa) e Realizar o Login se ja houver o cadastro existente.  <br>3) Verificar a validação das informações <br>4) Permitir o acesso e realizar o Logout.    |
| Critérios de Êxito     |    Acesso ao painel de Usuario/Empresa <br> Comunicação correta entre o Banco de Dados e aplicação.  |
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           | 
 
 
| ###Caso de Teste      | ###CT-02 – Teste de funcionalidade de pesquisa de Vagas                                                                                                                                    |
|--------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Requisitos Associados  | RF-011 - Exibição de resultados: o site deve exibir os resultados de pesquisa de maneira clara e fácil de entender, fornecendo informações relevantes sobre os itens encontrados.   |
| Objetivo do Teste      | Verificar se o aplicativo está dando o retorno esperado na barra de busca considerando as palavras chaves dos usuários.                                                                |
| Passos                 | 1) Acessar o site por um navegador <br> 2) Inserir palavras chaves na barra de pesquisa do site <br>3) Avaliar os resultados da pesquisa                                               |
| Critérios de Êxito     |   Deve apresentar resposta rápidas com uma flexibilidade ampla no sistema de pesquisa usando as palavras chaves de cada usuário.                                                       |                                      
| Dados de entrada   |                                                                                                                                                                                                             | 
| Resultado Obtido   |                                                                                                                                                                                                           |                             


| ###Caso de Teste      | ###CT-03 – Teste de funcionalidade de candidatura em uma Vaga Disponível                                                                                                                                                                                                                                               |
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



