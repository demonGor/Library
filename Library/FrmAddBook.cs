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
    public partial class FrmAddBook : Form
    {
        private LibraryDataEF.DBLibraryEntities dacC;
        public FrmAddBook()
        {
            InitializeComponent();
            dacC = new LibraryDataEF.DBLibraryEntities();
          
        }

        private void FrmAddBook_Load(object sender, EventArgs e)
        {
            dacC.DICTIONARY_AGE_CATEGORIES.Load();
            dICTIONARYAGECATEGORIESBindingSource.DataSource = dacC.DICTIONARY_AGE_CATEGORIES.Local.ToBindingList();

        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            dacC.Dispose();
        }
        private void button1_Click(object sender, EventArgs e)
        { int buf;
            string name = tBName.Text;
            if (name == "") { MessageBox.Show("Назва книжки не може бути порожньою", "Помилка введення"); }
            else
            if ((!(int.TryParse(tBRat.Text, out buf))) && tBRat.Text != "")

            { MessageBox.Show("Рейтинг повинен бути цілим числом", "Помилка введення"); }
            else
            {

               try { 
                string info = tBInfo.Text;
                int d=GetId(cBDac.Text);
                
                    BOOKS bk = new BOOKS();



                    bk.BK_NAME = name;
                    bk.BK_INFO = info;
                    bk.BK_RATING = buf;
                    bk.BK_DAC = d;
                    
                    dacC.BOOKS.Add(bk);
                    dacC.SaveChanges();
                }
              
                
               catch { MessageBox.Show("НЕ ВДАЛОСЯ ДОДАТИ", "Помилка додавання"); }
                
                
                    this.Close();
                
            }
        }

        private void dICTIONARYAGECATEGORIESBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
        private int GetId(string name)
        {
            var a = (from i in dacC.DICTIONARY_AGE_CATEGORIES where i.DAC_NAME == name select i.DAC_ID).First();
            return a;
        }
    }
}
