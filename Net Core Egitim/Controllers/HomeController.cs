using Microsoft.AspNetCore.Mvc;
using Net_Core_Egitim.Models;
using System.Diagnostics;

namespace Net_Core_Egitim.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            ViewBag.UrunAdi = "Anakart";
            ViewData["vdata"] = "Ekran Kartı";
            TempData["tdata"] = 2500;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string UrunAd, string UrunModel, string UrunFiyat)
        {

            ViewBag.UrunAdi = UrunAd;
            ViewData["vdata"] = UrunModel;
            TempData["tdata"] = UrunFiyat;

            return View();
        }

        public IActionResult ModelKullanimi()
        {

            var model = new urun()
            {
                Name = "Anakart",
                UrunFiyat = 900,
                Aciklama = "Çok iyi Fiyat"
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult ModelKullanimi(urun urun)
        { 
            
            return View(urun);
        }





        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}