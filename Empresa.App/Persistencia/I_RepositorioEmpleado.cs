using System.Collections.Generic;
using Dominio;

namespace Persistencia
{
    public interface I_RepositorioEmpleado
    {
        IEnumerable<Empleado> GetAllEmpleado();
        IEnumerable<Empleado> GetByEmpresa(int EmpresaId);
        Empleado AddEmpleado(Empleado empleado);
        Empleado UpdateEmpleado(Empleado empleado);
        void DeleteEmpleado(int IdEmpleado);
        Empleado GetEmpleado(int IdEmpleado);
        //Empresa TrabajaEn(int IdEmpleado, int IdEmpresa);
    }
}