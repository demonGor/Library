namespace Library
{
    partial class FrmAddBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddBook));
            this.tBName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBDac = new System.Windows.Forms.ComboBox();
            this.dICTIONARYAGECATEGORIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tBRat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dICTIONARYAGECATEGORIESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tBName
            // 
            this.tBName.Location = new System.Drawing.Point(29, 40);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(118, 20);
            this.tBName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(284, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Вікова категорія";
            // 
            // cBDac
            // 
            this.cBDac.DataSource = this.dICTIONARYAGECATEGORIESBindingSource;
            this.cBDac.DisplayMember = "DAC_NAME";
            this.cBDac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBDac.FormattingEnabled = true;
            this.cBDac.Location = new System.Drawing.Point(270, 40);
            this.cBDac.Name = "cBDac";
            this.cBDac.Size = new System.Drawing.Size(121, 21);
            this.cBDac.TabIndex = 3;
            this.cBDac.ValueMember = "DAC_ID";
            // 
            // dICTIONARYAGECATEGORIESBindingSource
            // 
            this.dICTIONARYAGECATEGORIESBindingSource.DataSource = typeof(LibraryDataEF.DICTIONARY_AGE_CATEGORIES);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(62, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Назва";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(263, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "Додати книгу";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBRat
            // 
            this.tBRat.Location = new System.Drawing.Point(44, 93);
            this.tBRat.Name = "tBRat";
            this.tBRat.Size = new System.Drawing.Size(84, 20);
            this.tBRat.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(62, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "рейтинг";
            // 
            // tBInfo
            // 
            this.tBInfo.Location = new System.Drawing.Point(263, 97);
            this.tBInfo.Name = "tBInfo";
            this.tBInfo.Size = new System.Drawing.Size(138, 20);
            this.tBInfo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(301, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Інформація";
            // 
            // FrmAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(413, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBInfo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBRat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBDac);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBName);
            this.Name = "FrmAddBook";
            this.Text = "Додавання книги";
            this.Load += new System.EventHandler(this.FrmAddBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dICTIONARYAGECATEGORIESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.Label label1;
        
        private System.Windows.Forms.ComboBox cBDac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
       
        private System.Windows.Forms.TextBox tBRat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource dICTIONARYAGECATEGORIESBindingSource;
    }
}