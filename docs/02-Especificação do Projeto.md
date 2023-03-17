# Especificações do Projeto

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

## Personas

+ ### Raquel Campos
	![Foto representativa]([docs/img/Persona_01.jpg](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-1-e2-proj-int-t4-g1-greenpath/blob/89ba4c5a0d69d57e0b95a7a99489d2b7df1f3f61/docs/img/Persona_01.jpg)

	+ **Idade**: 34 anos

  + **Situação Atual**:
  Desempregada

	+ **Ocupação**:  
	Engenheira de Minas e Energia, ex-funcionária da empresa Samarco.

	+ **Aplicativos**:  
Linkedin; Glassdoor; Gupy

	+ **Motivações**:  
		+ Aplicar os conhecimentos técnicos que adquiriu na vida na construção sustentável de empresas que se responsabilizam pela sociedade e pelo meio ambiente.

	+ **Frustrações**:  
		+ Trabalhava na empresa Samarco quando houve o rompimento das barragens em Mariana e Bento Rodrigues.
    + Sente-se parcialmente responsável pelo rompimento das barragens, apesar de não ter tido acesso a informações específicas.

	+ **Hobbies, História**:  
		+ Ambientalista
    + Gosta de trilhas e de acampar na natureza
    + Ativista do grupo WWF - Word Wide Fund for Nature




## Histórias de Usuários

Partindo das informações que as Personas apresentaram, chegou-se à conclusão das seguintes histórias de usuário relevantes ao problema identificado.

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Anderson Rodrigues  | Encontrar com facilidade empresas que oferecem vagas na área profissional que eu atuo. | Ingressar no mercado de trabalho.               |
|Fernanda Vasconcelos  | Ter um perfil de usuário que permite anexar Carta de Recomendação e CV em formatos padrão. Pode ser um formato personalizado ou formato padrão internacional (Ex: Europeu, Canadense, EUA, Carta de Apresentação, etc..).           | Aumentar as chances de uma empresa internacional analisar corretamente meu CV. Aumentar as chances de "robôs" de busca usados por HeadHunters alcançarem meu CV.               |
|Abilio Junior  | Encontrar com facilidade empresas que oferecem vagas na área profissional que eu atuo e que estejam alinhadas com valores socioambientais que eu tenho.         | Aumentar o engajamento com a empresa e melhorar as chances de um longo plano de carreira.               |
|Raquel Campos  | Ter maior credibilidade nas informações publicadas sobre uma empresa e avaliações reais de funcionários, tudo em um mesmo ambiente de internet.         | Dedicar-se e engajar-se a longo prazo com um plano de carreira em uma empresa sólida e coerente com os valores sociais e ambientais.               |
|Antonio Gomes da Empresa AG&F.  | Alcançar os melhores profissionais do mercado e que estes profissionais tenham engajamento com os valores da empresa.  | Reduzir custos relativos à alta rotatividade de profissionais (processos seletivos, desligamentos, contratações e treinamentos).  |
|Suzana Silva da Empresa Natur.  | Alcançar posição dentro do Top-5 das melhores empresas na opinião dos funcionários e ex-funcionários. | Acredita que o crescimento sustentável de uma empresa depende da satisfação e engajamento do seu corpo funcional. Por isto, projeta o modelo de negócios centralizado na satisfação do funcionário.             |
|Suzana Silva da Empresa Natur.  | Garantir a preservação da natureza e o uso sustentável de recursos naturais necessários para as linhas de produção dos produtos de sua empresa. | Necessita de equilíbrio sustentável na extração de elementos naturais do meio ambiente para a produção contínua de seus produtos.           


## Requisitos

Os requisitos de um projeto são suas pretensões e necessidades. De maneira geral, os requisitos de um projeto são propriedades que refletem as utilidades e funcionalidades do projeto, expectativas de seus criadores e buscam atender a necessidade de seus futuros usuários. Os requisitos são parte fundamental na estruturação de um projeto de software, são utilizados como abstrações de recursos e aplicabilidades, ajudando na formação de um projeto sólido criando propósitos bem definidos e objetivos claros. 

### Requisitos Funcionais

A ideia de requisito funcional vem de requisitos que atendem funcionalidades. Os requisitos funcionais são ações apresentadas pelo projeto criadas para atenderem seus requisitos.

A tabela a seguir apresenta a lista de requisitos funcionais deste projeto, ordenando-os por prioridade:

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| O Sistema permite que o usuário crie um perfil. | ALTA | 
|RF-002| O Sistema Permite o login ao usuário.   | ALTA |
|RF-003| O Sistema Permite que o usuário anexe arquivos pdf (cv e cartas de recomendação, intenção). | MÉDIA | 
|RF-004| O Sistema permite que o usuário demonstre interesse por uma vaga de trabalho publicada.  | ALTA |
|RF-005| O Sistema permite que o usuário demonstre interesse por uma empresa. | MÉDIA | 
|RF-006| O Sistema permite que a empresa crie um perfil.   | ALTA |
|RF-007| O Sistema permite o login da empresa. | ALTA | 
|RF-008| O Sistema permite que a empresa possa publicar vagas de trabalho.   | ALTA |
|RF-009| O Sistema permite comunicação entre empresa e usuário. | MÉDIA | 
|RF-010| O Sistema permite que o usuários compartilhe informações sobre o andamento de um processo seletivo de uma vaga de trabalho publicada.   | MÉDIA |
|RF-011| O Sistema exibe vagas de trabalho disponíveis. | ALTA | 
|RF-012| O Sistema filtra as vagas disponíveis por segmento profissional, ranking, avaliação de usuário, senioridade de responsabilidade social/sustentabilidade.  | ALTA |
|RF-013| O Sistema filtra empresas por segmento profissional, ranking, avaliação de usuário, senioridade de responsabilidade social/sustentabilidade. | ALTA | 
|RF-014| O Sistema permite que o usuário faça a avaliação e ranking de uma empresa.   | ALTA |
|RF-015| O Sistema conta com um mecanismo de selos, onde é possível a empresa ter selos em seu perfil representando quais comprovações de responsabilidade social, ambiental e/ou sustentabilidade, ela possui. | MÉDIA | 

### Requisitos não Funcionais

“A forma como o sistema fará para executar um requisito funcional”, esta é normalmente a definição de requisito não funcional. De forma mais ampla, os requisitos não funcionais são funcionalidades que não podem ser atendidas por requisitos funcionais.

A tabela a seguir apresenta a lista de requisitos não funcionais deste projeto, pontuando sua prioridade.

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O site deverá ser responsivo, permitindo a visualização em diversos dispositivos de forma adequada. | ALTA | 
|RNF-002| O site deve impossibilitar que as senhas dos usuários sejam visíveis a1 atores maliciosos. |  MÉDIA |
|RNF-003| O Site deve atender à Lei de proteção de dados. | MÉDIA | 
|RNF-004| O site deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge). |  ALTA |
|RNF-005| O site deve ser de fácil navegação entre suas telas. | MÉDIA | 
|RNF-006| O site deverá ser de código aberto. |  MÉDIA |


## Restrições

Restrições são obrigações claras e objetivas do projeto. A tabela a seguir mostra a lista de restrições do projeto.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do primeiro semestre de 2023. |
|02| A equipe não pode subcontratar o desenvolvimento do trabalho.        |
|03| O projeto deve usar um único banco de dados. |
|04| O site não poderá ser utilizado para fins lucrativos durante, ou após o seu desenvolvimento.        |


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
