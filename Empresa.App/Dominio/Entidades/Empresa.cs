using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;
using System.Collections.Generic; 
namespace Dominio
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string CIF { get; set; }
        public virtual ICollection<Cliente> ClienteLista { get; set; }
        public virtual ICollection<Empleado> EmpleadoLista { get; set; }
    }
}