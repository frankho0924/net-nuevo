namespace cinco.Models
{
    public class DetallePedido
    {
        public int DetallePedidoId { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; } = null!;

        public int ProductoId { get; set; }
        public Producto Producto { get; set; } = null!;

        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }

        public List<Topping> Toppings { get; set; } = new();

        // ✅ CORRECCIÓN: toppings por cantidad
        public decimal Subtotal =>
            (Cantidad * PrecioUnitario) +
            (Cantidad * Toppings.Sum(t => t.Precio));
    }
}
