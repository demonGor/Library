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
    public partial class FindBooksGenres : Form
    {
        int id_genre;
        string name;
        LibraryDataEF.DBLibraryEntities ctx_book;

        public FindBooksGenres()
        {
            InitializeComponent();
            
        }
        public FindBooksGenres(int id,string name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ",name);
            id_genre = id;
            this.name = name;
            ctx_book = new DBLibraryEntities();
            FindBooks();
        }


        private void FindBooksGenres_Load(object sender, EventArgs e)
        {

        }
        public void FindBooks()
        {
            ctx_book.Dispose();
            ctx_book = new DBLibraryEntities();
            var query = (from c in ctx_book.BOOKS where c.BOOKS_GENRES.Any(i=>i.GENRES.GN_ID == id_genre) select c);
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindBooks();
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

        private void dGVBooks_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ctx_book.SaveChanges();
                ctx_book = new DBLibraryEntities();

                BOOKS bk = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                var a = (from i in ctx_book.AUTHORS where i.BOOKS_AUTHORS.Any(x => x.BA_AU == i.AU_ID && x.BA_BK == bk.BK_ID) select i);
                a.Load();

                aUTHORSBindingSource.DataSource = ctx_book.AUTHORS.Local.ToBindingList();

             


            }
            catch { MessageBox.Show("Помилка", "Помилка"); }


        }

        private void btnBookDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)dGVBooks.CurrentRow.Cells["bKIDDataGridViewTextBoxColumn"].Value;
               
                {
                    
                }
               
                {

                    
                    { MessageBox.Show("Видаляти не можна! До книги прив'язані автори!", "Помилка видалення книги"); }

                    
                    { MessageBox.Show("Видаляти не можна! До книги прив'язані відгуки!", "Помилка видалення книги"); }

                   
                    { MessageBox.Show("Видаляти не можна! До книги прив'язані посилання!", "Помилка видалення книги"); }

                   
                    { MessageBox.Show("Видаляти не можна! До книги прив'язані жанри!", "Помилка видалення книги"); }

                }
            }
            catch { MessageBox.Show("Помилка видалення інформації про книгу!", "Видалення інформації про книгу"); }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void FindBooksGenres_FormClosed(object sender, FormClosedEventArgs e)
        {
            ctx_book.SaveChanges();
            ctx_book.Dispose();
        }

        private void btnSaveA_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                BOOKS book = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                AUTHORS author = (AUTHORS)dGVAuthors.CurrentRow.DataBoundItem;
                var g = (from i in ctx_book.BOOKS_AUTHORS where i.BA_BK == book.BK_ID && i.BA_AU == author.AU_ID select i).First();
                var a = (from k in ctx_book.AWARDS where k.AW_BA == g.BA_ID select k).Any();


                if (a)
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

        private void dGVBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                BOOKS book = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                BookReviewsAndSources dialog = new BookReviewsAndSources(book.BK_ID, book.BK_NAME);
                dialog.ShowDialog(this);
                dialog.Dispose();
            }
            catch { MessageBox.Show("Помилка при переході до відгуків", "ПОМИЛКА"); }
        }

        private void dGVAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                AUTHORS author = (AUTHORS)dGVAuthors.CurrentRow.DataBoundItem;
                AuthorReviews dialog = new AuthorReviews(author.AU_ID, author.AU_NAME);
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
    }
    }

