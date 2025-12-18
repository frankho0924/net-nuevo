using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cinco.Data;
using cinco.Models;
using System.Text.Json;

namespace cinco.Controllers
{
    public class PedidoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PedidoController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ==============================
        // INDEX
        // ==============================
        public IActionResult Index()
        {
            var pedidos = _context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Detalles)
                    .ThenInclude(d => d.Producto)
                .ToList();

            return View(pedidos);
        }

        // ==============================
        // DETAILS
        // ==============================
        public IActionResult Details(int id)
        {
            var pedido = _context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Detalles)
                    .ThenInclude(d => d.Producto)
                .Include(p => p.Detalles)
                    .ThenInclude(d => d.Toppings)
                .FirstOrDefault(p => p.Id == id);

            if (pedido == null)
                return NotFound();

            return View(pedido);
        }

        // ==============================
        // CREATE GET
        // ==============================
        public IActionResult Create()
        {
            ViewBag.Clientes = _context.Clientes.ToList();
            ViewBag.Productos = _context.Productos.ToList();
            ViewBag.Toppings = _context.Toppings.ToList();

            return View();
        }

        // ==============================
        // CREATE POST
        // ==============================
        [HttpPost]
        public IActionResult Create(int ClienteId, string MetodoPago, string DetallesJson)
        {
            var carrito = JsonSerializer.Deserialize<List<CarritoItem>>(DetallesJson);

            if (carrito == null || carrito.Count == 0)
            {
                ModelState.AddModelError("", "Carrito vacío.");
                return View();
            }

            var pedido = new Pedido
            {
                ClienteId = ClienteId,
                MetodoPago = MetodoPago,
                Estado = "En proceso"
            };

            _context.Pedidos.Add(pedido);
            _context.SaveChanges();

            foreach (var item in carrito)
            {
                var producto = _context.Productos.Find(item.ProductoId);
                if (producto == null) continue;

                _context.DetallesPedido.Add(new DetallePedido
                {
                    PedidoId = pedido.Id,
                    ProductoId = item.ProductoId,
                    Cantidad = item.Cantidad,
                    PrecioUnitario = producto.Precio
                });

                // 🔻 DESCONTAR STOCK
                producto.Stock -= item.Cantidad;
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // ==============================
        // DELETE PEDIDO (🔥 CLAVE)
        // ==============================
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var pedido = _context.Pedidos
                .Include(p => p.Detalles)
                    .ThenInclude(d => d.Producto)
                .FirstOrDefault(p => p.Id == id);

            if (pedido == null)
                return NotFound();

            // ✅ DEVOLVER STOCK DE TODOS LOS PRODUCTOS
            foreach (var detalle in pedido.Detalles)
            {
                detalle.Producto.Stock += detalle.Cantidad;
            }

            _context.Pedidos.Remove(pedido);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // ==============================
        // CAMBIAR ESTADO
        // ==============================
        [HttpPost]
        public IActionResult CambiarEstado(int pedidoId, string nuevoEstado)
        {
            var pedido = _context.Pedidos.Find(pedidoId);
            if (pedido == null)
                return NotFound();

            pedido.Estado = nuevoEstado;
            _context.SaveChanges();

            return RedirectToAction("Details", new { id = pedidoId });
        }
    }

    public class CarritoItem
    {
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }
        public List<int>? ToppingIds { get; set; }
    }
}
