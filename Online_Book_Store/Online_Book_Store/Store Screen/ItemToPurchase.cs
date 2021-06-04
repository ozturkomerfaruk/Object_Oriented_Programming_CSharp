using Online_Book_Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*!
 *  \addtogroup Online_Book_Store.Product
 *  @{
 */
//! Online_Book_Store.Product methods and implementations.
namespace Online_Book_Store.Product
{  /*!
     * \class ItemToPurchase.
     * \brief Contains the methods of the purchase.
     */
    public class ItemToPurchase
    {
        public string CustomerName { get; set; }
        public Product Product { get; set; }

        public string[] Derived;
        public string Quantity { get; set; }
        /*!
        * \brief default constructor method.
        * @param product is Product variable,
        * @param customerName is string variable,
        * @param derived is string variable,
        * @param quantity is string variable.
        */
        public ItemToPurchase(Product product, string customerName, string[] derived, string quantity = "1")
        {
            this.Product = product;
            this.Derived = derived;
            this.CustomerName = customerName;
            this.Quantity = quantity;
        }
        /*!
   * \brief method prints items.
   * @return nothing.
   */
        public void PrintItems()
        {
            this.Product.PrintProperties();
            Console.WriteLine(Environment.NewLine + "Number of products: " + this.Quantity + Environment.NewLine);
        }

    }
}// End namespace Online_Book_Store.Admin

/*! @} End of Doxygen Groups*/
