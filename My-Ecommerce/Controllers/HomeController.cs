using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using My_Ecommerce.Models;

namespace My_Ecommerce.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            SouqComContext db = new SouqComContext();
            var cats = db.Categories.ToList();
            ViewBag.Products = db.Products.ToList();
            return View(cats);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Categories()
        {
            SouqComContext db = new SouqComContext();
            var cats = db.Categories.ToList();
            return View(cats);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
