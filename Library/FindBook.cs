using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryDataEF;
using System.Data.Entity;
namespace Library
{
    public partial class FindBook : Form
    {
        LibraryDataEF.DBLibraryEntities ctx_book;
        public FindBook()
        {
            InitializeComponent();
            ctx_book = new DBLibraryEntities();
            FindBooks();

        }

        private void FindBook_Load(object sender, EventArgs e)
        {

        }
        public void FindBooks()
        {
            ctx_book.Dispose();
            ctx_book = new DBLibraryEntities();
            var query = (from c in ctx_book.BOOKS select c);
            if (!(String.IsNullOrWhiteSpace(textName.Text)))

            {
                query = query.Where(c => c.BK_NAME.Contains(textName.Text));
            }
            if (!(String.IsNullOrWhiteSpace(textInfo.Text)))

            {
                query = query.Where(c => c.BK_INFO.Contains(textInfo.Text));
            }
            if (!(String.IsNullOrWhiteSpace(textAuthor.Text)))

            {
                query = query.Where(c => c.BOOKS_AUTHORS.Any(f => f.AUTHORS.AU_NAME.Contains(textAuthor.Text)));
            }
            query.Load();
            bOOKSBindingSource.DataSource = ctx_book.BOOKS.Local.ToBindingList();




        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ctx_book.SaveChanges();
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                BOOKS bk = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                var a = (from c in ctx_book.AUTHORS where c.BOOKS_AUTHORS.Any(f => f.BA_BK == bk.BK_ID) select c).Any();
                var r = (from g in ctx_book.BOOKS_REVIEWS where g.BOOKS.BK_ID == bk.BK_ID select g).Any();

                var s = (from k in ctx_book.BOOKS_SOURCES where k.BOOKS.BK_ID == bk.BK_ID select k).Any();
                var t = (from l in ctx_book.GENRES where l.BOOKS_GENRES.Any(h => h.BG_BK == bk.BK_ID) select l).Any();

                if (!a && !r && !s && !t)
                {
                    bOOKSBindingSource.RemoveCurrent();
                }
                else
                {

                    if (a)
                    { MessageBox.Show("Видаляти не можна! До книги прив'язані автори!", "Помилка видалення книги"); }

                    if (r)
                    { MessageBox.Show("Видаляти не можна! До книги прив'язані відгуки!", "Помилка видалення книги"); }

                    if (s)
                    { MessageBox.Show("Видаляти не можна! До книги прив'язані посилання!", "Помилка видалення книги"); }

                    if (t)
                    { MessageBox.Show("Видаляти не можна! До книги прив'язані жанри!", "Помилка видалення книги"); }

                }
            }
            catch { MessageBox.Show("Помилка видалення інформації про книгу!", "Видалення інформації про книгу"); }

        }

        private void dGVBooks_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
           
            try
            {  ctx_book.SaveChanges();
                ctx_book=new DBLibraryEntities();
               
                BOOKS bk = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                var a = (from i in ctx_book.AUTHORS where i.BOOKS_AUTHORS.Any(x => x.BA_AU == i.AU_ID && x.BA_BK == bk.BK_ID) select i);
                a.Load();
                
                aUTHORSBindingSource.DataSource = ctx_book.AUTHORS.Local.ToBindingList();
                
                var b = (from i in ctx_book.GENRES where i.BOOKS_GENRES.Any(x => x.BG_GN == i.GN_ID && x.BG_BK == bk.BK_ID) select i);
                b.Load();
                gENRESBindingSource.DataSource = ctx_book.GENRES.Local.ToBindingList();
               

            }
            catch { MessageBox.Show("Помилка", "Помилка"); } 
            
          
        }

        private void btnDeleteAuthor_Click(object sender, EventArgs e)
        {
            try
            {
                BOOKS book = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                AUTHORS author = (AUTHORS)dGVAuthors.CurrentRow.DataBoundItem;
                var g = (from i in ctx_book.BOOKS_AUTHORS where i.BA_BK == book.BK_ID && i.BA_AU == author.AU_ID select i).First();
                var a = (from k in ctx_book.AWARDS where k.AW_BA == g.BA_ID select k).Any();
               
             
                if(a)
                {
                    MessageBox.Show("Видаляти не можна! До автора прив'язані нагороди!", "Помилка видалення автора для книги");
                }
                else
                {
                    ctx_book.BOOKS_AUTHORS.Remove(g);
                    ctx_book.SaveChanges();
                    var b = (from i in ctx_book.AUTHORS where i.BOOKS_AUTHORS.Any(x => x.BA_AU == i.AU_ID && x.BA_BK == book.BK_ID) select i).ToList();
                    dGVAuthors.DataSource = b;
                   
                }
            }
            catch { MessageBox.Show("Помилка", "Помилка видалення автора"); }
        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            try
            {

                BOOKS book = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                AuthorsBook dialog = new AuthorsBook(book.BK_ID, book.BK_NAME);
                dialog.ShowDialog(this);
                dialog.Dispose();
                BOOKS bk = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                var a = (from i in ctx_book.AUTHORS where i.BOOKS_AUTHORS.Any(x => x.BA_AU == i.AU_ID && x.BA_BK == bk.BK_ID) select i);
                a.Load();
                aUTHORSBindingSource.DataSource = ctx_book.AUTHORS.Local.ToBindingList();

            }
            catch { MessageBox.Show("Помилка при спробі додавання", "ПОМИЛКА"); }
        }

        private void dGVAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                AUTHORS author = (AUTHORS)dGVAuthors.CurrentRow.DataBoundItem;
                AuthorReviews dialog = new AuthorReviews(author.AU_ID,author.AU_NAME);
                dialog.ShowDialog(this);
                dialog.Dispose();
            }
            catch { MessageBox.Show("Помилка при переході до відгуків", "ПОМИЛКА"); }
        }

        private void dGVBooks_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is NoNullAllowedException)

            {
                MessageBox.Show("Це поле не може бути порожнім!", "ПОМИЛКА");
            }
            if (e.Exception is FormatException)

            {
                MessageBox.Show("Це поле повинно бути цілим!", "ПОМИЛКА");
            }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            try
            {

                BOOKS book = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                GENRES genre = (GENRES)dGVGenres.CurrentRow.DataBoundItem;
                var g =(from i in ctx_book.BOOKS_GENRES where i.BG_BK == book.BK_ID && i.BG_GN == genre.GN_ID select i).First();
                ctx_book.BOOKS_GENRES.Remove(g);
                ctx_book.SaveChanges();
                var b = (from i in ctx_book.GENRES where i.BOOKS_GENRES.Any(x => x.BG_GN == i.GN_ID && x.BG_BK == book.BK_ID) select i).ToList();
                dGVGenres.DataSource = b;
                




            }
            catch
            {
                MessageBox.Show("Помилка", "Помилка видалення жанру");
            }
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            try
            {

                BOOKS book = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                BooksGenres dialog = new BooksGenres(book.BK_ID,book.BK_NAME);
                dialog.ShowDialog(this);
                dialog.Dispose();
                BOOKS bk = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                
                var b = (from i in ctx_book.GENRES where i.BOOKS_GENRES.Any(x => x.BG_GN == i.GN_ID && x.BG_BK == bk.BK_ID) select i);
                b.Load();
                gENRESBindingSource.DataSource = ctx_book.GENRES.Local.ToBindingList();

            }
            catch { MessageBox.Show("Помилка при спробі додавання", "ПОМИЛКА"); }
        }

        private void FindBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            ctx_book.SaveChanges();
            ctx_book.Dispose();

        }

        private void dGVAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindBooks();
        }

        private void dGVBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                BOOKS book = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                BookReviewsAndSources dialog = new BookReviewsAndSources(book.BK_ID,book.BK_NAME);
                dialog.ShowDialog(this);
                dialog.Dispose();
            }
            catch { MessageBox.Show("Помилка при переході до відгуків", "ПОМИЛКА"); }
        }
    }
}
