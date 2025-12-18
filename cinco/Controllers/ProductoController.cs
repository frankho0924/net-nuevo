using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using cinco.Data;
using cinco.Models;

namespace cinco.Controllers
{
    public class ProductoController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductoController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Productos.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Productos.Add(producto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(producto);
        }

        public IActionResult Edit(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto == null)
                return NotFound();

            return View(producto);
        }

        [HttpPost]
        public IActionResult Edit(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Productos.Update(producto);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(producto);
        }

        // 🔹 MÉTODO QUE FALTABA (CAUSA DEL 404)
        public IActionResult Details(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto == null)
                return NotFound();

            return View(producto);
        }

        public IActionResult Delete(int id)
        {
            var producto = _context.Productos.Find(id);
            if (producto == null)
                return NotFound();

            _context.Productos.Remove(producto);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
