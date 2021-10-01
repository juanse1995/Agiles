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
    public class DetailsModel : PageModel
    {
        private readonly I_RepositorioSaludos repositorioSaludos;
        public Saludo Saludo { get; set; }
        public DetailsModel(I_RepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos = repositorioSaludos;
        }

        public IActionResult OnGet(int saludoId)
        {
            Saludo = repositorioSaludos.GetSaludoPorId(saludoId);
            if (Saludo == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}

