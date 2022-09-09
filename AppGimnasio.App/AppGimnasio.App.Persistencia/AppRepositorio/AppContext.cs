using Microsoft.EntityFrameworkCore;
using AppGimnasio.App.Dominio;

namespace AppGimnasio.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Entrenador> Entrenadores { get; set; }
        public DbSet<IngresoGimnasio> Ingresos { get; set; }
        public DbSet<Mensualidad> Mensualidades { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Rutina> Rutinas { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AppGimnasiotData");
            
            }
        }

    }
}