using CityBank.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityBank.DataAccesLayer.DALContracts
{
    /// <summary>
    /// Interface that represents customers data access layer
    /// </summary>
    public interface ICustomerDataAccessLayer
    {
        /// <summary>
        /// Returns all existing customers.
        /// </summary>
        /// <returns></returns>
        List<Customer> GetCustomers();

        /// <summary>
        /// Returns a set of customers that matches with specified criteria.
        /// </summary>
        /// <param name="predicate">Lamda expression that contains condition to check</param>
        /// <returns>The list of matching customers</returns>
        List<Customer> GetCustomersByCondition(Predicate<Customer> predicate);

        /// <summary>
        /// Adds a new customer to the existing customers list.
        /// </summary>
        /// <param name="customer">The customer object to add</param>
        /// <returns>Returns true, that indicates the customer is added successfully</returns>
        Guid AddCustomer(Customer customer);

        /// <summary>
        /// Updates an existing customer
        /// </summary>
        /// <param name="customer">Customer object that contains customer details to update.</param>
        /// <returns></returns>
        bool UpdateCustomer(Customer customer); 

        /// <summary>
        /// Delete an existing customer.
        /// </summary>
        /// <param name="customerId">CustomerID to delete.</param>
        /// <returns>Returns true, that indicates the customer is deleted successfully.</returns>
        bool DeleteCustomer(Guid customerId);
    }
}
