using Microsoft.AspNetCore.Mvc;
using UrunYonetimSistemi.Data;
using UrunYonetimSistemi.Models;
using System.Linq;

namespace UrunYonetimSistemi.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        // 1. Ürünleri Listeleme
        public IActionResult Index()
        {
            var products = _context.Products.ToList();
            return View(products);
        }

        // 2. Ürün Ekleme (GET)
        public IActionResult Create()
        {
            return View();
        }

        // 3. Ürün Ekleme (POST)
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                product.CreatedAt = DateTime.UtcNow;

                _context.Products.Add(product);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(product);
        }

        // 4. Ürün Düzenleme (GET)
        public IActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
                return NotFound();
            return View(product);
        }

        // 5. Ürün Düzenleme (POST)
        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        // 6. Ürün Silme (GET)
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
                return NotFound();
            return View(product);
        }

        // 7. Ürün Silme (POST)
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}