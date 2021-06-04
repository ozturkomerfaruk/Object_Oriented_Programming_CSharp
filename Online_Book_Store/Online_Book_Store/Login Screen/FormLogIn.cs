using Online_Book_Store.Admin;
using Online_Book_Store.My_Cart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*!
 *  \addtogroup Online_Book_Store
 *  @{
 */
//! Online_Book_Store methods and implementations.
namespace Online_Book_Store
{/*!
     * \class FormLogIn.
     * \brief Contains the general properties and methods of the LogIn.
     */
    public partial class FormLogIn : Form
    {    /*!
         * \brief default constructor.
         */
        public FormLogIn()
        {
            InitializeComponent();
        }

        public static FormFormlarArasıGecis gecisForm;
        /*!
      * \brief method loads the tasks that need to run when the app starts.
      * @param sender is object variable and e is EventArgs variable.
      * @return nothing.
      */
        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }
        /*!
      * \brief method contains the task to be done when the create a new account button is pressed.
      * @param sender is object variable and e is EventArgs variable.
      * @return nothing.
      */
        private void buttonCreateANewAccount_Click(object sender, EventArgs e)
        {
            FormNewAccount formNewAccount = new FormNewAccount();
            formNewAccount.Show();
            this.Hide();
        }
        /*!
        * \brief method contains the task to be done when the login button is pressed.
        * @param sender is object variable and e is EventArgs variable.
        * @return nothing.
        */
        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxAccountName.Text == "admin" && textBoxPassword.Text == "admin")
                {
                    FormAdminControl formAdminGecis = new FormAdminControl();
                    formAdminGecis.Show();
                    this.Hide();
                    return;
                }
                else if (textBoxAccountName.Text == "" && textBoxPassword.Text == "")
                    MessageBox.Show("Username and password are required!", "WARNING!");
                else if (textBoxAccountName.Text == "" && textBoxPassword.Text != "")
                    MessageBox.Show("Username is required!", "WARNING!");
                else if (textBoxAccountName.Text != "" && textBoxPassword.Text == "")
                    MessageBox.Show("Password is required!", "WARNING!");
                else
                {
                    if (checkBoxRememberMyPassword.Checked)
                    {
                        Properties.Settings.Default.username = textBoxAccountName.Text;
                        Properties.Settings.Default.password = textBoxPassword.Text;
                        Properties.Settings.Default.Save();
                    }

                    Product.Database db = new Product.Database();
                    db.CustomerList();
                    bool isInDatabase = false;
                    List<Customer> customerList = db.GetCustomersList;
                    foreach (Customer _customer in customerList)
                    {
                        if (_customer.IsInDatabase(textBoxAccountName.Text, textBoxPassword.Text))
                        {
                            LogIn.Instance.Customer = _customer;
                            gecisForm = new FormFormlarArasıGecis();
                            gecisForm.fL = this;
                            gecisForm.Show();
                            this.Hide();
                            isInDatabase = true;
                            return;
                        }    
                    }
                    if (isInDatabase == false)
                    {
                        MessageBox.Show("Please Register!", "WARNING!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
       * \brief method includes tasks done while closing the application.
       * @param sender is object variable and e is EventArgs variable.
       * @return nothing.
       */
        private void FormLogIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxRememberMyPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRememberMyPassword.Checked)
            {
                textBoxAccountName.Text = Properties.Settings.Default.username;
                textBoxPassword.Text = Properties.Settings.Default.password;
            }
        }
    }
}
// End namespace Online_Book_Store

/*! @} End of Doxygen Groups*/