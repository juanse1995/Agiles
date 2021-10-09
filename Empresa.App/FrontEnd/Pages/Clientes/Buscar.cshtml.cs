using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace BuscarUnCliente
{
    public class BuscarModel : PageModel
    {
        private readonly I_RepositorioCliente _repo;

        public Cliente Cliente_enc { get; set;}

        public BuscarModel(I_RepositorioCliente repo){
            _repo = repo;
        }
        public void OnGet(int IdCliente)
        {
            Cliente_enc = _repo.GetCliente(IdCliente);
        }        
    }    
}