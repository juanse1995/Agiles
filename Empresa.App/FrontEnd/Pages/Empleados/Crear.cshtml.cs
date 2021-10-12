using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace CrearUnEmpleado
{
    public class CrearModel : PageModel
    {
        private readonly I_RepositorioPersona _repoP;
        private readonly I_RepositorioEmpleado _repo;
        private readonly I_RepositorioEmpresa _repoE;
        public Empleado Empleado { get; set;}
        public Persona Persona { get; set;}
        public IEnumerable<Empresa> Empresas { get; set; }

        public CrearModel(I_RepositorioEmpleado repo, I_RepositorioPersona repo2, I_RepositorioEmpresa repo3){
            _repo = repo;
            _repoP = repo2;
            _repoE = repo3;
        }
        public void OnGet()
        {
            Empresas = _repoE.GetAllEmpresa();
        }
        public void OnPost(Empleado empleado)
        { 
            Empresas = _repoE.GetAllEmpresa();                        
            _repo.AddEmpleado(empleado);            
            Response.Redirect("/Empleados/List");         
        }       
    }    
}