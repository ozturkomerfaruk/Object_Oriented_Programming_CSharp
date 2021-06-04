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
{
    public abstract class Product
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Price { get; set; }

        public abstract void PrintProperties();
        public abstract string[] GetDerivedData();

        public byte[] Image { get; set; }
    }
}// End namespace Online_Book_Store.Product

/*! @} End of Doxygen Groups*/
