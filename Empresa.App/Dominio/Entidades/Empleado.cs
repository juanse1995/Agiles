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
        public virtual Directivo DirRef { get; set; }

        [ForeignKey("Persona")]
        public int PersonaId { get; set; }
        public virtual Persona PersonaRef { get; set; }

        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        public virtual Empresa EmpresaRef { get; set; }
    }
}