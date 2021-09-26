using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Persistencia
{
    public interface I_RepositorioSaludos
    {
         IEnumerable<Saludo> GetAll();
    }
}