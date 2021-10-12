using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.EmpresaList
{
    public class ListModelEmpresas : PageModel
    {
        private readonly I_RepositorioEmpresa repositorioEmpresa;
        public IEnumerable<Empresa> EmpresasList { get; set; }

        public ListModelEmpresas(I_RepositorioEmpresa repositorioEmpresa)
        {
            this.repositorioEmpresa = repositorioEmpresa;
        }

        public void OnGet()
        {
            EmpresasList = repositorioEmpresa.GetAllEmpresa();
        }
    }
}
