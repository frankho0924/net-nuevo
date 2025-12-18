using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cinco.Data;
using cinco.Models;

namespace cinco.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClienteController(ApplicationDbContext context)
        {
            _context = context;
        }

        // ==============================
        // INDEX
        // ==============================
        public IActionResult Index()
        {
            return View(_context.Clientes.ToList());
        }

        // ==============================
        // CREATE
        // ==============================
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (_context.Clientes.Any(x => x.Nombre == cliente.Nombre))
            {
                TempData["Error"] = "El nombre ya se encuentra registrado.";
                return View(cliente);
            }

            if (_context.Clientes.Any(x => x.Documento == cliente.Documento))
            {
                TempData["Error"] = "El documento ya se encuentra registrado.";
                return View(cliente);
            }

            if (ModelState.IsValid)
            {
                _context.Clientes.Add(cliente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // ==============================
        // EDIT
        // ==============================
        public IActionResult Edit(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente == null) return NotFound();

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            if (_context.Clientes.Any(x => x.Nombre == cliente.Nombre && x.Id != cliente.Id))
            {
                TempData["Error"] = "El nombre ya se encuentra registrado.";
                return View(cliente);
            }

            if (_context.Clientes.Any(x => x.Documento == cliente.Documento && x.Id != cliente.Id))
            {
                TempData["Error"] = "El documento ya se encuentra registrado.";
                return View(cliente);
            }

            if (ModelState.IsValid)
            {
                _context.Clientes.Update(cliente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // ==============================
        // DELETE (GET)
        // ==============================
        public IActionResult Delete(int id)
        {
            var cliente = _context.Clientes.Find(id);
            if (cliente == null)
                return NotFound();

            return View(cliente);
        }

        // ==============================
        // DELETE (POST)
        // ==============================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var cliente = _context.Clientes
                .Include(c => c.Pedidos)
                .FirstOrDefault(c => c.Id == id);

            if (cliente == null)
                return NotFound();

            // 🔒 Regla de negocio: NO borrar si tiene pedidos
            if (cliente.Pedidos.Any())
            {
                TempData["Error"] = "No se puede eliminar el cliente porque tiene pedidos asociados.";
                return RedirectToAction("Index");
            }

            _context.Clientes.Remove(cliente);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
