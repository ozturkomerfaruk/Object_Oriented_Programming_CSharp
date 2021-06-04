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
 *  \addtogroup Online_Book_Store
 *  @{
 */
//! Online_Book_Store methods and implementations.
namespace Online_Book_Store
{ /*!
     * \class FormNewAccount.
     * \brief Contains the general properties and methods of the new account.
     */
    public partial class FormNewAccount : Form
    {/*!
         * \brief default constructor.
         */
        public FormNewAccount()
        {
            InitializeComponent();
        }
        /*!
         * \brief method loads the tasks that need to run when the app starts.
         * @param sender is object variable and e is EventArgs variable.
         * @return nothing.
         */
        private void FormNewAccount_Load(object sender, EventArgs e)
        {
            labelAvailable.Text = "";
        }
        /*!
       * \brief method includes tasks done while closing the application.
       * @param sender is object variable and e is EventArgs variable.
       * @return nothing.
       */
        private void FormNewAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Do you want to exit the registration screen?", "EXIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                FormLogIn formLogIn = new FormLogIn();
                formLogIn.Show();
                this.Hide();
            }
        }
        /*!
      * \brief method backs to login screen.
      * @return nothing.
      */
        private void BackToTheLogIn()
        {
            FormLogIn loginForm = new FormLogIn();
            loginForm.Show();
            this.Hide();
        }
        /*!
       * \brief method contains the task to be done when the register button is pressed.
       * @param sender is object variable and e is EventArgs variable.
       * @return nothing.
       */
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                bool usernameControl = true;
                bool isEmailTest = Regex.IsMatch(txtBoxEmail.Text, @"\A(?:[a-z0-9!#$%&'+/=?^_`{|}~-]+(?:.[a-z0-9!#$%&'+/=?^_`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                bool isPasswordTest = Regex.IsMatch(txtBoxPassword.Text, @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]", RegexOptions.IgnoreCase);
                bool rePasswordTest = false;
                if (txtBoxPassword.Text == txtBoxRePassword.Text)
                    rePasswordTest = true;
                bool isNameTest = true;
                if (txtBoxName.Text == "")
                    isNameTest = false;
                bool isResidenceAddressTest = true;
                if (txtBoxResidenceAddress.Text == "")
                    isResidenceAddressTest = false;
                bool checkboxTickControl = false;
                if (checkBoxOnay1.Checked == true && checkBoxOnay2.Checked == true)
                    checkboxTickControl = true;

                Product.Database db = new Product.Database();
                db.CustomerList();
                List<Customer> CustomerList = db.GetCustomersList;

                foreach (Customer _customer in CustomerList)
                {
                    if (_customer.Username == txtBoxUsername.Text)
                    {
                        usernameControl = false;
                    }
                }

                if (usernameControl == true && 
                    isEmailTest == true && 
                    isPasswordTest == true && 
                    isNameTest == true && 
                    isResidenceAddressTest == true && 
                    rePasswordTest == true && 
                    checkboxTickControl == true)
                {
                    Customer newCustomer = new Customer(
                        "", txtBoxName.Text, txtBoxResidenceAddress.Text, txtBoxEmail.Text, txtBoxUsername.Text, txtBoxPassword.Text);
                    newCustomer.saveCustomer();
                    BackToTheLogIn();
                }
                else if (!usernameControl)
                {
                    MessageBox.Show("Username is already taken. Change your username for signing.");
                }
                else
                {
                    MessageBox.Show("Enter the information completely!!");
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
        private void FormNewAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            BackToTheLogIn();
        }
        /*!
       * \brief method contains the task to be done when the text box password is changed.
       * @param sender is object variable and e is EventArgs variable.
       * @return nothing.
       */
        private void txtBoxPassword_TextChanged(object sender, EventArgs e)
        {
            if (GetPasswordStrength(txtBoxPassword.Text) == PasswordStrength.Blank)
            {
                progressBarPasswordStrength.Value = 0;
                labelProgressBarPasswordStrength.Text = "0%";
            }
            if (GetPasswordStrength(txtBoxPassword.Text) == PasswordStrength.VeryWeak)
            {
                progressBarPasswordStrength.Value = 1;
                labelProgressBarPasswordStrength.Text = "25%";
            }
            if (GetPasswordStrength(txtBoxPassword.Text) == PasswordStrength.Weak)
            {
                progressBarPasswordStrength.Value = 2;
                labelProgressBarPasswordStrength.Text = "50%";
            }
            if (GetPasswordStrength(txtBoxPassword.Text) == PasswordStrength.Medium)
            {
                progressBarPasswordStrength.Value = 3;
                labelProgressBarPasswordStrength.Text = "75%";
            }
            if (GetPasswordStrength(txtBoxPassword.Text) == PasswordStrength.Strong)
            {
                progressBarPasswordStrength.Value = 4;
                labelProgressBarPasswordStrength.Text = "100%";
            }   
        }
        /*! This is enum PasswordStrength includes "Blank, VeryWeak, Weak, Medium,Strong" keywords.*/
        public enum PasswordStrength
        {
            Blank = 0, //şifre kısmı boş
            VeryWeak = 1, //8 haneden düşük
            Weak = 2, //büyük ve küçük harf girildi
            Medium = 3, //rakam girildi
            Strong = 4, //sembol girildi
        }
        /*!
       * \brief method checks password strength.
       * @param password is string variable.
       * @return (PasswordStrength)score.
       */
        public static PasswordStrength GetPasswordStrength(string password)
        {
            int score = 0;
            if (String.IsNullOrEmpty(password) || String.IsNullOrEmpty(password.Trim())) return PasswordStrength.Blank;
            if (HasMinimumLength(password)) score++;
            if (HasUpperCaseLetter(password) && HasLowerCaseLetter(password)) score++;
            if (HasDigit(password)) score++;
            if (HasSpecialChar(password)) score++;
            return (PasswordStrength)score;
        }
        /*!
   * \brief method checks password strength.
   * @param password is string variable.
   * @return (PasswordStrength)score.
   */
        public static bool HasLowerCaseLetter(string password)
        {
            return password.Any(c => char.IsLower(c));
        }
        /*!
   * \brief method checks if the upper case exists.
   * @param password is string variable.
   * @return true or false.
   */
        public static bool HasUpperCaseLetter(string password)
        {
            return password.Any(c => char.IsUpper(c));
        }
        /*!
     * \brief method checks if the char exists.
     * @param password is string variable.
     * @return true or false.
     */
        public static bool HasSpecialChar(string password)
        {
            return password.IndexOfAny("!@#$%^&*?_~-£().,".ToCharArray()) != -1;
        }
        /*!
     * \brief method checks if the digit case exists.
     * @param password is string variable.
     * @return true or false.
     */
        public static bool HasDigit(string password)
        {
            return password.Any(c => char.IsDigit(c));
        }
        /*!
        * \brief method checks the minimum character length.
        * @param password is string variable.
        * @return true or false.
        */
        public static bool HasMinimumLength(string password)
        {
            return password.Length >= 8;
        }
        /*!
        * \brief method contains the task to be done when the check availability button is pressed.
        * @param sender is object variable and e is EventArgs variable.
        * @return nothing.
        */
        private void btnCheckAvailability_Click(object sender, EventArgs e)
        {
            bool accountNameControl = true;
            Online_Book_Store.Product.Database db2 = new Online_Book_Store.Product.Database();
            db2.CustomerList();
            List<Customer> CustomerList2 = db2.GetCustomersList;

            foreach (Customer _customer2 in CustomerList2)
            {
                if (_customer2.Username == txtBoxUsername.Text)
                {
                    accountNameControl = false;
                }
            }
            if (accountNameControl)
            {
                labelAvailable.Text = "Available!";
                labelAvailable.ForeColor = Color.Green;
            }
            else
            {
                labelAvailable.Text = "Cannot be Used!";
                labelAvailable.ForeColor = Color.Red;
            }
        }
    }
}// End namespace Online_Book_Store

/*! @} End of Doxygen Groups*/