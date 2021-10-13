using System.Collections.Generic;
using System.Linq;
using Dominio;
using Microsoft.EntityFrameworkCore;


//Falta llevar al Main()

namespace Persistencia
{
    public class RepositorioDirectivo : I_RepositorioDirectivo
    {
        private readonly ApplicationContext _appContext;
        public RepositorioDirectivo(ApplicationContext  appContext)
        {
            _appContext = appContext;
        }
        Directivo I_RepositorioDirectivo.AddDirectivo(Directivo directivo)
        {
            var DirectivoAdicionado = _appContext.Directivos.Add(directivo);
            _appContext.SaveChanges();
            return DirectivoAdicionado.Entity;
        }

        void I_RepositorioDirectivo.DeleteDirectivo(int IdDirectivo)
        {
            var DirectivoEncontrado = _appContext.Directivos.FirstOrDefault(p => p.Id == IdDirectivo);
            if (DirectivoEncontrado == null)
                return;
            _appContext.Directivos.Remove(DirectivoEncontrado);
            _appContext.SaveChanges();
        }

        /*Directivo I_RepositorioDirectivo.Dirige(int IdDirectivo, int IdEmpresa)
        {
            var DirectivoEncontrado = _appContext.Directivos.FirstOrDefault(p => p.Id == IdDirectivo);
            if (DirectivoEncontrado != null)
            {
                var empresaEncontrada = _appContext.Empresas.FirstOrDefault(e => e.Id == IdEmpresa);
                if (empresaEncontrada  != null)
                {
                    DirectivoEncontrado.Dirige = empresaEncontrada ;
                    _appContext.SaveChanges();
                }
                return DirectivoEncontrado;
            }
            return null;
        }*/

        IEnumerable<Directivo> I_RepositorioDirectivo.GetAllDirectivo()
        {
            return _appContext.Directivos.AsNoTracking().Include(e => e.EmpleadoRef);
        }

        Directivo I_RepositorioDirectivo.GetDirectivo(int IdDirectivo)
        {
            return _appContext.Directivos.FirstOrDefault(p => p.Id == IdDirectivo);
        }

        /*Directivo I_RepositorioDirectivo.Subordinado(int IdDirectivo, int IdEmpleado)
        {
            var DirectivoEncontrado = _appContext.Directivos.FirstOrDefault(p => p.Id == IdDirectivo);
            if (DirectivoEncontrado != null)
            {
                var empleadoEncontrado = _appContext.Empleados.FirstOrDefault(e => e.Id == IdEmpleado);
                if (empleadoEncontrado != null)
                {
                    DirectivoEncontrado.Subordinado = empleadoEncontrado;
                    _appContext.SaveChanges();
                }
                return DirectivoEncontrado;
            }
            return null;
        }*/

      

        Directivo I_RepositorioDirectivo.UpdateDirectivo(Directivo directivo)
        {
            var DirectivoEncontrado = _appContext.Directivos.FirstOrDefault(p => p.Id == directivo.Id);
            if (DirectivoEncontrado != null)
            {
                DirectivoEncontrado.Categoria = directivo.Categoria;
                //DirectivoEncontrado.Subordinado = directivo.Subordinado;
                //DirectivoEncontrado.Dirige = directivo.Dirige;
                _appContext.SaveChanges();
            }
            return DirectivoEncontrado;
        }
    }
}