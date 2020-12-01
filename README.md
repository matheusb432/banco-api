# BancoAPI

* Funcionalidades de extrair, gravar, remover e atualizar dados de um banco de dados através de requisições HTTP.
* Acesso a um banco de dados com EF Core
* Serviço de mensageria que permite o envio de objetos serializados para uma fila do RabbitMQ (opcional)

# Camadas da aplicação utilizando domain-driven design (DDD)
* 1 - Presentation: compõe a API e a implementação dos serviços da mesma.
* 2 - Application: implementação da lógica da aplicação, envolvendo a implementação dos repositórios, por exemplo.
* 3 - Domain: representa os modelos do sistema bancário fictício, junto com as anotações de dados que serão interpretadas na quarta camada.
* 4 - Infra: camada da infraestrutura, aqui está a implementação do contexto de dados, as migrações do banco de dados e as tabelas representadas como 'DbSet<>'s do EF Core.
