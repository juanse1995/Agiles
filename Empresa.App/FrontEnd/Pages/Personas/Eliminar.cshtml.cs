using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace MyApp.Namespace.Personas
{
    public class EliminarModel : PageModel
    {
        private readonly I_RepositorioPersona _repo;

        public Persona Persona { get; set;}
        
        public EliminarModel(I_RepositorioPersona repo){
            _repo = repo;
        }   
        public void OnGet(int IdPersona)
        {
           Persona = _repo.GetPersona(IdPersona);
        }
        public void OnPost(int IdPersona)
        {
            _repo.DeletePersona(IdPersona);
            Response.Redirect("/Personas/List");
        }

        
    }
    
}
