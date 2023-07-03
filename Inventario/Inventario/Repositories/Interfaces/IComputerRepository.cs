using Inventario.Models;

namespace Inventario.Repositories.Interfaces
{
    public interface IComputerRepository
    {
        IEnumerable<Computer> Computers { get; }
        Computer GetComputerByComputerId(string computerId);
    }
}
