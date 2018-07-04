namespace Library
{
    partial class FindBooksCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBooksCategory));
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBFindName = new System.Windows.Forms.TextBox();
            this.textBFindAuthor = new System.Windows.Forms.TextBox();
            this.textBFindInfo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.dICTIONARYAGECATEGORIESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.dGVGenres = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSGENRESDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENRESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveGen = new System.Windows.Forms.Button();
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
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dICTIONARYAGECATEGORIESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENRESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(225, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Інформація";
            // 
            // textBFindName
            // 
            this.textBFindName.Location = new System.Drawing.Point(117, 63);
            this.textBFindName.Name = "textBFindName";
            this.textBFindName.Size = new System.Drawing.Size(223, 20);
            this.textBFindName.TabIndex = 6;
            // 
            // textBFindAuthor
            // 
            this.textBFindAuthor.Location = new System.Drawing.Point(117, 139);
            this.textBFindAuthor.Name = "textBFindAuthor";
            this.textBFindAuthor.Size = new System.Drawing.Size(223, 20);
            this.textBFindAuthor.TabIndex = 7;
            // 
            // textBFindInfo
            // 
            this.textBFindInfo.Location = new System.Drawing.Point(117, 100);
            this.textBFindInfo.Name = "textBFindInfo";
            this.textBFindInfo.Size = new System.Drawing.Size(223, 20);
            this.textBFindInfo.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(173, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Результати пошуку";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(134, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Жанри та категорія вибраної книги";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DataSource = this.dICTIONARYAGECATEGORIESBindingSource;
            this.comboBoxCategory.DisplayMember = "DAC_NAME";
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(163, 409);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(137, 21);
            this.comboBoxCategory.TabIndex = 12;
            this.comboBoxCategory.ValueMember = "DAC_ID";
            // 
            // dICTIONARYAGECATEGORIESBindingSource
            // 
            this.dICTIONARYAGECATEGORIESBindingSource.DataSource = typeof(LibraryDataEF.DICTIONARY_AGE_CATEGORIES);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Location = new System.Drawing.Point(12, 448);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddGenre.Location = new System.Drawing.Point(111, 448);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(108, 23);
            this.btnAddGenre.TabIndex = 14;
            this.btnAddGenre.Text = "Додати жанр";
            this.btnAddGenre.UseVisualStyleBackColor = false;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // dGVGenres
            // 
            this.dGVGenres.AllowUserToAddRows = false;
            this.dGVGenres.AllowUserToDeleteRows = false;
            this.dGVGenres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVGenres.AutoGenerateColumns = false;
            this.dGVGenres.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dGVGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.bOOKSGENRESDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5});
            this.dGVGenres.DataSource = this.gENRESBindingSource;
            this.dGVGenres.Location = new System.Drawing.Point(2, 488);
            this.dGVGenres.Name = "dGVGenres";
            this.dGVGenres.ReadOnly = true;
            this.dGVGenres.Size = new System.Drawing.Size(511, 158);
            this.dGVGenres.TabIndex = 15;
            this.dGVGenres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVGenres_CellContentClick);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GN_NAME";
            this.dataGridViewTextBoxColumn6.HeaderText = "Назва жанру";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "GN_INFO";
            this.dataGridViewTextBoxColumn7.HeaderText = "Інформація";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // bOOKSGENRESDataGridViewTextBoxColumn1
            // 
            this.bOOKSGENRESDataGridViewTextBoxColumn1.DataPropertyName = "BOOKS_GENRES";
            this.bOOKSGENRESDataGridViewTextBoxColumn1.HeaderText = "BOOKS_GENRES";
            this.bOOKSGENRESDataGridViewTextBoxColumn1.Name = "bOOKSGENRESDataGridViewTextBoxColumn1";
            this.bOOKSGENRESDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bOOKSGENRESDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "GN_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "GN_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // gENRESBindingSource
            // 
            this.gENRESBindingSource.DataSource = typeof(LibraryDataEF.GENRES);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Вікова категорія";
            // 
            // btnSaveGen
            // 
            this.btnSaveGen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveGen.Location = new System.Drawing.Point(318, 409);
            this.btnSaveGen.Name = "btnSaveGen";
            this.btnSaveGen.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGen.TabIndex = 17;
            this.btnSaveGen.Text = "Зберегти";
            this.btnSaveGen.UseVisualStyleBackColor = false;
            this.btnSaveGen.Click += new System.EventHandler(this.btnSaveGen_Click);
            // 
            // dGVBooks
            // 
            this.dGVBooks.AllowUserToAddRows = false;
            this.dGVBooks.AllowUserToDeleteRows = false;
            this.dGVBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dGVBooks.Location = new System.Drawing.Point(2, 206);
            this.dGVBooks.Name = "dGVBooks";
            this.dGVBooks.Size = new System.Drawing.Size(511, 162);
            this.dGVBooks.TabIndex = 18;
            this.dGVBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBooks_CellDoubleClick_1);
            this.dGVBooks.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVBooks_CellMouseEnter_1);
            this.dGVBooks.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dGVBooks_DataError);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BK_NAME";
            this.dataGridViewTextBoxColumn2.HeaderText = "Назва книги";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BK_INFO";
            this.dataGridViewTextBoxColumn3.HeaderText = "Інформація";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BK_RATING";
            this.dataGridViewTextBoxColumn4.HeaderText = "Рейтинг";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bKDACDataGridViewTextBoxColumn
            // 
            this.bKDACDataGridViewTextBoxColumn.DataPropertyName = "BK_DAC";
            this.bKDACDataGridViewTextBoxColumn.HeaderText = "BK_DAC";
            this.bKDACDataGridViewTextBoxColumn.Name = "bKDACDataGridViewTextBoxColumn";
            this.bKDACDataGridViewTextBoxColumn.Visible = false;
            // 
            // dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn
            // 
            this.dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn.DataPropertyName = "DICTIONARY_AGE_CATEGORIES";
            this.dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn.HeaderText = "DICTIONARY_AGE_CATEGORIES";
            this.dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn.Name = "dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn";
            this.dICTIONARYAGECATEGORIESDataGridViewTextBoxColumn.Visible = false;
            // 
            // bOOKSREVIEWSDataGridViewTextBoxColumn
            // 
            this.bOOKSREVIEWSDataGridViewTextBoxColumn.DataPropertyName = "BOOKS_REVIEWS";
            this.bOOKSREVIEWSDataGridViewTextBoxColumn.HeaderText = "BOOKS_REVIEWS";
            this.bOOKSREVIEWSDataGridViewTextBoxColumn.Name = "bOOKSREVIEWSDataGridViewTextBoxColumn";
            this.bOOKSREVIEWSDataGridViewTextBoxColumn.Visible = false;
            // 
            // bOOKSSOURCESDataGridViewTextBoxColumn
            // 
            this.bOOKSSOURCESDataGridViewTextBoxColumn.DataPropertyName = "BOOKS_SOURCES";
            this.bOOKSSOURCESDataGridViewTextBoxColumn.HeaderText = "BOOKS_SOURCES";
            this.bOOKSSOURCESDataGridViewTextBoxColumn.Name = "bOOKSSOURCESDataGridViewTextBoxColumn";
            this.bOOKSSOURCESDataGridViewTextBoxColumn.Visible = false;
            // 
            // bOOKSAUTHORSDataGridViewTextBoxColumn
            // 
            this.bOOKSAUTHORSDataGridViewTextBoxColumn.DataPropertyName = "BOOKS_AUTHORS";
            this.bOOKSAUTHORSDataGridViewTextBoxColumn.HeaderText = "BOOKS_AUTHORS";
            this.bOOKSAUTHORSDataGridViewTextBoxColumn.Name = "bOOKSAUTHORSDataGridViewTextBoxColumn";
            this.bOOKSAUTHORSDataGridViewTextBoxColumn.Visible = false;
            // 
            // bOOKSGENRESDataGridViewTextBoxColumn
            // 
            this.bOOKSGENRESDataGridViewTextBoxColumn.DataPropertyName = "BOOKS_GENRES";
            this.bOOKSGENRESDataGridViewTextBoxColumn.HeaderText = "BOOKS_GENRES";
            this.bOOKSGENRESDataGridViewTextBoxColumn.Name = "bOOKSGENRESDataGridViewTextBoxColumn";
            this.bOOKSGENRESDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BK_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BK_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataSource = typeof(LibraryDataEF.BOOKS);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(176, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Параметри пошуку";
            // 
            // FindBooksCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(514, 647);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dGVBooks);
            this.Controls.Add(this.btnSaveGen);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dGVGenres);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBFindInfo);
            this.Controls.Add(this.textBFindAuthor);
            this.Controls.Add(this.textBFindName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Name = "FindBooksCategory";
            this.Text = "Книги за віковою категорією";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindBooksCategory_FormClosed);
            this.Load += new System.EventHandler(this.FindBooksCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dICTIONARYAGECATEGORIESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENRESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBFindName;
        private System.Windows.Forms.TextBox textBFindAuthor;
        private System.Windows.Forms.TextBox textBFindInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.DataGridView dGVGenres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSaveGen;
       
        private System.Windows.Forms.DataGridView dGVBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNINFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKINFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKRATINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dACIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dACNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource dICTIONARYAGECATEGORIESBindingSource;
        private System.Windows.Forms.BindingSource gENRESBindingSource;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKSGENRESDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
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
    }
}