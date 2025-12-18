using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cinco.Data;
using cinco.Models;

namespace cinco.Controllers
{
    public class DetallePedidoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DetallePedidoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return RedirectToAction("Index", "Pedido");
        }

        // ==============================
        // EDIT GET
        // ==============================
        public IActionResult Edit(int id)
        {
            var detalle = _context.DetallesPedido
                .Include(d => d.Producto)
                .FirstOrDefault(d => d.DetallePedidoId == id);

            if (detalle == null)
                return NotFound();

            return View(detalle);
        }

        // ==============================
        // EDIT POST
        // ==============================
        [HttpPost]
        public IActionResult Edit(DetallePedido detalle)
        {
            var detalleDb = _context.DetallesPedido
                .Include(d => d.Producto)
                .FirstOrDefault(d => d.DetallePedidoId == detalle.DetallePedidoId);

            if (detalleDb == null)
                return NotFound();

            // 🔄 Ajustar stock según diferencia
            int diferencia = detalle.Cantidad - detalleDb.Cantidad;
            detalleDb.Producto.Stock -= diferencia;

            detalleDb.Cantidad = detalle.Cantidad;

            _context.SaveChanges();

            return RedirectToAction(
                "Details",
                "Pedido",
                new { id = detalleDb.PedidoId }
            );
        }

        // ==============================
        // DELETE
        // ==============================
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var detalle = _context.DetallesPedido
                .Include(d => d.Producto)
                .FirstOrDefault(d => d.DetallePedidoId == id);

            if (detalle == null)
                return NotFound();

            int pedidoId = detalle.PedidoId;

            // ✅ DEVOLVER STOCK
            detalle.Producto.Stock += detalle.Cantidad;

            _context.DetallesPedido.Remove(detalle);
            _context.SaveChanges();

            return RedirectToAction(
                "Details",
                "Pedido",
                new { id = pedidoId }
            );
        }
    }
}
