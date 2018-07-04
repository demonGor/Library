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
    public partial class FrmAddBookRew : Form
    {
        int id_book;
        string name;
        private LibraryDataEF.DBLibraryEntities ctx;

        public FrmAddBookRew(int book_id, string book_name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", "''", book_name, "''");
            
            id_book = book_id;
            name = book_name;
            ctx = new DBLibraryEntities();
        }
        public FrmAddBookRew()
        {
            InitializeComponent();
        }

        private void FrmAddBookRew_Load(object sender, EventArgs e)
        {

        }

        private void btnAddRev_Click(object sender, EventArgs e)
        {
            try
            {
                string rew = tBRev.Text;
                BOOKS_REVIEWS Rew = new BOOKS_REVIEWS();
                Rew.BR_BK = id_book;
                Rew.BR_R = rew;
                ctx.BOOKS_REVIEWS.Add(Rew);
                ctx.SaveChanges();

            }
            catch
            { MessageBox.Show("помилка", "Помилка додавання"); }
            this.Close();
        }

        private void FrmAddBookRew_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
        }
    }
}
