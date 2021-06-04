
namespace Online_Book_Store
{
    partial class FormFormlarArasıGecis
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelAccountName = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelProccessing = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bağlanılan BookIN Hesabı: ";
            // 
            // labelAccountName
            // 
            this.labelAccountName.AutoSize = true;
            this.labelAccountName.Location = new System.Drawing.Point(200, 9);
            this.labelAccountName.Name = "labelAccountName";
            this.labelAccountName.Size = new System.Drawing.Size(124, 20);
            this.labelAccountName.TabIndex = 1;
            this.labelAccountName.Text = "ozturkomerfaruk_";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 62);
            this.progressBar.MarqueeAnimationSpeed = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(489, 59);
            this.progressBar.Step = 100;
            this.progressBar.TabIndex = 2;
            // 
            // labelProccessing
            // 
            this.labelProccessing.AutoSize = true;
            this.labelProccessing.Location = new System.Drawing.Point(200, 39);
            this.labelProccessing.Name = "labelProccessing";
            this.labelProccessing.Size = new System.Drawing.Size(123, 20);
            this.labelProccessing.TabIndex = 3;
            this.labelProccessing.Text = "Proccessing ... 0%";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FormFormlarArasıGecis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(513, 131);
            this.ControlBox = false;
            this.Controls.Add(this.labelProccessing);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.labelAccountName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FormFormlarArasıGecis";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookIN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormFormlarArasıGecis_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFormlarArasıGecis_FormClosed);
            this.Load += new System.EventHandler(this.FormFormlarArasıGecis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelProccessing;
        private System.Windows.Forms.Timer timer;
        public System.Windows.Forms.Label labelAccountName;
    }
}