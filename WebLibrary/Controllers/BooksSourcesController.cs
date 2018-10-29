using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLibrary.Models;

namespace WebLibrary.Controllers
{
    public class BooksSourcesController : Controller
    {
        // GET: BooksSources
        private DBLibraryEntities1 db = new DBLibraryEntities1();

        public ActionResult BookSources(int id)
        {
            ViewBag.Id = id;
            ViewBag.Book = db.BOOKS.Where(k => k.BK_ID == id).First().BK_NAME;
            return View(db.BOOKS_SOURCES.Where(k => k.BS_BK == id));
        }
        public ActionResult Create(int id)
        {
            BOOKS_SOURCES R = new BOOKS_SOURCES();
            ViewBag.CmpList = db.BOOKS.Where(k => k.BK_ID == id).ToList();
            ViewBag.Book = db.BOOKS.Where(k => k.BK_ID == id).First().BK_NAME;



            return View(R);
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateR(BOOKS_SOURCES R)
        {

            try
            {

                if (ModelState.IsValid)
                    db.BOOKS_SOURCES.Add(R);
                db.SaveChanges();
                return RedirectToAction("BookSources", new { id = R.BS_BK });

            }
            catch { return View(R); }
        }
        public ActionResult Edit(int id, int bk_id)
        {
            ViewBag.CmpList = db.BOOKS.Where(k => k.BK_ID == bk_id).ToList();
            ViewBag.Book = db.BOOKS.Where(k => k.BK_ID == bk_id).First().BK_NAME;
            var R = (from c in db.BOOKS_SOURCES where c.BS_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult EditB(int id, int bk_id, FormCollection collection)
        {
            var R = (from c in db.BOOKS_SOURCES where c.BS_ID == id select c).First();
            try
            {
                UpdateModel(R);
                db.SaveChanges();
                return RedirectToAction("BookSources", new { id = bk_id });

            }
            catch { return View(R); }
        }
        public ActionResult Delete(int id, int bk_id)
        {
            ViewBag.CmpList = db.BOOKS.Where(k => k.BK_ID == bk_id).ToList();
            var R = (from c in db.BOOKS_SOURCES where c.BS_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteR(int id, int bk_id, FormCollection collection)
        {

            var R = (from c in db.BOOKS_SOURCES where c.BS_ID == id select c).First();
            try
            {

                db.BOOKS_SOURCES.Remove(R);
                db.SaveChanges();
                return RedirectToAction("BookSources", new { id = bk_id });

            }
            catch { return View(R); }
        }
    }
}