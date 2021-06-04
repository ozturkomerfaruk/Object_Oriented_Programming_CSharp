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
 *  \addtogroup Online_Book_Store.Products
 *  @{
 */
//! Online_Book_Store.Products methods and implementations.
namespace Online_Book_Store.Products
{ /*!
     * \class CartItem.
     * \brief Contains the general properties and methods of the CartItem.
     */
    public partial class CartItem : UserControl
    {
        private Product.ItemToPurchase item;
        public Product.ItemToPurchase Item { get => item; set => item = value; }
        /*!
       * \brief constructor method.
       * @param _item is Product.ItemToPurchase variable.
       */
        public CartItem(Product.ItemToPurchase _item)
        {
            InitializeComponent();
            item = _item;
            labelName.Text = item.Product.Name;
            labelPrice.Text = (double.Parse(item.Product.Price) * double.Parse(item.Quantity)).ToString();
            labelQuantity.Text = item.Quantity;
            switch (item.Product.GetType().Name)
            {
                case "Book":
                    {
                        label1.Text = item.Product.GetDerivedData()[1];
                        label2.Text = item.Product.GetDerivedData()[3];
                        label3.Text = item.Product.GetDerivedData()[2];
                        label4.Text = item.Product.GetDerivedData()[0];
                        break;
                    }
                case "MusicCD":
                    {
                        label1.Text = item.Product.GetDerivedData()[0];
                        label2.Text = item.Product.GetDerivedData()[1];
                        label3.Text = "";
                        label4.Text = "";
                        break;
                    }
                case "Magazine":
                    {
                        label1.Text = item.Product.GetDerivedData()[0];
                        label2.Text = item.Product.GetDerivedData()[1];
                        label3.Text = "";
                        label4.Text = "";
                        break;
                    }
                default: break;
            }
        }
        /*!
       * \brief method sets quantity.
       * @param i is int variable.
       * @return nothing.
       */
        private void SetQuantity(int i)
        {
            double q = double.Parse(labelQuantity.Text);
            if (i < 0 && q == 0) return;
            else labelQuantity.Text = (q + i).ToString();
            labelPrice.Text = (double.Parse(Item.Product.Price) * (q + i)).ToString();
        }
        /*!
       * \brief method contains the task to be done when the plus button is pressed.
       * @param sender is object variable and e is EventArgs variable.
       * @return nothing.
       */
        private void btnPlus_Click(object sender, EventArgs e)
        {
            SetQuantity(1);
        }
        /*!
        * \brief method contains the task to be done when the minus button is pressed.
        * @param sender is object variable and e is EventArgs variable.
        * @return nothing.
        */
        private void btnMinus_Click(object sender, EventArgs e)
        {
            SetQuantity(-1);
        }
        /*!
       * \brief method contains the task to be done when the remove button is pressed.
       * @param sender is object variable and e is EventArgs variable.
       * @return nothing.
       */
        private void buttonRemoveFromCart_Click(object sender, EventArgs e)
        {
            FormMainWindow.Instance.RemoveItemFromCart(this.Item);
        }
    }
}
// End namespace Online_Book_Store.Products

/*! @} End of Doxygen Groups*/
