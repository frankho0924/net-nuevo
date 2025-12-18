namespace cinco.Models
{
    public class Pedido
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = null!;

        public string Estado { get; set; } = "En proceso";

        public string MetodoPago { get; set; } = string.Empty;

        public List<DetallePedido> Detalles { get; set; } = new();

        public decimal Total => Detalles.Sum(x => x.Subtotal);
    }
}
