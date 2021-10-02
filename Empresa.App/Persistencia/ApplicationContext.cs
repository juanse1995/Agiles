using Dominio;
using Microsoft.EntityFrameworkCore;
namespace Persistencia
{
    public class ApplicationContext: DbContext
    {

        private const string connectionString = @"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = EmpresaWEB";
         public DbSet<Persona> Personas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Directivo> Directivos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }

        public ApplicationContext() { }

            public ApplicationContext(DbContextOptions<ApplicationContext> options)
            :base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer(connectionString);
            }
        }
    }
}