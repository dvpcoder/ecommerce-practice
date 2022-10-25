namespace WebApplication1.Models
{
    public class DetalleOrden
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public Orden Orden { get; set; }
        public Producto Producto { get; set; }
    }
}
