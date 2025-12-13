using Projeto1.Models;
using Projeto1.Interfaces;
using Projeto1.Data;
using Microsoft.EntityFrameworkCore;

namespace Projeto1.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly AppDbContext _context;
        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Cliente>> ListarTodosAsync()
        {
            // manter ordenado pelo Id
            return await _context.Clientes.OrderBy(c => c.Id).ToListAsync();
        }
        public async Task<Cliente?> ObterPorIdAsync(int id)
        {
            return await _context.Clientes.FindAsync(id);
        }
        public async Task IncluirAsync(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
        }
        public async Task AtualizarAsync(Cliente cliente)
        {
            _context.Clientes.Update(cliente);
            await _context.SaveChangesAsync();
        }
        public async Task ExcluirAsync(int id)
        {
            var cliente = await ObterPorIdAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }
    }
}