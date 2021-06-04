
namespace Online_Book_Store
{
    partial class FormLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogIn));
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxRememberMyPassword = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.labelNewAccount = new System.Windows.Forms.Label();
            this.buttonCreateANewAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLogo.Image")));
            this.pictureBoxLogo.Location = new System.Drawing.Point(148, 1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(432, 137);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxRememberMyPassword);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonLogIn);
            this.panel1.Controls.Add(this.textBoxPassword);
            this.panel1.Controls.Add(this.labelPassword);
            this.panel1.Controls.Add(this.textBoxAccountName);
            this.panel1.Controls.Add(this.labelAccountName);
            this.panel1.Location = new System.Drawing.Point(66, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 212);
            this.panel1.TabIndex = 3;
            // 
            // checkBoxRememberMyPassword
            // 
            this.checkBoxRememberMyPassword.AutoSize = true;
            this.checkBoxRememberMyPassword.Location = new System.Drawing.Point(154, 114);
            this.checkBoxRememberMyPassword.Name = "checkBoxRememberMyPassword";
            this.checkBoxRememberMyPassword.Size = new System.Drawing.Size(195, 24);
            this.checkBoxRememberMyPassword.TabIndex = 6;
            this.checkBoxRememberMyPassword.Text = "Remember my password";
            this.checkBoxRememberMyPassword.UseVisualStyleBackColor = true;
            this.checkBoxRememberMyPassword.CheckedChanged += new System.EventHandler(this.checkBoxRememberMyPassword_CheckedChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(356, 155);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(198, 29);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "CANCEL";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(154, 155);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(198, 29);
            this.buttonLogIn.TabIndex = 4;
            this.buttonLogIn.Text = "LOGIN";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(154, 66);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(400, 27);
            this.textBoxPassword.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(58, 69);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 20);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Password";
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Location = new System.Drawing.Point(154, 18);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(400, 27);
            this.textBoxAccountName.TabIndex = 1;
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Location = new System.Drawing.Point(24, 21);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(104, 20);
            this.labelAccountName.TabIndex = 0;
            this.labelAccountName.Text = "Account name";
            // 
            // labelNewAccount
            // 
            this.labelNewAccount.AutoSize = true;
            this.labelNewAccount.Location = new System.Drawing.Point(90, 377);
            this.labelNewAccount.Name = "labelNewAccount";
            this.labelNewAccount.Size = new System.Drawing.Size(203, 20);
            this.labelNewAccount.TabIndex = 6;
            this.labelNewAccount.Text = "Don\'t have a BookIN Account";
            // 
            // buttonCreateANewAccount
            // 
            this.buttonCreateANewAccount.Location = new System.Drawing.Point(326, 373);
            this.buttonCreateANewAccount.Name = "buttonCreateANewAccount";
            this.buttonCreateANewAccount.Size = new System.Drawing.Size(294, 29);
            this.buttonCreateANewAccount.TabIndex = 6;
            this.buttonCreateANewAccount.Text = "CREATE A NEW ACCOUNT...";
            this.buttonCreateANewAccount.UseVisualStyleBackColor = true;
            this.buttonCreateANewAccount.Click += new System.EventHandler(this.buttonCreateANewAccount_Click);
            // 
            // FormLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateANewAccount);
            this.Controls.Add(this.labelNewAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxLogo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogIn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookIN Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLogIn_FormClosed);
            this.Load += new System.EventHandler(this.FormLogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxRememberMyPassword;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelAccountName;
        private System.Windows.Forms.Label labelNewAccount;
        private System.Windows.Forms.Button buttonCreateANewAccount;
        public System.Windows.Forms.TextBox textBoxAccountName;
    }
}

