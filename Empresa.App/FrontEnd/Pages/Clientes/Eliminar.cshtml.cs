using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace EliminarUnCliente
{
    public class  EliminarModel : PageModel
    {
        private readonly I_RepositorioCliente _repo;
        private readonly I_RepositorioPersona _repoP;

        public Cliente Cliente_enc { get; set;}

        public EliminarModel(I_RepositorioCliente repo, I_RepositorioPersona repo2){
            _repo = repo;
            _repoP = repo2;
        }
        public void OnGet(int IdCliente)
        {
            Cliente_enc = _repo.GetCliente(IdCliente);
        } 
        public void OnPost(int IdCliente)
        {       
            Cliente_enc = _repo.GetCliente(IdCliente);     
            var perDelete = Cliente_enc.PerRef.Id;
            _repo.DeleteCliente(IdCliente);
            _repoP.DeletePersona(perDelete);
            Response.Redirect("/Clientes/List");
        }       
    }    
}