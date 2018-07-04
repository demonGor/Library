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
    public partial class AuthorReviews : Form
    {
        int au_id;
        string name;
        LibraryDataEF.DBLibraryEntities ctx;

        public AuthorReviews(int id_au,string au_name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ",au_name);

            au_id = id_au;
            name = au_name;
            ctx = new DBLibraryEntities();
            var a = from i in ctx.AUTHORS_REVIEWS where i.AR_AU == au_id select i;
            a.Load();
            aUTHORSREVIEWSBindingSource.DataSource = ctx.AUTHORS_REVIEWS.Local.ToBindingList();
          
        }
        public AuthorReviews()
        {
            InitializeComponent();
        }

        private void AuthorReviews_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ctx.SaveChanges();
                int id = au_id;
                string name = this.name; 
                FrmAddAuthorReview dialog = new FrmAddAuthorReview(id, name);
                dialog.ShowDialog(this);
                dialog.Dispose();
                var a = from i in ctx.AUTHORS_REVIEWS where i.AR_AU == au_id select i;
                a.Load();
                aUTHORSREVIEWSBindingSource.DataSource = ctx.AUTHORS_REVIEWS.Local.ToBindingList();

            }
            catch { MessageBox.Show("Помилка при спробі додавання", "ПОМИЛКА"); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ctx.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                aUTHORSREVIEWSBindingSource.RemoveCurrent();
            }
            catch { MessageBox.Show("Помилка видалення відгука!", "Видалення відгука"); }
        }

        private void AuthorReviews_FormClosed(object sender, FormClosedEventArgs e)
        {
            ctx.SaveChanges();
            ctx.Dispose();
        }

        private void dGVReviews_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
