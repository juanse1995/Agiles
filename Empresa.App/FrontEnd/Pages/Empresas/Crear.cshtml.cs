using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Crear.UnaEmpresa
{
    public class CrearModel : PageModel
    {
        private readonly I_RepositorioEmpresa _repo;
        public Empresa Empresa { get; set;}

        public CrearModel(I_RepositorioEmpresa repo){
            _repo = repo;
        }
        public void OnGet()
        {

        }
        public void OnPost(Empresa empresa)
        {                      
            _repo.AddEmpresa(empresa);
            Response.Redirect("/Empresas/List");     
        } 
    }
}
