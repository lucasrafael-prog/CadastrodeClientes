# Cadastro de Clientes
Este projeto é uma aplicação web de um Cadastro de Clientes desenvolvida em ASP.NET Core MVC utilizando Entity Framework Core para o acesso ao banco de dados e o padrão Domain-Driven Design (DDD) para organizar as camadas do projeto. A aplicação permite a criação, edição, exclusão e visualização de clientes e seus respectivos endereços.

# Tecnologias Utilizadas
C#
<br/>ASP.NET Core MVC
<br/>Entity Framework Core (EF Core)
<br/>SQL Server
<br/>Domain-Driven Design (DDD)
<br/>DevExpress
# Funcionalidades
Listagem de clientes
<br/>Criação de novos clientes
<br/>Edição de informações de clientes existentes
<br/>Exclusão de clientes
<br/>Validação de dados via anotações de modelo (DataAnnotations)
# Estrutura do Projeto (DDD)
O projeto segue a arquitetura de Domain-Driven Design (DDD), dividindo o código em diferentes camadas:
<br/>
Domain: Contém as entidades e regras de negócio. A entidade principal é Cliente.
<br/>Application: Contém os DTOs dos serviços de aplicação.
<br/>Infrastructure: Responsável pela persistência dos dados. Aqui se encontra o BDContext, que gerencia o acesso ao banco de dados usando o Entity Framework Core.
<br/>UI: A camada de interface de usuário, onde estão os controladores MVC e as views.
