
namespace Online_Book_Store.Admin
{
    partial class UC_Magazine
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
            this.txtBoxIssueMagazine = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMagazineType = new System.Windows.Forms.ComboBox();
            this.btnPerform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxIssueMagazine
            // 
            this.txtBoxIssueMagazine.Location = new System.Drawing.Point(346, 79);
            this.txtBoxIssueMagazine.Multiline = true;
            this.txtBoxIssueMagazine.Name = "txtBoxIssueMagazine";
            this.txtBoxIssueMagazine.Size = new System.Drawing.Size(212, 23);
            this.txtBoxIssueMagazine.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Issue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Magazine Type";
            // 
            // comboBoxMagazineType
            // 
            this.comboBoxMagazineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMagazineType.FormattingEnabled = true;
            this.comboBoxMagazineType.Items.AddRange(new object[] {
            "None",
            "Actual",
            "News",
            "Sport",
            "Computer",
            "Technology"});
            this.comboBoxMagazineType.Location = new System.Drawing.Point(346, 129);
            this.comboBoxMagazineType.Name = "comboBoxMagazineType";
            this.comboBoxMagazineType.Size = new System.Drawing.Size(212, 28);
            this.comboBoxMagazineType.TabIndex = 18;
            // 
            // btnPerform
            // 
            this.btnPerform.Location = new System.Drawing.Point(625, 277);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(123, 67);
            this.btnPerform.TabIndex = 19;
            this.btnPerform.Text = "Perform";
            this.btnPerform.UseVisualStyleBackColor = true;
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // UC_Magazine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.comboBoxMagazineType);
            this.Controls.Add(this.txtBoxIssueMagazine);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UC_Magazine";
            this.Size = new System.Drawing.Size(803, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxIssueMagazine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMagazineType;
        private System.Windows.Forms.Button btnPerform;
    }
}
