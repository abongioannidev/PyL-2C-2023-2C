using Microsoft.EntityFrameworkCore;

namespace Entidades
{
    public class MyDataBase : DbContext
    {
        public DbSet<Producto> Productos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=clase01112023;Trusted_Connection=True;TrustServerCertificate=Yes;");
        }

    }
}