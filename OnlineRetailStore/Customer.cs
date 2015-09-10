using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRetailStore
{
    /// <summary>
    /// This class defines the customer
    /// Reads the Customer Detais from Customer
    /// 
    /// </summary>
    class Customer
    {
        #region variables declared
        private static int prevCustID = 0;
        #endregion
        #region Properties
        /// <summary>
        /// Get customer name
        /// </summary>
        public string CustName { get; set; }
        /// <summary>
        /// Get customer id
        /// </summary>
        public int CustID { get; private set; }
        /// <summary>
        /// Get customer Email id
        /// </summary>
        public string CustEmail { get; set; }
        /// <summary>
        /// Get customer Phone Number
        /// </summary>
        public string CustPhone { get; set; }
        /// <summary>
        /// Get customer Address
        /// </summary>
        public string CustAddress { get; set; }
        /// <summary>
        /// Get customer Credit Card number
        /// </summary>
        public string CustCreditCard { get; set; }
        /// <summary>
        /// Get customer name
        /// </summary>
        #endregion


        /// <summary>
        /// default constructor
        /// </summary>
        public Customer()
        {
            CustID = ++prevCustID;
        }

        public Customer(string name)
        {
            CustID = ++prevCustID;
            CustName = name;
        }


    }
}
