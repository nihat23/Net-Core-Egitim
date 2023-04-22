using Microsoft.AspNetCore.Mvc;

namespace Net_Core_Egitim.Controllers
{
    public class resultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Yonlendir()
        {
            return Redirect("/Home/Index");//Yonlendır
        }

        public IActionResult Yonlendir1()
        {
            return RedirectToAction("Index");//Yonlendır
        }


        public IActionResult RouteYonlendir1()
        {
            return RedirectToRoute("default", new { Controller = "Home", Action = "Index", id = 1 });
        }
    }
}
