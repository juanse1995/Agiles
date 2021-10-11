using System.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Dominio
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Telefono { get; set; }
        //public Empresa EsCliente { get; set; }

        [ForeignKey("Persona")]
        public int PersonaId { get; set; }
        public virtual Persona PerRef { get; set; }

        [ForeignKey("Empresa")]
        public int EmpresaId { get; set; }
        public virtual Empresa EmpRef { get; set; }
    }
}