using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio
{
    public class Empleado //: Persona
    {
        public int Id { get; set; }
        public int SueldoBruto { get; set; }
        public string Cargo { get; set; }
        /// Relacion entre Empleado y la Empresa
        public Empresa Empleador { get; set; }

        [ForeignKey("Persona")]
        public int PersonaId { get; set; }
        public virtual Persona PerRef { get; set; }

    }
}