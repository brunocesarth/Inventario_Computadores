using Inventario.Models;
using Microsoft.EntityFrameworkCore;

namespace Inventario.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Computer> Computers { get; set; }
    }
}
