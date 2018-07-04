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
    public partial class FindBooksCategory : Form
    {
        int id_cat;
        string name;
        LibraryDataEF.DBLibraryEntities ctx_book;
        public FindBooksCategory()
        {
            InitializeComponent();
        }
        public FindBooksCategory(int id, string name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", name);
            id_cat = id;
            this.name = name;
            ctx_book = new DBLibraryEntities();
            FindBooks();
            ctx_book.DICTIONARY_AGE_CATEGORIES.Load();
            dICTIONARYAGECATEGORIESBindingSource.DataSource = ctx_book.DICTIONARY_AGE_CATEGORIES.Local.ToBindingList();
            comboBoxCategory.Text = name;

        }

        private void FindBooksCategory_Load(object sender, EventArgs e)
        {
           
        }
        public void FindBooks()
        {
            ctx_book.Dispose();
            ctx_book = new DBLibraryEntities();
            var query = (from c in ctx_book.BOOKS where c.BK_DAC == id_cat select c);
            if (!(String.IsNullOrWhiteSpace(textBFindName.Text)))

            {
                query = query.Where(c => c.BK_NAME.Contains(textBFindName.Text));
            }
            if (!(String.IsNullOrWhiteSpace(textBFindInfo.Text)))

            {
                query = query.Where(c => c.BK_INFO.Contains(textBFindInfo.Text));
            }
            if (!(String.IsNullOrWhiteSpace(textBFindAuthor.Text)))

            {
                query = query.Where(c => c.BOOKS_AUTHORS.Any(f=>f.AUTHORS.AU_NAME.Contains(textBFindAuthor.Text)));
            }
            query.Load();
            bOOKSBindingSource.DataSource = ctx_book.BOOKS.Local.ToBindingList();






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

        private void dGVBooks_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ctx_book.SaveChanges();
                ctx_book = new DBLibraryEntities();

                BOOKS bk = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
              

                var b = (from i in ctx_book.GENRES where i.BOOKS_GENRES.Any(x => x.BG_GN == i.GN_ID && x.BG_BK == bk.BK_ID) select i);
                b.Load();
                gENRESBindingSource.DataSource = ctx_book.GENRES.Local.ToBindingList();
                
                

            }
            catch { MessageBox.Show("Помилка", "Помилка"); }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FindBooks();
        }

        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            try
            {

                BOOKS book = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                BooksGenres dialog = new BooksGenres(book.BK_ID, book.BK_NAME);
                dialog.ShowDialog(this);
                dialog.Dispose();
               
            }
            catch { MessageBox.Show("Помилка при спробі додавання", "ПОМИЛКА"); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                BOOKS book = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                GENRES genre = (GENRES)dGVGenres.CurrentRow.DataBoundItem;
                var g = (from i in ctx_book.BOOKS_GENRES where i.BG_BK == book.BK_ID && i.BG_GN == genre.GN_ID select i).First();
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
        private int GetId(string name)
        {
            var a = (from i in ctx_book.DICTIONARY_AGE_CATEGORIES where i.DAC_NAME == name select i.DAC_ID).First();
            return a;
        }

        private void btnSaveGen_Click(object sender, EventArgs e)
        {
            try
            {
                BOOKS book = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;
                var a = (from i in ctx_book.BOOKS where i.BK_ID == book.BK_ID select i).First();
               if (comboBoxCategory.Text==name)
                {
                    MessageBox.Show("Категорію не змінено!", "Зміна категорії");
                }
               else
                { a.BK_DAC = GetId(comboBoxCategory.Text);
                    ctx_book.SaveChanges();
                }
                
            }
            catch { MessageBox.Show("Помилка при зміні категорії!", "Зміна категорії"); }
        }


      

        private void FindBooksCategory_FormClosed(object sender, FormClosedEventArgs e)
        {
            ctx_book.SaveChanges();
            ctx_book.Dispose();
        }

        private void dGVBooks_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void dGVBooks_CellMouseEnter_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                ctx_book.SaveChanges();
                ctx_book = new DBLibraryEntities();

                BOOKS bk = (BOOKS)dGVBooks.CurrentRow.DataBoundItem;


                var b = (from i in ctx_book.GENRES where i.BOOKS_GENRES.Any(x => x.BG_GN == i.GN_ID && x.BG_BK == bk.BK_ID) select i);
                b.Load();
                gENRESBindingSource.DataSource = ctx_book.GENRES.Local.ToBindingList();


            }
            catch { MessageBox.Show("Помилка", "Помилка"); }
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

        private void dGVGenres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
