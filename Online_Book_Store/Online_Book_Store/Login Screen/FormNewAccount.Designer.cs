
namespace Online_Book_Store
{
    partial class FormNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewAccount));
            this.labelDefiniton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUsername = new System.Windows.Forms.TextBox();
            this.txtBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRePassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAvailable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCheckAvailability = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelProgressBarPasswordStrength = new System.Windows.Forms.Label();
            this.progressBarPasswordStrength = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxResidenceAddress = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.checkBoxOnay1 = new System.Windows.Forms.CheckBox();
            this.checkBoxOnay2 = new System.Windows.Forms.CheckBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDefiniton
            // 
            this.labelDefiniton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDefiniton.Location = new System.Drawing.Point(12, 9);
            this.labelDefiniton.Name = "labelDefiniton";
            this.labelDefiniton.Size = new System.Drawing.Size(749, 73);
            this.labelDefiniton.TabIndex = 0;
            this.labelDefiniton.Text = "Please provide an account name and password. Be sure to make your password someth" +
    "ing hard to guess, and use at least 8 characters.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account name";
            // 
            // txtBoxUsername
            // 
            this.txtBoxUsername.Location = new System.Drawing.Point(14, 47);
            this.txtBoxUsername.Name = "txtBoxUsername";
            this.txtBoxUsername.Size = new System.Drawing.Size(357, 27);
            this.txtBoxUsername.TabIndex = 2;
            // 
            // txtBoxPassword
            // 
            this.txtBoxPassword.Location = new System.Drawing.Point(15, 43);
            this.txtBoxPassword.Name = "txtBoxPassword";
            this.txtBoxPassword.PlaceholderText = "Please enter a password of at least 8 characters.";
            this.txtBoxPassword.Size = new System.Drawing.Size(357, 27);
            this.txtBoxPassword.TabIndex = 4;
            this.txtBoxPassword.TextChanged += new System.EventHandler(this.txtBoxPassword_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose a password";
            // 
            // txtBoxRePassword
            // 
            this.txtBoxRePassword.Location = new System.Drawing.Point(15, 119);
            this.txtBoxRePassword.Name = "txtBoxRePassword";
            this.txtBoxRePassword.Size = new System.Drawing.Size(357, 27);
            this.txtBoxRePassword.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Re-enter password";
            // 
            // labelAvailable
            // 
            this.labelAvailable.AutoSize = true;
            this.labelAvailable.ForeColor = System.Drawing.Color.Green;
            this.labelAvailable.Location = new System.Drawing.Point(591, 45);
            this.labelAvailable.Name = "labelAvailable";
            this.labelAvailable.Size = new System.Drawing.Size(75, 20);
            this.labelAvailable.TabIndex = 8;
            this.labelAvailable.Text = "Available!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCheckAvailability);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelAvailable);
            this.panel1.Controls.Add(this.txtBoxUsername);
            this.panel1.Location = new System.Drawing.Point(12, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 84);
            this.panel1.TabIndex = 9;
            // 
            // btnCheckAvailability
            // 
            this.btnCheckAvailability.Location = new System.Drawing.Point(411, 41);
            this.btnCheckAvailability.Name = "btnCheckAvailability";
            this.btnCheckAvailability.Size = new System.Drawing.Size(149, 29);
            this.btnCheckAvailability.TabIndex = 18;
            this.btnCheckAvailability.Text = "Check availability";
            this.btnCheckAvailability.UseVisualStyleBackColor = true;
            this.btnCheckAvailability.Click += new System.EventHandler(this.btnCheckAvailability_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelProgressBarPasswordStrength);
            this.panel2.Controls.Add(this.progressBarPasswordStrength);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtBoxPassword);
            this.panel2.Controls.Add(this.txtBoxRePassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(749, 169);
            this.panel2.TabIndex = 10;
            // 
            // labelProgressBarPasswordStrength
            // 
            this.labelProgressBarPasswordStrength.AutoSize = true;
            this.labelProgressBarPasswordStrength.Location = new System.Drawing.Point(548, 81);
            this.labelProgressBarPasswordStrength.Name = "labelProgressBarPasswordStrength";
            this.labelProgressBarPasswordStrength.Size = new System.Drawing.Size(29, 20);
            this.labelProgressBarPasswordStrength.TabIndex = 10;
            this.labelProgressBarPasswordStrength.Text = "0%";
            // 
            // progressBarPasswordStrength
            // 
            this.progressBarPasswordStrength.Location = new System.Drawing.Point(411, 117);
            this.progressBarPasswordStrength.Maximum = 4;
            this.progressBarPasswordStrength.Name = "progressBarPasswordStrength";
            this.progressBarPasswordStrength.Size = new System.Drawing.Size(299, 29);
            this.progressBarPasswordStrength.Step = 1;
            this.progressBarPasswordStrength.TabIndex = 9;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(411, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "Password strength:";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(411, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 52);
            this.label6.TabIndex = 7;
            this.label6.Text = "Use at least one uppercase(A), lowercase letter(a), number(0) and punctuation mar" +
    "k(?)";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtBoxName);
            this.panel3.Controls.Add(this.txtBoxEmail);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(12, 329);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(749, 164);
            this.panel3.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(408, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(152, 33);
            this.label14.TabIndex = 8;
            this.label14.Text = "Full name is required";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(408, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(302, 46);
            this.label7.TabIndex = 7;
            this.label7.Text = "Your email address is used to confirm purchases.\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(15, 31);
            this.txtBoxName.Multiline = true;
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(357, 39);
            this.txtBoxName.TabIndex = 4;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(14, 106);
            this.txtBoxEmail.Multiline = true;
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.PlaceholderText = "iletisim@ozturkomerfaruk.com";
            this.txtBoxEmail.Size = new System.Drawing.Size(357, 36);
            this.txtBoxEmail.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Enter email address";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(785, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 531);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WHY JOIN BookIN?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 362);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(6, 47);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(277, 309);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = resources.GetString("textBox6.Text");
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.txtBoxResidenceAddress);
            this.panel4.Location = new System.Drawing.Point(12, 481);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(749, 137);
            this.panel4.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(405, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 87);
            this.label10.TabIndex = 5;
            this.label10.Text = "It is highly requested that you enter your address of residence correctly and com" +
    "pletely.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "Residence address";
            // 
            // txtBoxResidenceAddress
            // 
            this.txtBoxResidenceAddress.Location = new System.Drawing.Point(15, 43);
            this.txtBoxResidenceAddress.Multiline = true;
            this.txtBoxResidenceAddress.Name = "txtBoxResidenceAddress";
            this.txtBoxResidenceAddress.Size = new System.Drawing.Size(357, 87);
            this.txtBoxResidenceAddress.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(785, 619);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(318, 111);
            this.label13.TabIndex = 13;
            this.label13.Text = "Please review the agreement(s) below and agree by selecting the checkbox(es) at t" +
    "he bottom of the page. You must agree with the terms of these agreements to cont" +
    "inue.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(26, 619);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(735, 114);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // checkBoxOnay1
            // 
            this.checkBoxOnay1.Location = new System.Drawing.Point(27, 739);
            this.checkBoxOnay1.Name = "checkBoxOnay1";
            this.checkBoxOnay1.Size = new System.Drawing.Size(463, 56);
            this.checkBoxOnay1.TabIndex = 15;
            this.checkBoxOnay1.Text = "BookIN Music Book Stores Marketing Inc. has permission to send commercial electro" +
    "nic messages to those stated here.";
            this.checkBoxOnay1.UseVisualStyleBackColor = true;
            // 
            // checkBoxOnay2
            // 
            this.checkBoxOnay2.Location = new System.Drawing.Point(496, 739);
            this.checkBoxOnay2.Name = "checkBoxOnay2";
            this.checkBoxOnay2.Size = new System.Drawing.Size(265, 56);
            this.checkBoxOnay2.TabIndex = 16;
            this.checkBoxOnay2.Text = "I have read the Membership Agreement, I approve.";
            this.checkBoxOnay2.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(791, 723);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(296, 59);
            this.btnRegister.TabIndex = 17;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FormNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1115, 794);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.checkBoxOnay2);
            this.Controls.Add(this.checkBoxOnay1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDefiniton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewAccount";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create a BookIN Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewAccount_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNewAccount_FormClosed);
            this.Load += new System.EventHandler(this.FormNewAccount_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDefiniton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUsername;
        private System.Windows.Forms.TextBox txtBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxRePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAvailable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBarPasswordStrength;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxResidenceAddress;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBoxOnay1;
        private System.Windows.Forms.CheckBox checkBoxOnay2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelProgressBarPasswordStrength;
        private System.Windows.Forms.Button btnCheckAvailability;
    }
}