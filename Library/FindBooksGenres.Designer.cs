namespace Library
{
    partial class FindBooksGenres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBooksGenres));
            this.btnSearch = new System.Windows.Forms.Button();
            this.textName = new System.Windows.Forms.TextBox();
            this.textInfo = new System.Windows.Forms.TextBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dGVBooks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bKDACDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSREVIEWSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSSOURCESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSAUTHORSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSGENRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dGVAuthors = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORSREVIEWSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSAUTHORSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(218, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(109, 60);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(219, 20);
            this.textName.TabIndex = 3;
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(109, 86);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(219, 20);
            this.textInfo.TabIndex = 4;
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(109, 119);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(219, 20);
            this.textAuthor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Інформація";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(35, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Назва";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Автор";
            // 
            // dGVBooks
            // 
            this.dGVBooks.AllowUserToAddRows = false;
            this.dGVBooks.AllowUserToDeleteRows = false;
            this.dGVBooks.AutoGenerateColumns = false;
            this.dGVBooks.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dGVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.bKDACDataGridViewTextBoxColumn,
            this.dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn,
            this.bOOKSREVIEWSDataGridViewTextBoxColumn,
            this.bOOKSSOURCESDataGridViewTextBoxColumn,
            this.bOOKSAUTHORSDataGridViewTextBoxColumn,
            this.bOOKSGENRESDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.dGVBooks.DataSource = this.bOOKSBindingSource;
            this.dGVBooks.Location = new System.Drawing.Point(10, 165);
            this.dGVBooks.Name = "dGVBooks";
            this.dGVBooks.ReadOnly = true;
            this.dGVBooks.Size = new System.Drawing.Size(481, 140);
            this.dGVBooks.TabIndex = 9;
            this.dGVBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBooks_CellDoubleClick);
            this.dGVBooks.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBooks_CellMouseEnter);
            this.dGVBooks.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dGVBooks_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BK_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Назва книги";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BK_INFO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Інформація";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BK_RATING";
            this.dataGridViewTextBoxColumn4.HeaderText = "Рейтинг";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // bKDACDataGridViewTextBoxColumn
            // 
            this.bKDACDataGridViewTextBoxColumn.DataPropertyName = "BK_DAC";
            this.bKDACDataGridViewTextBoxColumn.HeaderText = "BK_DAC";
            this.bKDACDataGridViewTextBoxColumn.Name = "bKDACDataGridViewTextBoxColumn";
            this.bKDACDataGridViewTextBoxColumn.ReadOnly = true;
            this.bKDACDataGridViewTextBoxColumn.Visible = false;
            // 
            // dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn
            // 
            this.dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn.DataPropertyName = "DICTIONARY_AGE_CATEGORIES";
            this.dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn.HeaderText = "DICTIONARY_AGE_CATEGORIES";
            this.dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn.Name = "dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn";
            this.dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn.ReadOnly = true;
            this.dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn.Visible = false;
            // 
            // bOOKSREVIEWSDataGridViewTextBoxColumn
            // 
            this.bOOKSREVIEWSDataGridViewTextBoxColumn.DataPropertyName = "BOOKS_REVIEWS";
            this.bOOKSREVIEWSDataGridViewTextBoxColumn.HeaderText = "BOOKS_REVIEWS";
            this.bOOKSREVIEWSDataGridViewTextBoxColumn.Name = "bOOKSREVIEWSDataGridViewTextBoxColumn";
            this.bOOKSREVIEWSDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOOKSREVIEWSDataGridViewTextBoxColumn.Visible = false;
            // 
            // bOOKSSOURCESDataGridViewTextBoxColumn
            // 
            this.bOOKSSOURCESDataGridViewTextBoxColumn.DataPropertyName = "BOOKS_SOURCES";
            this.bOOKSSOURCESDataGridViewTextBoxColumn.HeaderText = "BOOKS_SOURCES";
            this.bOOKSSOURCESDataGridViewTextBoxColumn.Name = "bOOKSSOURCESDataGridViewTextBoxColumn";
            this.bOOKSSOURCESDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOOKSSOURCESDataGridViewTextBoxColumn.Visible = false;
            // 
            // bOOKSAUTHORSDataGridViewTextBoxColumn
            // 
            this.bOOKSAUTHORSDataGridViewTextBoxColumn.DataPropertyName = "BOOKS_AUTHORS";
            this.bOOKSAUTHORSDataGridViewTextBoxColumn.HeaderText = "BOOKS_AUTHORS";
            this.bOOKSAUTHORSDataGridViewTextBoxColumn.Name = "bOOKSAUTHORSDataGridViewTextBoxColumn";
            this.bOOKSAUTHORSDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOOKSAUTHORSDataGridViewTextBoxColumn.Visible = false;
            // 
            // bOOKSGENRESDataGridViewTextBoxColumn
            // 
            this.bOOKSGENRESDataGridViewTextBoxColumn.DataPropertyName = "BOOKS_GENRES";
            this.bOOKSGENRESDataGridViewTextBoxColumn.HeaderText = "BOOKS_GENRES";
            this.bOOKSGENRESDataGridViewTextBoxColumn.Name = "bOOKSGENRESDataGridViewTextBoxColumn";
            this.bOOKSGENRESDataGridViewTextBoxColumn.ReadOnly = true;
            this.bOOKSGENRESDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BK_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BK_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataSource = typeof(LibraryDataEF.BOOKS);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(173, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Результати пошуку";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(147, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Автори вибраної книги";
            // 
            // dGVAuthors
            // 
            this.dGVAuthors.AllowUserToAddRows = false;
            this.dGVAuthors.AllowUserToDeleteRows = false;
            this.dGVAuthors.AutoGenerateColumns = false;
            this.dGVAuthors.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dGVAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.aUTHORSREVIEWSDataGridViewTextBoxColumn,
            this.bOOKSAUTHORSDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.dGVAuthors.DataSource = this.aUTHORSBindingSource;
            this.dGVAuthors.Location = new System.Drawing.Point(10, 377);
            this.dGVAuthors.Name = "dGVAuthors";
            this.dGVAuthors.ReadOnly = true;
            this.dGVAuthors.Size = new System.Drawing.Size(481, 164);
            this.dGVAuthors.TabIndex = 12;
            this.dGVAuthors.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVAuthors_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "AU_NAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "ПІБ";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "AU_INFO";
            this.dataGridViewTextBoxColumn7.HeaderText = "Інформація";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // aUTHORSREVIEWSDataGridViewTextBoxColumn
            // 
            this.aUTHORSREVIEWSDataGridViewTextBoxColumn.DataPropertyName = "AUTHORS_REVIEWS";
            this.aUTHORSREVIEWSDataGridViewTextBoxColumn.HeaderText = "AUTHORS_REVIEWS";
            this.aUTHORSREVIEWSDataGridViewTextBoxColumn.Name = "aUTHORSREVIEWSDataGridViewTextBoxColumn";
            this.aUTHORSREVIEWSDataGridViewTextBoxColumn.ReadOnly = true;
            this.aUTHORSREVIEWSDataGridViewTextBoxColumn.Visible = false;
            // 
            // bOOKSAUTHORSDataGridViewTextBoxColumn1
            // 
            this.bOOKSAUTHORSDataGridViewTextBoxColumn1.DataPropertyName = "BOOKS_AUTHORS";
            this.bOOKSAUTHORSDataGridViewTextBoxColumn1.HeaderText = "BOOKS_AUTHORS";
            this.bOOKSAUTHORSDataGridViewTextBoxColumn1.Name = "bOOKSAUTHORSDataGridViewTextBoxColumn1";
            this.bOOKSAUTHORSDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bOOKSAUTHORSDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "AU_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "AU_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // aUTHORSBindingSource
            // 
            this.aUTHORSBindingSource.DataSource = typeof(LibraryDataEF.AUTHORS);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddAuthor.Location = new System.Drawing.Point(16, 348);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(97, 23);
            this.btnAddAuthor.TabIndex = 13;
            this.btnAddAuthor.Text = "Додати автора";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(132, 348);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(176, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Параметри пошуку";
            // 
            // FindBooksGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(503, 553);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.dGVAuthors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dGVBooks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.btnSearch);
            this.Name = "FindBooksGenres";
            this.Text = "Пошук книг за жанром";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindBooksGenres_FormClosed);
            this.Load += new System.EventHandler(this.FindBooksGenres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dGVBooks;
       
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dGVAuthors;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnDelete;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn bKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKINFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKRATINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUINFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private System.Windows.Forms.BindingSource aUTHORSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKDACDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKSREVIEWSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKSSOURCESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKSAUTHORSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKSGENRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORSREVIEWSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKSAUTHORSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}