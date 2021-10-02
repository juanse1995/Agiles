using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Dominio;
using Persistencia;
using Microsoft.EntityFrameworkCore;



namespace Frontend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();            
            
            services.AddSingleton<I_RepositorioSaludos, RepositorioSaludos>(); 
            services.AddScoped<I_RepositorioPersona, RepositorioPersona>();
            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            //services.AddTransient<I_RepositorioPersona, RepositorioPersona>();           
            //services.AddScoped<I_RepositorioPersona, RepositorioPersona>();
            //services.AddSingleton<I_RepositorioPersona, RepositorioPersona>();
            //services.AddSingleton<I_RepositorioEmpresa, RepositorioEmpresa>();
            //services.AddSingleton<I_RepositorioCliente, RepositorioCliente>();
            //services.AddSingleton<I_RepositorioEmpleado, RepositorioEmpleado>();
            //services.AddSingleton<I_RepositorioDirectivo, RepositorioDirectivo>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
