
using Microsoft.AspNetCore.Mvc;
using UrunYonetimSistemi.Data;
using System.Linq;

namespace UrunYonetimSistemi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Sadece ana sayfayý (hoþ geldiniz yazýsýný vs.) gösterir.
        }
    }
}