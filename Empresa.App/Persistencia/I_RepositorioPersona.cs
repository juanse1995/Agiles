using System.Collections.Generic;
using Dominio;
using System.Linq;

namespace Persistencia
{
    public interface I_RepositorioPersona
    {
        IEnumerable<Persona> GetAllPersona();
        Persona AddPersona(Persona persona);
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int IdPersona);
        Persona GetPersona(int IdPersona);
    }
}