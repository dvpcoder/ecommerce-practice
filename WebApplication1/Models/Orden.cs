namespace WebApplication1.Models
{
    public class Orden
    {
        public int Id { get; set; }
        public string Numero { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaRecibida { get; set; }
        public decimal Total { get; set; }
        public Usuario Usuario { get; set; }
        public List<DetalleOrden> DetallesOrden { get; set; }
    }
}
