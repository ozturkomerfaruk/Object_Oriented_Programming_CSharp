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
     * \class MusicCD.
     * \brief Contains the general properties and methods of the MusicCD.
     */
    public class MusicCD : Product
    { /*! This is enum MusicCDType includes "None, Rock, Rap, House, Jazz" keywords.*/
        public enum MusicCDType
        {
            None, Rock, Rap, House, Jazz
        }

        public string Singer { get; set; }

        public MusicCDType Type { get; set; }
        /*!
         * \brief constructor method.
         * @param _name is string variable.
         * @param _id is string variable.
         * @param _price is string variable.
         * @param _singer is string variable.
         * @param _type is MusicCDType variable.
         */
        public MusicCD(/*byte[] _image, */string _name = "", string _id = "", string _price = "", string _singer = "", MusicCDType _type = MusicCDType.None)
        {
            this.Name = _name;
            this.ID = _id;
            this.Price = _price;
            this.Singer = _singer;
            this.Type = _type;
            //this.Image = _image;
        }
        /*!
       * \brief method prints the musicCD properties.
       * @return nothing.
       */
        public override void PrintProperties()
        {
            Console.WriteLine(base.ID + base.Name + base.Price
                   + Singer + Type.ToString());
        }
        /*!
        * \brief method stores and forwards the musicCD properties.
        * @return r.
        */
        public override string[] GetDerivedData()
        {
            string[] r = new string[4];
            r[0] = Singer;
            r[1] = Type.ToString();
            r[2] = "";
            r[3] = "";
            return r;
        }// End namespace Online_Book_Store.Product

        /*! @} End of Doxygen Groups*/
    }
}
