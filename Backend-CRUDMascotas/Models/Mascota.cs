namespace Backend_CRUDMascotas.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public string Raza { get; set; }
        public string Color { get; set; }
        public int Edad { get; set; }
        public float Peso { get; set; }
        public DateTime FechaCreacion { get; set; }
    }
}
