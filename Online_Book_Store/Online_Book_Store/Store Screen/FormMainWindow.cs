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
{     /*!
     * \class FormMainWindow.
     * \brief Contains the general properties and methods of the main window.
     */
    public partial class FormMainWindow : Form
    {
        private int i = 0, j = 0;
        private int x = 250;
        private int storeColumn = 5, cartColumn = 1;
        private bool isStoreActive = true;
        private int padding = 5;
        private List<Filter> filters = new List<Filter>();
        private List<Product.ItemToPurchase> storeItems = new List<Product.ItemToPurchase>();
        private List<Product.ItemToPurchase> cartItems = new List<Product.ItemToPurchase>();
        private enum Filter { Book, MusicCD, Magazine }

        Product.Database dataBase;
        public string CustomerName { get; set; }
        private static FormMainWindow instance = null;
        public static FormMainWindow Instance { 
            get {
                if (instance is null)
                    instance = new FormMainWindow("");
                return instance;
            }
            set => instance = value; }
        /*!
        * \brief constructor method.
        * @param customerName is string variable.
        */
        public FormMainWindow(string customerName)
        {
            InitializeComponent();
            CustomerName = customerName;
            this.IsMdiContainer = true;

            MenuStrip ms = new MenuStrip();

            ToolStripMenuItem BookINMenu = new ToolStripMenuItem("BookIN");
            ToolStripMenuItem HelpMenu = new ToolStripMenuItem("Help");

            ToolStripMenuItem LogOut = new ToolStripMenuItem("Log Out", null, new EventHandler(LogOut_Click));
            BookINMenu.DropDownItems.Add(LogOut);
            ToolStripMenuItem Settings = new ToolStripMenuItem("Settings", null, new EventHandler(Settings_Click));
            BookINMenu.DropDownItems.Add(Settings);
            ToolStripMenuItem Exit = new ToolStripMenuItem("Exit", null, new EventHandler(Exit_Click));
            BookINMenu.DropDownItems.Add(Exit);

            ToolStripMenuItem BookINSupport = new ToolStripMenuItem("BookIN Support", null, new EventHandler(BookINSupport_Click));
            HelpMenu.DropDownItems.Add(BookINSupport);
            ToolStripMenuItem AboutBookIN = new ToolStripMenuItem("About BookIN", null, new EventHandler(AboutBookIN_Click));
            HelpMenu.DropDownItems.Add(AboutBookIN);

            ((ToolStripDropDownMenu)(BookINMenu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(BookINMenu.DropDown)).ShowCheckMargin = false;
            
            ((ToolStripDropDownMenu)(HelpMenu.DropDown)).ShowImageMargin = false;
            ((ToolStripDropDownMenu)(HelpMenu.DropDown)).ShowCheckMargin = false;

            ms.MdiWindowListItem = BookINMenu;
            ms.MdiWindowListItem = HelpMenu;
            ms.Items.Add(BookINMenu);
            ms.Items.Add(HelpMenu);
            ms.Dock = DockStyle.Top;
            this.MainMenuStrip = ms;
            this.Controls.Add(ms); 
        }

        void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void LogOut_Click(object sender, EventArgs e)
        {
            FormLogIn flog = new FormLogIn();
            flog.Show();
            this.Dispose();
        }

        void Settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature will be coming soon!");
        }
        
        void BookINSupport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("One day, i will help you :)");
        }
        
        void AboutBookIN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was developed by 4 students" + Environment.NewLine + 
                Environment.NewLine + "Ömer Faruk ÖZTÜRK - 152120171018" +
                Environment.NewLine + "Yahya Bekir CANEVİ - 152120181030" +
                Environment.NewLine + "Fatih HEVESLİ - 152120181037" +
                Environment.NewLine + "Ceyhun ÖZKAN - 151820173028");
        }
 /*!
         * \brief method loads the tasks that need to run when the app starts.
         * @param sender is object variable and e is EventArgs variable.
         * @return nothing.
         */
        private void FormMainWindow_Load(object sender, EventArgs e)
        {
            txtBoxDate.Text = "";
            timerDate.Start();
            checkBoxBook.Checked = true;
            checkBoxCD.Checked = true;
            checkBoxMagazine.Checked = true;
            labelCustomerName.Text = CustomerName;

            ConnectToDatabase();
            panelFilter.Visible = false;
            btnProceed.Visible = false;
        }
        /*!
        * \brief method provides to connect database.
        * @return nothing.
        */
        private void ConnectToDatabase()
        {
            dataBase = new Product.Database();
            dataBase.BookList();
            dataBase.MagazineList();
            dataBase.MusicCDList();
            dataBase.CartItemList();

            panelProducts.Controls.Clear();

            dataBase.GetBookList.ForEach((item) => { storeItems.Add(new Product.ItemToPurchase(item, this.CustomerName, item.GetDerivedData())); });
            dataBase.GetMagazineList.ForEach((item) => { storeItems.Add(new Product.ItemToPurchase(item, this.CustomerName, item.GetDerivedData())); });
            dataBase.GetMusicCDList.ForEach((item) => { storeItems.Add(new Product.ItemToPurchase(item, this.CustomerName, item.GetDerivedData())); });
            dataBase.GetCartItemList.ForEach((item) => { if(item.Item.CustomerName == this.CustomerName) cartItems.Add(item.Item); });

            LoadProducts(storeColumn);
        }
        /*!
        * \brief method loads products accordingly column index.
        * @param maxColumn is int variable.
        * @return nothing.
        */
        private void LoadProducts(int maxColumn)
        {
            panelProducts.Controls.Clear();
            i = j = 0;
            if (maxColumn == storeColumn)
            {
                if (filters.Count > 0 && storeItems.Count > 0)
                {
                    storeItems.ForEach((x) =>
                    {
                        if (filters.Contains(Enum.Parse<Filter>(x.Product.GetType().Name)))
                        {
                            Product.ProductDesign design = new Product.ProductDesign(x);
                            AddUserControl(design, maxColumn, 425);
                        }
                    });
                }
            }
            else if (maxColumn == cartColumn)
            {
                if (cartItems.Count > 0)
                {
                    cartItems.ForEach((x) => {
                        if (this.CustomerName == x.CustomerName)
                        {
                            Products.CartItem cartItem = new Products.CartItem(x);
                            AddUserControl(cartItem, maxColumn, 180);
                        }
                    });
                }
            }
            else return;
        }
        /*!
      * \brief method adds user control.
      * @param design is UserControl variable and _x is int variable and _y is int variable.
      * @return nothing.
      */
        private void AddUserControl(UserControl design, int _x, int _y)
        {
            design.Location = new Point(i * (x + padding), j * (_y + padding));
            i++;
            if (i == _x)
            {
                i = 0;
                j++;
            }
            panelProducts.Controls.Add(design);
        }
        /*!
       * \brief method adds cart to item.
       * @param item is Product.ItemToPurchase variable.
       * @return nothing.
       */
        public void AddCartItem(Product.ItemToPurchase item)
        {
            bool contains = false;
            int index = 0;
            cartItems.ForEach((x) => { if (item.Product.Name == x.Product.Name && this.CustomerName == x.CustomerName) 
                { contains = true; index = cartItems.IndexOf(x); } });
            if (double.Parse(item.Quantity) > 0)
            {
                if (!contains)//Add Item
                {
                    cartItems.Add(item);
                    dataBase.AddCartItem(new Products.CartItem(item));
                }
                else                                             //Update Item
                {
                    cartItems[index] = item;
                    dataBase.UpdateCartItem(new Products.CartItem(item));
                }
            }
            else return;
        }
        /*!
       * \brief method removes cart to item.
       * @param item is Product.ItemToPurchase variable.
       * @return nothing.
       */
        public void RemoveItemFromCart(Product.ItemToPurchase item)
        {
            bool contains = false;
            cartItems.ForEach((x) => {
                if (item.Product.Name == x.Product.Name && this.CustomerName == x.CustomerName)
                    {
                        contains = true;
                        item = x;
                    }
            });
            if (contains)
            {
                cartItems.Remove(item);
                dataBase.DeleteCartItem(new Products.CartItem(item));
            }
            else return;
        }
        /*!
      * \brief method contains the task to be done when the click button is pressed.
      * @param sender is object variable and e is EventArgs variable.
      * @return nothing.
      */
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = !panelFilter.Visible;
        }
        /*!
      * \brief method shows date.
      * @param sender is object variable and e is EventArgs variable.
      * @return nothing.
      */
        private void timerDate_Tick(object sender, EventArgs e)
        {
            txtBoxDate.Text = DateTime.Now.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }
        /*!
       * \brief method contains the task to be done when the checkbox book is changed.
       * @param sender is object variable and e is EventArgs variable.
       * @return nothing.
       */
        private void checkBoxBook_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBook.Checked)
            {
                filters.Add(Filter.Book);
            }
            else
            {
                filters.Remove(Filter.Book);
            }
            LoadProducts(storeColumn);
        }
        /*!
       * \brief method contains the task to be done when the checkbox musicCD is changed.
       * @param sender is object variable and e is EventArgs variable.
       * @return nothing.
       */
        private void checkBoxCD_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCD.Checked)
            {
                filters.Add(Filter.MusicCD);
            }
            else
            {
                filters.Remove(Filter.MusicCD);
            }
            LoadProducts(storeColumn);
        }
        /*!
        * \brief method contains the task to be done when the checkbox magazine is changed.
        * @param sender is object variable and e is EventArgs variable.
        * @return nothing.
        */
        private void checkBoxMagazine_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMagazine.Checked)
            {
                filters.Add(Filter.Magazine);
            }
            else
            {
                filters.Remove(Filter.Magazine);
            }
            LoadProducts(storeColumn);
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            My_Cart.FormPaymentMethods formpayment = My_Cart.FormPaymentMethods.Instance;
            formpayment.Show();
            this.Hide();
            formpayment.subTotal = 0;
            dataBase.GetCustomersList.ForEach((x) => { if (x.Name == CustomerName) formpayment.email = x.Email; });
            
            cartItems.ForEach((x) => { formpayment.subTotal += double.Parse(x.Quantity) * double.Parse(x.Product.Price); }); 
        }
        /*!
      * \brief method contains the task to be done when the change tab is changed.
      * @param sender is object variable and e is EventArgs variable.
      * @return nothing.
      */
        private void buttonChngTab_Click(object sender, EventArgs e)
        {
            

            isStoreActive = !isStoreActive;
            btnProceed.Visible = !isStoreActive;
            panelFilter.Visible = false;
            buttonFilter.Visible = isStoreActive;
            LoadProducts(isStoreActive ? storeColumn : cartColumn);
            buttonChngTab.Text = isStoreActive ? "My Cart" : "Store";
        }
        /*!
         * \brief method includes tasks done while closing the application.
         * @param sender is object variable and e is EventArgs variable.
         * @return nothing.
         */
        private void FormBookStore_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }// End namespace Online_Book_Store

    /*! @} End of Doxygen Groups*/
}
