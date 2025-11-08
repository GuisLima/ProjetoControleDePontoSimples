📘 Projeto de Controle de Ponto

Este projeto foi desenvolvido em C# (.NET) com o objetivo de criar um sistema simples de cadastro e controle de pontos vinculados a funcionários.

Além da prática em Programação Orientada a Objetos (POO), o desenvolvimento proporcionou diversos aprendizados importantes em estrutura de código, encapsulamento, injeção de dependência e manipulação de dados e datas.

🚀 Execução do projeto

Para executar o projeto, basta utilizar o comando abaixo no terminal:

dotnet run

🧠 Aprendizados
🔹 Primary Key e controle de alterações

Durante o projeto, utilizei um conceito aprendido em banco de dados: o uso de uma chave primária (ID) para controlar alterações nos registros.

Adicionei a propriedade ID em cada classe.

O incremento é feito automaticamente na classe gerenciadora, garantindo que cada registro tenha um identificador único.

📍 Esse foi o primeiro projeto em que apliquei algo semelhante ao controle de chave primária de banco de dados.

🔹 Instâncias e gerenciamento de objetos

Aprendi como as instâncias funcionam de forma prática.

Cada vez que um novo ponto é cadastrado, uma nova instância é criada automaticamente dentro do método de cadastro.

Não há necessidade de criar variáveis separadas para cada objeto, pois os dados são persistidos em uma lista.

💡 Esse conceito foi essencial para entender melhor como os objetos são criados e manipulados em memória.

🔹 Manipulação de datas e horas

A entrada de data e hora é feita pelo usuário em formato de string, e convertida utilizando o método TryParseExact.

Esse aprendizado me ajudou a compreender melhor como trabalhar com DateTime, formatações e validações de entrada.

🕒 Manipular datas e horários de forma correta foi um dos pontos mais importantes do projeto.

🔹 Encapsulamento

O projeto também reforçou meu entendimento sobre encapsulamento.

Apliquei validações diretamente nos métodos get e set.

Propriedades e variáveis que não precisam ser acessadas de fora da classe foram mantidas privadas.

🔐 Foi a primeira vez que usei o encapsulamento de forma efetiva e consciente, melhorando a segurança e clareza do código.

🔹 Injeção de Dependência

Tive um problema inicial ao criar listas em lugares diferentes, o que gerava desencontro de dados.
Com o uso da injeção de dependência, consegui organizar o fluxo corretamente:

O menu principal controla o fluxo e cria os objetos principais.

O gerenciador de funcionários cuida da lista de funcionários.

O menu de funcionários apenas executa ações, recebendo o gerenciador pronto.

⚙️ Essa estrutura deixou o código mais limpo, modular e fácil de manter.

🧩 Funcionalidades

O sistema implementa um CRUD completo para os funcionários e seus pontos:

Criar novos registros

Retornar listagens

Update (alterar informações)

Deletar registros

🗂️ O foco é o cadastro de ponto, vinculado a um funcionário existente.

🛠️ Tecnologias utilizadas

Linguagem: C#

Framework: .NET

Paradigma: Programação Orientada a Objetos (POO)

✨ Conclusão

Este foi um projeto de grande aprendizado.
Refatorei várias partes do código, e embora ainda existam pontos a melhorar, considero o projeto encerrado com sucesso.

Cada funcionalidade desenvolvida me ajudou a compreender conceitos fundamentais da POO e a estruturar melhor meus códigos em C#.
