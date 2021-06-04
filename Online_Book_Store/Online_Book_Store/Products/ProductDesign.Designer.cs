
namespace Online_Book_Store.Product
{
    partial class ProductDesign
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
            this.panelBookQuantitiy = new System.Windows.Forms.Panel();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnAdd2Cart = new System.Windows.Forms.Button();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.panelBookInfo = new System.Windows.Forms.Panel();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBookQuantitiy.SuspendLayout();
            this.panelBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBookQuantitiy
            // 
            this.panelBookQuantitiy.Controls.Add(this.btnPlus);
            this.panelBookQuantitiy.Controls.Add(this.btnMinus);
            this.panelBookQuantitiy.Controls.Add(this.btnAdd2Cart);
            this.panelBookQuantitiy.Controls.Add(this.labelQuantity);
            this.panelBookQuantitiy.Location = new System.Drawing.Point(0, 311);
            this.panelBookQuantitiy.Margin = new System.Windows.Forms.Padding(4);
            this.panelBookQuantitiy.Name = "panelBookQuantitiy";
            this.panelBookQuantitiy.Size = new System.Drawing.Size(248, 116);
            this.panelBookQuantitiy.TabIndex = 19;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPlus.Location = new System.Drawing.Point(196, 0);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(51, 45);
            this.btnPlus.TabIndex = 3;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinus.Location = new System.Drawing.Point(0, 2);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(44, 44);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnAdd2Cart
            // 
            this.btnAdd2Cart.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd2Cart.Location = new System.Drawing.Point(0, 49);
            this.btnAdd2Cart.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd2Cart.Name = "btnAdd2Cart";
            this.btnAdd2Cart.Size = new System.Drawing.Size(248, 58);
            this.btnAdd2Cart.TabIndex = 5;
            this.btnAdd2Cart.Text = "Add To Cart";
            this.btnAdd2Cart.UseVisualStyleBackColor = true;
            this.btnAdd2Cart.Click += new System.EventHandler(this.btnAdd2Cart_Click);
            // 
            // labelQuantity
            // 
            this.labelQuantity.BackColor = System.Drawing.SystemColors.Control;
            this.labelQuantity.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelQuantity.Location = new System.Drawing.Point(52, 2);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(136, 45);
            this.labelQuantity.TabIndex = 4;
            this.labelQuantity.Text = "0";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBookInfo
            // 
            this.panelBookInfo.Controls.Add(this.labelPrice);
            this.panelBookInfo.Controls.Add(this.labelName);
            this.panelBookInfo.Location = new System.Drawing.Point(0, 214);
            this.panelBookInfo.Margin = new System.Windows.Forms.Padding(4);
            this.panelBookInfo.Name = "panelBookInfo";
            this.panelBookInfo.Size = new System.Drawing.Size(248, 89);
            this.panelBookInfo.TabIndex = 18;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(0, 47);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(66, 32);
            this.labelPrice.TabIndex = 7;
            this.labelPrice.Text = "price";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(0, 6);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 32);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 206);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // ProductDesign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panelBookQuantitiy);
            this.Controls.Add(this.panelBookInfo);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductDesign";
            this.Size = new System.Drawing.Size(250, 425);
            this.panelBookQuantitiy.ResumeLayout(false);
            this.panelBookInfo.ResumeLayout(false);
            this.panelBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBookQuantitiy;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnAdd2Cart;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Panel panelBookInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
    }
}
