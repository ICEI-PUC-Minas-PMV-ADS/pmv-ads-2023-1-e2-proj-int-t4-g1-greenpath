# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:
 
| <br><br><br><br><br><br>Caso de Teste      | <br><br><br><br>CT-01 – Teste de funcionalidade de pesquisa                                                                                                                                    |
|--------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| <br><br><br><br>Requisitos <br>Associados  | <br><br>RF-01 - Exibição de resultados: o site deve exibir os resultados de pesquisa de maneira clara e fácil de entender, fornecendo informações relevantes sobre os itens encontrados. <br>  |
| <br><br><br><br>Objetivo do <br>Teste      | <br><br>Verificar se o aplicativo está dando o retorno esperado na barra de busca considerando as palavras chaves dos usuários.                                                                |
| <br><br><br><br>Passos                     | <br><br>1) Acessar o site por um navegador  <br>2) Inserir palavras chaves na barra de pesquisa do site <br>3) Avaliar os resultados da pesquisa                                               |
| <br><br><br><br>Critérios de <br>Êxito     | <br><br>  Deve apresentar resposta rápidas com uma flexibilidade ampla no sistema de pesquisa usando as palavras chaves de cada usuário.                                                       |

| <br><br><br><br><br><br>Caso de Teste      | <br><br><br><br>CT-02 –  Teste de funcionalidade de filtragem                                                                                                                                                                                            |
|--------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| <br><br><br><br>Requisitos <br>Associados  | <br><br> RF-01 - Personalização: o site deve permitir que os usuários personalizem suas preferências de filtragem e salve-as para uso futuro. <br> <br>                                                                                                  |
| <br><br><br><br>Objetivo do <br>Teste      | <br><br>Garantir que a filtragem de dados esteja funcionando corretamente atendendo as expectativas do usuário.                                                                                                                                          |
| <br><br><br><br>Passos                     | <br><br> 1)Acessar o site por um navegador. <br> 2) Localizar a opção de filtragem perto da barra de pesquisa. <br>  3) Selecionar algumas das opções de filtragem disponibilizadas pelo site. <br>  4) Observar e avaliar os resultados exibidos. <br>  |
| <br><br><br><br>Critérios de <br>Êxito     | <br><br>  Deve apresentar diversas opções de filtragem para o usuário; exibir resultados rápidos e precisos.                                                                                                                                             |

| <br><br><br><br><br><br>Caso de Teste      | <br><br><br><br>CT-03 – Teste de funcionalidade de candidatura  <br>                                                                                                                                                                                                                                             |
|--------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| <br><br><br><br>Requisitos <br>Associados  | <br><br>RF-01 - Facilidade de uso: o processo de candidatura deve ser fácil de usar e intuitivo, permitindo que os usuários enviem sua candidatura sem esforço e que permita que os usuários acompanhem o status de sua candidatura, fornecendo informações sobre o andamento do processo de seleção. <br> <br>  |
| <br><br><br><br>Objetivo do <br>Teste      | <br><br>Garantir que a candidatura do usuário seja fácil e intuitiva, permitindo que os usuários tenham pelo acesso ao status da sua candidatura e que se comuniquem e recebam feedbacks das empresas contratantes.                                                                                              |
| <br><br><br><br>Passos                     | <br><br>1)Acessar o site por um navegador  <br>2)Navegar pelo site  <br>3)Ir na opção de cadastramento e inserir todas as informações pessoais <br>4)Aplicar para as vagas disponíveis                                                                                                                           |
| <br><br><br><br>Critérios de <br>Êxito     | <br><br>  O site deve apresentar um sistema de cadastramento fácil dando espaço para conter todas as informações pessoais e até anexo; facilidade de comunicação entre candidato e empresa.                                                                                                                      |

| <br><br><br><br><br><br>Caso de Teste      | <br><br><br><br>CT-04 – Teste de funcionalidade de geolocalização                                                                                                                                                                   |
|--------------------------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| <br><br><br><br>Requisitos <br>Associados  | <br><br>                      RF-01 - Precisão da localização: é importante verificar se a                           aplicação está fornecendo informações precisas sobre a localização      do usuário e das vagas mais proximas.  |
| <br><br><br><br>Objetivo do <br>Teste      | <br><br>Verificar se a aplicação está respondendo corretamente a mudanças na localização do usuário..                                                                                                                               |
| <br><br><br><br>Passos                     | <br><br>1) Acessar o site por um navegador  <br>2) Entrar na barra de filtragem  <br> 3) selecionar o estado e a cidade desejado                                                                                                    |
| <br><br><br><br>Critérios de <br>Êxito     | <br><br>  Exibição das vagas mais proximas da localização desejada do usuario.                                                                                                                                                      |

| <br><br><br><br><br><br>Caso de Teste      | <br><br><br><br>CT-05 - Teste de Usabilidade                                                                                                                                                                 |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| <br><br><br><br>Requisitos <br>Associados  | <br><br> RF-01 -  Consistência da interface: a interface do site deve ser consistente em todo o site, com o uso de cores e fontes consistentes, e uma estrutura de navegação lógica e fácil de seguir. <br>  |
| <br><br><br><br>Objetivo do <br>Teste      | <br><br>Garantir uma navegação facil e simples para o usuario.                                                                                                                                               |
| <br><br><br><br>Passos                     | <br><br>1)Acessar o site por um navegador  <br>2)Navegar por todo site  <br>3)Testar todas suas funcionalidades                                                                                              |
| <br><br><br><br>Critérios de <br>Êxito     | <br><br>  O funcionamento de todo o site e suas funcionalidades em 100% , sem erros.                                                                                                                         |

| <br><br><br><br><br><br>Caso de Teste      | <br><br><br><br>CT-06 -   Teste de Segurança                                                                                                                                                     |
|--------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| <br><br><br><br>Requisitos <br>Associados  | <br><br> Criptografia: Garantir que as informações dos usuários, como senhas e dados pessoais, estejam criptografadas e protegidas de possíveis invasões. <br>                                   |
| <br><br><br><br>Objetivo do <br>Teste      | <br><br> Verificar todas as brechas de possiveis ataques contra o site visando roubar informações dos usuarios.                                                                                  |
| <br><br><br><br>Passos                     | <br><br>1) Analisar o codigo fonte  <br>2) Verificar qual tipo de criptografia esta sendo utilizado no site  <br>3) Realizar testes de penetração <br>4) Corrigir todas as brechas encontradas   |
| <br><br><br><br>Critérios de <br>Êxito     | <br><br>  Plena segurança dos dados pessoais dos usuarios.                                                                                                                                       |





> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
