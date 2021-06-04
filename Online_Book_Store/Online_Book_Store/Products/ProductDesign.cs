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
 *  \addtogroup Online_Book_Store.Product
 *  @{
 */
//! Online_Book_Store.Product methods and implementations.
namespace Online_Book_Store.Product
{/*!
     * \class ProductDesign.
     * \brief Contains the general properties and methods of the ProductDesign.
     */
    public partial class ProductDesign : UserControl
    {
        public ItemToPurchase Item { get; set; }
        /*!
        * \brief constructor method.
        * @param _item is ItemToPurchase variable.
        */
        public ProductDesign(ItemToPurchase _item)
        {
            InitializeComponent();
            Item = _item;
            labelName.Text = Item.Product.Name;
            labelPrice.Text = Item.Product.Price;
            labelQuantity.Text = Item.Quantity;
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
            else Item.Quantity = (q + i).ToString();
            labelQuantity.Text = Item.Quantity;
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
        * \brief method contains the task to be done when the add to cart button is pressed.
        * @param sender is object variable and e is EventArgs variable.
        * @return nothing.
        */
        private void btnAdd2Cart_Click(object sender, EventArgs e)
        {
            FormMainWindow.Instance.AddCartItem(this.Item);
        }
    }
}
// End namespace Online_Book_Store.Product

/*! @} End of Doxygen Groups*/