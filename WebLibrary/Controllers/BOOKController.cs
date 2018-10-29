using System;
using System.Linq;
using System.Web.Mvc;
using System.Xml;
using System.IO;
using WebLibrary.Models;
using System.Data.Entity;

namespace WebLibrary.Controllers
{
    public class BOOKController : Controller

    {
      private  DBLibraryEntities1 db = new DBLibraryEntities1();
        // GET: BOOK
        public ActionResult BooksRender(string name,string info)
        {
            var Books = from i in db.BOOKS select i;//вибираємо всі книги
   if (!String.IsNullOrEmpty(name)) { Books = Books.Where(s => s.BK_NAME.Contains(name)); }//фідфільтровуємо за назвою
if (!String.IsNullOrEmpty(info)) { Books = Books.Where(s => s.BK_INFO.Contains(info)); }//фідфільтровуємо за інформацією
           

            return View(Books);
        }
        public ActionResult Edit(int id=0)
        {
            ViewBag.CmpList = db.DICTIONARY_AGE_CATEGORIES.ToList();
            var R = (from c in db.BOOKS where c.BK_ID == id select c).First();
            ViewBag.a = (from i in db.AUTHORS where i.BOOKS.Any(x=> x.BK_ID == id) select i).ToList();
            ViewBag.Authors = db.AUTHORS.ToList();
            ViewBag.Genres = db.GENRES.ToList();
            return View(R);

           
        }
        [HttpPost]
        public ActionResult Edit(BOOKS R, int[] selectedAuthors, int[] selectedGenres)
        {
            BOOKS nr = db.BOOKS.Find(R.BK_ID);
            nr.BK_NAME = R.BK_NAME;
            nr.BK_INFO = R.BK_INFO;
            nr.BK_RATING = R.BK_RATING;
            nr.BK_DAC=R.BK_DAC;
            try
            {



                nr.AUTHORS.Clear();
                nr.GENRES.Clear();
                db.Entry(nr).State = EntityState.Modified;
                ViewBag.CmpList = db.DICTIONARY_AGE_CATEGORIES.ToList();
                ViewBag.a = (from i in db.AUTHORS where i.BOOKS.Any(x => x.BK_ID == R.BK_ID) select i).ToList();
                ViewBag.Authors = db.AUTHORS.ToList();
                ViewBag.Genres = db.GENRES.ToList();
                if (selectedAuthors != null)
                {
                    foreach (var c in db.AUTHORS.Where(co => selectedAuthors.Contains(co.AU_ID)))
                    {
                        nr.AUTHORS.Add(c);
                    }
                }
                if (selectedGenres != null)
                {
                    foreach (var c in db.GENRES.Where(co => selectedGenres.Contains(co.GN_ID)))
                    {

                        nr.GENRES.Add(c);
                    }
                }
                db.Entry(nr).State = EntityState.Modified;


                db.SaveChanges();

                return RedirectToAction("BooksRender");
            }


            catch { return View(R); }
        }

       





        public ActionResult Create()
        {
           BOOKS R = new BOOKS();
          
            ViewBag.CmpList = db.DICTIONARY_AGE_CATEGORIES.ToList();
            ViewBag.Authors = db.AUTHORS.ToList();
            ViewBag.Genres = db.GENRES.ToList();
            return View(R);
        }
        [HttpPost, ActionName("Create")]
        public ActionResult CreateB(BOOKS R, int[] selectedAuthors, int[] selectedGenres)
        {
           
            try

            {
                ViewBag.CmpList = db.DICTIONARY_AGE_CATEGORIES.ToList();
               
                ViewBag.Authors = db.AUTHORS.ToList();
                ViewBag.Genres = db.GENRES.ToList();
                if (selectedAuthors != null)
                {
                    foreach (var c in db.AUTHORS.Where(co => selectedAuthors.Contains(co.AU_ID)))
                    {
                        R.AUTHORS.Add(c);
                    }
                }
                if (selectedGenres != null)
                {
                    foreach (var c in db.GENRES.Where(co => selectedGenres.Contains(co.GN_ID)))
                    {

                        R.GENRES.Add(c);
                    }
                }

                if (ModelState.IsValid)
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
            return View(db.AUTHORS.Where(x=>x.AU_ID==id).First().BOOKS);
        }
        public ActionResult BooksByGenre(int id)

        {
            ViewBag.GenreName = db.GENRES.Where(k => k.GN_ID == id).First().GN_NAME;
            return View(db.GENRES.Where(x => x.GN_ID == id).First().BOOKS);
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
          
            var BR = (from c in db.BOOKS_REVIEWS where c.BR_BK == id select c);
            var BS = (from c in db.BOOKS_SOURCES where c.BS_BK == id select c);
            var B = (from c in db.BOOKS where c.BK_ID == id select c).First();
            try
            {
                db.BOOKS.Where(x => x.BK_ID == id).First().AUTHORS.Clear();
                db.BOOKS.Where(x => x.BK_ID == id).First().GENRES.Clear();
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
    
