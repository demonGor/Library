namespace Library
{
    partial class AuthorsBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorsBook));
            this.cBAuthors = new System.Windows.Forms.ComboBox();
            this.aUTHORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cBAuthors
            // 
            this.cBAuthors.DataSource = this.aUTHORSBindingSource;
            this.cBAuthors.DisplayMember = "AU_NAME";
            this.cBAuthors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBAuthors.FormattingEnabled = true;
            this.cBAuthors.Location = new System.Drawing.Point(38, 74);
            this.cBAuthors.Name = "cBAuthors";
            this.cBAuthors.Size = new System.Drawing.Size(181, 21);
            this.cBAuthors.TabIndex = 1;
            this.cBAuthors.ValueMember = "AU_ID";
            this.cBAuthors.SelectedIndexChanged += new System.EventHandler(this.cBAuthors_SelectedIndexChanged);
            this.cBAuthors.TextUpdate += new System.EventHandler(this.cBAuthors_TextUpdate);
            this.cBAuthors.SelectedValueChanged += new System.EventHandler(this.cBAuthors_SelectedValueChanged);
            this.cBAuthors.TextChanged += new System.EventHandler(this.cBAuthors_TextChanged);
            // 
            // aUTHORSBindingSource
            // 
            this.aUTHORSBindingSource.DataSource = typeof(LibraryDataEF.AUTHORS);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вибрати автора";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddAuthor.Location = new System.Drawing.Point(261, 117);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(203, 41);
            this.btnAddAuthor.TabIndex = 4;
            this.btnAddAuthor.Text = "Додати вибраного автора";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // AuthorsBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(476, 177);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBAuthors);
            this.Name = "AuthorsBook";
            this.Text = "Додавання автора до книги";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuthorsBook_FormClosing);
            this.Load += new System.EventHandler(this.AuthorsBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cBAuthors;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.BindingSource aUTHORSBindingSource;
    }
}