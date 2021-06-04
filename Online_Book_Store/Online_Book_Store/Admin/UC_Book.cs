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
 *  \addtogroup Online_Book_Store.Admin
 *  @{
 */
//! Online_Book_Store.Admin methods and implementations.
namespace Online_Book_Store.Admin
{   /*!
     * \class UC_Book.
     * \brief Contains book-related methods in the user panel.
     */
    public partial class UC_Book : UserControl
    {
        /*!
         * \brief default constructor method.
         */
        public UC_Book()
        {
            InitializeComponent();
        }
        /*!
        * \brief method stores and forwards book properties.
        * @return data
        */
        public string[] GetData()
        {
            string[] data = new string[4];
            data[0] = txtBoxPage.Text;
            data[1] = txtBoxAuthor.Text;
            data[2] = txtBoxPublisher.Text;
            data[3] = txtBoxISBN.Text;
            return data;
        }
        /*!
        * \brief method sets page.
        * @param page is string variable.
        * @return nothing
        */
        public void setPage(string page)
        {
            txtBoxPage.Text = page;
        }
        /*!
     * \brief method sets author.
     * @param author is string variable.
     * @return nothing
     */
        public void setAuthor(string author)
        {
            txtBoxAuthor.Text = author;
        }
        /*!
      * \brief method sets publisher.
      * @param publisher is string variable.
      * @return nothing
      */
        public void setPublisher(string publisher)
        {
            txtBoxPublisher.Text = publisher;
        }
        /*!
     * \brief method sets isbn.
     * @param isbn is string variable.
     * @return nothing
     */
        public void setISBN(string isbn)
        {
            txtBoxISBN.Text = isbn;
        }
        /*!
        * \brief method contains the task to be done when the perform button is pressed.
       * @param sender is object variable and e is EventArgs variable.
       * @return nothing.
       */
        private void btnPerform_Click(object sender, EventArgs e)
        {
            switch (Admin.UC_AdminProduct.Instance.currentState)
            {
                case UC_AdminProduct.States.None:
                    break;
                case UC_AdminProduct.States.Add:
                    {
                        Admin.UC_AdminProduct.Instance.Add();
                    }
                    break;
                case UC_AdminProduct.States.Update:
                    {
                        Admin.UC_AdminProduct.Instance.Update();
                    }
                    break;
                case UC_AdminProduct.States.Delete:
                    {
                        Admin.UC_AdminProduct.Instance.Delete();
                    }
                    break;
                default:
                    break;
            }
            
        }
    }
}// End namespace Online_Book_Store.Admin

/*! @} End of Doxygen Groups*/
