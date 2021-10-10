using System.Collections.Generic;
using System.Linq;
using Dominio;
using Microsoft.EntityFrameworkCore;


//Falta llevar al Main()

namespace Persistencia
{
    public class RepositorioEmpleado : I_RepositorioEmpleado
    {
        private readonly ApplicationContext  _appContext;
        public RepositorioEmpleado(ApplicationContext  appContext)
        {
            _appContext = appContext;
        }

        Empleado I_RepositorioEmpleado.AddEmpleado(Empleado empleado)
        {
            var empleadoAdicionado = _appContext.Empleados.Add(empleado);
            _appContext.SaveChanges();
            return empleadoAdicionado.Entity;
        }

        void I_RepositorioEmpleado.DeleteEmpleado(int IdEmpleado)
        {
            var empleadoEncontrado = _appContext.Empleados.FirstOrDefault(e => e.Id == IdEmpleado);
            if (empleadoEncontrado == null)
                return;
            _appContext.Empleados.Remove(empleadoEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Empleado> I_RepositorioEmpleado.GetAllEmpleado()
        {
            return _appContext.Empleados.AsNoTracking().Include(p => p.PersonaRef).Include(p => p.Empleador);
        }

        Empleado I_RepositorioEmpleado.GetEmpleado(int IdEmpleado)
        {
            return _appContext.Empleados.Include(p => p.PersonaRef).Include(p => p.Empleador).Where(emple => emple.Id == IdEmpleado).FirstOrDefault();

        }

        Empresa I_RepositorioEmpleado.TrabajaEn(int IdEmpleado, int IdEmpresa)
        {
            var empleadoEncontrado = _appContext.Empleados.FirstOrDefault(e => e.Id == IdEmpleado);
            if (empleadoEncontrado != null)
            {
                var empresaEncontrada = _appContext.Empresas.FirstOrDefault(em => em.Id == IdEmpresa);
                if (empresaEncontrada != null)
                {
                    empleadoEncontrado.Empleador = empresaEncontrada;
                    _appContext.SaveChanges();
                }
                return empresaEncontrada;
            }
            return null;
        }

        Empleado I_RepositorioEmpleado.UpdateEmpleado(Empleado empleado)
        {
            var empleadoEncontrado = _appContext.Empleados.FirstOrDefault(e => e.Id == empleado.Id);
            if (empleadoEncontrado != null)
            {
                empleadoEncontrado.SueldoBruto = empleado.SueldoBruto;
                empleadoEncontrado.Cargo = empleado.Cargo;                
                _appContext.SaveChanges();
            }
            return empleadoEncontrado;            
        }
    }
}