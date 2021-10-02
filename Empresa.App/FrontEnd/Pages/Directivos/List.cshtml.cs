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
    public class ListModelDirectivos : PageModel
    {
        private readonly I_RepositorioDirectivo _repo;

        public IEnumerable<Directivo> Directivos {get;set;}

        public ListModelDirectivos(I_RepositorioDirectivo repositorioDirectivos)
        {
            _repo = repositorioDirectivos;
        }
        public void OnGet()
        {
            Directivos = _repo.GetAllDirectivo();
        }
    }
}
