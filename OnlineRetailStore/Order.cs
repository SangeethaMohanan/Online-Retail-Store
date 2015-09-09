using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRetailStore
{
    /// <summary>
    /// Customer can order 
    /// their product and get confirmation
    /// or cancel a order and get canced confirmation
    /// </summary>
    class Order
    {
        #region Variables
        public string orderProduct;
        public int orderPrice;
        #endregion

        Customer abc = new Customer(" Cust id ");
        /*I dont want to create a new customer id but 
         wants to retrive the one I have created in customer class

        also want to give a option for cutomer to choose from product and when they choose 
        we have to display the cost and option to choose size and qty */

        #region properties

        #endregion

        /// <summary>
        /// Customer can get confirmation of their order
        /// will display the order details
        /// </summary>
        /// <param name="confirmation"></param>
        #region Constructor
        /// <summary>
        /// default constructor
        /// </summary>
        public Order()
        {

        }

        public Order(string orderprice)
        {
           // orderPrice =
        }

        #endregion

        #region Methods
        public void orderPurchase(string confirmation)
        {

        }
        /// <summary>
        /// Customer can get order cancelled confirmation
        /// and will display the prize returned withina week notification
        /// </summary>
        /// <param name="confirmation"></param>
        public void OrderCancel(string confirmation)
        {
        }
        #endregion
    }
}
