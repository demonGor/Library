using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryDataEF;
namespace WebLibrary.Controllers
{
    public class BooksGenresController : Controller
    {
        private DBLibraryEntities db = new DBLibraryEntities();
        // GET: BooksGenres
        public ActionResult BooksGenresByBook(int id)
        {
            ViewBag.Id = id;
            return PartialView(db.BOOKS_GENRES.Where(k=>k.BG_BK==id).ToList());
        }
        public ActionResult Create(int id)
        {
            BOOKS_GENRES R = new BOOKS_GENRES();
            ViewBag.CmpList1 = db.BOOKS.Where(k => k.BK_ID == id).ToList();
            ViewBag.Book = db.BOOKS.Where(k => k.BK_ID == id).First().BK_NAME;
            var a = (from i in db.GENRES where i.BOOKS_GENRES.Any(x => x.BG_GN == i.GN_ID && x.BG_BK == id) select i).ToList();
            var b = (from k in db.GENRES select k).ToList();
            ViewBag.CmpList2 = b.Except(a);


            return View(R);
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateR(BOOKS_GENRES R)
        {

            try
            {

                if (ModelState.IsValid)
                    db.BOOKS_GENRES.Add(R);
                db.SaveChanges();
                return RedirectToAction("Details", "BOOK", new { id = R.BG_BK });

            }
            catch { return View(R); }
        }
        public ActionResult Delete(int id, int bk_id)
        {
            ViewBag.CmpList = db.BOOKS.Where(k => k.BK_ID == bk_id).ToList();
            var R = (from c in db.BOOKS_GENRES where c.BG_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteR(int id, int bk_id, FormCollection collection)
        {

            var R = (from c in db.BOOKS_GENRES where c.BG_ID == id select c).First();
            try
            {

                db.BOOKS_GENRES.Remove(R);
                db.SaveChanges();
                return RedirectToAction("Details", "BOOK", new { id = bk_id });

            }
            catch { return View(R); }
        }
    }
}