using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Persona
    {
        /*[Key]*/
        //public int Persona_id { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Documento { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public virtual Cliente CliRef { get; set; }
        public virtual Empleado EmpRef { get; set; }
    }
}