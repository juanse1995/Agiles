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
    public class ListModel : PageModel
    {

        private readonly I_RepositorioSaludos repositorioSaludos;
        public IEnumerable<Saludo> Saludos {get; set;}

        public ListModel(I_RepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos = repositorioSaludos;
        }

        public void OnGet()
        {           
            Saludos = repositorioSaludos.GetAll();
        }
    }
}
