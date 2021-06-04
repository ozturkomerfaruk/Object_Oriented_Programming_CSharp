using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Online_Book_Store;
using System.Data.SqlClient;
/*!
 *  \addtogroup Online_Book_Store.Product
 *  @{
 */
//! Online_Book_Store.Product methods and implementations.
namespace Online_Book_Store.Product
{
    /*!
     * \class Database.
     * \brief Contains the general methods of the database.
     */
    public class Database
    {
        private DatabaseConnection connection = new DatabaseConnection();

        private DataTable customerTable = new DataTable();
        private DataTable bookTable = new DataTable();
        private DataTable magazineTable = new DataTable();
        private DataTable musicTable = new DataTable();
        private DataTable cartItemTable = new DataTable();

        private Customer customer;
        private List<Customer> customers = new List<Customer>();
        public List<Customer> GetCustomersList { get => customers; }

        private Book book;
        private List<Book> books = new List<Book>();
        public List<Book> GetBookList { get => books; }

        private Magazine magazine;
        private List<Magazine> magazines = new List<Magazine>();
        public List<Magazine> GetMagazineList { get => magazines; }

        private MusicCD musicCD;
        private List<MusicCD> musicsCD = new List<MusicCD>();
        public List<MusicCD> GetMusicCDList { get => musicsCD; }

        private Products.CartItem cartItem;
        private List<Products.CartItem> cartItems = new List<Products.CartItem>();
        public List<Products.CartItem> GetCartItemList { get => cartItems; }

        private byte[] img = new byte[1];
        /*!
        * \brief method adds the customer to the database with the entered information.
        * @param customer is Customer variable.
        * @return nothing.
        */
        public void AddCustomer(Customer customer)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into CustomerTbl(CustomerName,CustomerAddress,CustomerEmail,CustomerUsername,CustomerPassword)values (@Name,@Address,@Email,@Username,@Password)", connection.Connect);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@Address", customer.Address);
                command.Parameters.AddWithValue("@Email", customer.Email);
                command.Parameters.AddWithValue("@Username", customer.Username);
                command.Parameters.AddWithValue("@Password", customer.Password);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Registration has been successfully completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
         * \brief method updates the customer to the database with the entered information.
         * @param customer is Customer variable.
         * @return nothing.
         */
        public void UpdateCustomer(Customer customer)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Update CustomerTbl set CustomerName=@Name,CustomerAddress=@Address,CustomerEmail=@Email,CustomerUsername=@Username,CustomerPassword=@Password where CustomerUsername=@Username", connection.Connect);
                command.Parameters.AddWithValue("@Name", customer.Name);
                command.Parameters.AddWithValue("@Address", customer.Address);
                command.Parameters.AddWithValue("@Email", customer.Email);
                command.Parameters.AddWithValue("@Username", customer.Username);
                command.Parameters.AddWithValue("@Password", customer.Password);
                command.Parameters.AddWithValue("@CustomerId", customer.CustomerID);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The registration has been successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
         * \brief method deletes the customer to the database with the entered information.
         * @param customer is Customer variable.
         * @return nothing.
         */
        public void DeleteCustomer(Customer customer)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from CustomerTbl where CustomerUsername=@Username", connection.Connect);
                command.Parameters.AddWithValue("@Username", customer.Username);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The customer has been deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
        * \brief method lists the customers with their information.
        * @return nothing.
        */
        public void CustomerList()
        {
            try
            {
                customerTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter dataBase = new SqlDataAdapter("Select * From CustomerTbl", connection.Connect);
                dataBase.Fill(customerTable);
                connection.Close();
                for (int i = 0; i < customerTable.Rows.Count; i++)
                {
                    customer = new Customer(
                        customerTable.Rows[i]["CustomerID"].ToString(),
                        customerTable.Rows[i]["CustomerName"].ToString(),
                        customerTable.Rows[i]["CustomerAddress"].ToString(),
                        customerTable.Rows[i]["CustomerEmail"].ToString(),
                        customerTable.Rows[i]["CustomerUsername"].ToString(),
                        customerTable.Rows[i]["CustomerPassword"].ToString());
                    customers.Add(customer);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*!
         * \brief method adds cart item to the database with the entered information.
         * @param cartItem is Products.CartItem variable.
         * @return nothing.
         */
        public void AddCartItem(Products.CartItem cartItem)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into ShoppingCartTbl(CartName,CartPrice,CartQuantity,CartTextBox0,CartTextBox1,CartTextBox2,CartTextBox3,CartCustomerName) values " +
                    "(@ProductName,@ProductPrice,@Quantity,@Derived0,@Derived1,@Derived2,@Derived3,@CustomerName)", connection.Connect);
                command.Parameters.AddWithValue("@ProductName", cartItem.Item.Product.Name);
                command.Parameters.AddWithValue("@ProductPrice", cartItem.Item.Product.Price);
                command.Parameters.AddWithValue("@Quantity", cartItem.Item.Quantity);
                command.Parameters.AddWithValue("@Derived0", cartItem.Item.Derived[0]);
                command.Parameters.AddWithValue("@Derived1", cartItem.Item.Derived[1]);
                command.Parameters.AddWithValue("@Derived2", cartItem.Item.Derived[2]);
                command.Parameters.AddWithValue("@Derived3", cartItem.Item.Derived[3]);
                command.Parameters.AddWithValue("@CustomerName", cartItem.Item.CustomerName);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("CartItem has been successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
          * \brief method updates cart item in the database with the entered information.
          * @param cartItem is Products.CartItem variable.
          * @return nothing.
          */
        public void UpdateCartItem(Products.CartItem cartItem)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Update ShoppingCartTbl set CartName=@ProductName,CartPrice=@ProductPrice,CartQuantity=@Quantity,CartTextBox0=@Derived0,CartTextBox1=@Derived1," +
                    "CartTextBox2=@Derived2,CartTextBox3=@Derived3,CartCustomerName=@CustomerName where CartName=@ProductName and CartCustomerName=@CustomerName", connection.Connect);
                command.Parameters.AddWithValue("@ProductName", cartItem.Item.Product.Name);
                command.Parameters.AddWithValue("@ProductPrice", cartItem.Item.Product.Price);
                command.Parameters.AddWithValue("@Quantity", cartItem.Item.Quantity);
                command.Parameters.AddWithValue("@Derived0", cartItem.Item.Derived[0]);
                command.Parameters.AddWithValue("@Derived1", cartItem.Item.Derived[1]);
                command.Parameters.AddWithValue("@Derived2", cartItem.Item.Derived[2]);
                command.Parameters.AddWithValue("@Derived3", cartItem.Item.Derived[3]);
                command.Parameters.AddWithValue("@CustomerName", cartItem.Item.CustomerName);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("CartItem has been successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
         * \brief method deletes cart item from the database with the entered information.
         * @param cartItem is Products.CartItem variable.
         * @return nothing.
         */
        public void DeleteCartItem(Products.CartItem cartItem)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from ShoppingCartTbl where CartName=@ProductName and CartCustomerName=@CustomerName", connection.Connect);
                command.Parameters.AddWithValue("@ProductName", cartItem.Item.Product.Name);
                command.Parameters.AddWithValue("@CustomerName", cartItem.Item.CustomerName);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("CartItem has been deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
         * \brief method lists cart items with the entered information.
         * @return nothing.
         */
        public void CartItemList()
        {
            try
            {
                cartItemTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter dataBase = new SqlDataAdapter("Select * From ShoppingCartTbl", connection.Connect);
                dataBase.Fill(cartItemTable);
                connection.Close();
                for (int i = 0; i < cartItemTable.Rows.Count; i++)
                {
                    Product p = new Book();
                    p.ID = cartItemTable.Rows[i]["CartID"].ToString();
                    p.Name = cartItemTable.Rows[i]["CartName"].ToString();
                    p.Price = cartItemTable.Rows[i]["CartPrice"].ToString();
                    string[] derived = new string[4];
                    if (cartItemTable.Rows[i]["CartTextBox2"].ToString() == "" &&
                        cartItemTable.Rows[i]["CartTextBox3"].ToString() == "")
                    {
                        derived[0] = cartItemTable.Rows[i]["CartTextBox0"].ToString();
                        derived[1] = cartItemTable.Rows[i]["CartTextBox1"].ToString();
                        derived[2] = "";
                        derived[3] = "";
                    }
                    else
                    {
                        derived[0] = cartItemTable.Rows[i]["CartTextBox0"].ToString();
                        derived[1] = cartItemTable.Rows[i]["CartTextBox1"].ToString();
                        derived[2] = cartItemTable.Rows[i]["CartTextBox2"].ToString();
                        derived[3] = cartItemTable.Rows[i]["CartTextBox3"].ToString();
                    }

                    cartItem = new Products.CartItem(new ItemToPurchase(p, cartItemTable.Rows[i]["CartCustomerName"].ToString(),
                        derived, cartItemTable.Rows[i]["CartQuantity"].ToString()));
                    cartItems.Add(cartItem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        /*!
     * \brief method adds book to the database with the entered information.
     * @param book is Book variable.
     * @return nothing.
     */
        public void AddBook(Book book)
        {
            try
            {
                connection.Connection();
                connection.Open();
                byte[] img = new byte[1];
                SqlCommand command = new SqlCommand("Insert into BookTbl(BookName,BookPrice,BookISBN,BookAuthor,BookPublisher,BookPage,BookImage) values(@Name,@Price,@Isbn,@Author,@Publisher,@Page,@Image)", connection.Connect);
                command.Parameters.AddWithValue("@Name", book.Name);
                command.Parameters.AddWithValue("@Price", book.Price);
                command.Parameters.AddWithValue("@Isbn", book.ISBN);
                command.Parameters.AddWithValue("@Author", book.Author);
                command.Parameters.AddWithValue("@Publisher", book.Publisher);
                command.Parameters.AddWithValue("@Page", book.Page);
                command.Parameters.AddWithValue("@Image", img); //book.Image
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The book has been successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
         * \brief method updates book in the database with the entered information.
         * @param book is Book variable.
         * @return nothing.
         */
        public void UpdateBook(Book book)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Update BookTbl set BookName=@Name,BookPrice=@Price,BookISBN=@_ISBN,BookAuthor=@Author,BookPublisher=@Publisher,BookPage=@Page,BookImage=@Image where BookName=@Name", connection.Connect);
                command.Parameters.AddWithValue("@Name", book.Name);
                command.Parameters.AddWithValue("@Price", book.Price);
                command.Parameters.AddWithValue("@_ISBN", book.ISBN);
                command.Parameters.AddWithValue("@Author", book.Author);
                command.Parameters.AddWithValue("@Publisher", book.Publisher);
                command.Parameters.AddWithValue("@Page", book.Page);
                command.Parameters.AddWithValue("@Image", img);
                command.Parameters.AddWithValue("@ProductBookID", book.ID);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The book has been successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
         * \brief method deletes book from the database with the entered information.
         * @param book is Book variable.
         * @return nothing.
         */
        public void DeleteBook(Book book)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from BookTbl where BookName=@Name", connection.Connect);
                command.Parameters.AddWithValue("@Name", book.Name);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("The book has been deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
        * \brief method lists books with their information.
        * @return nothing.
        */
        public void BookList()
        {
            try
            {
                bookTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter dataBase = new SqlDataAdapter("Select * from BookTbl", connection.Connect);
                dataBase.Fill(bookTable);
                connection.Close();
                for (int i = 0; i < bookTable.Rows.Count; i++)
                {
                    book = new Book(
                        //(byte[])bookTable.Rows[i]["BookImage"],
                        bookTable.Rows[i]["BookName"].ToString(),
                        bookTable.Rows[i]["BookID"].ToString(),
                        bookTable.Rows[i]["BookPrice"].ToString(),
                        bookTable.Rows[i]["BookISBN"].ToString(),
                        bookTable.Rows[i]["BookAuthor"].ToString(),
                        bookTable.Rows[i]["BookPublisher"].ToString(),
                        bookTable.Rows[i]["BookPage"].ToString());

                    books.Add(book);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*!
      * \brief method adds magazine to the database with the entered information.
      * @param magazine is Magazine variable.
      * @return nothing.
      */

        public void AddMagazine(Magazine magazine)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into MagazineTbl(MagazineID,MagazineName,MagazinePrice,MagazineIssue,MagazineType,MagazineImage) values(@ID,@Name,@Price,@Issue,@Type,@Image)", connection.Connect);
                command.Parameters.AddWithValue("@ID", magazine.ID);
                command.Parameters.AddWithValue("@Name", magazine.Name);
                command.Parameters.AddWithValue("@Price", magazine.Price);
                command.Parameters.AddWithValue("@Issue", magazine.Issue);
                command.Parameters.AddWithValue("@Type", magazine.Type);
                command.Parameters.AddWithValue("@Image", img);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Magazine has been successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
        * \brief method updates magazine in the database with the entered information.
        * @param magazine is Magazine variable.
        * @return nothing.
        */
        public void UpdateMagazine(Magazine magazine)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Update MagazineTbl set MagazineName=@Name,MagazinePrice=@Price,MagazineIssue=@Issue,MagazineType=@Type,MagazineImage=@Image where MagazineName=@Name", connection.Connect);
                command.Parameters.AddWithValue("@Name", magazine.Name);
                command.Parameters.AddWithValue("@Price", magazine.Price);
                command.Parameters.AddWithValue("@Issue", magazine.Issue);
                command.Parameters.AddWithValue("@Type", magazine.Type);
                command.Parameters.AddWithValue("@Image", img);
                command.Parameters.AddWithValue("@ProductMagazineID", magazine.ID);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Magazine successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
       * \brief method deletes magazine from the database with the entered information.
       * @param magazine is Magazine variable.
       * @return nothing.
       */
        public void DeleteMagazine(Magazine magazine)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from MagazineTbl where MagazineName=@Name", connection.Connect);
                command.Parameters.AddWithValue("@Name", magazine.Name);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Magazine successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
           * \brief method lists magazines with their information.
           * @return nothing.
           */
        public void MagazineList()
        {
            try
            {
                magazineTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter dataBase = new SqlDataAdapter("Select * from MagazineTbl", connection.Connect);
                dataBase.Fill(magazineTable);
                connection.Close();
                for (int i = 0; i < magazineTable.Rows.Count; i++)
                {
                    magazine = new Magazine(
                        //(byte[])magazineTable.Rows[i]["MagazineImage"],
                        magazineTable.Rows[i]["MagazineName"].ToString(),
                        magazineTable.Rows[i]["MagazineID"].ToString(),
                        magazineTable.Rows[i]["MagazinePrice"].ToString(),
                        magazineTable.Rows[i]["MagazineIssue"].ToString(),
                        Enum.Parse<MagazineType>(magazineTable.Rows[i]["MagazineType"].ToString()));
                    magazines.Add(magazine);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /*!
       * \brief method adds musicCD to the database with the entered information.
       * @param musicCD is MusicCD variable.
       * @return nothing.
       */
        public void AddMusicCD(MusicCD musicCD)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Insert into MusicCDTbl(MusicCDID,MusicCDName,MusicCDPrice,MusicCDSinger,MusicCDType,MusicCDImage) values(@ID,@Name,@Price,@Singer,@Type,@Image)", connection.Connect);
                command.Parameters.AddWithValue("@ID", musicCD.ID);
                command.Parameters.AddWithValue("@Name", musicCD.Name);
                command.Parameters.AddWithValue("@Price", musicCD.Price);
                command.Parameters.AddWithValue("@Singer", musicCD.Singer);
                command.Parameters.AddWithValue("@Type", musicCD.Type);
                command.Parameters.AddWithValue("@Image", img);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Music CD has been successfully added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
         * \brief method updates musicCD in the database with the entered information.
         * @param musicCD is MusicCD variable.
         * @return nothing.
         */
        public void UpdateMusicCD(MusicCD music)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Update MusicCDTbl set MusicCDName=@Name,MusicCDPrice=@Price,MusicCDSinger=@Singer,MusicCDType=@Type,MusicCDImage=@Image where MusicCDName=@Name", connection.Connect);
                command.Parameters.AddWithValue("@Name", music.Name);
                command.Parameters.AddWithValue("@Price", music.Price);
                command.Parameters.AddWithValue("@Singer", music.Singer);
                command.Parameters.AddWithValue("@Type", music.Type);
                command.Parameters.AddWithValue("@Image", img);
                command.Parameters.AddWithValue("@ProductMusicCDID", music.ID);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Music CD successfully updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
        * \brief method deletes musicCD from the database with the entered information.
        * @param musicCD is MusicCD variable.
        * @return nothing.
        */
        public void DeleteMusicCD(MusicCD music)
        {
            try
            {
                connection.Connection();
                connection.Open();
                SqlCommand command = new SqlCommand("Delete from MusicCDTbl where MusicCDName=@Name", connection.Connect);
                command.Parameters.AddWithValue("@Name", music.Name);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Music CD successfully deleted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*!
       * \brief method lists musicCD with their information.
       * @return nothing.
       */
        public void MusicCDList()
        {
            try
            {
                musicTable.Clear();
                connection.Connection();
                connection.Open();
                SqlDataAdapter dataBase = new SqlDataAdapter("Select * from MusicCDTbl", connection.Connect);
                dataBase.Fill(musicTable);
                connection.Close();
                for (int i = 0; i < musicTable.Rows.Count; i++)
                {
                    musicCD = new MusicCD(
                         //(byte[])musicTable.Rows[i]["MusicCDImage"],
                         musicTable.Rows[i]["MusicCDName"].ToString(),
                         musicTable.Rows[i]["MusicCDID"].ToString(),
                         musicTable.Rows[i]["MusicCDPrice"].ToString(),
                         musicTable.Rows[i]["MusicCDSinger"].ToString(),
                         Enum.Parse<MusicCD.MusicCDType>(musicTable.Rows[i]["MusicCDType"].ToString()));

                    musicsCD.Add(musicCD);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }// End namespace Online_Book_Store.Product

    /*! @} End of Doxygen Groups*/
}
