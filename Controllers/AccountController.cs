using Microsoft.AspNetCore.Mvc;
using UrunYonetimSistemi.Data;
using UrunYonetimSistemi.Models;
using System.Linq;

namespace UrunYonetimSistemi.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        public AccountController(AppDbContext context)
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
                .FirstOrDefault(x => x.Username == username && x.Password == password);

            if (user != null)
            {
                return RedirectToAction("Index", "Product");
            }

            ViewBag.Error = "Kullanýcý adý veya þifre hatalý";
            return View();
        }
    }
}