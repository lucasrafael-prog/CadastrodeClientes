using System.ComponentModel.DataAnnotations;

namespace CadastrodeClientes.Domain.Entities
{
    // A classe 'Cliente' representa a entidade de um cliente no domínio.
    public class Cliente
    {
        // Propriedade que representa o identificador único do cliente.
        public int Id { get; set; }

        // Propriedade que representa o nome do cliente, com uma restrição de tamanho máximo de 100 caracteres.
        [MaxLength(100)] public string Nome { get; set; }

        // Propriedade que representa o telefone do cliente, com uma restrição de tamanho máximo de 20 caracteres.
        [MaxLength(20)] public string Telefone { get; set; }

        // Propriedade que representa o e-mail do cliente, com uma restrição de tamanho máximo de 100 caracteres.
        [MaxLength(100)] public string Email { get; set; }

        // Propriedade que representa o endereço do cliente, com uma restrição de tamanho máximo de 300 caracteres.
        [MaxLength(300)] public string Endereco { get; set; }

        // Propriedade que indica o tipo de endereço do cliente, como "Fiscal", "Cobrança" ou "Entrega", com uma restrição de tamanho máximo de 10 caracteres.
        [MaxLength(10)] public string TipoEndereco { get; set; }

        // Propriedade que armazena a data em que o pedido foi realizado, utilizando o tipo 'DateOnly' para representar apenas a data.
        public DateOnly DataDoPedido { get; set; }
    }
}
