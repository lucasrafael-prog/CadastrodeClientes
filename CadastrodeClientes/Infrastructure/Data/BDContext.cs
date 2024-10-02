using CadastrodeClientes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CadastrodeClientes.Infrastructure.Data
{
    // A classe 'BDContext' representa o contexto do banco de dados da aplicação, 
    // responsável por gerenciar as interações com a base de dados usando Entity Framework Core.
    public class BDContext : DbContext
    {
        // O construtor da classe 'BDContext' recebe opções de configuração para o DbContext
        // e as passa para a classe base (DbContext), configurando a conexão com o banco de dados.
        public BDContext(DbContextOptions options) : base(options)
        {
        }

        // Esta propriedade representa a tabela 'Clientes' no banco de dados, 
        // com base na entidade 'Cliente' definida no domínio.
        public DbSet<Cliente> Clientes { get; set; }
    }
}
