
namespace Online_Book_Store.My_Cart
{
    partial class FormPaymentMethods
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnBtnTransferEFT = new System.Windows.Forms.RadioButton();
            this.rdnbtnCreditCart = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBanks = new System.Windows.Forms.ComboBox();
            this.groupBoxTransferEFT = new System.Windows.Forms.GroupBox();
            this.txtBoxIBAN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxDrawee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxCreditCard = new System.Windows.Forms.GroupBox();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.comboBoxMonths = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxCVV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxNameOFCard = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBoxInvoiceAdress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtBoxTelephoneNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdnBtnPTTCargo = new System.Windows.Forms.RadioButton();
            this.rdnBtnMNGCargo = new System.Windows.Forms.RadioButton();
            this.rdnBtnYURTICICargo = new System.Windows.Forms.RadioButton();
            this.rdnBtnUPSCargo = new System.Windows.Forms.RadioButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblTaxes = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBoxTransferEFT.SuspendLayout();
            this.groupBoxCreditCard.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnBtnTransferEFT);
            this.groupBox1.Controls.Add(this.rdnbtnCreditCart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please choose a payment method.";
            // 
            // rdnBtnTransferEFT
            // 
            this.rdnBtnTransferEFT.AutoSize = true;
            this.rdnBtnTransferEFT.Location = new System.Drawing.Point(185, 29);
            this.rdnBtnTransferEFT.Name = "rdnBtnTransferEFT";
            this.rdnBtnTransferEFT.Size = new System.Drawing.Size(119, 24);
            this.rdnBtnTransferEFT.TabIndex = 2;
            this.rdnBtnTransferEFT.TabStop = true;
            this.rdnBtnTransferEFT.Text = "Transfer / EFT";
            this.rdnBtnTransferEFT.UseVisualStyleBackColor = true;
            this.rdnBtnTransferEFT.CheckedChanged += new System.EventHandler(this.rdnBtnTransferEFT_CheckedChanged);
            // 
            // rdnbtnCreditCart
            // 
            this.rdnbtnCreditCart.AutoSize = true;
            this.rdnbtnCreditCart.Location = new System.Drawing.Point(10, 29);
            this.rdnbtnCreditCart.Name = "rdnbtnCreditCart";
            this.rdnbtnCreditCart.Size = new System.Drawing.Size(105, 24);
            this.rdnbtnCreditCart.TabIndex = 1;
            this.rdnbtnCreditCart.TabStop = true;
            this.rdnbtnCreditCart.Text = "Credit Card";
            this.rdnbtnCreditCart.UseVisualStyleBackColor = true;
            this.rdnbtnCreditCart.CheckedChanged += new System.EventHandler(this.rdnbtnCreditCart_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select a bank";
            // 
            // comboBoxBanks
            // 
            this.comboBoxBanks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBanks.FormattingEnabled = true;
            this.comboBoxBanks.Items.AddRange(new object[] {
            "Halkbank",
            "VakıfBank",
            "Ziraat Bankası",
            "Akbank",
            "Anadolubank",
            "Fibabanka",
            "Şekerbank",
            "Turkish Bank",
            "Türk Ekonomi Bankası",
            "Türkiye İş Bankası",
            "Yapı Kredi Bankası",
            "Adabank",
            "Birleşik Fon Bankası"});
            this.comboBoxBanks.Location = new System.Drawing.Point(6, 46);
            this.comboBoxBanks.Name = "comboBoxBanks";
            this.comboBoxBanks.Size = new System.Drawing.Size(298, 28);
            this.comboBoxBanks.TabIndex = 0;
            // 
            // groupBoxTransferEFT
            // 
            this.groupBoxTransferEFT.Controls.Add(this.txtBoxIBAN);
            this.groupBoxTransferEFT.Controls.Add(this.label3);
            this.groupBoxTransferEFT.Controls.Add(this.txtBoxDrawee);
            this.groupBoxTransferEFT.Controls.Add(this.label2);
            this.groupBoxTransferEFT.Controls.Add(this.label1);
            this.groupBoxTransferEFT.Controls.Add(this.comboBoxBanks);
            this.groupBoxTransferEFT.Location = new System.Drawing.Point(12, 88);
            this.groupBoxTransferEFT.Name = "groupBoxTransferEFT";
            this.groupBoxTransferEFT.Size = new System.Drawing.Size(317, 160);
            this.groupBoxTransferEFT.TabIndex = 2;
            this.groupBoxTransferEFT.TabStop = false;
            this.groupBoxTransferEFT.Text = "Transfer / EFT";
            // 
            // txtBoxIBAN
            // 
            this.txtBoxIBAN.Location = new System.Drawing.Point(74, 114);
            this.txtBoxIBAN.MaxLength = 26;
            this.txtBoxIBAN.Name = "txtBoxIBAN";
            this.txtBoxIBAN.Size = new System.Drawing.Size(230, 27);
            this.txtBoxIBAN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "IBAN";
            // 
            // txtBoxDrawee
            // 
            this.txtBoxDrawee.Location = new System.Drawing.Point(74, 81);
            this.txtBoxDrawee.Name = "txtBoxDrawee";
            this.txtBoxDrawee.Size = new System.Drawing.Size(230, 27);
            this.txtBoxDrawee.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Drawee";
            // 
            // groupBoxCreditCard
            // 
            this.groupBoxCreditCard.Controls.Add(this.comboBoxYear);
            this.groupBoxCreditCard.Controls.Add(this.comboBoxMonths);
            this.groupBoxCreditCard.Controls.Add(this.label7);
            this.groupBoxCreditCard.Controls.Add(this.label6);
            this.groupBoxCreditCard.Controls.Add(this.txtBoxCVV);
            this.groupBoxCreditCard.Controls.Add(this.label5);
            this.groupBoxCreditCard.Controls.Add(this.txtCardNumber);
            this.groupBoxCreditCard.Controls.Add(this.label4);
            this.groupBoxCreditCard.Controls.Add(this.txtBoxNameOFCard);
            this.groupBoxCreditCard.Location = new System.Drawing.Point(12, 82);
            this.groupBoxCreditCard.Name = "groupBoxCreditCard";
            this.groupBoxCreditCard.Size = new System.Drawing.Size(317, 160);
            this.groupBoxCreditCard.TabIndex = 3;
            this.groupBoxCreditCard.TabStop = false;
            this.groupBoxCreditCard.Text = "Credit Card";
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032"});
            this.comboBoxYear.Location = new System.Drawing.Point(209, 122);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(74, 28);
            this.comboBoxYear.TabIndex = 9;
            // 
            // comboBoxMonths
            // 
            this.comboBoxMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonths.FormattingEnabled = true;
            this.comboBoxMonths.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxMonths.Location = new System.Drawing.Point(114, 122);
            this.comboBoxMonths.Name = "comboBoxMonths";
            this.comboBoxMonths.Size = new System.Drawing.Size(74, 28);
            this.comboBoxMonths.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Exprity Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "CVV";
            // 
            // txtBoxCVV
            // 
            this.txtBoxCVV.Location = new System.Drawing.Point(114, 89);
            this.txtBoxCVV.MaxLength = 3;
            this.txtBoxCVV.Name = "txtBoxCVV";
            this.txtBoxCVV.Size = new System.Drawing.Size(65, 27);
            this.txtBoxCVV.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Card Number";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(114, 57);
            this.txtCardNumber.MaxLength = 16;
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(197, 27);
            this.txtCardNumber.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Full Name";
            // 
            // txtBoxNameOFCard
            // 
            this.txtBoxNameOFCard.Location = new System.Drawing.Point(114, 24);
            this.txtBoxNameOFCard.MaxLength = 32000;
            this.txtBoxNameOFCard.Name = "txtBoxNameOFCard";
            this.txtBoxNameOFCard.Size = new System.Drawing.Size(197, 27);
            this.txtBoxNameOFCard.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBoxInvoiceAdress);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtBoxTelephoneNumber);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.txtBoxName);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(335, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(453, 236);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Invoice information";
            // 
            // txtBoxInvoiceAdress
            // 
            this.txtBoxInvoiceAdress.Location = new System.Drawing.Point(6, 122);
            this.txtBoxInvoiceAdress.Multiline = true;
            this.txtBoxInvoiceAdress.Name = "txtBoxInvoiceAdress";
            this.txtBoxInvoiceAdress.Size = new System.Drawing.Size(441, 108);
            this.txtBoxInvoiceAdress.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 20);
            this.label14.TabIndex = 22;
            this.label14.Text = "Invoice Address";
            // 
            // txtBoxTelephoneNumber
            // 
            this.txtBoxTelephoneNumber.Location = new System.Drawing.Point(311, 52);
            this.txtBoxTelephoneNumber.MaxLength = 11;
            this.txtBoxTelephoneNumber.Name = "txtBoxTelephoneNumber";
            this.txtBoxTelephoneNumber.Size = new System.Drawing.Size(136, 27);
            this.txtBoxTelephoneNumber.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(311, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 20);
            this.label13.TabIndex = 20;
            this.label13.Text = "Telephone Number";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(6, 52);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(274, 27);
            this.txtBoxName.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Name";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdnBtnPTTCargo);
            this.groupBox5.Controls.Add(this.rdnBtnMNGCargo);
            this.groupBox5.Controls.Add(this.rdnBtnYURTICICargo);
            this.groupBox5.Controls.Add(this.rdnBtnUPSCargo);
            this.groupBox5.Location = new System.Drawing.Point(12, 266);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(317, 178);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Please choose a cargo company";
            // 
            // rdnBtnPTTCargo
            // 
            this.rdnBtnPTTCargo.AutoSize = true;
            this.rdnBtnPTTCargo.Location = new System.Drawing.Point(6, 148);
            this.rdnBtnPTTCargo.Name = "rdnBtnPTTCargo";
            this.rdnBtnPTTCargo.Size = new System.Drawing.Size(98, 24);
            this.rdnBtnPTTCargo.TabIndex = 3;
            this.rdnBtnPTTCargo.TabStop = true;
            this.rdnBtnPTTCargo.Text = "PTT Cargo";
            this.rdnBtnPTTCargo.UseVisualStyleBackColor = true;
            this.rdnBtnPTTCargo.CheckedChanged += new System.EventHandler(this.rdnBtnPTTCargo_CheckedChanged);
            // 
            // rdnBtnMNGCargo
            // 
            this.rdnBtnMNGCargo.AutoSize = true;
            this.rdnBtnMNGCargo.Location = new System.Drawing.Point(7, 109);
            this.rdnBtnMNGCargo.Name = "rdnBtnMNGCargo";
            this.rdnBtnMNGCargo.Size = new System.Drawing.Size(108, 24);
            this.rdnBtnMNGCargo.TabIndex = 2;
            this.rdnBtnMNGCargo.TabStop = true;
            this.rdnBtnMNGCargo.Text = "MNG Cargo";
            this.rdnBtnMNGCargo.UseVisualStyleBackColor = true;
            this.rdnBtnMNGCargo.CheckedChanged += new System.EventHandler(this.rdnBtnMNGCargo_CheckedChanged);
            // 
            // rdnBtnYURTICICargo
            // 
            this.rdnBtnYURTICICargo.AutoSize = true;
            this.rdnBtnYURTICICargo.Location = new System.Drawing.Point(6, 70);
            this.rdnBtnYURTICICargo.Name = "rdnBtnYURTICICargo";
            this.rdnBtnYURTICICargo.Size = new System.Drawing.Size(125, 24);
            this.rdnBtnYURTICICargo.TabIndex = 1;
            this.rdnBtnYURTICICargo.TabStop = true;
            this.rdnBtnYURTICICargo.Text = "YURTICI Cargo";
            this.rdnBtnYURTICICargo.UseVisualStyleBackColor = true;
            this.rdnBtnYURTICICargo.CheckedChanged += new System.EventHandler(this.rdnBtnYURTICICargo_CheckedChanged);
            // 
            // rdnBtnUPSCargo
            // 
            this.rdnBtnUPSCargo.AutoSize = true;
            this.rdnBtnUPSCargo.Location = new System.Drawing.Point(7, 27);
            this.rdnBtnUPSCargo.Name = "rdnBtnUPSCargo";
            this.rdnBtnUPSCargo.Size = new System.Drawing.Size(100, 24);
            this.rdnBtnUPSCargo.TabIndex = 0;
            this.rdnBtnUPSCargo.TabStop = true;
            this.rdnBtnUPSCargo.Text = "UPS Cargo";
            this.rdnBtnUPSCargo.UseVisualStyleBackColor = true;
            this.rdnBtnUPSCargo.CheckedChanged += new System.EventHandler(this.rdnBtnUPSCargo_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTotalPrice);
            this.groupBox6.Controls.Add(this.label23);
            this.groupBox6.Controls.Add(this.label21);
            this.groupBox6.Controls.Add(this.lblTaxes);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.lblDelivery);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.lblSubTotal);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Location = new System.Drawing.Point(341, 266);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(441, 178);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Invoice Summary";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(156, 150);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(65, 20);
            this.lblTotalPrice.TabIndex = 8;
            this.lblTotalPrice.Text = "$ $ $ $ $";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 150);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 20);
            this.label23.TabIndex = 7;
            this.label23.Text = "Total Price";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(0, 129);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(309, 20);
            this.label21.TabIndex = 6;
            this.label21.Text = "__________________________________________________";
            // 
            // lblTaxes
            // 
            this.lblTaxes.AutoSize = true;
            this.lblTaxes.Location = new System.Drawing.Point(156, 109);
            this.lblTaxes.Name = "lblTaxes";
            this.lblTaxes.Size = new System.Drawing.Size(73, 20);
            this.lblTaxes.TabIndex = 5;
            this.lblTaxes.Text = "$9999999";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 109);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(44, 20);
            this.label19.TabIndex = 4;
            this.label19.Text = "Taxes";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(156, 74);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(25, 20);
            this.lblDelivery.TabIndex = 3;
            this.lblDelivery.Text = "$8";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 74);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "Delivery";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(156, 42);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(33, 20);
            this.lblSubTotal.TabIndex = 1;
            this.lblSubTotal.Text = "$84";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Subtotal";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(646, 450);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(136, 55);
            this.btnPlaceOrder.TabIndex = 5;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // FormPaymentMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1202, 541);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxCreditCard);
            this.Controls.Add(this.groupBoxTransferEFT);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPaymentMethods";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment Method";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPaymentMethods_FormClosed);
            this.Load += new System.EventHandler(this.FormPaymentMethods_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxTransferEFT.ResumeLayout(false);
            this.groupBoxTransferEFT.PerformLayout();
            this.groupBoxCreditCard.ResumeLayout(false);
            this.groupBoxCreditCard.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdnBtnTransferEFT;
        private System.Windows.Forms.RadioButton rdnbtnCreditCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBanks;
        private System.Windows.Forms.GroupBox groupBoxTransferEFT;
        private System.Windows.Forms.TextBox txtBoxIBAN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxDrawee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxCreditCard;
        private System.Windows.Forms.ComboBox comboBoxYear;
        private System.Windows.Forms.ComboBox comboBoxMonths;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxCVV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxNameOFCard;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtBoxInvoiceAdress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBoxTelephoneNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdnBtnPTTCargo;
        private System.Windows.Forms.RadioButton rdnBtnMNGCargo;
        private System.Windows.Forms.RadioButton rdnBtnYURTICICargo;
        private System.Windows.Forms.RadioButton rdnBtnUPSCargo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblTaxes;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPlaceOrder;
    }
}