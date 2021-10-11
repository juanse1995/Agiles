using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace ActualizarCliente
{
public class ActualizarModel : PageModel
    {
        private readonly I_RepositorioPersona _repoP;
        private readonly I_RepositorioCliente _repo;
        private readonly I_RepositorioEmpresa _repoE;
        public Cliente Cliente { get; set;}
        public Persona Persona { get; set;}
        public IEnumerable<Empresa> Empresas { get; set; }

        public ActualizarModel(I_RepositorioCliente repo, I_RepositorioPersona repo2, I_RepositorioEmpresa repo3){
            _repo = repo;
            _repoP = repo2;
            _repoE = repo3;
        }

        public void OnGet(int IdCliente)
        {
            Cliente = _repo.GetCliente(IdCliente);
            Empresas = _repoE.GetAllEmpresa();
        }
        
        public void OnPost(Cliente cliente)
        {            
            Empresas = _repoE.GetAllEmpresa();
            _repo.UpdateCliente(cliente);
            Response.Redirect("/Clientes/List");
        }        
    }
    
}