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
    public class ListModelEmpleados : PageModel
    {

        private readonly I_RepositorioEmpleado repositorioEmpleado;
        
        public IEnumerable<Empleado> Empleados { get; set; }

        public ListModelEmpleados(I_RepositorioEmpleado repositorioEmpleado)
        {
            this.repositorioEmpleado = repositorioEmpleado;
        }

        public void OnGet()
        {
            Empleados = repositorioEmpleado.GetAllEmpleado();
        }
    }
}
