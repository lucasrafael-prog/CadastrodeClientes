# CadastrodeClientes
Este projeto é uma aplicação web de um Cadastro de Clientes desenvolvida em ASP.NET Core MVC utilizando Entity Framework Core para o acesso ao banco de dados e o padrão Domain-Driven Design (DDD) para organizar as camadas do projeto. A aplicação permite a criação, edição, exclusão e visualização de clientes e seus respectivos endereços.

# Tecnologias Utilizadas
C#
ASP.NET Core MVC
Entity Framework Core (EF Core)
SQL Server
Domain-Driven Design (DDD)
DevExpress
# Funcionalidades
Listagem de clientes
Criação de novos clientes
Edição de informações de clientes existentes
Exclusão de clientes
Validação de dados via anotações de modelo (DataAnnotations)
# Estrutura do Projeto (DDD)
O projeto segue a arquitetura de Domain-Driven Design (DDD), dividindo o código em diferentes camadas:

Domain: Contém as entidades e regras de negócio. A entidade principal é Cliente.
Application: Contém os DTOs dos serviços de aplicação.
Infrastructure: Responsável pela persistência dos dados. Aqui se encontra o BDContext, que gerencia o acesso ao banco de dados usando o Entity Framework Core.
UI: A camada de interface de usuário, onde estão os controladores MVC e as views.
