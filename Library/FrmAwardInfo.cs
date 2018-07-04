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
    public partial class FrmAwardInfo : Form
    {
        int aw_id;
        string aw_name;
        LibraryDataEF.DBLibraryEntities ctx;
        public FrmAwardInfo()
        {
            InitializeComponent();
        }
        public FrmAwardInfo(int id,string name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", "''", name, "''");

            aw_id = id;
            aw_name = name;
            ctx = new DBLibraryEntities();
        }

        private void FrmAwardInfo_Load(object sender, EventArgs e)
        {
            var b = (from i in ctx.AWARDS
                     join k in ctx.BOOKS_AUTHORS on i.AW_BA equals k.BA_ID
                     join t in ctx.BOOKS on k.BA_BK equals t.BK_ID
                     join x in ctx.AUTHORS on k.BA_AU equals x.AU_ID
                     where i.AW_ID == aw_id
                     select new
                     {
                         AWARDS = i.AW_NAME,
                         BA_ID = x.AU_ID,
                         BK_ID = t.BK_ID,
                 Data = i.AW_DATE,
                  BA_AU= x.AU_NAME,
                 BOOKS = t.BK_NAME
             }).ToList();
            bOOKSAUTHORSBindingSource.DataSource = b;

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                int id = (int)dGVInfo.CurrentRow.Cells["bABKDataGridViewTextBoxColumn"].Value;
                string name = (string)dGVInfo.CurrentRow.Cells["bOOKSDataGridViewTextBoxColumn"].Value;
                BookReviewsAndSources dialog = new BookReviewsAndSources(id, name);
                dialog.ShowDialog(this);
                int id1 = (int)dGVInfo.CurrentRow.Cells["bAIDDataGridViewTextBoxColumn"].Value;
                string name1 = (string)dGVInfo.CurrentRow.Cells["bAAUDataGridViewTextBoxColumn"].Value;
                AuthorReviews dialog1 = new AuthorReviews(id1, name1);
                dialog1.ShowDialog(this);
                dialog.Dispose();
                dialog1.Dispose();

            }
            catch { MessageBox.Show("Помилка при переході до відгуків", "ПОМИЛКА"); }
        }

        private void bOOKSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void aUTHORSBindingSource_CurrentChanged(object sender, EventArgs e)
        {
                    }

        private void aWARDSBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FrmAwardInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.Dispose();
        }
    }
}
