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
/*!
 * \class UC_AdminProduct.
 * \brief Contains the methods of the products in the admin panel.
 */
{
    public partial class UC_AdminProduct : UserControl
    { /*!
         * \brief default constructor method.
         */
        public UC_AdminProduct()
        {
            InitializeComponent();
        }
        /*!
      * \brief method loads the tasks that need to run when the app starts.
      * @param sender is object variable and e is EventArgs variable.
      * @return nothing.
      */
        private void UC_AdminProduct_Load(object sender, EventArgs e)
        {
            Instance = this;
        }
        /*!
        * \brief method adds the submitted usercontrol value to the control section of the panelProductSelect.
        * @param userControl is UserControl variable.
        * @return nothing.
        */
        public void ChangePanel(UserControl userControl)
        {
            panelProductSelect.Controls.Clear();
            panelProductSelect.Controls.Add(userControl);
        }
        /*! This is enum states includes "None, Add, Update, Delete" keywords.*/
        public enum States
        {
            None, Add, Update, Delete
        }

        public States currentState = States.None;

        public static UC_AdminProduct Instance { get; set; }
        /*!
       * \brief method contains the task to be done when the add button is pressed.
       * @param sender is object variable and e is EventArgs variable.
       * @return nothing.
       */
        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtBoxName.Enabled = true;

            currentState = States.Add;
        }
        /*!
   * \brief method contains the task to be done when the update button is pressed.
   * @param sender is object variable and e is EventArgs variable.
   * @return nothing.
   */
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            txtBoxName.Enabled = true;

            currentState = States.Update;
        }
        /*!
      * \brief method contains the task to be done when the delete button is pressed.
      * @param sender is object variable and e is EventArgs variable.
      * @return nothing.
      */
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtBoxName.Enabled = true;
            currentState = States.Delete;
        }
        /*!
    * \brief method contains the task to be done when the list button is pressed.
    * @param sender is object variable and e is EventArgs variable.
    * @return nothing.
    */
        private void btnList_Click(object sender, EventArgs e)
        {
            txtBoxName.Enabled = true;
            FormAdminListView.Instance.Show();
        }
        /*!
    * \brief method adds to the database according to the selected type.
    * @return nothing.
    */
        public void Add()
        {
            Product.Database dataBase = new Product.Database();
            FormAdminControl a = FormAdminControl.instance;
            switch (FormAdminControl._ProductType)
            {
                case FormAdminControl.ProductType.Book:
                    {

                        Product.Book book = new Product.Book(txtBoxName.Text, "", txtBoxPrice.Text, a.ucbook.GetData()[3], a.ucbook.GetData()[1], a.ucbook.GetData()[2], a.ucbook.GetData()[0]);
                        dataBase.AddBook(book);
                        break;
                    }
                case FormAdminControl.ProductType.MusicCD:
                    {
                        Product.MusicCD musicCD = new Product.MusicCD(txtBoxName.Text, "", txtBoxPrice.Text, a.ucmusicCD.GetData()[0], Enum.Parse<Product.MusicCD.MusicCDType>(a.ucmusicCD.GetData()[1]));
                        dataBase.AddMusicCD(musicCD);
                        break;
                    }
                case FormAdminControl.ProductType.Magazine:
                    {
                        Product.Magazine magazine = new Product.Magazine(txtBoxName.Text, "", txtBoxPrice.Text, a.ucmagazine.GetData()[0], Enum.Parse<Product.MagazineType>(a.ucmagazine.GetData()[1]));
                        dataBase.AddMagazine(magazine);
                        break;
                    }
                default:
                    break;
            }
        }
        /*!
             * \brief method updates the database according to the selected type.
             * @return nothing.
             */
        public void Update()
        {
            Product.Database dataBase = new Product.Database();
            FormAdminControl a = FormAdminControl.instance;
            switch (FormAdminControl._ProductType)
            {
                case FormAdminControl.ProductType.Book:
                    {
                        Product.Book book = new Product.Book(txtBoxName.Text, "", txtBoxPrice.Text, a.ucbook.GetData()[3], a.ucbook.GetData()[1], a.ucbook.GetData()[2], a.ucbook.GetData()[0]);
                        dataBase.UpdateBook(book);
                        break;
                    }
                case FormAdminControl.ProductType.MusicCD:
                    {
                        Product.MusicCD musicCD = new Product.MusicCD(txtBoxName.Text, "", txtBoxPrice.Text, a.ucmusicCD.GetData()[0], Enum.Parse<Product.MusicCD.MusicCDType>(a.ucmusicCD.GetData()[1]));
                        dataBase.UpdateMusicCD(musicCD);
                        break;
                    }
                case FormAdminControl.ProductType.Magazine:
                    {
                        Product.Magazine magazine = new Product.Magazine(txtBoxName.Text, "", txtBoxPrice.Text, a.ucmagazine.GetData()[0], Enum.Parse<Product.MagazineType>(a.ucmagazine.GetData()[1]));
                        dataBase.UpdateMagazine(magazine);
                        break;
                    }
                default:
                    break;
            }
        }
        /*!
       * \brief method deletes from the database according to the selected type
       * @return nothing.
       */
        public void Delete()
        {
            Product.Database dataBase = new Product.Database();
            FormAdminControl a = FormAdminControl.instance;
            switch (FormAdminControl._ProductType)
            {
                case FormAdminControl.ProductType.Book:
                    {
                        Product.Book book = new Product.Book(txtBoxName.Text, "", txtBoxPrice.Text, a.ucbook.GetData()[3], a.ucbook.GetData()[1], a.ucbook.GetData()[2], a.ucbook.GetData()[0]);
                        dataBase.DeleteBook(book);
                        break;
                    }
                case FormAdminControl.ProductType.MusicCD:
                    {
                        Product.MusicCD musicCD = new Product.MusicCD(txtBoxName.Text, "", txtBoxPrice.Text, a.ucmusicCD.GetData()[0], Enum.Parse<Product.MusicCD.MusicCDType>(a.ucmusicCD.GetData()[1]));
                        dataBase.DeleteMusicCD(musicCD);
                        break;
                    }
                case FormAdminControl.ProductType.Magazine:
                    {
                        Product.Magazine magazine = new Product.Magazine(txtBoxName.Text, "", txtBoxPrice.Text, a.ucmagazine.GetData()[0], Enum.Parse<Product.MagazineType>(a.ucmagazine.GetData()[1]));
                        dataBase.DeleteMagazine(magazine);
                        break;
                    }
                default:
                    break;
            }
        }
        /*!
      * \brief method contains the task to be done when the select button is pressed.
      * @param sender is object variable and e is EventArgs variable.
      * @return nothing.
      */
        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtBoxName.Enabled = false;
            Product.Database dataBase = new Product.Database();
            FormAdminControl a = FormAdminControl.instance;
            bool contains = false;

            switch (FormAdminControl._ProductType)
            {
                case FormAdminControl.ProductType.Book:
                    {
                        Product.Book book = new Product.Book();
                        dataBase.BookList();
                        foreach (Product.Book _book in dataBase.GetBookList)
                        {
                            if (_book.Name == txtBoxName.Text)
                            {
                                contains = true;
                                book = _book;
                            }
                            
                        }
                        if (contains)
                        {
                            txtBoxPrice.Text = book.Price;
                            a.ucbook.setPage(book.Page);
                            a.ucbook.setAuthor(book.Author);
                            a.ucbook.setISBN(book.ISBN);
                            a.ucbook.setPublisher(book.Publisher);
                        }
                        break;
                    }
                case FormAdminControl.ProductType.MusicCD:
                    {
                        Product.MusicCD musicCD = new Product.MusicCD();
                        dataBase.MusicCDList();
                        foreach (Product.MusicCD _musicCD in dataBase.GetMusicCDList)
                        {
                            if (_musicCD.Name == txtBoxName.Text)
                            {
                                contains = true;
                                musicCD = _musicCD;
                            }        
                        }
                        if (contains)
                        {
                            txtBoxPrice.Text = musicCD.Price;
                            a.ucmusicCD.setSinger(musicCD.Singer);
                            a.ucmusicCD.setMusicCDType(musicCD.Type);
                        }
                        break;
                    }
                case FormAdminControl.ProductType.Magazine:
                    {
                        Product.Magazine magazine = new Product.Magazine();
                        dataBase.MagazineList();
                        foreach (Product.Magazine _magazine in dataBase.GetMagazineList)
                        {
                            if (_magazine.Name == txtBoxName.Text)
                            {
                                contains = true;
                                magazine = _magazine;
                            }
                            
                        }
                        if (contains)
                        {
                            txtBoxPrice.Text = magazine.Price;
                            a.ucmagazine.setIssue(magazine.Issue);
                            a.ucmagazine.setMagazineType(magazine.Type);
                        }
                        break;
                    }
                default:
                    break;
            }
            if (contains)
            {
                MessageBox.Show("It Has Done Successfully!");
            }
            else
            {
                MessageBox.Show("Some Errors Occured");
            }
        }
    }
}// End namespace Online_Book_Store.Admin

/*! @} End of Doxygen Groups*/
