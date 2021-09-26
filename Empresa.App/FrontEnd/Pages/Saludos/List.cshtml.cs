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
    public class ListModel : PageModel
    {
        //private string[] saludos = { "Buenos dias", "Buenas tardes", "Buenas noches", "Hasta mañana" };
        //public List<string> ListaSaludos { get; set; }

        private readonly I_RepositorioSaludos repositorioSaludos;
        public IEnumerable<Saludo> Saludos {get; set;}
        public ListModel(I_RepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos = repositorioSaludos;
        }

        //private readonly I_RepositorioPersona repositorioPersona;
        //private readonly I_RepositorioEmpresa repositorioEmpresa;
        //private readonly I_RepositorioCliente repositorioCliente;
        //private readonly I_RepositorioEmpleado repositorioEmpleado;
        //private readonly I_RepositorioDirectivo repositorioDirectivo;

        public void OnGet()
        {
            //ListaSaludos = new List<string>();
            //ListaSaludos.AddRange(saludos);
            Saludos = repositorioSaludos.GetAll();
        }

    }
}
