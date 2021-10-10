using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Persistencia;
using Dominio;

namespace DetallesEmpleado
{
    
    
        public class DetallesModel : PageModel
        {
            private readonly I_RepositorioEmpleado _repo;

            public Empleado empleado { get; set; }
            
            

            public DetallesModel (I_RepositorioEmpleado repo){
                _repo = repo;


            }
            public void OnGet(int IdEmpleado)
            {
                empleado = _repo.GetEmpleado(IdEmpleado);
            }
    }
}
