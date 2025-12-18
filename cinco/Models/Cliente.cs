namespace cinco.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        public required string Nombre { get; set; }

        public required string Direccion { get; set; }

        public required string Telefono { get; set; }

        // 🔹 Nuevo campo opcional
        public string? Telefono2 { get; set; }

        // 🔹 Documento obligatorio (Cédula, NIT, etc.)
        public required string Documento { get; set; }

        public List<Pedido> Pedidos { get; set; } = new();
    }
}
