using Inventario.Context;
using Inventario.Models;
using Inventario.Repositories.Interfaces;

namespace Inventario.Repositories
{
    public class ComputerRepository : IComputerRepository
    {
        private readonly AppDbContext _context;

        public ComputerRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Computer> Computers => _context.Computers;
        public Computer GetComputerByComputerId(string computerId)
        {
            return _context.Computers.FirstOrDefault(c => c.ComputerId == computerId);
        }
    }
}