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
{ /*!
     * \class FormFormlarArasıGecis.
     * \brief Contains the general properties and methods of the FormFormlarArasıGecis.
     */
    public partial class FormFormlarArasıGecis : Form
    { /*!
         * \brief default constructor.
         */
        public FormFormlarArasıGecis()
        {
            InitializeComponent();
        }

        public FormLogIn fL { get; set; }
        /*!
        * \brief method loads the tasks that need to run when the app starts.
        * @param sender is object variable and e is EventArgs variable.
        * @return nothing.
        */
        private void FormFormlarArasıGecis_Load(object sender, EventArgs e)
        {
            nextForm = FormMainWindow.Instance;
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Start();
            nextForm.CustomerName = fL.textBoxAccountName.Text;
            this.labelAccountName.Text = fL.textBoxAccountName.Text;      
        }

        int sayac = 0;
        FormMainWindow nextForm;
        /*!
         * \brief method performs the counting.
         * @param sender is object variable and e is EventArgs variable.
         * @return nothing.
         */
        private void timer_Tick(object sender, EventArgs e)
        {
            if (sayac == 100)
            {
                timer.Stop();
                nextForm.Show();
                this.Hide();
            }

            progressBar.Value = sayac;
            labelProccessing.Text = "Proccessing ... " + sayac + "%";
            sayac += 25;  
        }
        /*!
         * \brief method includes tasks done while closing the application.
         * @param sender is object variable and e is EventArgs variable.
         * @return nothing.
         */
        private void FormFormlarArasıGecis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        /*!
        * \brief method includes tasks done while closing the application.
        * @param sender is object variable and e is EventArgs variable.
        * @return nothing.
        */
        private void FormFormlarArasıGecis_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}// End namespace Online_Book_Store

/*! @} End of Doxygen Groups*/
