using Online_Book_Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
/*!
 *  \addtogroup Online_Book_Store
 *  @{
 */
//! Online_Book_Store methods and implementations.
namespace Online_Book_Store
{   /*!
     * \class Customer.
     * \brief Contains the general properties and methods of the customer.
     */
    public class Customer
    {
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        /*!
        * \brief constructor method.
        * @param customerID is string variable.
        * @param name is string variable.
        * @param address is string variable.
        * @param email is string variable.
        * @param username is string variable.
        * @param password is string variable.
        */
        public Customer(string customerID = "", string name = "", string address = "", string email = "", string username = "", string password = "")
        {
            this.CustomerID = customerID;
            this.Name = name;
            this.Address = address;
            this.Email = email;
            this.Username = username;
            this.Password = password;
        }
        /*!
         * \brief method prints the customer properties.
         * @return nothing.
         */
        public void printCustomerDetails()
        {
            Console.WriteLine("CustomerID:" + CustomerID + " " + "Name:" + Name + " " + "Address:" + Address + " " +
                "Email:" + Email + " " + "Username" + Username + " " + "Password:" + Password);
        }
        /*!
       * \brief method saves the customer with their information.
       * @return nothing.
       */
        public void saveCustomer()
        {
            Product.Database db = new Product.Database();
            db.AddCustomer(this);
        }
        /*!
        * \brief method print the customer purchases.
        * @return nothing.
        */
        public void printCustomerPurchases(List<Product.ItemToPurchase> itemsToPurchase)
        {
            itemsToPurchase.ForEach(x => { x.PrintItems(); });
        }
        /*!
       * \brief method print the customer purchases.
       * @param accountName is string variable and password is string variable.
       * @return nothing.
       */
        public bool IsInDatabase(string accountName, string password)
        {
            return this.Username.Equals(accountName) && this.Password.Equals(password);
        }

        //public static string ComputeSha256Hash(string password)
        //{
        //    using (SHA256 sha256Hash = SHA256.Create())
        //    {
        //        byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

        //        StringBuilder builder = new StringBuilder();
        //        for (int i = 0; i < bytes.Length; i++)
        //        {
        //            builder.Append(bytes[i].ToString("x2"));
        //        }
        //        return builder.ToString();
        //    }
        //}
    }
}// End namespace Online_Book_Store

/*! @} End of Doxygen Groups*/
