namespace Library
{
    partial class FrmAddAuthorReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddAuthorReview));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAddRev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(25, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 132);
            this.textBox1.TabIndex = 0;
            // 
            // btnAddRev
            // 
            this.btnAddRev.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddRev.Location = new System.Drawing.Point(345, 194);
            this.btnAddRev.Name = "btnAddRev";
            this.btnAddRev.Size = new System.Drawing.Size(122, 41);
            this.btnAddRev.TabIndex = 2;
            this.btnAddRev.Text = "Додати відгук";
            this.btnAddRev.UseVisualStyleBackColor = false;
            this.btnAddRev.Click += new System.EventHandler(this.btnAddRev_Click);
            // 
            // FrmAddAuthorReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(499, 261);
            this.Controls.Add(this.btnAddRev);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmAddAuthorReview";
            this.Text = "Додавання відгука до автора";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddAuthorReview_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddAuthorReview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAddRev;
       
    }
}