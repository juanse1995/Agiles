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
    public class ListModelClientes : PageModel
    {
        private readonly I_RepositorioCliente _repo;
        public IEnumerable<Cliente> Clientes { get; set; }

        public ListModelClientes(I_RepositorioCliente repositorioClientes)
        {
            _repo = repositorioClientes;
        }
        public void OnGet()
        {
            Clientes = _repo.GetAllCliente();
        }
    }
}
