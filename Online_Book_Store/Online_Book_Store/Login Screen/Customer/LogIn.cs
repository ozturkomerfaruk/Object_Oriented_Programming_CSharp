using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*!
 *  \addtogroup Online_Book_Store
 *  @{
 */
//! Online_Book_Store methods and implementations.
namespace Online_Book_Store
{ /*!
     * \class LogIn.
     * \brief Contains the general properties and methods of login.
     */
    class LogIn
    {
        private Customer customer;
        private static LogIn instance;
        //Singleton Design Pattern
        public static LogIn Instance { get { if (instance is null) instance = new LogIn(); return instance; } set { instance = value; } }
        //Singleton Design Pattern
        public Customer Customer { get => customer; set { customer = value; } }

    }
}// End namespace Online_Book_Store

/*! @} End of Doxygen Groups*/

