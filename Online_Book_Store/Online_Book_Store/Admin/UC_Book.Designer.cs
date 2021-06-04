
namespace Online_Book_Store.Admin
{
    partial class UC_Book
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBoxAuthor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPublisher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxPage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxISBN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPerform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxAuthor
            // 
            this.txtBoxAuthor.Location = new System.Drawing.Point(330, 106);
            this.txtBoxAuthor.Multiline = true;
            this.txtBoxAuthor.Name = "txtBoxAuthor";
            this.txtBoxAuthor.Size = new System.Drawing.Size(212, 23);
            this.txtBoxAuthor.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Author";
            // 
            // txtBoxPublisher
            // 
            this.txtBoxPublisher.Location = new System.Drawing.Point(330, 163);
            this.txtBoxPublisher.Multiline = true;
            this.txtBoxPublisher.Name = "txtBoxPublisher";
            this.txtBoxPublisher.Size = new System.Drawing.Size(212, 23);
            this.txtBoxPublisher.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Publisher";
            // 
            // txtBoxPage
            // 
            this.txtBoxPage.Location = new System.Drawing.Point(330, 36);
            this.txtBoxPage.Multiline = true;
            this.txtBoxPage.Name = "txtBoxPage";
            this.txtBoxPage.Size = new System.Drawing.Size(212, 23);
            this.txtBoxPage.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Page";
            // 
            // txtBoxISBN
            // 
            this.txtBoxISBN.Location = new System.Drawing.Point(330, 237);
            this.txtBoxISBN.Multiline = true;
            this.txtBoxISBN.Name = "txtBoxISBN";
            this.txtBoxISBN.Size = new System.Drawing.Size(212, 23);
            this.txtBoxISBN.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(189, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "ISBN";
            // 
            // btnPerform
            // 
            this.btnPerform.Location = new System.Drawing.Point(616, 286);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(123, 67);
            this.btnPerform.TabIndex = 12;
            this.btnPerform.Text = "Perform";
            this.btnPerform.UseVisualStyleBackColor = true;
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // UC_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.txtBoxISBN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPublisher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxAuthor);
            this.Controls.Add(this.label1);
            this.Name = "UC_Book";
            this.Size = new System.Drawing.Size(803, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPublisher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPerform;
    }
}
