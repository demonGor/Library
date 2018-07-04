using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using LibraryDataEF;
namespace Library
{
    public partial class FrmLibrary : Form
    {
        Enter my = new Enter();
        private LibraryDataEF.DBLibraryEntities ctx;
        public FrmLibrary()

        {
           
           

            InitializeComponent();
            my.Show();
            System.Threading.Thread.Sleep(7000);
            my.Close();
           
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            ctx = new LibraryDataEF.DBLibraryEntities();
            ctx.AUTHORS.Load();
            aUTHORSBindingSource.DataSource = ctx.AUTHORS.Local.ToBindingList();
            ctx.BOOKS.Load();
            bOOKSBindingSource.DataSource = ctx.BOOKS.Local.ToBindingList();
            ctx.DICTIONARY_AGE_CATEGORIES.Load();
            dICTIONARYAGECATEGORIESBindingSource.DataSource = ctx.DICTIONARY_AGE_CATEGORIES.Local.ToBindingList();
            ctx.GENRES.Load();
            gENRESBindingSource.DataSource = ctx.GENRES.Local.ToBindingList();
            ctx.AWARDS.Load();
            aWARDSBindingSource.DataSource = ctx.AWARDS.Local.ToBindingList();

             
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            ctx.Dispose();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnSaveAuthors_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void dGVAuthors_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Це поле не може бути порожнім!", "ПОМИЛКА");
        }

        private void btnSaveBooks_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnSaveGenres_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnSaveAgeCat_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void dGVBOOKS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddSource_Click(object sender, EventArgs e)
        { try
            {
                ctx.SaveChanges();
                int id = (int)dGVBOOKS.CurrentRow.Cells["bKIDDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVBOOKS.CurrentRow.Cells["bKNAMEDataGridViewTextBoxColumn"].Value;
                FrmAddBookSource dialog = new FrmAddBookSource(id, name);
                dialog.ShowDialog(this);
                dialog.Dispose();
            }
            catch { MessageBox.Show("Помилка при спробі додавання", "ПОМИЛКА"); }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                FrmAddBook dialog = new FrmAddBook();
                dialog.ShowDialog(this);
                dialog.Dispose();
                ctx.BOOKS.Load();
            }
            catch { MessageBox.Show("Помилка при спробі додавання", "ПОМИЛКА"); }
        }

        private void FrmLibrary_Load(object sender, EventArgs e)
        {
           
            
            
        }

        private void btnGenreForBook_Click(object sender, EventArgs e)
        { try
            {
                ctx.SaveChanges();
                int id = (int)dGVBOOKS.CurrentRow.Cells["bKIDDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVBOOKS.CurrentRow.Cells["bKNAMEDataGridViewTextBoxColumn"].Value;
                BooksGenres dialog = new BooksGenres(id, name);
                dialog.ShowDialog(this);
                dialog.Dispose();
            }
            catch { MessageBox.Show("Помилка при спробі додавання", "ПОМИЛКА"); }
        }

        private void btnAddAuthors_Click(object sender, EventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                int id = (int)dGVBOOKS.CurrentRow.Cells["bKIDDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVBOOKS.CurrentRow.Cells["bKNAMEDataGridViewTextBoxColumn"].Value;
                AuthorsBook dialog = new AuthorsBook(id, name);
                dialog.ShowDialog(this);
                dialog.Dispose();
            }
            catch { MessageBox.Show("Помилка при спробі додавання", "ПОМИЛКА"); }
        }

        private void btnDeleteAuthors_Click(object sender, EventArgs e)
        {
            try
            {
                AUTHORS aut = (AUTHORS)dGVAuthors.CurrentRow.DataBoundItem;
                var b = (from c in ctx.BOOKS where c.BOOKS_AUTHORS.Any(f => f.BA_AU == aut.AU_ID) select c).Any();
                var r = (from g in ctx.AUTHORS_REVIEWS where g.AUTHORS.AU_ID==aut.AU_ID select g).Any(); 
                if (!b && !r)
                {
                    aUTHORSBindingSource.RemoveCurrent();
                }
                else {

                    if (b)
                    { MessageBox.Show("Видаляти не можна! До автора прив'язані книги!", "Помилка видалення автора"); }

                    if (r)
                    { MessageBox.Show("Видаляти не можна! До автора прив'язані відгуки!", "Помилка видалення автора"); }

                }
            }
            catch { MessageBox.Show("Помилка видалення інформації про автора!", "Видалення інформації про автора"); }
        }

        private void btnAddBookReview_Click(object sender, EventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                int id = (int)dGVBOOKS.CurrentRow.Cells["bKIDDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVBOOKS.CurrentRow.Cells["bKNAMEDataGridViewTextBoxColumn"].Value;
                FrmAddBookRew dialog = new FrmAddBookRew(id, name);
                dialog.ShowDialog(this);
                dialog.Dispose();
            }
            catch { MessageBox.Show("Помилка при спробі додавання", "ПОМИЛКА"); }
        }

        private void btnAddAReview_Click(object sender, EventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                int id = (int)dGVAuthors.CurrentRow.Cells["aUIDDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVAuthors.CurrentRow.Cells["aUNAMEDataGridViewTextBoxColumn"].Value;
                FrmAddAuthorReview dialog = new FrmAddAuthorReview(id, name);
                dialog.ShowDialog(this);
                dialog.Dispose();
            }
            catch { MessageBox.Show("Помилка при спробі додавання", "ПОМИЛКА"); }
        }

        private void btnSaveAwards_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnAddAwards_Click(object sender, EventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                int id = (int)dGVAuthors.CurrentRow.Cells["aUIDDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVAuthors.CurrentRow.Cells["aUNAMEDataGridViewTextBoxColumn"].Value;
                FrmAddAward dialog = new FrmAddAward(id, name);
                dialog.ShowDialog(this);
                dialog.Dispose();
                ctx.AWARDS.Load();
            }
            catch { MessageBox.Show("Помилка при спробі додавання", "ПОМИЛКА"); }
        }

        private void dGVGENRES_CellErrorTextNeeded(object sender, DataGridViewCellErrorTextNeededEventArgs e)
        {

        }

        private void dGVGENRES_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is NoNullAllowedException)

            {
                MessageBox.Show("Це поле не може бути порожнім!", "ПОМИЛКА");
            }
        }

        private void dGVAGE_CATEGORIES_DataError(object sender, DataGridViewDataErrorEventArgs e)
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

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                BOOKS bk = (BOOKS)dGVBOOKS.CurrentRow.DataBoundItem;
                var a = (from c in ctx.AUTHORS where c.BOOKS_AUTHORS.Any(f => f.BA_BK == bk.BK_ID) select c).Any();
                var r = (from g in ctx.BOOKS_REVIEWS where g.BOOKS.BK_ID == bk.BK_ID select g).Any();

                var s = (from k in ctx.BOOKS_SOURCES where k.BOOKS.BK_ID == bk.BK_ID select k).Any();
                var t = (from l in ctx.GENRES where l.BOOKS_GENRES.Any(h => h.BG_BK == bk.BK_ID) select l).Any();

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

        private void btnDelAwar_Click(object sender, EventArgs e)
        {
            try
            {
                aWARDSBindingSource.RemoveCurrent();
            }
            catch { MessageBox.Show("Помилка видалення інформації про нагороду!", "Видалення інформації про нагороду"); }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            try
            {

                DICTIONARY_AGE_CATEGORIES dac = (DICTIONARY_AGE_CATEGORIES)dGVAGE_CATEGORIES.CurrentRow.DataBoundItem;
                var b = (from i in ctx.BOOKS where i.BK_DAC == dac.DAC_ID select i).Any();
                if (!b)
                {
                    dICTIONARYAGECATEGORIESBindingSource.RemoveCurrent();
                }
                else
                {

                    if (b)
                    { MessageBox.Show("Видаляти не можна! До вікової категорії прив'язані книги!", "Помилка видалення вікової категорії"); }

                }
            }
            catch { MessageBox.Show("Помилка видалення інформації про вікову категорію!", "Видалення інформації про вікову категорію"); }
        }

        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            try
            {
                GENRES gn = (GENRES)dGVGENRES.CurrentRow.DataBoundItem;
                var b = (from a in ctx.BOOKS where a.BOOKS_GENRES.Any(f=>f.BG_GN==gn.GN_ID) select a).Any();
                if (!b)
                {
                    gENRESBindingSource.RemoveCurrent();
                }
                else
                {

                    if (b)
                    { MessageBox.Show("Видаляти не можна! До жанру прив'язані книги!", "Помилка видалення жанру"); }

                }
            }
            catch { MessageBox.Show("Помилка видалення інформації про жанр!", "Видалення інформації про жанр"); }
        }

        private void dGVAwards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dGVGENRES_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dGVGENRES_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                int id = (int)dGVGENRES.CurrentRow.Cells["gNIDDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVGENRES.CurrentRow.Cells["gNNAMEDataGridViewTextBoxColumn"].Value;
                FindBooksGenres dialog = new FindBooksGenres(id, name);
                dialog.ShowDialog(this);
                dialog.Dispose();
                ctx.BOOKS.Load();
            }
            catch { MessageBox.Show("Помилка при переході до книг даного жанру", "ПОМИЛКА"); }
        }

        private void dGVGENRES_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dGVAuthors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                int id = (int)dGVAuthors.CurrentRow.Cells["aUIDDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVAuthors.CurrentRow.Cells["aUNAMEDataGridViewTextBoxColumn"].Value;
                AuthorReviews dialog = new AuthorReviews(id, name);
                dialog.ShowDialog(this);
                dialog.Dispose();
            }
            catch { MessageBox.Show("Помилка при переході до відгуків", "ПОМИЛКА"); }
        }

        private void FrmLibrary_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            MessageBox.Show("ВСІ ЗМІНИ ЗБЕРЕЖЕНО", "Повідомлення");
        }

        private void dGVBOOKS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                int id = (int)dGVBOOKS.CurrentRow.Cells["bKIDDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVBOOKS.CurrentRow.Cells["bKNAMEDataGridViewTextBoxColumn"].Value;
                BookReviewsAndSources dialog = new BookReviewsAndSources(id, name);
                dialog.ShowDialog(this);
                dialog.Dispose();
            }
            catch { MessageBox.Show("Помилка при переході до відгуків", "ПОМИЛКА"); }
        }

       
        
           

        private void dGVAwards_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                int id = (int)dGVAwards.CurrentRow.Cells["aWIDDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVAwards.CurrentRow.Cells["aWNAMEDataGridViewTextBoxColumn"].Value;
                FrmAwardInfo dialog = new FrmAwardInfo(id, name);
                dialog.ShowDialog(this);
                dialog.Dispose();
            }
            catch { MessageBox.Show("Помилка при переході до нагороди", "ПОМИЛКА"); }
        
    }

        private void dGVBOOKS_DataError(object sender, DataGridViewDataErrorEventArgs e)
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

        private void dGVAwards_DataError(object sender, DataGridViewDataErrorEventArgs e)
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

        private void dGVAGE_CATEGORIES_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                int id = (int)dGVAGE_CATEGORIES.CurrentRow.Cells["dACIDDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVAGE_CATEGORIES.CurrentRow.Cells["dACNAMEDataGridViewTextBoxColumn"].Value;
                FindBooksCategory dialog = new FindBooksCategory(id, name);
                dialog.ShowDialog(this);
                dialog.Dispose();
                ctx.BOOKS.Load();
            }
            catch { MessageBox.Show("Помилка при переході до книг даної категорії", "ПОМИЛКА"); }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                
                FindBook dialog = new FindBook();
                dialog.ShowDialog(this);
                dialog.Dispose();
                ctx.BOOKS.Load();
                bOOKSBindingSource.DataSource = ctx.BOOKS.Local.ToBindingList();
                
            }
           
            catch { MessageBox.Show("Помилка при переході до пошуку книг!", "ПОМИЛКА"); }
        }

        private void проРозробникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Розробник інформаційної системи - Студент групи К24 Зазимко Дмитро", "ПРО АВТОРА");
        }

        private void довідкаКористувачаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("Довідник.pdf");
        }

        private void tabAwards_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            

        }

        private void FrmLibrary_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx = new DBLibraryEntities();
            ctx.SaveChanges();
        }
    }
}
