using Microsoft.EntityFrameworkCore;
using WebAppParcial1.Models;

namespace WebAppParcial1.Data
{
    public class AppDBcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=(localdb)\\mssqllocaldb;Database=ProductosParcial1;Trusted_Connection=True;MultipleActiveResultSets=True");
        }

        public DbSet<Categoria> categoria { get; set; }
        public DbSet<Producto> productos { get; set; }
    }
}
