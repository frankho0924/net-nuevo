using Microsoft.EntityFrameworkCore;
using cinco.Models;

namespace cinco.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // ==============================
        // TABLAS
        // ==============================
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallesPedido { get; set; }

        // ==============================
        // RELACIONES
        // ==============================
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // CLIENTE → PEDIDOS
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.ClienteId)
                .OnDelete(DeleteBehavior.Restrict);

            // PRODUCTO → DETALLE PEDIDO
            modelBuilder.Entity<DetallePedido>()
                .HasOne(d => d.Producto)
                .WithMany()
                .HasForeignKey(d => d.ProductoId)
                .OnDelete(DeleteBehavior.Restrict);

            // PEDIDO → DETALLES
            modelBuilder.Entity<DetallePedido>()
                .HasOne(d => d.Pedido)
                .WithMany(p => p.Detalles)
                .HasForeignKey(d => d.PedidoId)
                .OnDelete(DeleteBehavior.Cascade);

            // 🔥 MUCHOS A MUCHOS: DETALLE PEDIDO ↔ TOPPING
            modelBuilder.Entity<DetallePedido>()
                .HasMany(d => d.Toppings)
                .WithMany()
                .UsingEntity(j => j.ToTable("DetallePedidoToppings"));
        }
    }
}
