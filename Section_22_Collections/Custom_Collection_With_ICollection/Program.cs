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
    public class CustomersList : ICollection<Customer>
    {
        private List<Customer> _customers = new List<Customer>();

        public int Count => this._customers.Count;

        public bool IsReadOnly => false; //we can modify the collection _customers

        public List<Customer> GetCustomers()
        {
            return this._customers;
        }

        //If you want to check for example your customer id should begin with capital a or any other condition it cannot be
        //checked by the predefined add method and that is what you can add validation logic here and that is what the purpose or reason why we create custom collections


        //of course some of those validations even can be kept in the set accessors of the respective properties
        //while creating the customer class itself okay it is up to you some type of validations can be kept in
        //this set accessor and whichever the validations that cannot be kept in that set accessor
        //all those can be added in this add method here.
        public void Add(Customer customer)
        {
            if (customer.CustomerID.StartsWith("A") || customer.CustomerID.StartsWith("a"))
            {
                this._customers.Add(customer);
            }
            else
            {
                Console.WriteLine("Invalid Customer ID");
            }
        }


        //private method as per the rule of explicit interface implementation
        IEnumerator IEnumerable.GetEnumerator()
        {
            //yield return _customers[0]; // yeild is treated as IEnnumerator object.
            //yield return _customers[1];
            //yield return _customers[2];

            for (int i = 0; i < this._customers.Count; i++)
            {
                yield return _customers[i];
            }
        }


        public IEnumerator<Customer> GetEnumerator()
        {
            for (int i = 0; i < this._customers.Count; i++)
            {
                yield return _customers[i]; //return and pause
            }
        }

        public void Clear()
        {
            this._customers.Clear();
        }

        public bool Contains(Customer item)
        {
            return this._customers.Contains(item);
        }

        public void CopyTo(Customer[] array, int arrayIndex)
        {
            this._customers.CopyTo(array, arrayIndex);
        }

        public bool Remove(Customer item)
        {
            return (this._customers.Remove(item));
        }

        //Additional Methods

        // Predicate is a predefined deligate that represents a method that returns a boolean value.
        // In order to store the method reference, we can use Predicate Deligate.

        public Customer Find(Predicate<Customer> match)
        {
            return this._customers.Find(match);
        }

        public List<Customer> FindAll(Predicate<Customer> match)
        {
            return this._customers.FindAll(match);
        }
    }



    internal class Program
    {
        static void Main()
        {
            //this is called as Collection Initializer. whenever a custom collection class has Add method
            // and you supply a set of customer objects like this; for each method supplied here, the add method will be called once.
            // this is inbuilt in C#
            CustomersList customersList = new CustomersList()
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


            //approach 3

            //Add
            Customer cust = new Customer()
            {
                CustomerID = "A456",
                CustomerName = "Jacob",
                Email = "jacon@example.com",
                CustomerType = TypeOfCustomer.VIPCustomer
            };

            customersList.Add(cust);

            //Contains
            Console.WriteLine("\nContains: "+ customersList.Contains(new Customer()));

            //Count
            Console.WriteLine(customersList.Count + " customers found");

            //Remove
            customersList.Remove(cust);

            //Find
            Customer matchingCustomer = customersList.Find(cus => cus.CustomerID == "A103");

            if (matchingCustomer != null)
            {
                Console.WriteLine(matchingCustomer.CustomerID
                    +","+matchingCustomer.CustomerName);
            }

            //FindAll
            List<Customer> vipcust =  customersList.FindAll(cus => cus.CustomerType == TypeOfCustomer.VIPCustomer);



            foreach (Customer customer in customersList) //behind the scene, it will call the GetEnumerator() method of CustomerList class as it implements IEnumerable interface.
            {
                Console.WriteLine(customer.CustomerID + "," + customer.CustomerName
                    + "," + customer.Email + "," + customer.CustomerType);
            }

            customersList.Clear();

            Console.ReadKey();
        }
    }
}
