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
     * \class Book.
     * \brief Contains the general properties and methods of the book.
     */
    public class Book : Product
    {
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Page { get; set; }
        public string Publisher { get; set; }
        /*!
         * \brief constructor method.
         * @param _name is string variable.
         * @param _id is string variable.
         * @param _price is string variable.
         * @param _ISBN is string variable.
         * @param _author string variable.
         * @param _publisher string variable.
         * @param _page is string variable.
         */
        public Book(/*byte[] _image, */string _name = "", string _id = "", string _price = "", string _ISBN = "",
            string _author = "", string _publisher = "", string _page = "")
        {
            this.Name = _name;
            this.ID = _id;
            this.Price = _price;
            this.ISBN = _ISBN;
            this.Author = _author;
            this.Publisher = _publisher;
            this.Page = _page;
            //this.Image = _image;
        }
        /*!
         * \brief method prints the book properties.
         * @return nothing.
         */
        public override void PrintProperties()
        {
            Console.WriteLine(base.ID + base.Name + base.Price
                  + ISBN + Author + Publisher + Page);
        }
        /*!
        * \brief method stores and forwards the book properties.
        * @return r.
        */
        public override string[] GetDerivedData()
        {
            string[] r = new string[4];
            r[0] = ISBN;
            r[1] = Author;
            r[2] = Page;
            r[3] = Publisher;
            return r;
        }
    }
}// End namespace Online_Book_Store.Product

/*! @} End of Doxygen Groups*/
