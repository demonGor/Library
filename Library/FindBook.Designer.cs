namespace Library
{
    partial class FindBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBook));
            this.textName = new System.Windows.Forms.TextBox();
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
            this.dGVAuthors = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORSREVIEWSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSAUTHORSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dGVGenres = new System.Windows.Forms.DataGridView();
            this.gNNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNINFODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSGENRESDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gNIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENRESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textInfo = new System.Windows.Forms.TextBox();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.btnDeleteAuthor = new System.Windows.Forms.Button();
            this.btnAddGenre = new System.Windows.Forms.Button();
            this.btnDeleteGenre = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAuthors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENRESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(208, 60);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(326, 20);
            this.textName.TabIndex = 0;
            // 
            // dGVBooks
            // 
            this.dGVBooks.AllowUserToAddRows = false;
            this.dGVBooks.AllowUserToDeleteRows = false;
            this.dGVBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.dGVBooks.Location = new System.Drawing.Point(172, 184);
            this.dGVBooks.Name = "dGVBooks";
            this.dGVBooks.ReadOnly = true;
            this.dGVBooks.Size = new System.Drawing.Size(862, 171);
            this.dGVBooks.TabIndex = 1;
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
            // dGVAuthors
            // 
            this.dGVAuthors.AllowUserToAddRows = false;
            this.dGVAuthors.AllowUserToDeleteRows = false;
            this.dGVAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
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
            this.dGVAuthors.Location = new System.Drawing.Point(628, 453);
            this.dGVAuthors.Name = "dGVAuthors";
            this.dGVAuthors.ReadOnly = true;
            this.dGVAuthors.Size = new System.Drawing.Size(406, 194);
            this.dGVAuthors.TabIndex = 2;
            this.dGVAuthors.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVAuthors_CellContentClick);
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
            // dGVGenres
            // 
            this.dGVGenres.AllowUserToAddRows = false;
            this.dGVGenres.AllowUserToDeleteRows = false;
            this.dGVGenres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dGVGenres.AutoGenerateColumns = false;
            this.dGVGenres.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dGVGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVGenres.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gNNAMEDataGridViewTextBoxColumn,
            this.gNINFODataGridViewTextBoxColumn,
            this.bOOKSGENRESDataGridViewTextBoxColumn1,
            this.gNIDDataGridViewTextBoxColumn});
            this.dGVGenres.DataSource = this.gENRESBindingSource;
            this.dGVGenres.Location = new System.Drawing.Point(172, 453);
            this.dGVGenres.Name = "dGVGenres";
            this.dGVGenres.ReadOnly = true;
            this.dGVGenres.Size = new System.Drawing.Size(406, 194);
            this.dGVGenres.TabIndex = 3;
            // 
            // gNNAMEDataGridViewTextBoxColumn
            // 
            this.gNNAMEDataGridViewTextBoxColumn.DataPropertyName = "GN_NAME";
            this.gNNAMEDataGridViewTextBoxColumn.HeaderText = "Назва жанру";
            this.gNNAMEDataGridViewTextBoxColumn.Name = "gNNAMEDataGridViewTextBoxColumn";
            this.gNNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gNINFODataGridViewTextBoxColumn
            // 
            this.gNINFODataGridViewTextBoxColumn.DataPropertyName = "GN_INFO";
            this.gNINFODataGridViewTextBoxColumn.HeaderText = "Інформація";
            this.gNINFODataGridViewTextBoxColumn.Name = "gNINFODataGridViewTextBoxColumn";
            this.gNINFODataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bOOKSGENRESDataGridViewTextBoxColumn1
            // 
            this.bOOKSGENRESDataGridViewTextBoxColumn1.DataPropertyName = "BOOKS_GENRES";
            this.bOOKSGENRESDataGridViewTextBoxColumn1.HeaderText = "BOOKS_GENRES";
            this.bOOKSGENRESDataGridViewTextBoxColumn1.Name = "bOOKSGENRESDataGridViewTextBoxColumn1";
            this.bOOKSGENRESDataGridViewTextBoxColumn1.ReadOnly = true;
            this.bOOKSGENRESDataGridViewTextBoxColumn1.Visible = false;
            // 
            // gNIDDataGridViewTextBoxColumn
            // 
            this.gNIDDataGridViewTextBoxColumn.DataPropertyName = "GN_ID";
            this.gNIDDataGridViewTextBoxColumn.HeaderText = "GN_ID";
            this.gNIDDataGridViewTextBoxColumn.Name = "gNIDDataGridViewTextBoxColumn";
            this.gNIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.gNIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // gENRESBindingSource
            // 
            this.gENRESBindingSource.DataSource = typeof(LibraryDataEF.GENRES);
            // 
            // textInfo
            // 
            this.textInfo.Location = new System.Drawing.Point(208, 97);
            this.textInfo.Name = "textInfo";
            this.textInfo.Size = new System.Drawing.Size(326, 20);
            this.textInfo.TabIndex = 4;
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(208, 132);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.Size = new System.Drawing.Size(326, 20);
            this.textAuthor.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSearch.Location = new System.Drawing.Point(380, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(119, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Назва";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(88, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Інформація";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(119, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Автор";
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddAuthor.Location = new System.Drawing.Point(637, 414);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(107, 23);
            this.btnAddAuthor.TabIndex = 12;
            this.btnAddAuthor.Text = "Додати автора";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // btnDeleteAuthor
            // 
            this.btnDeleteAuthor.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteAuthor.Location = new System.Drawing.Point(787, 414);
            this.btnDeleteAuthor.Name = "btnDeleteAuthor";
            this.btnDeleteAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAuthor.TabIndex = 13;
            this.btnDeleteAuthor.Text = "Видалити";
            this.btnDeleteAuthor.UseVisualStyleBackColor = false;
            this.btnDeleteAuthor.Click += new System.EventHandler(this.btnDeleteAuthor_Click);
            // 
            // btnAddGenre
            // 
            this.btnAddGenre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddGenre.Location = new System.Drawing.Point(189, 414);
            this.btnAddGenre.Name = "btnAddGenre";
            this.btnAddGenre.Size = new System.Drawing.Size(104, 23);
            this.btnAddGenre.TabIndex = 14;
            this.btnAddGenre.Text = "Додати жанр";
            this.btnAddGenre.UseVisualStyleBackColor = false;
            this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
            // 
            // btnDeleteGenre
            // 
            this.btnDeleteGenre.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteGenre.Location = new System.Drawing.Point(332, 414);
            this.btnDeleteGenre.Name = "btnDeleteGenre";
            this.btnDeleteGenre.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteGenre.TabIndex = 15;
            this.btnDeleteGenre.Text = "Видалити";
            this.btnDeleteGenre.UseVisualStyleBackColor = false;
            this.btnDeleteGenre.Click += new System.EventHandler(this.btnDeleteGenre_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(546, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Результати пошуку";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(281, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Жанри вибраної книги";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(749, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Автори вибраної книги";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(344, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Параметри пошуку";
            // 
            // FindBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1193, 688);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDeleteGenre);
            this.Controls.Add(this.btnAddGenre);
            this.Controls.Add(this.btnDeleteAuthor);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textAuthor);
            this.Controls.Add(this.textInfo);
            this.Controls.Add(this.dGVGenres);
            this.Controls.Add(this.dGVAuthors);
            this.Controls.Add(this.dGVBooks);
            this.Controls.Add(this.textName);
            this.DoubleBuffered = true;
            this.Name = "FindBook";
            this.Text = "Знайти книгу";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindBook_FormClosed);
            this.Load += new System.EventHandler(this.FindBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVAuthors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aUTHORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gENRESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.DataGridView dGVBooks;
        private System.Windows.Forms.DataGridView dGVAuthors;
        private System.Windows.Forms.DataGridView dGVGenres;
        private System.Windows.Forms.TextBox textInfo;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Button btnDeleteAuthor;
        private System.Windows.Forms.Button btnAddGenre;
        private System.Windows.Forms.Button btnDeleteGenre;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn bKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKINFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKRATINGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKIDDataGridViewTextBoxColumn;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn aUNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUINFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNNAMEDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNINFODataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORSREVIEWSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKSAUTHORSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource aUTHORSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNINFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKSGENRESDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn gNIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource gENRESBindingSource;
    }
}