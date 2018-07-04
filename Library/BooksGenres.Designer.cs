namespace Library
{
    partial class BooksGenres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BooksGenres));
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cBGenres = new System.Windows.Forms.ComboBox();
            this.gENRESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gENRESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.AutoSize = true;
            this.btnAddGenre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddGenre.Location = new System.Drawing.Point(377, 124);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(84, 33);
            this.btnAddGenre.TabIndex = 0;
            this.btnAddGenre.Text = "Додати";
            this.btnAddGenre.UseVisualStyleBackColor = false;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(55, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Виберіть жанр";
            // 
            // cBGenres
            // 
            this.cBGenres.DataSource = this.gENRESBindingSource;
            this.cBGenres.DisplayMember = "GN_NAME";
            this.cBGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBGenres.FormattingEnabled = true;
            this.cBGenres.Location = new System.Drawing.Point(36, 51);
            this.cBGenres.Name = "cBGenres";
            this.cBGenres.Size = new System.Drawing.Size(162, 21);
            this.cBGenres.TabIndex = 4;
            this.cBGenres.ValueMember = "GN_ID";
            this.cBGenres.SelectedIndexChanged += new System.EventHandler(this.cBGenres_SelectedIndexChanged);
            // 
            // gENRESBindingSource
            // 
            this.gENRESBindingSource.DataSource = typeof(LibraryDataEF.GENRES);
            // 
            // BooksGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(473, 178);
            this.Controls.Add(this.cBGenres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddGenre);
            this.Name = "BooksGenres";
            this.Text = "Додавання жанру до книги";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BooksGenres_FormClosing);
            this.Load += new System.EventHandler(this.BooksGenres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gENRESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBGenres;
        private System.Windows.Forms.BindingSource gENRESBindingSource;
    }
}