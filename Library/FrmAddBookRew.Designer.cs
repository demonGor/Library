namespace Library
{
    partial class FrmAddBookRew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddBookRew));
            this.btnAddRev = new System.Windows.Forms.Button();
            this.tBRev = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddRev
            // 
            this.btnAddRev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddRev.Location = new System.Drawing.Point(342, 190);
            this.btnAddRev.Name = "btnAddRev";
            this.btnAddRev.Size = new System.Drawing.Size(119, 37);
            this.btnAddRev.TabIndex = 0;
            this.btnAddRev.Text = "Додати відгук";
            this.btnAddRev.UseVisualStyleBackColor = false;
            this.btnAddRev.Click += new System.EventHandler(this.btnAddRev_Click);
            // 
            // tBRev
            // 
            this.tBRev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBRev.Location = new System.Drawing.Point(20, 29);
            this.tBRev.Multiline = true;
            this.tBRev.Name = "tBRev";
            this.tBRev.Size = new System.Drawing.Size(451, 122);
            this.tBRev.TabIndex = 1;
            // 
            // FrmAddBookRew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(483, 261);
            this.Controls.Add(this.tBRev);
            this.Controls.Add(this.btnAddRev);
            this.Name = "FrmAddBookRew";
            this.Text = "Додавання відгуку до книги";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddBookRew_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddBookRew_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        
        private System.Windows.Forms.Button btnAddRev;
        private System.Windows.Forms.TextBox tBRev;
      
    }
}