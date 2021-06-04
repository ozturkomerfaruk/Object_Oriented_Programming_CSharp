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
{ /*! This is enum MagazineType includes "None, Actual, News, Sport, Computer, Technology" keywords.*/
    public enum MagazineType
    {
        None, Actual, News, Sport, Computer, Technology
    }
    /*!
 * \class Magazine.
 * \brief Contains the general properties and methods of the Magazine.
 */
    public class Magazine : Product
    {
        public string Issue { get; set; }

        public MagazineType Type { get; set; }
        /*!
        * \brief constructor method.
        * @param _name is string variable.
        * @param _id is string variable.
        * @param _price is string variable.
        * @param _issue is string variable.
        * @param _type is MagazineType variable.
        */
        public Magazine(/*byte[] _image, */string _name = "", string _id = "", string _price = "", string _issue = "", MagazineType _type = MagazineType.None)
        {
            this.Name = _name;
            this.ID = _id;
            this.Price = _price;
            this.Issue = _issue;
            this.Type = _type;
            //this.Image = _image;
        }
        /*!
       * \brief method prints the magazine properties.
       * @return nothing.
       */
        public override void PrintProperties()
        {
            Console.WriteLine(
                base.ID +
                base.Name +
                base.Price +
                Issue +
                Type.ToString());
        }
        /*!
        * \brief method stores and forwards the magazine properties.
        * @return r.
        */
        public override string[] GetDerivedData()
        {
            string[] r = new string[4];
            r[0] = Issue;
            r[1] = Type.ToString();
            r[2] = "";
            r[3] = "";
            return r;
        }
    }
}// End namespace Online_Book_Store.Product

/*! @} End of Doxygen Groups*/
