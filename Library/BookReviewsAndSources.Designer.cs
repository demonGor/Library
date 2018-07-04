namespace Library
{
    partial class BookReviewsAndSources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookReviewsAndSources));
            this.label1 = new System.Windows.Forms.Label();
            this.dGVReviews = new System.Windows.Forms.DataGridView();
            this.dGVSources = new System.Windows.Forms.DataGridView();
            this.btnSaveR = new System.Windows.Forms.Button();
            this.btnDeleteR = new System.Windows.Forms.Button();
            this.btnAddR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveS = new System.Windows.Forms.Button();
            this.btnDeleteS = new System.Windows.Forms.Button();
            this.btnAddS = new System.Windows.Forms.Button();
            this.bOOKSREVIEWSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSSOURCESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOOKSDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVReviews)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSREVIEWSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSSOURCESBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(331, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Відгуки про дану книгу";
            // 
            // dGVReviews
            // 
            this.dGVReviews.AllowUserToAddRows = false;
            this.dGVReviews.AllowUserToDeleteRows = false;
            this.dGVReviews.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVReviews.AutoGenerateColumns = false;
            this.dGVReviews.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dGVReviews.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVReviews.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.bOOKSDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dGVReviews.DataSource = this.bOOKSREVIEWSBindingSource;
            this.dGVReviews.Location = new System.Drawing.Point(12, 55);
            this.dGVReviews.Name = "dGVReviews";
            this.dGVReviews.Size = new System.Drawing.Size(523, 192);
            this.dGVReviews.TabIndex = 1;
            // 
            // dGVSources
            // 
            this.dGVSources.AllowUserToAddRows = false;
            this.dGVSources.AllowUserToDeleteRows = false;
            this.dGVSources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVSources.AutoGenerateColumns = false;
            this.dGVSources.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dGVSources.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVSources.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.bOOKSDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dGVSources.DataSource = this.bOOKSSOURCESBindingSource;
            this.dGVSources.Location = new System.Drawing.Point(12, 299);
            this.dGVSources.Name = "dGVSources";
            this.dGVSources.Size = new System.Drawing.Size(523, 217);
            this.dGVSources.TabIndex = 2;
            // 
            // btnSaveR
            // 
            this.btnSaveR.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveR.Location = new System.Drawing.Point(25, 12);
            this.btnSaveR.Name = "btnSaveR";
            this.btnSaveR.Size = new System.Drawing.Size(75, 23);
            this.btnSaveR.TabIndex = 3;
            this.btnSaveR.Text = "Зберегти";
            this.btnSaveR.UseVisualStyleBackColor = false;
            this.btnSaveR.Click += new System.EventHandler(this.btnDeleteR_Click);
            // 
            // btnDeleteR
            // 
            this.btnDeleteR.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteR.Location = new System.Drawing.Point(106, 12);
            this.btnDeleteR.Name = "btnDeleteR";
            this.btnDeleteR.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteR.TabIndex = 4;
            this.btnDeleteR.Text = "Видалити";
            this.btnDeleteR.UseVisualStyleBackColor = false;
            this.btnDeleteR.Click += new System.EventHandler(this.btnSaveR_Click);
            // 
            // btnAddR
            // 
            this.btnAddR.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddR.Location = new System.Drawing.Point(187, 12);
            this.btnAddR.Name = "btnAddR";
            this.btnAddR.Size = new System.Drawing.Size(111, 23);
            this.btnAddR.TabIndex = 5;
            this.btnAddR.Text = "Додати відгук";
            this.btnAddR.UseVisualStyleBackColor = false;
            this.btnAddR.Click += new System.EventHandler(this.btnAddR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(312, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Посилання на дану книгу";
            // 
            // btnSaveS
            // 
            this.btnSaveS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveS.Location = new System.Drawing.Point(25, 270);
            this.btnSaveS.Name = "btnSaveS";
            this.btnSaveS.Size = new System.Drawing.Size(75, 23);
            this.btnSaveS.TabIndex = 7;
            this.btnSaveS.Text = "Зберегти";
            this.btnSaveS.UseVisualStyleBackColor = false;
            this.btnSaveS.Click += new System.EventHandler(this.btnSaveS_Click);
            // 
            // btnDeleteS
            // 
            this.btnDeleteS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDeleteS.Location = new System.Drawing.Point(106, 270);
            this.btnDeleteS.Name = "btnDeleteS";
            this.btnDeleteS.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteS.TabIndex = 8;
            this.btnDeleteS.Text = "Видалити";
            this.btnDeleteS.UseVisualStyleBackColor = false;
            this.btnDeleteS.Click += new System.EventHandler(this.btnDeleteS_Click);
            // 
            // btnAddS
            // 
            this.btnAddS.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddS.Location = new System.Drawing.Point(187, 270);
            this.btnAddS.Name = "btnAddS";
            this.btnAddS.Size = new System.Drawing.Size(111, 23);
            this.btnAddS.TabIndex = 9;
            this.btnAddS.Text = "Додати посилання";
            this.btnAddS.UseVisualStyleBackColor = false;
            this.btnAddS.Click += new System.EventHandler(this.btnAddS_Click);
            // 
            // bOOKSREVIEWSBindingSource
            // 
            this.bOOKSREVIEWSBindingSource.DataSource = typeof(LibraryDataEF.BOOKS_REVIEWS);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BR_R";
            this.dataGridViewTextBoxColumn3.HeaderText = "Відгук";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 480;
            // 
            // bOOKSDataGridViewTextBoxColumn
            // 
            this.bOOKSDataGridViewTextBoxColumn.DataPropertyName = "BOOKS";
            this.bOOKSDataGridViewTextBoxColumn.HeaderText = "BOOKS";
            this.bOOKSDataGridViewTextBoxColumn.Name = "bOOKSDataGridViewTextBoxColumn";
            this.bOOKSDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BR_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "BR_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BR_BK";
            this.dataGridViewTextBoxColumn2.HeaderText = "BR_BK";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // bOOKSSOURCESBindingSource
            // 
            this.bOOKSSOURCESBindingSource.DataSource = typeof(LibraryDataEF.BOOKS_SOURCES);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BS_S";
            this.dataGridViewTextBoxColumn6.HeaderText = "Посилання";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BS_INFO";
            this.dataGridViewTextBoxColumn7.HeaderText = "Інформація";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // bOOKSDataGridViewTextBoxColumn1
            // 
            this.bOOKSDataGridViewTextBoxColumn1.DataPropertyName = "BOOKS";
            this.bOOKSDataGridViewTextBoxColumn1.HeaderText = "BOOKS";
            this.bOOKSDataGridViewTextBoxColumn1.Name = "bOOKSDataGridViewTextBoxColumn1";
            this.bOOKSDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BS_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "BS_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "BS_BK";
            this.dataGridViewTextBoxColumn5.HeaderText = "BS_BK";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // BookReviewsAndSources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(536, 517);
            this.Controls.Add(this.btnAddS);
            this.Controls.Add(this.btnDeleteS);
            this.Controls.Add(this.btnSaveS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddR);
            this.Controls.Add(this.btnDeleteR);
            this.Controls.Add(this.btnSaveR);
            this.Controls.Add(this.dGVSources);
            this.Controls.Add(this.dGVReviews);
            this.Controls.Add(this.label1);
            this.Name = "BookReviewsAndSources";
            this.Text = "Відгуки і посилання на книгу";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BookReviewsAndSources_FormClosed);
            this.Load += new System.EventHandler(this.BookReviewsAndSources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVReviews)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSREVIEWSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSSOURCESBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGVReviews;
        private System.Windows.Forms.DataGridView dGVSources;
        private System.Windows.Forms.Button btnSaveR;
        private System.Windows.Forms.Button btnDeleteR;
        private System.Windows.Forms.Button btnAddR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveS;
        private System.Windows.Forms.Button btnDeleteS;
        private System.Windows.Forms.Button btnAddS;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn bRRDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRBKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bRIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSINFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSBKDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource bOOKSREVIEWSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKSDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource bOOKSSOURCESBindingSource;
    }
}