using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Directivo
    {
        public int Id { get; set; }
        public int Categoria { get; set; }
        //public Empleado Subordinado { get; set; }
        //public Empresa Dirige { get; set; }

        [ForeignKey("Empleado")]
        public int EmpleadoId { get; set; }
        public virtual Empleado EmpleadoRef { get; set; }
    }
}