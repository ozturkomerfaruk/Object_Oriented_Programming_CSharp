using Online_Book_Store;
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
{/*! This is enum PaymentType includes "CreditCard, TransferEFT" keywords.*/
    public enum PaymentType
    {
        CreditCard, TransferEFT
    }
    /*!
    * \class ShoppingCart.
    * \brief Contains the methods of the shopping cart.
    */
    public class ShoppingCart
    {
        //Single Customer Object //singleton design pattern
        private Customer customer;
        public Customer Customer { get => customer; set { customer = value; } }

        public string CustomerID { get; set; }
        public double PaymentAmount { get; set; }
        public PaymentType PaymentType { get; set; }

        public List<Online_Book_Store.Product.ItemToPurchase> itemsToPurchase = new List<Online_Book_Store.Product.ItemToPurchase>();

        //Single Customer Object //singleton design pattern
        private ShoppingCart instance = null;
        public ShoppingCart Instance { get => instance; set { instance = value; } }
        /*!
         * \brief default constructor method.
         */
        public ShoppingCart()
        {
            PaymentAmount = 0;
        }
        /*!
      * \brief method prints product.
      * @param item is Online_Book_Store.Product.ItemToPurchase variable.
      * @return nothing.
      */
        public void PrintProduct(Online_Book_Store.Product.ItemToPurchase item)
        {
            if (itemsToPurchase.Contains(item))
            {
                item.PrintItems();
            }
        }
          /*!
       * \brief method adds product.
       * @param item is Online_Book_Store.Product.ItemToPurchase variable.
       * @return nothing.
       */
        public void AddProduct(Online_Book_Store.Product.ItemToPurchase item)
        {
            itemsToPurchase.Add(item);
            PaymentAmount += (double.Parse(item.Product.Price) * double.Parse(item.Quantity));
        }
          /*!
       * \brief method removes product.
       * @param item is Online_Book_Store.Product.ItemToPurchase variable.
       * @return nothing.
       */
        public void RemoveProduct(Online_Book_Store.Product.ItemToPurchase item)
        {
            if (itemsToPurchase.Contains(item))
            {
                PaymentAmount -= (double.Parse(item.Product.Price) * double.Parse(item.Quantity));
                itemsToPurchase.Remove(item);
            }
        }
        /*!
      * \brief method indicates place of orders.
      * @return nothing.
      */
        public void PlaceOrder()
        {
            if (instance is null)
                instance = new ShoppingCart();

            CancelOrder();
        }
            /*!
       * \brief method cancels orders.
       * @return nothing.
       */
        public void CancelOrder()
        {
            itemsToPurchase.Clear();
            PaymentAmount = 0.0;
        }
        /*!
     * \brief method sends in voice by emails.
     * @return nothing.
     */
        public void SendInvoicebyEmail()
        {

        }
                /*!
       * \brief method sends in voice by sms.
       * @return nothing.
       */
        public void sendInvoicebySMS()
        {
            Console.WriteLine("SMS has been sent to your phone!");
        }
    }// End namespace Online_Book_Store

    /*! @} End of Doxygen Groups*/
}
