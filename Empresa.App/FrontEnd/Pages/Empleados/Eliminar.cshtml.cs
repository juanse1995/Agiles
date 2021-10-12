using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace EliminarEmpleado
{
    public class EliminarModel : PageModel
    {
        private readonly I_RepositorioEmpleado _repo;
        private readonly I_RepositorioPersona _repoP;
        public Empleado Empleado_enc { get; set;}
        public EliminarModel(I_RepositorioEmpleado repo, I_RepositorioPersona repo2){
            _repo = repo;
            _repoP = repo2;
        }        
        public void OnGet(int IdEmpleado)
        {
            Empleado_enc = _repo.GetEmpleado(IdEmpleado);
        }
        public void OnPost(int IdEmpleado)
        {       
            Empleado_enc = _repo.GetEmpleado(IdEmpleado);     
            var perDelete = Empleado_enc.PersonaRef.Id;
            _repo.DeleteEmpleado(IdEmpleado);
            _repoP.DeletePersona(perDelete);
            Response.Redirect("/Empleados/List");
        }   
    }
}
