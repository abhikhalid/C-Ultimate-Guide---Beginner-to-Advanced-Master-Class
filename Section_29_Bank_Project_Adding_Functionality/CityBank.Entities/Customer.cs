using System;

namespace CityBank.Entities
{
    /// <summary>
    /// Represents customer of the bank.
    /// </summary>
    public class Customer : ICustomer
    {
        #region Public Properties

        /// <summary>
        /// Guid of Customer Unique identification
        /// </summary>
        public Guid CustomerID { get ; set ; }

        /// <summary>
        /// Auto-generated code number of the customer
        /// </summary>
        public long CustomerCode { get ; set ; }

        /// <summary>
        /// Name of the customer
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// Address of the customer
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Landmark of the customer's address
        /// </summary>
        public string LandMark { get; set; }

        /// <summary>
        /// City of the customer
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Country of the customer
        /// </summary>
        public string Country { get; set;}

        /// <summary>
        /// 10-digit Mobile number of the customer
        /// </summary>
        public string Mobile { get; set; }
        #endregion


    }
}
