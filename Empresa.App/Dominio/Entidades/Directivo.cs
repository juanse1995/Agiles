namespace Dominio
{
    public class Directivo //: Empleado
    {
        public int Id { get; set; }
        public int Categoria { get; set; }
        public Empleado Subordinado { get; set; }
        public Empresa Dirige { get; set; }
    }
}