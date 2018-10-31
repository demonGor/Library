using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryDataEF;
namespace WebLibrary.Controllers
{
    public class CategoriesController : Controller
    {
        private DBLibraryEntities db = new DBLibraryEntities();
        // GET: Categories
        public ActionResult ALLCategories()
        {
            return View(db.DICTIONARY_AGE_CATEGORIES.ToList());
        }
        public ActionResult Edit(int id)
        {
            var R = (from c in db.DICTIONARY_AGE_CATEGORIES where c.DAC_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult EditA(int id, FormCollection collection)
        {
            var R = (from c in db.DICTIONARY_AGE_CATEGORIES where c.DAC_ID == id select c).First();
            try
            {
                UpdateModel(R);
                db.SaveChanges();
                return RedirectToAction("ALLCategories");

            }
            catch { return View(R); }
        }
        public ActionResult Create()
        {
         DICTIONARY_AGE_CATEGORIES R = new DICTIONARY_AGE_CATEGORIES();
           

            return View(R);
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateA(DICTIONARY_AGE_CATEGORIES R)
        {

            try
            {
                if (ModelState.IsValid)
                    db.DICTIONARY_AGE_CATEGORIES.Add(R);
                db.SaveChanges();
                return RedirectToAction("ALLCategories");

            }
            catch { return View(R); }
        }
    }
}