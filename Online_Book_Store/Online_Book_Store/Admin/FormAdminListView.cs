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
{
    /*!
    * \class FormAdminListView.
    * \brief Includes list view methods in admin panel.
    */
    public partial class FormAdminListView : Form
    {
        //singleton 
        private static FormAdminListView instance;
        /*!
       * \brief constructor method is done with singleton design pattern.
       */
        public static FormAdminListView Instance 
        {
            get 
            {
                if (instance is null || instance.IsDisposed)
                {
                    instance = new FormAdminListView();
                }
                return instance;
            }  
            set 
            {
                instance = value; 
            } 
        }
        /*!
                 * \brief default constructor method.
                 */
        public FormAdminListView()
        {
            InitializeComponent();
        }
        /*!
       * \brief method loads the tasks that need to run when the app starts.
       * @param sender is object variable and e is EventArgs variable.
       * @return nothing.
       */
        private void FormAdminListView_Load(object sender, EventArgs e)
        {
            listViewAdminControl.GridLines = true;
        }
        /*!
       * \brief method sets the sent listview value to listview.
       * @param listView is ListView variable.
       * @return nothing.
       */
        public void setListView(ListView listView)
        {
            listViewAdminControl.Columns.AddRange((from ColumnHeader Col in listView.Columns
                                        select (ColumnHeader)Col.Clone()).ToArray());

            listViewAdminControl.Items.AddRange((from ListViewItem item in listView.Items
                                    select (ListViewItem)item.Clone()).ToArray());
        }
        /*!
         * \brief method contains the task to be done when the application is closed.
         * @param sender is object variable and e is FormClosedEventArgs variable.
         * @return nothing.
         */
        private void FormAdminListView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
// End namespace Online_Book_Store.Admin
/*! @} End of Doxygen Groups*/

