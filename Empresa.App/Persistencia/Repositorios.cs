/*
//Este código es mi original

using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class ApplicationContext : DbContext

    {       
        private const string connectionString = @"Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = EmpresaWEB"; 
        
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Directivo> Directivos { get; set; }
        public DbSet<Empresa> Empresas { get; set; }

        public ApplicationContext() {
         }
            public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder
                .UseSqlServer(connectionString);
            }
        }
    }
}
*/

/*
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get; set;}
        public DbSet<Empleado> Empleados {get; set;}
        public DbSet<Cliente> Clientes {get; set;}
        public DbSet<Directivo> Directivos {get; set;}
        public DbSet<Empresa> Empresas {get; set;}

    private const string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog = Empresa;Integrated Security = True";
           protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder
                .UseSqlServer(connectionString);
            }
        }
    }
}
*/