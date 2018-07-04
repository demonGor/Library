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
    public partial class AuthorsBook : Form
    {
        private LibraryDataEF.DBLibraryEntities ctx;
        int id_book;
        string name;

        public AuthorsBook(int book_id,string book_name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", "''" ,book_name, "''");
           
            id_book = book_id;
            name = book_name;
            ctx = new DBLibraryEntities();
            
        }
        public AuthorsBook()
        {
            InitializeComponent();
            
        }

        private void AuthorsBook_Load(object sender, EventArgs e)
        {

            var a = (from i in ctx.AUTHORS where i.BOOKS_AUTHORS.Any(x => x.BA_AU == i.AU_ID && x.BA_BK==id_book)   select i).ToList();
            var b = (from k in ctx.AUTHORS select k).ToList();
            var c = b.Except(a);

            aUTHORSBindingSource.DataSource = c;
        }
        private int GetId(string name)
        {
            var a = (from i in ctx.AUTHORS where i.AU_NAME == name select i.AU_ID).First();
            return a;
        }

        private void cBAuthors_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            try {

                BOOKS_AUTHORS bk = new BOOKS_AUTHORS();
                int id = GetId(cBAuthors.Text);
                bk.BA_BK = id_book;
                bk.BA_AU = id;
                ctx.BOOKS_AUTHORS.Add(bk);
                ctx.SaveChanges();
            }
            catch {MessageBox.Show("Помилка", "Помилка додавання"); }
            ctx.Dispose();
            this.Close();
            }
        

        private void cBAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cBAuthors_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void cBAuthors_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cBBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AuthorsBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
        }
    }
}
