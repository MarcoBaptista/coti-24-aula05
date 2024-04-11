# Sistema de Cadastro e Controle de Estoque (Console Application)

Este é um sistema simples desenvolvido em C# como uma aplicação de console. O objetivo é gerenciar o cadastro de produtos e controlar o estoque. O sistema utiliza o Entity Framework para interagir com o banco de dados SQL Server.

## Funcionalidades

1. **Cadastro de Produtos:**
   - Permite adicionar novos produtos com informações como nome, preço e quantidade em estoque.
   - Validações básicas são aplicadas para garantir que os campos obrigatórios sejam preenchidos corretamente.

2. **Controle de Estoque:**
   - Exibe a lista de produtos cadastrados com seus detalhes.
   - Permite atualizar a quantidade em estoque de um produto específico.

## Pré-requisitos

- .NET SDK instalado (versão compatível com o Entity Framework e SQL Server).
- SQL Server instalado e configurado.

## Configuração

1. Clone o repositório.
2. Configure a string de conexão com o SQL Server no arquivo `appsettings.json`.
3. Execute as migrações do Entity Framework para criar o banco de dados e as tabelas.

## Executando o Sistema

1. Abra o terminal na pasta do projeto.
2. Execute o comando `dotnet run`.

