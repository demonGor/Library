namespace Library
{
    partial class FrmAwardInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAwardInfo));
            this.dGVInfo = new System.Windows.Forms.DataGridView();
            this.bOOKSAUTHORSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aWARDSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAAUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aWARDSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aUTHORSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bAIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bABKDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dGVInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSAUTHORSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aWARDSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVInfo
            // 
            this.dGVInfo.AllowUserToAddRows = false;
            this.dGVInfo.AllowUserToDeleteRows = false;
            this.dGVInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVInfo.AutoGenerateColumns = false;
            this.dGVInfo.BackgroundColor = System.Drawing.Color.PapayaWhip;
            this.dGVInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bOOKSDataGridViewTextBoxColumn,
            this.bAAUDataGridViewTextBoxColumn,
            this.aWARDSDataGridViewTextBoxColumn,
            this.aUTHORSDataGridViewTextBoxColumn,
            this.bAIDDataGridViewTextBoxColumn,
            this.bABKDataGridViewTextBoxColumn});
            this.dGVInfo.DataSource = this.bOOKSAUTHORSBindingSource;
            this.dGVInfo.Location = new System.Drawing.Point(0, 34);
            this.dGVInfo.Name = "dGVInfo";
            this.dGVInfo.ReadOnly = true;
            this.dGVInfo.Size = new System.Drawing.Size(547, 116);
            this.dGVInfo.TabIndex = 0;
            this.dGVInfo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // bOOKSAUTHORSBindingSource
            // 
            this.bOOKSAUTHORSBindingSource.DataSource = typeof(LibraryDataEF.BOOKS_AUTHORS);
            // 
            // aWARDSBindingSource
            // 
            this.aWARDSBindingSource.DataSource = typeof(LibraryDataEF.AWARDS);
            // 
            // bOOKSDataGridViewTextBoxColumn
            // 
            this.bOOKSDataGridViewTextBoxColumn.DataPropertyName = "BOOKS";
            this.bOOKSDataGridViewTextBoxColumn.HeaderText = "Назва книги";
            this.bOOKSDataGridViewTextBoxColumn.Name = "bOOKSDataGridViewTextBoxColumn";
            this.bOOKSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bAAUDataGridViewTextBoxColumn
            // 
            this.bAAUDataGridViewTextBoxColumn.DataPropertyName = "BA_AU";
            this.bAAUDataGridViewTextBoxColumn.HeaderText = "Автор";
            this.bAAUDataGridViewTextBoxColumn.Name = "bAAUDataGridViewTextBoxColumn";
            this.bAAUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aWARDSDataGridViewTextBoxColumn
            // 
            this.aWARDSDataGridViewTextBoxColumn.DataPropertyName = "AWARDS";
            this.aWARDSDataGridViewTextBoxColumn.HeaderText = "Нагорода";
            this.aWARDSDataGridViewTextBoxColumn.Name = "aWARDSDataGridViewTextBoxColumn";
            this.aWARDSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aUTHORSDataGridViewTextBoxColumn
            // 
            this.aUTHORSDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.aUTHORSDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.aUTHORSDataGridViewTextBoxColumn.Name = "aUTHORSDataGridViewTextBoxColumn";
            this.aUTHORSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bAIDDataGridViewTextBoxColumn
            // 
            this.bAIDDataGridViewTextBoxColumn.DataPropertyName = "BA_ID";
            this.bAIDDataGridViewTextBoxColumn.HeaderText = "BA_ID";
            this.bAIDDataGridViewTextBoxColumn.Name = "bAIDDataGridViewTextBoxColumn";
            this.bAIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bAIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bABKDataGridViewTextBoxColumn
            // 
            this.bABKDataGridViewTextBoxColumn.DataPropertyName = "BK_ID";
            this.bABKDataGridViewTextBoxColumn.HeaderText = "BA_BK";
            this.bABKDataGridViewTextBoxColumn.Name = "bABKDataGridViewTextBoxColumn";
            this.bABKDataGridViewTextBoxColumn.ReadOnly = true;
            this.bABKDataGridViewTextBoxColumn.Visible = false;
            // 
            // FrmAwardInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(547, 150);
            this.Controls.Add(this.dGVInfo);
            this.Name = "FrmAwardInfo";
            this.Text = "Інформація про нагороду";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAwardInfo_FormClosing);
            this.Load += new System.EventHandler(this.FrmAwardInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSAUTHORSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aWARDSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       
        private System.Windows.Forms.DataGridView dGVInfo;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn bKNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWINFODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bKIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWBADataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bOOKSAUTHORSBindingSource;
        private System.Windows.Forms.BindingSource aWARDSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOOKSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAAUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aWARDSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aUTHORSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bAIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bABKDataGridViewTextBoxColumn;
    }
}