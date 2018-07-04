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
    public partial class FrmAddBookSource : Form
    {
        int id_book;
        string name;
        private LibraryDataEF.DBLibraryEntities ctx;

        public FrmAddBookSource(int book_id, string book_name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", "''", book_name, "''");

            id_book = book_id;
            name = book_name;
            ctx = new DBLibraryEntities();
        }
        public FrmAddBookSource()
        {
            InitializeComponent();
        }

        private void FrmAddBookSource_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string t = tBInfo.Text;
                string s = tBSource.Text;
                BOOKS_SOURCES bs = new BOOKS_SOURCES();
                bs.BS_BK = id_book;
                bs.BS_INFO = t;
                bs.BS_S = s;
                ctx.BOOKS_SOURCES.Add(bs);
                ctx.SaveChanges();
            }
            catch
            { MessageBox.Show("помилка", "Помилка додавання"); }
            this.Close();
        }

        private void FrmAddBookSource_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
        }
    }
}
