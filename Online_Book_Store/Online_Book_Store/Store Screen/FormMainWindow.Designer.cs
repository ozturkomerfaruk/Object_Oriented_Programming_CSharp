
namespace Online_Book_Store
{
    partial class FormMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainWindow));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnProceed = new System.Windows.Forms.Button();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonChngTab = new System.Windows.Forms.Button();
            this.txtBoxDate = new System.Windows.Forms.Label();
            this.panelProducts = new System.Windows.Forms.Panel();
            this.timerDate = new System.Windows.Forms.Timer(this.components);
            this.panelFilter = new System.Windows.Forms.Panel();
            this.checkBoxMagazine = new System.Windows.Forms.CheckBox();
            this.checkBoxCD = new System.Windows.Forms.CheckBox();
            this.checkBoxBook = new System.Windows.Forms.CheckBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.DarkCyan;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.btnProceed);
            this.panelLogo.Controls.Add(this.labelCustomerName);
            this.panelLogo.Controls.Add(this.buttonFilter);
            this.panelLogo.Controls.Add(this.buttonChngTab);
            this.panelLogo.Location = new System.Drawing.Point(0, 31);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1058, 115);
            this.panelLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // btnProceed
            // 
            this.btnProceed.BackColor = System.Drawing.SystemColors.Control;
            this.btnProceed.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProceed.Location = new System.Drawing.Point(650, 50);
            this.btnProceed.Name = "btnProceed";
            this.btnProceed.Size = new System.Drawing.Size(199, 58);
            this.btnProceed.TabIndex = 11;
            this.btnProceed.Text = "Proceed";
            this.btnProceed.UseVisualStyleBackColor = false;
            this.btnProceed.Click += new System.EventHandler(this.btnProceed_Click);
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCustomerName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelCustomerName.Location = new System.Drawing.Point(191, 23);
            this.labelCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(292, 54);
            this.labelCustomerName.TabIndex = 10;
            this.labelCustomerName.Text = "customerName";
            // 
            // buttonFilter
            // 
            this.buttonFilter.BackColor = System.Drawing.SystemColors.Control;
            this.buttonFilter.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFilter.Location = new System.Drawing.Point(650, 50);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(199, 58);
            this.buttonFilter.TabIndex = 9;
            this.buttonFilter.Text = "Filter";
            this.buttonFilter.UseVisualStyleBackColor = false;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonChngTab
            // 
            this.buttonChngTab.BackColor = System.Drawing.SystemColors.Control;
            this.buttonChngTab.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonChngTab.Location = new System.Drawing.Point(856, 50);
            this.buttonChngTab.Name = "buttonChngTab";
            this.buttonChngTab.Size = new System.Drawing.Size(199, 58);
            this.buttonChngTab.TabIndex = 8;
            this.buttonChngTab.Text = "My Cart";
            this.buttonChngTab.UseVisualStyleBackColor = false;
            this.buttonChngTab.Click += new System.EventHandler(this.buttonChngTab_Click);
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.AutoSize = true;
            this.txtBoxDate.BackColor = System.Drawing.SystemColors.Control;
            this.txtBoxDate.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxDate.ForeColor = System.Drawing.Color.Black;
            this.txtBoxDate.Location = new System.Drawing.Point(714, 0);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(58, 28);
            this.txtBoxDate.TabIndex = 4;
            this.txtBoxDate.Text = "DATE";
            // 
            // panelProducts
            // 
            this.panelProducts.AutoScroll = true;
            this.panelProducts.Location = new System.Drawing.Point(0, 153);
            this.panelProducts.Name = "panelProducts";
            this.panelProducts.Size = new System.Drawing.Size(1055, 734);
            this.panelProducts.TabIndex = 3;
            // 
            // timerDate
            // 
            this.timerDate.Interval = 1000;
            this.timerDate.Tick += new System.EventHandler(this.timerDate_Tick);
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelFilter.Controls.Add(this.checkBoxMagazine);
            this.panelFilter.Controls.Add(this.checkBoxCD);
            this.panelFilter.Controls.Add(this.checkBoxBook);
            this.panelFilter.Location = new System.Drawing.Point(650, 152);
            this.panelFilter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(246, 198);
            this.panelFilter.TabIndex = 10;
            // 
            // checkBoxMagazine
            // 
            this.checkBoxMagazine.AutoSize = true;
            this.checkBoxMagazine.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxMagazine.Location = new System.Drawing.Point(14, 130);
            this.checkBoxMagazine.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxMagazine.Name = "checkBoxMagazine";
            this.checkBoxMagazine.Size = new System.Drawing.Size(217, 58);
            this.checkBoxMagazine.TabIndex = 2;
            this.checkBoxMagazine.Text = "Magazine";
            this.checkBoxMagazine.UseVisualStyleBackColor = true;
            this.checkBoxMagazine.CheckedChanged += new System.EventHandler(this.checkBoxMagazine_CheckedChanged);
            // 
            // checkBoxCD
            // 
            this.checkBoxCD.AutoSize = true;
            this.checkBoxCD.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxCD.Location = new System.Drawing.Point(14, 70);
            this.checkBoxCD.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCD.Name = "checkBoxCD";
            this.checkBoxCD.Size = new System.Drawing.Size(202, 58);
            this.checkBoxCD.TabIndex = 1;
            this.checkBoxCD.Text = "MusicCD";
            this.checkBoxCD.UseVisualStyleBackColor = true;
            this.checkBoxCD.CheckedChanged += new System.EventHandler(this.checkBoxCD_CheckedChanged);
            // 
            // checkBoxBook
            // 
            this.checkBoxBook.AutoSize = true;
            this.checkBoxBook.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxBook.Location = new System.Drawing.Point(14, 10);
            this.checkBoxBook.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxBook.Name = "checkBoxBook";
            this.checkBoxBook.Size = new System.Drawing.Size(134, 58);
            this.checkBoxBook.TabIndex = 0;
            this.checkBoxBook.Text = "Book";
            this.checkBoxBook.UseVisualStyleBackColor = true;
            this.checkBoxBook.CheckedChanged += new System.EventHandler(this.checkBoxBook_CheckedChanged);
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1058, 844);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.panelProducts);
            this.Controls.Add(this.panelLogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainWindow";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Store";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBookStore_FormClosed);
            this.Load += new System.EventHandler(this.FormMainWindow_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem menuBookIn;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonChngTab;
        private System.Windows.Forms.Panel panelProducts;
        private System.Windows.Forms.Label txtBoxDate;
        private System.Windows.Forms.Timer timerDate;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.CheckBox checkBoxMagazine;
        private System.Windows.Forms.CheckBox checkBoxCD;
        private System.Windows.Forms.CheckBox checkBoxBook;
        private System.Windows.Forms.ToolStripMenuItem menuSteam;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Button btnProceed;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}