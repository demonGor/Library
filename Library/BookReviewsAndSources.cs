using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using LibraryDataEF;
namespace Library
{
    public partial class BookReviewsAndSources : Form
    {
        
        int bk_id;
        string name;
        LibraryDataEF.DBLibraryEntities ctx;
        public BookReviewsAndSources()
        {
            InitializeComponent();
        }
        public BookReviewsAndSources(int id_bk, string bk_name)
        {
            InitializeComponent();
            
            Text = String.Concat(Text, " ","''",bk_name, "''");

            bk_id = id_bk;
            name = bk_name;
            ctx = new DBLibraryEntities();
            var a = from i in ctx.BOOKS_REVIEWS where i.BR_BK == bk_id select i;
            a.Load();
            bOOKSREVIEWSBindingSource.DataSource = ctx.BOOKS_REVIEWS.Local.ToBindingList();
            var b= from i in ctx.BOOKS_SOURCES where i.BS_BK == bk_id select i;
            b.Load();
            bOOKSSOURCESBindingSource.DataSource = ctx.BOOKS_SOURCES.Local.ToBindingList();

        }

        private void btnSaveS_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnDeleteR_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnSaveR_Click(object sender, EventArgs e)
        {

            try
            {
                bOOKSREVIEWSBindingSource.RemoveCurrent();
            }
            catch { MessageBox.Show("Помилка видалення відгука!", "Видалення відгука"); }
        }

        private void btnDeleteS_Click(object sender, EventArgs e)
        {
            try
            {
                bOOKSSOURCESBindingSource.RemoveCurrent();
            }
            catch { MessageBox.Show("Помилка видалення посилання!", "Видалення посилання"); }
        }

        private void BookReviewsAndSources_FormClosed(object sender, FormClosedEventArgs e)
        {
            ctx.SaveChanges();
            ctx.Dispose();
        }

        private void btnAddR_Click(object sender, EventArgs e)
        {
            try
            { 
           
            int id = bk_id;
            string name = this.name;
            FrmAddBookRew dialog = new FrmAddBookRew(id, name);
            dialog.ShowDialog(this);
            dialog.Dispose();
                var a = from i in ctx.BOOKS_REVIEWS where i.BR_BK == bk_id select i;
                a.Load();
                bOOKSREVIEWSBindingSource.DataSource = ctx.BOOKS_REVIEWS.Local.ToBindingList();
                var b = from i in ctx.BOOKS_SOURCES where i.BS_BK == bk_id select i;
                b.Load();
                bOOKSSOURCESBindingSource.DataSource = ctx.BOOKS_SOURCES.Local.ToBindingList();

            }
            catch { MessageBox.Show("Помилка при спробі додавання", "ПОМИЛКА"); }
}

        private void btnAddS_Click(object sender, EventArgs e)
        {
            try
            {
               
                int id = bk_id;
                string name = this.name;
                FrmAddBookSource dialog = new FrmAddBookSource(id, name);
                dialog.ShowDialog(this);
                dialog.Dispose();
                var a = from i in ctx.BOOKS_REVIEWS where i.BR_BK == bk_id select i;
                a.Load();
                bOOKSREVIEWSBindingSource.DataSource = ctx.BOOKS_REVIEWS.Local.ToBindingList();
                var b = from i in ctx.BOOKS_SOURCES where i.BS_BK == bk_id select i;
                b.Load();
                bOOKSSOURCESBindingSource.DataSource = ctx.BOOKS_SOURCES.Local.ToBindingList();
            }
            catch { MessageBox.Show("Помилка при спробі додавання", "ПОМИЛКА"); }
        }

        private void BookReviewsAndSources_Load(object sender, EventArgs e)
        {

        }
    }
}
