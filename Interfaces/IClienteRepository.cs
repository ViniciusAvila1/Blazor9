using Projeto1.Models;
namespace Projeto1.Interfaces
{
public interface IClienteRepository
    {
        Task AtualizarAsync(Cliente cliente);
        Task ExcluirAsync(int id);
        Task IncluirAsync(Cliente cliente);
        Task<List<Cliente>> ListarTodosAsync();
        Task<Cliente?> ObterPorIdAsync(int id);
    }
} 