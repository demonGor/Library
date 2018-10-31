using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryDataEF;
namespace WebLibrary.Controllers
{
    public class AUTHORS_REVIEWSController : Controller
    {
        private DBLibraryEntities db = new DBLibraryEntities();
        // GET: AUTHORS_REVIEWS
        public ActionResult AuthorReviews(int id)
        {
            ViewBag.Id = id;
            ViewBag.AuthorName = db.AUTHORS.Where(k => k.AU_ID == id).First().AU_NAME;
            return View(db.AUTHORS_REVIEWS.Where(k=>k.AR_AU==id));
        }
        public ActionResult Create(int id)
        {
            AUTHORS_REVIEWS R = new AUTHORS_REVIEWS();
            ViewBag.CmpList = db.AUTHORS.Where(k=>k.AU_ID==id).ToList();
            ViewBag.Author = db.AUTHORS.Where(k => k.AU_ID == id).First().AU_NAME;
           


            return View(R);
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateR(AUTHORS_REVIEWS R)
        {

            try
            {

                if (ModelState.IsValid)
                    db.AUTHORS_REVIEWS.Add(R);
                db.SaveChanges();
                return RedirectToAction("AuthorReviews", new { id=R.AR_AU });

            }
            catch { return View(R); }
        }
        public ActionResult Edit(int id,int au_id)
        {
            ViewBag.CmpList = db.AUTHORS.Where(k => k.AU_ID == au_id).ToList();
            ViewBag.Author = db.AUTHORS.Where(k => k.AU_ID == au_id).First().AU_NAME;
            var R = (from c in db.AUTHORS_REVIEWS where c.AR_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult EditB(int id, int au_id, FormCollection collection)
        {
            var R = (from c in db.AUTHORS_REVIEWS where c.AR_ID == id select c).First();
            try
            {
                UpdateModel(R);
                db.SaveChanges();
                return RedirectToAction("AuthorReviews", new { id = au_id });

            }
            catch { return View(R); }
        }
        public ActionResult Delete(int id, int au_id)
        {
            ViewBag.CmpList = db.AUTHORS.Where(k => k.AU_ID == au_id).ToList();
            var R = (from c in db.AUTHORS_REVIEWS where c.AR_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteR(int id,int au_id,FormCollection collection)
        {
           
            var R = (from c in db.AUTHORS_REVIEWS where c.AR_ID == id select c).First();
            try
            {
                
                db.AUTHORS_REVIEWS.Remove(R);
                db.SaveChanges();
                return RedirectToAction("AuthorReviews", new { id = au_id });

            }
            catch { return View(R); }
        }
    }
}