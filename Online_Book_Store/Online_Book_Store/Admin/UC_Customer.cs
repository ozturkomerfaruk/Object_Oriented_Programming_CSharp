using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
/*!
 *  \addtogroup Online_Book_Store.Admin
 *  @{
 */
//! Online_Book_Store.Admin methods and implementations.
namespace Online_Book_Store.Admin
{  /*!
     * \class UC_Customer.
     * \brief Contains the methods of the customer in the user panel.
     */
    public partial class UC_Customer : UserControl
    {  /*!
         * \brief default constructor method.
         */
        public UC_Customer()
        {
            InitializeComponent();
            ClearText();
        }
        /*!
       * \brief method contains the task to be done when the select button is pressed.
       * @param sender is object variable and e is EventArgs variable.
       * @return nothing.
       */
        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Enabled = false;
            Product.Database dataBase = new Product.Database();
            FormAdminControl a = FormAdminControl.instance;
            bool contains = false;

            Customer customer = new Customer();

            dataBase.CustomerList();
            foreach (Customer _customer in dataBase.GetCustomersList)
            {
                if (_customer.Username == txtBoxUsername.Text)
                {
                    contains = true;
                    customer = _customer;
                }

            }
            if (contains)
            {
                txtBoxName.Text = customer.Name;
                txtBoxEmail.Text = customer.Email;
                txtBoxAdress.Text = customer.Address;
                txtBoxUsername.Text = customer.Username;
                txtBoxPassword.Text = customer.Password;
            }
        }
        /*!
        * \brief method contains the task to be done when the update button is pressed.
        * @param sender is object variable and e is EventArgs variable.
        * @return nothing.
        */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CheckPassword();
            txtBoxUsername.Enabled = true;
            
        }
        /*!
       * \brief method contains the task to be done when the delete button is pressed.
        * @param sender is object variable and e is EventArgs variable.
        * @return nothing.
       */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtBoxUsername.Enabled = true;
            Product.Database dataBase = new Product.Database();
            FormAdminControl a = FormAdminControl.instance;
            Customer customer = new Customer("", txtBoxName.Text, txtBoxAdress.Text, txtBoxEmail.Text, txtBoxUsername.Text, txtBoxPassword.Text);
            dataBase.DeleteCustomer(customer);
            ClearText();
        }
        /*!
     * \brief method checks that users are correctly registered in the system.
     * @return nothing.
     */
        private void CheckPassword()
        {
            try
            {
                bool isEmailTest = Regex.IsMatch(txtBoxEmail.Text, @"\A(?:[a-z0-9!#$%&'+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'+/=?^_`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                bool isPasswordTest = Regex.IsMatch(txtBoxPassword.Text, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]", RegexOptions.IgnoreCase);
                bool isNameTest = true;
                if (txtBoxName.Text == "")
                    isNameTest = false;
                bool isResidenceAddressTest = true;
                if (txtBoxAdress.Text == "")
                    isResidenceAddressTest = false;

                Product.Database db = new Product.Database();
                db.CustomerList();
                List<Customer> CustomerList = db.GetCustomersList;

                if (isEmailTest == true &&
                    isPasswordTest == true &&
                    isNameTest == true &&
                    isResidenceAddressTest == true)
                {
                    Product.Database dataBase = new Product.Database();
                    FormAdminControl a = FormAdminControl.instance;
                    Customer customer = new Customer("", txtBoxName.Text, txtBoxAdress.Text, txtBoxEmail.Text, txtBoxUsername.Text, txtBoxPassword.Text);
                    dataBase.UpdateCustomer(customer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
       * \brief method clears text.
       * @return nothing.
       */
        private void ClearText()
        {
            txtBoxAdress.Text = "";
            txtBoxEmail.Text = "";
            txtBoxName.Text = "";
            txtBoxPassword.Text = "";
            txtBoxUsername.Text = "";
        }
        /*!
       * \brief method contains the task to be done when the list button is pressed.
        * @param sender is object variable and e is EventArgs variable.
        * @return nothing.
       */
        private void btnList_Click(object sender, EventArgs e)
        {
            FormAdminListView.Instance.Show();
        }
    }
}// End namespace Online_Book_Store.Admin

/*! @} End of Doxygen Groups*/
