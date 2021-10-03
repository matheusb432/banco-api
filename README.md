# BancoAPI

- Funcionalidades de extrair, gravar, remover e atualizar dados de um banco de dados através de requisições HTTP
- Implementação do Repository Pattern, para desacoplar as camadas da API com o contexto de dados, e facilitar a implementação genérica de operações com DbSet<>()'s
- Acesso a um banco de dados com EF Core
- AutoMapper para configurar DTOs (Data-transfer objects), permitindo a exibição de apenas informações relevantes ao usuário em requisições GET
- Logger para lidar com exceções e retornar código de status 500, além de salvar a stack trace em um arquivo txt definido em nlog.config
- Serviço de mensageria que permite o envio de objetos serializados para uma fila do RabbitMQ (opcional)

## Executando o Projeto

### Prerequisites

Softwares que serão necessários estarem instaladas na sua máquina:

- [.NET 5.0 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)

- [Microsoft® SQL Server® 2019](https://www.microsoft.com/en-us/download/details.aspx?id=101064)

- Para setup mais ágil, com a string de conexão em app.settings.Development apontando para uma instância local de servidor SQL, basta rodar o comando no Package Manager Console do Visual Studio:
  `Update-Database`
  ou no CLI do .NET Core:
  `dotnet ef database update`
  e então executar através do Visual Studio ou pelo CLI do .NET Core no projeto BancoAPI.Api e rodar:
  `dotnet run`

## Camadas da aplicação em DDD

- 1 - Presentation: compõe a API e a implementação dos serviços da mesma
- 2 - Application: implementação da lógica da aplicação, envolvendo a implementação dos repositórios, por exemplo
- 3 - Domain: representa os modelos do sistema bancário fictício, junto com as anotações de dados que serão interpretadas na quarta camada
- 4 - Infra: camada da infraestrutura, aqui está a implementação do contexto de dados, as migrações do banco de dados e as tabelas representadas como 'DbSet<>'s do EF Core

## Observações

- Este é apenas um projeto simples que fiz para a faculdade no início de 2021, apenas refatorei umas coisas simples para republicar.
