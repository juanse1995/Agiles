using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace BuscarUnDirectivo
{
    public class BuscarModel : PageModel
    {
        private readonly I_RepositorioDirectivo _repo;

        public Directivo Directivo_enc { get; set;}

        public BuscarModel(I_RepositorioDirectivo repo){
            _repo = repo;
        }
        public void OnGet(int IdDirectivo)
        {
            Directivo_enc = _repo.GetDirectivo(IdDirectivo);
        }        
    }    
}