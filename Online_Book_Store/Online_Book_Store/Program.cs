using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*!
 *  \addtogroup Online_Book_Store
 *  @{
 */
//! Online_Book_Store methods and implementations.
namespace Online_Book_Store
{  /*!
     * \class Program.
     * \brief Contains the methods of the program.
     */
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogIn());
        }
    }
}// End namespace Online_Book_Store

/*! @} End of Doxygen Groups*/