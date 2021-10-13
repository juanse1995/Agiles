using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace CrearDirectivo
{
    public class CrearModel : PageModel
    {
        private readonly I_RepositorioDirectivo _repo;
        private readonly I_RepositorioEmpleado _repoE;
        public Directivo Directivo { get; set;}
        public IEnumerable<Empleado> Empleados { get; set;}

        public CrearModel(I_RepositorioDirectivo repo, I_RepositorioEmpleado repo2){
            _repo = repo;
            _repoE = repo2;
        }
        public void OnGet()
        {            
            Empleados = _repoE.GetAllEmpleado();
        }
        public void OnPost(Directivo directivo)
        {              
            Empleados = _repoE.GetAllEmpleado();
            _repo.AddDirectivo(directivo);
            Response.Redirect("/Directivos/List");     
        } 
    }
}
