using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryDataEF;
namespace WebLibrary.Controllers
{
    public class AuthorsController : Controller
    {
        DBLibraryEntities db = new DBLibraryEntities();
        // GET: Authors
        public ActionResult AllAuthors()
        {
            return View(db.AUTHORS.ToList());
        }
        public ActionResult Edit(int id)
        {
            
            var R = (from c in db.AUTHORS where c.AU_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult EditA(int id, FormCollection collection)
        {
            var R = (from c in db.AUTHORS where c.AU_ID == id select c).First();
            try
            {
                UpdateModel(R);
                db.SaveChanges();
                return RedirectToAction("AllAuthors");

            }
            catch { return View(R); }

        }
        public ActionResult Create()
        {
            AUTHORS R = new AUTHORS();
           

            return View(R);
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateA(AUTHORS R)
        {

            try
            {
                if (ModelState.IsValid)
                    db.AUTHORS.Add(R);
                db.SaveChanges();
                return RedirectToAction("AllAuthors");

            }
            catch { return View(R); }
        }
        public ActionResult Delete(int id)
        {
           
            var R = (from c in db.AUTHORS where c.AU_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteA(int id, FormCollection collection)
        {
            var BA = (from c in db.BOOKS_AUTHORS where c.BA_AU == id select c);
           
            var AR = (from c in db.AUTHORS_REVIEWS where c.AR_AU == id select c);
           
            var A = (from c in db.AUTHORS where c.AU_ID == id select c).First();
            try
            {
                db.BOOKS_AUTHORS.RemoveRange(BA);
               
                db.AUTHORS_REVIEWS.RemoveRange(AR);
              
                db.AUTHORS.Remove(A);
                db.SaveChanges();
                return RedirectToAction("AllAuthors");

            }
            catch { return View(A); }
        }
    }
}