namespace Dominio
{
    public class Empleado //: Persona
    {
        public int Id { get; set; }
        public int SueldoBruto { get; set; }
        public string Cargo { get; set; }
        /// Relacion entre Empleado y la Empresa
        public Empresa Empleador { get; set; }

    }
}