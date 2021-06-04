using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*!
 *  \addtogroup Online_Book_Store
 *  @{
 */
//! Online_Book_Store methods and implementations.
namespace Online_Book_Store
{/*!
     * \class DatabaseConnection.
     * \brief Contains the connections methods of the database.
     */
    class DatabaseConnection
    {
        public SqlConnection Connect { get; set; }
        /*!
       * \brief method provides connection to database.
       * @return nothing.
       */
        public void Connection()
        {
            var connectionASPString = @"Data Source = SQL5097.site4now.net; Initial Catalog = db_a7525e_ahmetleap; User Id = db_a7525e_ahmetleap_admin; Password = AhmetLeap98.";
            Connect = new SqlConnection(connectionASPString);
        }
        /*!
         * \brief method opens connection.
         * @return nothing.
         */
        public void Open()
        {
            Connect.Open();
        }
        /*!
        * \brief method closes connection.
        * @return nothing.
        */
        public void Close()
        {
            Connect.Close();
        }
    }
}// End namespace Online_Book_Store

/*! @} End of Doxygen Groups*/

