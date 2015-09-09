using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRetailStore
{
    /// <summary>
    /// This is not accessible to customer(read only) accessible to owner only
    /// </summary>
    class Products
    {
        #region variables declared
        private static int prevProdkey = 0;
        #endregion

        #region Properties

        /// <summary>
        /// Product name
        /// </summary>
        public string ProdName { get; private set; }
        /// <summary>
        /// Product key
        /// </summary>
        public int ProdKey { get; private set; }
        /// <summary>
        /// Get the product Discription 
        /// </summary>
        public string Prodcolor { get; private set; }
        public string ProdSize { get; private set; }
        public string prodquantity { get; private set; }
        /// <summary>
        /// get product prize
        /// </summary>
        public double prodPrize { get; private set; }
        #endregion

        public Products()
        {
            ProdKey = ++prevProdkey;
        }

        public Products(string name)
        {
            ProdKey = ++prevProdkey;
            ProdName = name;
        }

    }
}
