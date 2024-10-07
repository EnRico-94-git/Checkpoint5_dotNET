# Checkpoint5_dotNET

Descrição
Checkpoint5_dotNET é uma WebAPI desenvolvida em .NET com a finalidade de realizar operações CRUD (Create, Read, Update, Delete) em uma entidade de exemplo, utilizando MongoDB como banco de dados e chamadas assíncronas. O projeto também inclui testes unitários com xUnit e Moq para garantir a qualidade e funcionalidade do código.

## Funcionalidades
A WebAPI implementa os seguintes endpoints:
- GET /api/products - Consulta todos os produtos.
- GET /api/products/{id} - Consulta um produto específico por ID.
- POST /api/products - Adiciona um novo produto.
- PUT /api/products/{id} - Atualiza um produto existente por ID.
- DELETE /api/products/{id} - Remove um produto por ID.

## Tecnologias Utilizadas:
- .NET 7.0 - Framework de desenvolvimento da API.
- MongoDB - Banco de dados NoSQL para armazenamento dos dados.
- MongoDB.Driver - Biblioteca para interagir com o MongoDB.
- xUnit - Ferramenta de testes unitários.
- Moq - Biblioteca para criação de mocks durante os testes.
- Swagger - Documentação interativa para testar a API.
