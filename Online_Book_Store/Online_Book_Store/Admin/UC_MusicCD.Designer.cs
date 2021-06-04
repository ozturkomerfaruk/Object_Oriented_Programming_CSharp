
namespace Online_Book_Store.Admin
{
    partial class UC_MusicCD
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
            this.comboBoxMusicType = new System.Windows.Forms.ComboBox();
            this.txtBoxSingerMusicCD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPerform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxMusicType
            // 
            this.comboBoxMusicType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMusicType.FormattingEnabled = true;
            this.comboBoxMusicType.Items.AddRange(new object[] {
            "None",
            "Rock",
            "Rap",
            "House",
            "Jazz"});
            this.comboBoxMusicType.Location = new System.Drawing.Point(334, 119);
            this.comboBoxMusicType.Name = "comboBoxMusicType";
            this.comboBoxMusicType.Size = new System.Drawing.Size(212, 28);
            this.comboBoxMusicType.TabIndex = 22;
            // 
            // txtBoxSingerMusicCD
            // 
            this.txtBoxSingerMusicCD.Location = new System.Drawing.Point(334, 63);
            this.txtBoxSingerMusicCD.Multiline = true;
            this.txtBoxSingerMusicCD.Name = "txtBoxSingerMusicCD";
            this.txtBoxSingerMusicCD.Size = new System.Drawing.Size(212, 23);
            this.txtBoxSingerMusicCD.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Singer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Music Type";
            // 
            // btnPerform
            // 
            this.btnPerform.Location = new System.Drawing.Point(631, 285);
            this.btnPerform.Name = "btnPerform";
            this.btnPerform.Size = new System.Drawing.Size(123, 67);
            this.btnPerform.TabIndex = 23;
            this.btnPerform.Text = "Perform";
            this.btnPerform.UseVisualStyleBackColor = true;
            this.btnPerform.Click += new System.EventHandler(this.btnPerform_Click);
            // 
            // UC_MusicCD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btnPerform);
            this.Controls.Add(this.comboBoxMusicType);
            this.Controls.Add(this.txtBoxSingerMusicCD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "UC_MusicCD";
            this.Size = new System.Drawing.Size(803, 397);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMusicType;
        private System.Windows.Forms.TextBox txtBoxSingerMusicCD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPerform;
    }
}
