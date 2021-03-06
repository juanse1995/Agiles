using System.Collections.Generic;
using System.Linq;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class RepositorioPersona : I_RepositorioPersona
    {
        private readonly ApplicationContext  _appContext;
        public RepositorioPersona(ApplicationContext appContext)
        {
            _appContext = appContext;
        }

        public RepositorioPersona() { }

        Persona I_RepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionada = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionada.Entity;
        }

        void I_RepositorioPersona.DeletePersona(int IdPersona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == IdPersona);
            if (personaEncontrada == null)
                return;
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Persona> I_RepositorioPersona.GetAllPersona()
        {
            return _appContext.Personas.AsNoTracking();
        }

        Persona I_RepositorioPersona.GetPersona(int IdPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.Id == IdPersona);
        }

        Persona I_RepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
            if (personaEncontrada != null)
            {
                personaEncontrada.Nombre = persona.Nombre;
                personaEncontrada.Apellidos = persona.Apellidos;
                personaEncontrada.Documento = persona.Documento;
                personaEncontrada.FechaNacimiento = persona.FechaNacimiento;
                _appContext.SaveChanges();
            }
            return personaEncontrada;
        }
    }
}