
namespace Online_Book_Store.Admin
{
    partial class FormAdminControl
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnMusicCD = new System.Windows.Forms.Button();
            this.btnMagazine = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.panelButtom = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelTop.Controls.Add(this.btnCustomer);
            this.panelTop.Controls.Add(this.btnMusicCD);
            this.panelTop.Controls.Add(this.btnMagazine);
            this.panelTop.Controls.Add(this.btnBook);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1058, 159);
            this.panelTop.TabIndex = 0;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(838, 51);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(135, 71);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnMusicCD
            // 
            this.btnMusicCD.Location = new System.Drawing.Point(616, 51);
            this.btnMusicCD.Name = "btnMusicCD";
            this.btnMusicCD.Size = new System.Drawing.Size(135, 71);
            this.btnMusicCD.TabIndex = 2;
            this.btnMusicCD.Text = "Music CD";
            this.btnMusicCD.UseVisualStyleBackColor = true;
            this.btnMusicCD.Click += new System.EventHandler(this.btnMusicCD_Click);
            // 
            // btnMagazine
            // 
            this.btnMagazine.Location = new System.Drawing.Point(360, 51);
            this.btnMagazine.Name = "btnMagazine";
            this.btnMagazine.Size = new System.Drawing.Size(135, 71);
            this.btnMagazine.TabIndex = 1;
            this.btnMagazine.Text = "Magazine";
            this.btnMagazine.UseVisualStyleBackColor = true;
            this.btnMagazine.Click += new System.EventHandler(this.btnMagazine_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(138, 51);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(135, 71);
            this.btnBook.TabIndex = 0;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // panelButtom
            // 
            this.panelButtom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtom.Location = new System.Drawing.Point(0, 165);
            this.panelButtom.Name = "panelButtom";
            this.panelButtom.Size = new System.Drawing.Size(1058, 717);
            this.panelButtom.TabIndex = 0;
            // 
            // FormAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1058, 882);
            this.Controls.Add(this.panelButtom);
            this.Controls.Add(this.panelTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdminControl";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminControl";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminControl_FormClosed);
            this.Load += new System.EventHandler(this.FormAdminControl_Load);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnMusicCD;
        private System.Windows.Forms.Button btnMagazine;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Panel panelButtom;
    }
}