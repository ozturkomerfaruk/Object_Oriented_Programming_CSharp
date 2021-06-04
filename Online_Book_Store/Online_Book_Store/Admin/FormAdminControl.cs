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
 *  \addtogroup Online_Book_Store.Admin
 *  @{
 */
//! Online_Book_Store.Admin methods and implementations.
namespace Online_Book_Store.Admin
{
    /*!
    * \class FormAdminControl.
    * \brief Contains the methods of the control in the admin panel.
    */
    public partial class FormAdminControl : Form
    {
        /*!
        * \brief default constructor method.
        */
        public FormAdminControl()
        {
            InitializeComponent();
        }
        /*! This is enum ProductType includes "Book, MusicCD, Magazine" keywords.*/
        public enum ProductType
        {
            Book, MusicCD, Magazine
        }

        public static ProductType _ProductType { get; set; }

        public UC_AdminProduct adminProduct = new UC_AdminProduct();
        public UC_Customer adminCustomer = new UC_Customer();

        public UC_Book ucbook = new UC_Book();
        public UC_Magazine ucmagazine = new UC_Magazine();
        public UC_MusicCD ucmusicCD = new UC_MusicCD();

        public static FormAdminControl instance;

        private ListView customerListView = new ListView();
        private ListView bookListView = new ListView();
        private ListView magazineListView = new ListView();
        private ListView musicCDListView = new ListView();
        /*!
    * \brief method contains the task to be done when the book button is pressed.
    * @param sender is object variable and e is EventArgs variable.
    * @return nothing.
    */
        Product.Database dataBase = new Product.Database();

        private void btnBook_Click(object sender, EventArgs e)
        {
            dataBase.BookList();
            List<Product.Book> BookList = dataBase.GetBookList;

            panelButtom.Controls.Clear();
            panelButtom.Controls.Add(adminProduct);
            _ProductType = ProductType.Book;
            adminProduct.ChangePanel(ucbook);
            bookListView.Columns.Clear();
            bookListView.Columns.Add("Name", 140, HorizontalAlignment.Center);
            bookListView.Columns.Add("Author", 140, HorizontalAlignment.Center);
            bookListView.Columns.Add("Publisher", 140, HorizontalAlignment.Center);
            bookListView.Columns.Add("Price", 140, HorizontalAlignment.Center);
            bookListView.Columns.Add("Page", 140, HorizontalAlignment.Center);
            bookListView.Columns.Add("ISBN", 140, HorizontalAlignment.Center);

            bookListView.Items.Clear();

            foreach (Product.Book item in BookList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Name;
                listViewItem.SubItems.Add(item.Author);
                listViewItem.SubItems.Add(item.Publisher);
                listViewItem.SubItems.Add(item.Price);
                listViewItem.SubItems.Add(item.Page);
                listViewItem.SubItems.Add(item.ISBN);
                bookListView.Items.Add(listViewItem);
            }

            FormAdminListView.Instance.setListView(bookListView);
        }
        /*!
     * \brief method contains the task to be done when the magazine button is pressed.
     * @param sender is object variable and e is EventArgs variable.
     * @return nothing.
     */
        private void btnMagazine_Click(object sender, EventArgs e)
        {
            dataBase.MagazineList();
            List<Product.Magazine> MagazineList = dataBase.GetMagazineList;

            panelButtom.Controls.Clear();
            panelButtom.Controls.Add(adminProduct);
            _ProductType = ProductType.Magazine;
            adminProduct.ChangePanel(ucmagazine);
            magazineListView.Columns.Clear();
            magazineListView.Columns.Add("Name", 140, HorizontalAlignment.Center);
            magazineListView.Columns.Add("Issue", 140, HorizontalAlignment.Center);
            magazineListView.Columns.Add("Magazine Type", 140, HorizontalAlignment.Center);
            magazineListView.Columns.Add("Price", 140, HorizontalAlignment.Center);

            magazineListView.Items.Clear();

            foreach (Product.Magazine item in MagazineList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Name;
                listViewItem.SubItems.Add(item.Issue);
                listViewItem.SubItems.Add(item.Type.ToString());
                listViewItem.SubItems.Add(item.Price);
                magazineListView.Items.Add(listViewItem);
            }
            FormAdminListView.Instance.setListView(magazineListView);
        }
        /*!
      * \brief method contains the task to be done when the musicCD button is pressed.
      * @param sender is object variable and e is EventArgs variable.
      * @return nothing.
      */
        private void btnMusicCD_Click(object sender, EventArgs e)
        {
            dataBase.MusicCDList();
            List<Product.MusicCD> MusicCDList = dataBase.GetMusicCDList;

            panelButtom.Controls.Clear();
            panelButtom.Controls.Add(adminProduct);
            _ProductType = ProductType.MusicCD;
            adminProduct.ChangePanel(ucmusicCD);
            musicCDListView.Columns.Clear();
            musicCDListView.Columns.Add("Name", 140, HorizontalAlignment.Center);
            musicCDListView.Columns.Add("Singer", 140, HorizontalAlignment.Center);
            musicCDListView.Columns.Add("Music CD Type", 140, HorizontalAlignment.Center);
            musicCDListView.Columns.Add("Price", 140, HorizontalAlignment.Center);

            musicCDListView.Items.Clear();

            foreach (Product.MusicCD item in MusicCDList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Name;
                listViewItem.SubItems.Add(item.Singer);
                listViewItem.SubItems.Add(item.Type.ToString());
                listViewItem.SubItems.Add(item.Price);
                musicCDListView.Items.Add(listViewItem);
            }
            FormAdminListView.Instance.setListView(musicCDListView);

        }
        /*!
     * \brief method contains the task to be done when the customer button is pressed.
     * @param sender is object variable and e is EventArgs variable.
     * @return nothing.
     */
        private void btnCustomer_Click(object sender, EventArgs e)
        {
            dataBase.CustomerList();
            List<Customer> CustomerList = dataBase.GetCustomersList;

            panelButtom.Controls.Clear();
            panelButtom.Controls.Add(adminCustomer);
            customerListView.Columns.Clear();
            customerListView.Columns.Add("Username", 140, HorizontalAlignment.Center);
            customerListView.Columns.Add("Password", 140, HorizontalAlignment.Center);
            customerListView.Columns.Add("Name", 140, HorizontalAlignment.Center);
            customerListView.Columns.Add("Email", 200, HorizontalAlignment.Center);
            customerListView.Columns.Add("Address", 140, HorizontalAlignment.Center);

            customerListView.Items.Clear();

            foreach (Customer item in CustomerList)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Username;
                listViewItem.SubItems.Add(item.Password);
                listViewItem.SubItems.Add(item.Name);
                listViewItem.SubItems.Add(item.Email);
                listViewItem.SubItems.Add(item.Address);  
                customerListView.Items.Add(listViewItem);
            }
            FormAdminListView.Instance.setListView(customerListView);
        }
        /*!
        * \brief method loads the tasks that need to run when the app starts.
        * @param sender is object variable and e is EventArgs variable.
        * @return nothing.
        */
        private void FormAdminControl_Load(object sender, EventArgs e)
        {
            instance = this;
        }
        /*!
        * \brief method includes tasks done while closing the application.
        * @param sender is object variable and e is EventArgs variable.
        * @return nothing.
        */
        private void FormAdminControl_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}// End namespace Online_Book_Store.Admin

/*! @} End of Doxygen Groups*/
