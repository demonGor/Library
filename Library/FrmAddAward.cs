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
    public partial class FrmAddAward : Form
    {
        int id_author;
        string name;
        LibraryDataEF.DBLibraryEntities ctx;

        public FrmAddAward(int author_id, string author_name)
        {
            InitializeComponent();
            Text = String.Concat(Text, " ", author_name);

            id_author = author_id;
            name = author_name;
            ctx = new DBLibraryEntities();
            var b = from a in ctx.BOOKS join c in ctx.BOOKS_AUTHORS on a.BK_ID equals c.BA_BK join d in ctx.AUTHORS on c.BA_AU equals d.AU_ID where d.AU_ID == id_author select a;

            
                   
                   
                

            b.Load();
            bOOKSBindingSource.DataSource = ctx.BOOKS.Local.ToBindingList();
            
        }
        private int GetId(string name)
        {
            var a = (from i in ctx.BOOKS where i.BK_NAME == name select i.BK_ID).First();
            return a;
        }

        public FrmAddAward()
        {
            InitializeComponent();
        }

        private void FrmAddAward_Load(object sender, EventArgs e)
        {

        }

        private void btnAddAward_Click(object sender, EventArgs e)
        {

            string name = tBName.Text;
            if (name == "") { MessageBox.Show("Назва нагороди не може бути порожньою", "Помилка введення"); }
            else
            {
                try
                {
                    var a = (from i in ctx.BOOKS_AUTHORS where i.BA_BK == GetId(cBBooks.Text) && i.BA_AU == id_author select i.BA_ID).FirstOrDefault();
                    var date = Convert.ToDateTime   (tBDate.Text);


                
                    string info = tBInfo.Text;
               
                    AWARDS d = new AWARDS();
                    d.AW_DATE = date;
                    d.AW_BA = a;
                    d.AW_NAME = name;
                    d.AW_INFO = info;
                    ctx.AWARDS.Add(d);
                    ctx.SaveChanges();
                   
                 
                    
                }

                catch
                { MessageBox.Show("НЕ ВДАЛОСЯ ДОДАТИ", "Помилка додавання");
                 MessageBox.Show("Не Вірна Дата", "Помилка"); 
            }

                ctx.SaveChanges();
                this.Close();

            }
        }

        private void cBBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddAward_FormClosing(object sender, FormClosingEventArgs e)
        {
            ctx.SaveChanges();
        }
    }
}
