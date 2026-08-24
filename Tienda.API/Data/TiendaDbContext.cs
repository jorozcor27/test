

using Microsoft.EntityFrameworkCore;
using Tienda.API.Models;

namespace Tienda.API.Data
{
    public class TiendaDbContext : DbContext
    {
        public TiendaDbContext(DbContextOptions<TiendaDbContext> options): base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }

    }
}
