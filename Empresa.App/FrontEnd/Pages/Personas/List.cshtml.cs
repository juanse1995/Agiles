using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages
{
    public class ListModelPersonas : PageModel
    {
        private readonly I_RepositorioPersona repositorioPersonas;
        public IEnumerable<Persona> Persona { get; set; }

        public ListModelPersonas(I_RepositorioPersona repositorioPersonas)
        {
            this.repositorioPersonas = repositorioPersonas;
        }
        public void OnGet()
        {
            Persona = repositorioPersonas.GetAllPersona();
        }
    }
}
