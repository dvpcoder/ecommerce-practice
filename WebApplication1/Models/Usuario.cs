namespace WebApplication1.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Username { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Tipo { get; set; }
        public string Password { get; set; }
        public List<Orden> Ordenes { get; set; }

        //public List<Producto> Productos { get; set; }
    }
}
