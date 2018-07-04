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
    public partial class FrmAddAuthorReview : Form
    {
        LibraryDataEF.DBLibraryEntities ctx;
        int id_author;
        string name;


        public FrmAddAuthorReview(int author_id, string author_name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", author_name);

            id_author = author_id;
            name = author_name;
            ctx = new DBLibraryEntities();
            

        }
        public FrmAddAuthorReview()
        {
            InitializeComponent();
        }

        private void btnAddRev_Click(object sender, EventArgs e)
        {
            try
            {
                string Rew = textBox1.Text;
                AUTHORS_REVIEWS rew = new AUTHORS_REVIEWS();
                rew.AR_AU = id_author;
                rew.AR_R = Rew;
                ctx.AUTHORS_REVIEWS.Add(rew);
                ctx.SaveChanges();

            }
            catch
            { MessageBox.Show("помилка", "Помилка додавання"); }
            this.Close();
        }

        private void FrmAddAuthorReview_Load(object sender, EventArgs e)
        {

        }

        private void FrmAddAuthorReview_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
        }
    }
}
