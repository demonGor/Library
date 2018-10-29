using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLibrary.Models;

namespace WebLibrary.Controllers
{
    public class GenresController : Controller
    {
        private DBLibraryEntities1 db = new DBLibraryEntities1();
        // GET: Genres
        public ActionResult AllGenres()
        {
            return View(db.GENRES.ToList());
        }
        public ActionResult Edit(int id)
        {
            var R = (from c in db.GENRES where c.GN_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult EditG(int id, FormCollection collection)
        {
            var R = (from c in db.GENRES where c.GN_ID == id select c).First();
            try
            {
                UpdateModel(R);
                db.SaveChanges();
                return RedirectToAction("AllGenres");

            }
            catch { return View(R); }
        }
        public ActionResult Create()
        {
            GENRES R = new GENRES();


            return View(R);
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateG(GENRES R)
        {

            try
            {
                if (ModelState.IsValid)
                    db.GENRES.Add(R);
                db.SaveChanges();
                return RedirectToAction("AllGenres");

            }
            catch { return View(R); }
        }
        public ActionResult Delete(int id)
        {
            var R = (from c in db.GENRES where c.GN_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteG(int id, FormCollection collection)
        {
            
            var R = (from c in db.GENRES where c.GN_ID == id select c).First();
            try
            {
                R.BOOKS.Clear();
                db.GENRES.Remove(R);
                db.SaveChanges();
                return RedirectToAction("AllGenres");

            }
            catch { return View(R); }
        }
    }
}