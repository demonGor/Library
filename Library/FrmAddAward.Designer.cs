namespace Library
{
    partial class FrmAddAward
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddAward));
            this.cBBooks = new System.Windows.Forms.ComboBox();
            this.bOOKSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tBName = new System.Windows.Forms.TextBox();
            this.tBDate = new System.Windows.Forms.TextBox();
            this.tBInfo = new System.Windows.Forms.TextBox();
            this.btnAddAward = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cBBooks
            // 
            this.cBBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBBooks.DataSource = this.bOOKSBindingSource;
            this.cBBooks.DisplayMember = "BK_NAME";
            this.cBBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBBooks.FormattingEnabled = true;
            this.cBBooks.Location = new System.Drawing.Point(102, 37);
            this.cBBooks.Name = "cBBooks";
            this.cBBooks.Size = new System.Drawing.Size(121, 21);
            this.cBBooks.TabIndex = 0;
            this.cBBooks.ValueMember = "BK_ID";
            this.cBBooks.SelectedIndexChanged += new System.EventHandler(this.cBBooks_SelectedIndexChanged);
            // 
            // bOOKSBindingSource
            // 
            this.bOOKSBindingSource.DataSource = typeof(LibraryDataEF.BOOKS);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(102, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Виберіть книгу";
            // 
            // tBName
            // 
            this.tBName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBName.Location = new System.Drawing.Point(315, 37);
            this.tBName.Name = "tBName";
            this.tBName.Size = new System.Drawing.Size(164, 20);
            this.tBName.TabIndex = 2;
            // 
            // tBDate
            // 
            this.tBDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBDate.Location = new System.Drawing.Point(99, 163);
            this.tBDate.Name = "tBDate";
            this.tBDate.Size = new System.Drawing.Size(124, 20);
            this.tBDate.TabIndex = 3;
            // 
            // tBInfo
            // 
            this.tBInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBInfo.Location = new System.Drawing.Point(296, 122);
            this.tBInfo.Multiline = true;
            this.tBInfo.Name = "tBInfo";
            this.tBInfo.Size = new System.Drawing.Size(219, 61);
            this.tBInfo.TabIndex = 4;
            // 
            // btnAddAward
            // 
            this.btnAddAward.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddAward.Location = new System.Drawing.Point(413, 230);
            this.btnAddAward.Name = "btnAddAward";
            this.btnAddAward.Size = new System.Drawing.Size(102, 40);
            this.btnAddAward.TabIndex = 5;
            this.btnAddAward.Text = "Додати нагороду";
            this.btnAddAward.UseVisualStyleBackColor = false;
            this.btnAddAward.Click += new System.EventHandler(this.btnAddAward_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(98, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Дата вручення";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(367, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Назва";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(353, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Інформація";
            // 
            // FrmAddAward
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(566, 293);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddAward);
            this.Controls.Add(this.tBInfo);
            this.Controls.Add(this.tBDate);
            this.Controls.Add(this.tBName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBBooks);
            this.Name = "FrmAddAward";
            this.Text = "Додання нагороди ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddAward_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddAward_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bOOKSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBName;
        private System.Windows.Forms.TextBox tBDate;
        private System.Windows.Forms.TextBox tBInfo;
        private System.Windows.Forms.Button btnAddAward;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bOOKSBindingSource;
    }
}