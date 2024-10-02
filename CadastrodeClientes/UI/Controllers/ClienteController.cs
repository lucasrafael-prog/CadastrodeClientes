using CadastrodeClientes.Domain.Entities;
using CadastrodeClientes.Infrastructure.Data;
using CadastrodeClientes.Models;
using Microsoft.AspNetCore.Mvc;

namespace CadastrodeClientes.UI.Controllers
{
    // Controlador responsável pelas operações de CRUD do cliente.
    public class ClienteController : Controller
    {
        // Contexto do banco de dados injetado através de dependência, usado para interagir com a base de dados.
        private readonly BDContext _bdContext;

        // Construtor do controller, inicializa o BDContext necessário para acessar o banco de dados.
        public ClienteController(BDContext bdContext, IWebHostEnvironment environment)
        {
            _bdContext = bdContext;
        }

        // Método que exibe a lista de clientes na página inicial (Index).
        public IActionResult Index()
        {
            // Obtém todos os clientes do banco de dados, ordenando por Id de forma decrescente.
            var clientes = _bdContext.Clientes.OrderByDescending(p => p.Id).ToList();
            return View(clientes);  // Retorna a lista de clientes para a View correspondente.
        }

        // Método que exibe a tela de criação de um novo cliente.
        public IActionResult Create()
        {
            return View();  // Retorna a View para criar um novo cliente (formulário vazio).
        }

        // Método que lida com o POST do formulário de criação de cliente.
        [HttpPost]
        public IActionResult Create(ClienteDto clienteDto)
        {
            // Verifica se os dados enviados no formulário são válidos.
            if (!ModelState.IsValid)
            {
                return View(clienteDto);  // Se houver erro de validação, retorna a mesma View com os dados inseridos.
            }

            // Cria uma nova instância de cliente baseado nos dados recebidos do DTO (Data Transfer Object).
            Cliente cliente = new Cliente()
            {
                Nome = clienteDto.Nome,
                Telefone = clienteDto.Telefone,
                Email = clienteDto.Email,
                Endereco = clienteDto.Endereco,
                TipoEndereco = clienteDto.TipoEndereco,
                DataDoPedido = clienteDto.DataDoPedido,
            };

            // Adiciona o novo cliente ao contexto (em memória, antes de persistir).
            _bdContext.Clientes.Add(cliente);
            _bdContext.SaveChanges();  // Salva as alterações no banco de dados (persistência).

            // Redireciona o usuário de volta para a página inicial de listagem de clientes.
            return RedirectToAction("Index", "Cliente");
        }

        // Método que exibe a tela de edição de um cliente existente.
        public IActionResult Edit(int Id)
        {
            // Procura o cliente no banco de dados pelo Id.
            var cliente = _bdContext.Clientes.Find(Id);

            // Se o cliente não for encontrado, redireciona para a página inicial.
            if (cliente == null)
            {
                return RedirectToAction("Index", "Cliente");
            }

            // Mapeia os dados do cliente para um DTO para ser exibido no formulário de edição.
            var clienteDto = new ClienteDto()
            {
                Nome = cliente.Nome,
                Telefone = cliente.Telefone,
                Email = cliente.Email,
                Endereco = cliente.Endereco,
                TipoEndereco = cliente.TipoEndereco,
                DataDoPedido = cliente.DataDoPedido,
            };

            // Passa o Id do cliente para a View através de ViewData.
            ViewData["ClienteId"] = cliente.Id;

            // Retorna a View de edição com os dados preenchidos do cliente.
            return View(clienteDto);
        }

        // Método que lida com o POST do formulário de edição do cliente.
        [HttpPost]
        public IActionResult Edit(int Id, ClienteDto clienteDto)
        {
            // Procura o cliente no banco de dados pelo Id.
            var cliente = _bdContext.Clientes.Find(Id);

            // Se o cliente não for encontrado, redireciona para a página inicial.
            if (cliente == null)
            {
                return RedirectToAction("Index", "Cliente");
            }

            // Verifica se os dados enviados no formulário são válidos.
            if (!ModelState.IsValid)
            {
                // Se houver erro de validação, retorna a View com os dados inseridos.
                ViewData["ClienteId"] = cliente.Id;
                return View(clienteDto);
            }

            // Atualiza os dados do cliente com os dados do DTO (enviados pelo formulário).
            cliente.Nome = clienteDto.Nome;
            cliente.Telefone = clienteDto.Telefone;
            cliente.Email = clienteDto.Email;
            cliente.Endereco = clienteDto.Endereco;
            cliente.TipoEndereco = clienteDto.TipoEndereco;
            cliente.DataDoPedido = clienteDto.DataDoPedido;

            // Salva as alterações no banco de dados.
            _bdContext.SaveChanges();

            // Redireciona para a página inicial de listagem de clientes.
            return RedirectToAction("Index", "Cliente");
        }

        // Método que exibe a tela de confirmação de exclusão de um cliente.
        public IActionResult Delete(int Id)
        {
            // Procura o cliente no banco de dados pelo Id.
            var cliente = _bdContext.Clientes.Find(Id);

            // Se o cliente não for encontrado, redireciona para a página inicial.
            if (cliente == null)
            {
                return RedirectToAction("Index", "Cliente");
            }

            // Remove o cliente do contexto e, posteriormente, do banco de dados.
            _bdContext.Clientes.Remove(cliente);
            _bdContext.SaveChanges(true);  // Confirma a exclusão no banco de dados.

            // Redireciona para a página inicial de listagem de clientes.
            return RedirectToAction("Index", "Cliente");
        }
    }
}
