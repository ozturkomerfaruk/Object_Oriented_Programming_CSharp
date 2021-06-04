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
     * \class UC_Magazine.
     * \brief Contains the methods of the magazine in the user panel.
     */
    public partial class UC_Magazine : UserControl
    {
        /*!
         * \brief default constructor method.
         */
        public UC_Magazine()
        {
            InitializeComponent();
        }
        /*!
      * \brief method stores and forwards magazine properties.
      * @return data
      */
        public string[] GetData()
        {
            string selected = this.comboBoxMagazineType.GetItemText(this.comboBoxMagazineType.SelectedItem);
            string[] data = new string[2];
            data[0] = txtBoxIssueMagazine.Text;
            data[1] = selected;
            return data;
        }
        /*!
        * \brief method sets issue.
        * @param issue is string variable.
        * @return nothing
        */
        public void setIssue(string issue)
        {
            txtBoxIssueMagazine.Text = issue;
        }
        /*!
     * \brief method sets type.
     * @param type is string variable.
     * @return nothing
     */
        public void setMagazineType(Product.MagazineType type)
        {
            comboBoxMagazineType.SelectedIndex = comboBoxMagazineType.Items.IndexOf(type.ToString());
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
}
// End namespace Online_Book_Store.Admin

/*! @} End of Doxygen Groups*/