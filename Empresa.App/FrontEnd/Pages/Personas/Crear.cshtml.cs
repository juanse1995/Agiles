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
    public class CrearModel : PageModel
    {
        private readonly I_RepositorioPersona _repo;

        public Persona Persona { get; set;}

        public CrearModel(I_RepositorioPersona repo){
            _repo = repo;

        }

        public void OnGet()
        {

        }
        public void OnPost(Persona persona)
        {
            _repo.AddPersona(persona);
            Response.Redirect("/Personas/List");
        }
        
        
    }
    
}
