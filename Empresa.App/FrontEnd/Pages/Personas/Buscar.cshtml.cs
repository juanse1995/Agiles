using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace BuscarUnaPersona
{
    public class BuscarModel : PageModel
    {
        private readonly I_RepositorioPersona _repo;

        public Persona Persona_enc { get; set;}

        public BuscarModel(I_RepositorioPersona repo){
            _repo = repo;
        }
        public void OnGet(int IdPersona)
        {
            Persona_enc = _repo.GetPersona(IdPersona);
        }        
    }    
}
