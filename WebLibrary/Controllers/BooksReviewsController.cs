using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryDataEF;
namespace WebLibrary.Controllers
{
    public class BooksReviewsController : Controller
    {
        private DBLibraryEntities db = new DBLibraryEntities();
        
        public ActionResult BookReviews(int id)
        {
            ViewBag.Id = id;
            ViewBag.Book = db.BOOKS.Where(k => k.BK_ID == id).First().BK_NAME;
            return View(db.BOOKS_REVIEWS.Where(k => k.BR_BK == id));
        }
        public ActionResult Create(int id)
        {
            BOOKS_REVIEWS R = new BOOKS_REVIEWS();
            ViewBag.CmpList = db.BOOKS.Where(k => k.BK_ID == id).ToList();
            ViewBag.Book = db.BOOKS.Where(k => k.BK_ID == id).First().BK_NAME;



            return View(R);
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateR(BOOKS_REVIEWS R)
        {

            try
            {

                if (ModelState.IsValid)
                    db.BOOKS_REVIEWS.Add(R);
                db.SaveChanges();
                return RedirectToAction("BookReviews", new { id = R.BR_BK });

            }
            catch { return View(R); }
        }
        public ActionResult Edit(int id, int bk_id)
        {
            ViewBag.CmpList = db.BOOKS.Where(k => k.BK_ID == bk_id).ToList();
            ViewBag.Book = db.BOOKS.Where(k => k.BK_ID == bk_id).First().BK_NAME;
            var R = (from c in db.BOOKS_REVIEWS where c.BR_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult EditB(int id, int bk_id, FormCollection collection)
        {
            var R = (from c in db.BOOKS_REVIEWS where c.BR_ID == id select c).First();
            try
            {
                UpdateModel(R);
                db.SaveChanges();
                return RedirectToAction("BookReviews", new { id = bk_id });

            }
            catch { return View(R); }
        }
        public ActionResult Delete(int id, int bk_id)
        {
            ViewBag.CmpList = db.BOOKS.Where(k => k.BK_ID == bk_id).ToList();
            var R = (from c in db.BOOKS_REVIEWS where c.BR_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteR(int id, int bk_id, FormCollection collection)
        {

            var R = (from c in db.BOOKS_REVIEWS where c.BR_ID == id select c).First();
            try
            {

                db.BOOKS_REVIEWS.Remove(R);
                db.SaveChanges();
                return RedirectToAction("BookReviews", new { id = bk_id });

            }
            catch { return View(R); }
        }
    }
}