using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace ActualizarEmpresa
{
    public class ActualizarModel : PageModel
    {
        private readonly I_RepositorioEmpresa _repo;
        public Empresa Empresa { get; set;}
        public ActualizarModel(I_RepositorioEmpresa repo)
        {
            _repo = repo;
        }
        public void OnGet(int IdEmpresa)
        {
            Empresa = _repo.GetEmpresa(IdEmpresa);
        }
        public void OnPost(Empresa empresa)
        {
            Empresa = _repo.UpdateEmpresa(empresa);
            Response.Redirect("/Empresas/List");            
        }
    }
}
