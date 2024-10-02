using System.ComponentModel.DataAnnotations;

namespace CadastrodeClientes.Models
{
    // A classe 'ClienteDto' serve como um Data Transfer Object (DTO), que é usado para transferir dados
    // entre as camadas da aplicação, como entre o controlador e a view, ou vice-versa.
    public class ClienteDto
    {
        // O campo 'Nome' é obrigatório e tem um limite de tamanho de 100 caracteres.
        [Required, MaxLength(100)] public string Nome { get; set; }

        // O campo 'Telefone' é obrigatório e tem um limite de tamanho de 20 caracteres.
        [Required, MaxLength(20)] public string Telefone { get; set; }

        // O campo 'Email' é obrigatório e tem um limite de tamanho de 100 caracteres.
        [Required, MaxLength(100)] public string Email { get; set; }

        // O campo 'Endereco' é obrigatório e tem um limite de tamanho de 300 caracteres.
        [Required, MaxLength(300)] public string Endereco { get; set; }

        // O campo 'TipoEndereco' é obrigatório e tem um limite de tamanho de 10 caracteres, que pode armazenar valores como "Fiscal", "Cobrança", "Entrega".
        [Required, MaxLength(10)] public string TipoEndereco { get; set; }

        // O campo 'DataDoPedido' é obrigatório e representa a data em que o pedido foi feito, usando o tipo 'DateOnly' para armazenar apenas a data.
        [Required] public DateOnly DataDoPedido { get; set; }
    }
}
