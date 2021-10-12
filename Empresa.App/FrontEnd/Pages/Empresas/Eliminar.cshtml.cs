using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace EliminarUnaEmpresa
{
    public  class EliminarModel : PageModel
    {
        private readonly I_RepositorioEmpresa _repo;
        public Empresa Empresa_enc { get; set;}
                
        public EliminarModel (I_RepositorioEmpresa repo)
        {
            _repo = repo;
        }
        public void OnGet(int IdEmpresa)
        {
            Empresa_enc = _repo.GetEmpresa(IdEmpresa);
        }
        public void OnPost(int IdEmpresa)
        {
            _repo.DeleteEmpresa(IdEmpresa);            
            Response.Redirect("/Empresas/List");
        }
    }
}
