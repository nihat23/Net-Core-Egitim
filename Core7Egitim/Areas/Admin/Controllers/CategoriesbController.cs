using Core7Egitim.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Core7Egitim.Areas.Admin.Controllers
{


    [Area("Admin")]

    

    public class CategoriesbController : Controller
    {
        DatabaseContext context = new DatabaseContext();
       

        // GET: CategoriesbController
        public ActionResult Index()
        {
            var listele = context.Categoriesb.ToList();

            return View(listele);
        }

        // GET: CategoriesbController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoriesbController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriesbController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            try
            {
                context.Categoriesb.Add(category); 
                context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesbController/Edit/5
        public ActionResult Edit(int id)
        {
            var model=context.Categoriesb.Find(id);  
             
            return View(model);
        }

        // POST: CategoriesbController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            try
            {
                context.Categoriesb.Update(category);
                context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoriesbController/Delete/5
        public ActionResult Delete(int id)
        { 
            var sil=context.Categoriesb.Find(id);

            return View(sil);
        }

        // POST: CategoriesbController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category  category)
        {
            try
            {
                context.Categoriesb.Remove(category);
                context.SaveChanges();  

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
