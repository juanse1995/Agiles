namespace Dominio
{
    public class Cliente //: Persona
    {
        public int Id { get; set; }
        public string Telefono { get; set; }
        public Empresa EsCliente { get; set; }

    }
}