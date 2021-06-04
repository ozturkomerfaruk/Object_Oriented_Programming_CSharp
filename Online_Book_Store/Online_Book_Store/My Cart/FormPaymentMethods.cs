using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
/*!
 *  \addtogroup Online_Book_Store.My_Cart
 *  @{
 */
//! Online_Book_Store.My_Cart methods and implementations.
namespace Online_Book_Store.My_Cart
{  /*!
     * \class FormPaymentMethods.
     * \brief Contains the methods of the payment.
     */
    public partial class FormPaymentMethods : Form
    {    /*!
         * \brief default constructor method.
         */
        private double  totalPrice, taxex;
        public double subTotal;
        public string email;

        /*!
       * \brief method includes Total amaount of money.
       * @return nothing.
       */
        private void CalculateTotal()
        {
            taxex = subTotal * 0.4f;
            totalPrice = subTotal + taxex + delivery;
            lblTotalPrice.Text = Math.Round(totalPrice,2).ToString();
            lblTaxes.Text = Math.Round(taxex, 2).ToString();
            lblSubTotal.Text = Math.Round(subTotal,2).ToString();
        }

        //Singleton
        private static FormPaymentMethods instance;
        public static FormPaymentMethods Instance
        {
            get
            {
                if (instance is null)
                {
                    instance = new FormPaymentMethods();
                }
                return instance;
            }
            set
            {
                instance = value;
            }
        }
        
             /*! 
             *\brief default constructor
             */
        public FormPaymentMethods()
        {
            InitializeComponent();
        }

        private void FormPaymentMethods_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /*!
      * \brief method clears text.
      * @return nothing.
      */
        private void ClearText()
        {
            txtBoxDrawee.Text = "";
            txtBoxIBAN.Text = "";
            txtBoxName.Text = "";
            txtBoxTelephoneNumber.Text = "";
            txtBoxInvoiceAdress.Text = "";
            lblTotalPrice.Text = "";
            lblTaxes.Text = "";
            lblSubTotal.Text = "";
            lblDelivery.Text = "";
        }
        /*!
         * \brief method if credit card box checked this method clear it.
         * @param sender is object variable and e is EventArgs variable.
         * @return nothing.
         */
        private void FormPaymentMethods_Load(object sender, EventArgs e)
        {
            rdnbtnCreditCart.Checked = true;
            ClearText();
            lblSubTotal.Text = subTotal.ToString();
            lblTaxes.Text = taxex.ToString();
            lblTotalPrice.Text = totalPrice.ToString();
        }

        public List<string> OrderList = new List<string>();
        /*!
               * \brief method includes tasks done while closing the application.
               * @param sender is object variable and e is EventArgs variable.
               * @return nothing.
               */
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            OrderList.Clear();

            if (rdnbtnCreditCart.Checked)
            {
                OrderList.Add(txtBoxNameOFCard.Text != "" ? txtBoxNameOFCard.Text : "");
                OrderList.Add(txtCardNumber.Text != "" ? txtCardNumber.Text : "");
                OrderList.Add(txtBoxCVV.Text != "" ? txtBoxCVV.Text : "");
                OrderList.Add(comboBoxMonths.SelectedItem is null? "" : comboBoxMonths.SelectedItem.ToString() );
                OrderList.Add(comboBoxYear.SelectedItem is null ? "" : comboBoxYear.SelectedItem.ToString());
            }
            else if (rdnBtnTransferEFT.Checked)
            {
                OrderList.Add(comboBoxBanks.SelectedItem is null ? "" : comboBoxBanks.SelectedItem.ToString());
                OrderList.Add(txtBoxDrawee.Text != "" ? txtBoxDrawee.Text : "");
                OrderList.Add(txtBoxIBAN.Text != "" ? txtBoxIBAN.Text : "");
            }
            else
                return;

            OrderList.Add(rdnBtnUPSCargo.Checked ? "UPS Cargo" : rdnBtnYURTICICargo.Checked ? "YURTICI Cargo" :
                rdnBtnMNGCargo.Checked ? "MNG Cargo" : rdnBtnPTTCargo.Checked ? "PTT Cargo" : "");

            OrderList.Add(txtBoxName.Text != "" ? txtBoxName.Text : "");
            OrderList.Add(txtBoxTelephoneNumber.Text != "" ? txtBoxTelephoneNumber.Text : "");
            OrderList.Add(txtBoxInvoiceAdress.Text != "" ? txtBoxInvoiceAdress.Text : "");
            OrderList.Add(lblTotalPrice.Text != "" ? lblTotalPrice.Text : "");

            foreach (string item in OrderList)
            {
                if (item == "")
                {
                    MessageBox.Show("Please, fill all spaces");
                    return;
                }
            }
            MessageBox.Show("Successful!" + Environment.NewLine + "Your invoice has been sent to your e-mail address.");

            MailMessage message = new MailMessage();
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential("bookin26@hotmail.com", "bookininfo1");
            client.Port = 587;
            client.Host = "smtp.live.com";
            client.EnableSsl = true;

            message.To.Add(email);
            message.From = new MailAddress("bookin26@hotmail.com");
            message.Subject = "Invoice Information";
            message.Body = "";
            foreach (string item in OrderList)
            {
                message.Body += item + Environment.NewLine;
            }

            client.Send(message);
        }
        /*!
         * \brief method Credit Includes tasks when credit card button changes
         * @param sender is object variable and e is EventArgs variable.
         * @return nothing.
         */
        private void rdnbtnCreditCart_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxTransferEFT.Visible = false;
            groupBoxCreditCard.Visible = true;
        }
        /*!
         * \brief method Credit Includes tasks when eft button changes
         * @param sender is object variable and e is EventArgs variable.
         * @return nothing.
         */
        private void rdnBtnTransferEFT_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxCreditCard.Visible = false;
            groupBoxTransferEFT.Visible = true;
        }

        double delivery;
        /*!
         * \brief method UPS Cargo Includes tasks when rdnBtnUPSCargo button changes
         * @param sender is object variable and e is EventArgs variable.
         * @return nothing.
         */
        private void rdnBtnUPSCargo_CheckedChanged(object sender, EventArgs e)
        {
            delivery = 20;
            lblDelivery.Text = delivery.ToString() + "TL";
            CalculateTotal();
        }
        /*!
         * \brief method YURTICI Cargo Includes tasks when rdnBtnYURTICICargo button changes
         * @param sender is object variable and e is EventArgs variable.
         * @return nothing.
         */
        private void rdnBtnYURTICICargo_CheckedChanged(object sender, EventArgs e)
        {
            delivery = 85;
            lblDelivery.Text = delivery.ToString() + "TL";
            CalculateTotal();
        }
        /*!
        * \brief method MNG Cargo Includes tasks when rdnBtnMNGCargo button changes
        * @param sender is object variable and e is EventArgs variable.
        * @return nothing.
        */
        private void rdnBtnMNGCargo_CheckedChanged(object sender, EventArgs e)
        {
            delivery = 1;
            lblDelivery.Text = delivery.ToString() + "TL";
            CalculateTotal();
        }
        /*!
       * \brief method PTT Cargo Includes tasks when rdnBtnPTTCargo button changes
       * @param sender is object variable and e is EventArgs variable.
       * @return nothing.
       */
        private void rdnBtnPTTCargo_CheckedChanged(object sender, EventArgs e)
        {
            delivery = 10;
            lblDelivery.Text = delivery.ToString() + "TL";
            CalculateTotal();
        }
    }
}// End namespace Online_Book_Store.My_Cart

/*! @} End of Doxygen Groups*/
