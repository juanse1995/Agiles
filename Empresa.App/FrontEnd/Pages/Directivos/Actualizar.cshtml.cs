using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace ActualizarDirectivo
{
    public class ActualizarModel : PageModel
    {
        private readonly I_RepositorioDirectivo _repo;
        private readonly I_RepositorioEmpleado _repoE;
        public Directivo Directivo { get; set;}
        public IEnumerable<Empleado> Empleados { get; set;}

        public ActualizarModel(I_RepositorioDirectivo repo, I_RepositorioEmpleado repo2){
            _repo = repo;
            _repoE = repo2;
        }
        public void OnGet(int IdDirectivo)
        {            
            Directivo = _repo.GetDirectivo(IdDirectivo);
            Empleados = _repoE.GetAllEmpleado();
        }
        public void OnPost(Directivo directivo)
        {              
            Empleados = _repoE.GetAllEmpleado();
            _repo.UpdateDirectivo(directivo);
            Response.Redirect("/Directivos/List");     
        } 
    }
}
