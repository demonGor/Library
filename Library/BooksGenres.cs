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
    public partial class BooksGenres : Form
    {
        int id_book;
        string name;
        LibraryDataEF.DBLibraryEntities ctx;
        public BooksGenres(int book_id, string book_name)
        {

            InitializeComponent();
            Text = String.Concat(Text, " ", "''", book_name, "''");
           
            id_book = book_id;
            name = book_name;
            ctx = new DBLibraryEntities();
        }
        public BooksGenres()
        {
            InitializeComponent();
            
            
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BooksGenres_Load(object sender, EventArgs e)
        {
            var a = (from i in ctx.GENRES where i.BOOKS_GENRES.Any(x => x.BG_GN == i.GN_ID && x.BG_BK == id_book) select i).ToList();
            var b = (from k in ctx.GENRES select k).ToList();
            var c = b.Except(a);

            gENRESBindingSource.DataSource=c;
        }

        private void cBBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private int GetId(string name)
        {
            var a = (from i in ctx.GENRES where i.GN_NAME == name select i.GN_ID).First();
            return a;
        }
        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            try
            {
                BOOKS_GENRES bk = new BOOKS_GENRES();
                int id = GetId(cBGenres.Text);
                bk.BG_BK = id_book;
                bk.BG_GN = id;
                ctx.BOOKS_GENRES.Add(bk);
                ctx.SaveChanges();

            }
            catch { MessageBox.Show("помилка", "Помилка додавання"); }
            ctx.Dispose();
            this.Close();
        }

        private void cBGenres_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BooksGenres_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
        }
    }
}
