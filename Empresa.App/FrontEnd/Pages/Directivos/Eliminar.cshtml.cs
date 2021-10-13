using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace EliminarUnDirectivo
{
    public class  EliminarModel : PageModel
    {
        private readonly I_RepositorioDirectivo _repo;

        public Directivo Directivo_enc { get; set;}

        public EliminarModel(I_RepositorioDirectivo repo){
            _repo = repo;
        }
        public void OnGet(int IdDirectivo)
        {
            Directivo_enc = _repo.GetDirectivo(IdDirectivo);
        } 
        public void OnPost(int IdDirectivo)
        {        
           _repo.DeleteDirectivo(IdDirectivo);
           Response.Redirect("/Directivos/List");
        }       
    }    
}