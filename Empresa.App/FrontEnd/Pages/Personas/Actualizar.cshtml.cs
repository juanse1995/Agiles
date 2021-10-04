using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace MyApp.Namespace.PersonaA
{
public class ActualizarModel : PageModel
    {
        private readonly I_RepositorioPersona _repo;

        public Persona Persona { get; set;}
        public Persona Persona_encontrada { get; set;}

        public ActualizarModel(I_RepositorioPersona repo){
            _repo = repo;

        }

        public void OnGet(int IdPersona)
        {
            Persona_encontrada = _repo.GetPersona(IdPersona);
        }
        public void OnPost(Persona persona)
        {
            _repo.UpdatePersona(persona);
            Response.Redirect("/Personas/List");
        }        
    }
    
}
