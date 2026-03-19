using Microsoft.AspNetCore.Mvc;
using UrunYonetimSistemi.Data;
using System.Linq;

namespace UrunYonetimSistemi.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                return RedirectToAction("Index", "Product");
            }

            ViewBag.Error = "Kullanýcý adý veya þifre yanlýþ";
            return View();
        }
    }
}