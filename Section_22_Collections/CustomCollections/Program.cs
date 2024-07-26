using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomCollections
{
    public enum TypeOfCustomer
    {
        RegularCustomer,
        VIPCustomer
    }

    public class Customer
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public TypeOfCustomer CustomerType { get; set; }
    }

    //custom collection class
    public class CustomersList : IEnumerable
    {
        private List<Customer> _customers = new List<Customer>()
        {
            new Customer()
            {
                CustomerID = "A101",
                CustomerName = "James",
                Email = "khalid@gmail.com",
                CustomerType = TypeOfCustomer.RegularCustomer
            },
              new Customer()
            {
                CustomerID = "A201",
                CustomerName = "Bob",
                Email = "bob@gmail.com",
                CustomerType = TypeOfCustomer.VIPCustomer
            },
                new Customer()
            {
                CustomerID = "A301",
                CustomerName = "Alice",
                Email = "alice@gmail.com",
                CustomerType = TypeOfCustomer.VIPCustomer
            }
        };


        public List<Customer> GetCustomers()
        {
            return this._customers;
        }


        public IEnumerator GetEnumerator()
        {
            //yield return _customers[0]; // yeild is treated as IEnnumerator object.
            //yield return _customers[1];
            //yield return _customers[2];

            for (int i = 0; i < this._customers.Count; i++)
            {
                yield return _customers[i];
            }
        }

        //If you want to check for example your customer id should begin with capital a or any other condition it cannot be
        //checked by the predefined add method and that is what you can add validation logic here and that is what the purpose or reason why we create custom collections


        //of course some of those validations even can be kept in the set accessors of the respective properties
        //while creating the customer class itself okay it is up to you some type of validations can be kept in
        //this set accessor and whichever the validations that cannot be kept in that set accessor
        //all those can be added in this add method here.
        public void Add(Customer customer)
        {
            if(customer.CustomerID.StartsWith("A") || customer.CustomerID.StartsWith("a"))
            {
                this._customers.Add(customer);
            }
            else
            {
                Console.WriteLine("Invalid Customer ID");
            }
        }
    }

   

    internal class Program
    {
        static void Main()
        {
            CustomersList customersList = new CustomersList(); //3 Customers

            //aproach 1
            //List<Customer> c = customersList.GetCustomers();
            //c.Add(); 

            //this is not a good way as we can use Add, Remove, Delete method to manipulate private _customers field 


            //approach 2
            //IEnumerator enumerator = customersList.GetEnumerator();

            //enumerator.MoveNext();
            //Console.WriteLine(enumerator.Current);
            //enumerator.MoveNext();
            //Console.WriteLine(enumerator.Current);
            //enumerator.MoveNext();
            //Console.WriteLine(enumerator.Current);

            //or

            Customer new_cust = new Customer()
            {
                CustomerID = "A456",
                CustomerName = "Jacob",
                Email = "jacon@example.com",
                CustomerType = TypeOfCustomer.VIPCustomer
            };


            //approach 3 
            foreach (Customer customer in customersList) //behind the scene, it will call the GetEnumerator() method of CustomerList class as it implements IEnumerable interface.
            {
                Console.WriteLine(customer.CustomerID + "," + customer.CustomerName
                    + "," + customer.Email + "," + customer.CustomerType);
            }

            


            Console.ReadKey();  

        }
    }
}
