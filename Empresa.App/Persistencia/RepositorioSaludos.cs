using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public class RepositorioSaludos : I_RepositorioSaludos
    {
        List<Saludo> saludos;

        public RepositorioSaludos()
        {
            saludos = new List<Saludo>()
            {
                new Saludo{Id=1,EnEspanol="Buenos Dias",EnIngles="Good Morning",EnItaliano="Bungiorno"},
                new Saludo{Id=2,EnEspanol="Buenas Tardes",EnIngles="Good Afternoon",EnItaliano="Buon pomeriggio"},
                new Saludo{Id=3,EnEspanol="Buenas Noches",EnIngles="Good Evening",EnItaliano="Buona notte"}
            };
        }
        public IEnumerable<Saludo> GetAll()
        {
            return saludos;
        }
    }
}