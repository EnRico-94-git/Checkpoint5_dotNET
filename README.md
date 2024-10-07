# Checkpoint5_dotNET

Descrição
Checkpoint5_dotNET é uma WebAPI desenvolvida em .NET com a finalidade de realizar operações CRUD (Create, Read, Update, Delete) em uma entidade de exemplo, utilizando MongoDB como banco de dados e chamadas assíncronas. O projeto também inclui testes unitários com xUnit e Moq para garantir a qualidade e funcionalidade do código.

Funcionalidades
A WebAPI implementa os seguintes endpoints:

GET /api/products - Consulta todos os produtos.
GET /api/products/{id} - Consulta um produto específico por ID.
POST /api/products - Adiciona um novo produto.
PUT /api/products/{id} - Atualiza um produto existente por ID.
DELETE /api/products/{id} - Remove um produto por ID.
Tecnologias Utilizadas
.NET 7.0 - Framework de desenvolvimento da API.
MongoDB - Banco de dados NoSQL para armazenamento dos dados.
MongoDB.Driver - Biblioteca para interagir com o MongoDB.
xUnit - Ferramenta de testes unitários.
Moq - Biblioteca para criação de mocks durante os testes.
Swagger (opcional) - Documentação interativa para testar a API.
Estrutura do Projeto
plaintext
Copiar código
Checkpoint5_dotNET/
│
├── Controllers/             # Controladores da API
│   └── ProductController.cs
├── Data/                    # Repositório de dados e configuração do MongoDB
│   ├── IProductRepository.cs
│   ├── ProductRepository.cs
│   └── MongoDbSettings.cs
├── Models/                  # Modelos das entidades
│   └── Product.cs
├── Tests/                   # Testes unitários com xUnit
│   └── Controllers/
│       └── ProductControllerTests.cs
├── appsettings.json          # Configurações da aplicação
├── Program.cs                # Ponto de entrada da aplicação
├── Startup.cs                # Configuração de serviços e middlewares
├── Checkpoint5_dotNET.csproj # Arquivo de configuração do projeto .NET
└── README.md                 # Documento explicativo do projeto
Configurações
Certifique-se de configurar o arquivo appsettings.json para incluir a string de conexão correta com o MongoDB:

json
Copiar código
{
  "MongoDbSettings": {
    "ConnectionString": "mongodb://localhost:27017",
    "DatabaseName": "Checkpoint5_dotNET"
  }
}
Executando o Projeto
Pré-requisitos
.NET 7.0 SDK
MongoDB instalado e em execução localmente ou em um serviço remoto
Passos para rodar o projeto
Clone este repositório:

bash
Copiar código
git clone https://github.com/seu-usuario/Checkpoint5_dotNET.git
cd Checkpoint5_dotNET
Restaure as dependências do projeto:

bash
Copiar código
dotnet restore
Execute a aplicação:

bash
Copiar código
dotnet run
A API estará disponível em https://localhost:5001 ou http://localhost:5000.

Rodando os Testes
Para executar os testes unitários:

bash
Copiar código
dotnet test
