using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LibraryDataEF;
using System.Xml;
using System.IO;

namespace WebLibrary.Controllers
{
    public class BOOKController : Controller
    {
        private DBLibraryEntities db = new DBLibraryEntities();
        // GET: BOOK
        public ActionResult BooksRender(string name,string info)
        {
            var Books = from i in db.BOOKS select i;//вибираємо всі книги
   if (!String.IsNullOrEmpty(name)) { Books = Books.Where(s => s.BK_NAME.Contains(name)); }//фідфільтровуємо за назвою
if (!String.IsNullOrEmpty(info)) { Books = Books.Where(s => s.BK_INFO.Contains(info)); }//фідфільтровуємо за інформацією
           

            return View(Books);
        }
        public ActionResult Edit(int id)
        {
            ViewBag.CmpList = db.DICTIONARY_AGE_CATEGORIES.ToList();
            var R = (from c in db.BOOKS where c.BK_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Edit")]
        public ActionResult EditB(int id, FormCollection collection)
        {
            var R = (from c in db.BOOKS where c.BK_ID == id select c).First();
            try
            {
                UpdateModel(R);
                db.SaveChanges();
                return RedirectToAction("BooksRender");

            }
            catch { return View(R); }
        }

             public ActionResult Create()
        {
            BOOKS R = new BOOKS();
            ViewBag.CmpList = db.DICTIONARY_AGE_CATEGORIES.ToList();
           
            return View(R);
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateB(BOOKS R)
        {
           
            try
            {if (ModelState.IsValid)
                    db.BOOKS.Add(R);
                db.SaveChanges();
                return RedirectToAction("BooksRender");

            }
            catch { return View(R); }
        }
        [NonAction]
        public static string getFilePath(string fileName)

        {

            return Path.Combine(Environment.GetFolderPath(

            Environment.SpecialFolder.Desktop), fileName);

        }
        public ActionResult BooksByCategory(int id)

        {
            ViewBag.Id = id;
            ViewBag.CategoryName = db.DICTIONARY_AGE_CATEGORIES.Where(y => y.DAC_ID == id).First().DAC_NAME;
            var list = db.BOOKS.Where(x => x.BK_DAC == id).ToList();

            var xmlDoc = new XmlDocument();

            XmlElement el;

           //Створення xml декларації

            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8",null));
          //Створення кореневого елементу і додавання його в документ
          el = xmlDoc.CreateElement("BOOKS");
          xmlDoc.AppendChild(el);
            foreach(var a in list)
            {
                var childelmt = xmlDoc.CreateElement("Book");

                var childattr1 = xmlDoc.CreateAttribute("BK_ID");
                childattr1.Value = a.BK_ID.ToString();
                var childattr2 = xmlDoc.CreateAttribute("BK_NAME");
                childattr2.Value = a.BK_NAME.ToString();
                var childattr3 = xmlDoc.CreateAttribute("BK_RATING");
                childattr3.Value = a.BK_RATING.ToString();
                var childattr4 = xmlDoc.CreateAttribute("BK_INFO");
                childattr4.Value = a.BK_INFO.ToString();
                childelmt.Attributes.Append(childattr1);
                childelmt.Attributes.Append(childattr2);
                childelmt.Attributes.Append(childattr3);
                childelmt.Attributes.Append(childattr4);
                el.AppendChild(childelmt);

            }
            xmlDoc.Save(getFilePath("XmlDocumentBooks.xml"));
            return View(db.BOOKS.Where(x => x.BK_DAC == id));
        }
        public ActionResult BooksByAuthor(int id)

        {
            ViewBag.AuthorName =  db.AUTHORS.Where(k=>k.AU_ID==id).First().AU_NAME;
            return View(from c in db.BOOKS join k in db.BOOKS_AUTHORS on c.BK_ID equals k.BA_BK where k.BA_AU == id select c);
        }
        public ActionResult BooksByGenre(int id)

        {
            ViewBag.GenreName = db.GENRES.Where(k => k.GN_ID == id).First().GN_NAME;
            return View(from c in db.BOOKS join k in db.BOOKS_GENRES on c.BK_ID equals k.BG_BK where k.BG_GN == id select c);
        }
        public ActionResult Delete(int id)
        {
            ViewBag.CmpList = db.DICTIONARY_AGE_CATEGORIES.ToList();
            var R = (from c in db.BOOKS where c.BK_ID == id select c).First();
            return View(R);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteB(int id, FormCollection collection)
        {
            var BA = (from c in db.BOOKS_AUTHORS where c.BA_BK== id select c);
            var BG = (from c in db.BOOKS_GENRES where c.BG_BK == id select c);
            var BR = (from c in db.BOOKS_REVIEWS where c.BR_BK == id select c);
            var BS = (from c in db.BOOKS_SOURCES where c.BS_BK == id select c);
            var B = (from c in db.BOOKS where c.BK_ID == id select c).First();
            try
            {
                db.BOOKS_AUTHORS.RemoveRange(BA);
                db.BOOKS_GENRES.RemoveRange(BG);
                db.BOOKS_REVIEWS.RemoveRange(BR);
                db.BOOKS_SOURCES.RemoveRange(BS);
                db.BOOKS.Remove(B);
                db.SaveChanges();
                return RedirectToAction("BooksRender");

            }
            catch { return View(B); }
        }
        public ActionResult Details(int id)
        {
            ViewBag.Id = id;
            ViewBag.Book = db.BOOKS.Where(k => k.BK_ID == id).First().BK_NAME;
            return View();
        }


    }
}
    
