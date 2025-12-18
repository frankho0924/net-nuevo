using Microsoft.AspNetCore.Mvc;
using cinco.Data;
using cinco.Models;

namespace cinco.Controllers
{
    public class ToppingController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ToppingController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Toppings.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // ✅ CLAVE
        public IActionResult Create(Topping topping)
        {
            if (!ModelState.IsValid)
                return View(topping);

            _context.Toppings.Add(topping);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var topping = _context.Toppings.Find(id);
            if (topping == null)
                return NotFound();

            _context.Toppings.Remove(topping);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
