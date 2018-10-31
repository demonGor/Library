using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryDataEF;
namespace WebLibrary.Controllers
{
    public class BooksAuthorsController : Controller
    {
        private DBLibraryEntities db = new DBLibraryEntities();
        // GET: BooksAuthors
        public ActionResult BooksAuthorsByBook(int id)
        {
            ViewBag.Id = id;
            return PartialView(db.BOOKS_AUTHORS.Where(k=>k.BA_BK==id).ToList());
        }
        public ActionResult Create(int id)
        {
            BOOKS_AUTHORS R = new BOOKS_AUTHORS();
            ViewBag.CmpList1 = db.BOOKS.Where(k => k.BK_ID == id).ToList();
            ViewBag.Book = db.BOOKS.Where(k => k.BK_ID == id).First().BK_NAME;
            var a = (from i in db.AUTHORS where i.BOOKS_AUTHORS.Any(x => x.BA_AU == i.AU_ID && x.BA_BK == id) select i).ToList();
            var b = (from k in db.AUTHORS select k).ToList();
            ViewBag.CmpList2 = b.Except(a);


            return View(R);
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateR(BOOKS_AUTHORS R)
        {

            try
            {

                if (ModelState.IsValid)
                    db.BOOKS_AUTHORS.Add(R);
                db.SaveChanges();
                return RedirectToAction("Details","BOOK", new { id = R.BA_BK });

            }
            catch { return View(R); }
        }
        public ActionResult Delete(int id, int bk_id)
        {
            ViewBag.CmpList = db.BOOKS.Where(k => k.BK_ID == bk_id).ToList();
            var R = (from c in db.BOOKS_AUTHORS where c.BA_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteR(int id, int bk_id, FormCollection collection)
        {

            var R = (from c in db.BOOKS_AUTHORS where c.BA_ID == id select c).First();
            try
            {

                db.BOOKS_AUTHORS.Remove(R);
                db.SaveChanges();
                return RedirectToAction("Details", "BOOK", new { id = bk_id });

            }
            catch { return View(R); }
        }
    }
}