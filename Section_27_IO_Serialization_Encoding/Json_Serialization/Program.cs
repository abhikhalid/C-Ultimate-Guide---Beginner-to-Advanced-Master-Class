using System;
using System.IO;
using System.Web.Script.Serialization; //by default this namespace is missing in Console Application, select the Reference of this project and look for 'System.Web.Extensions' then add it.

namespace Json_Serialization
{
    [Serializable]
    public class Customer
    {
        public int CustomerId { get; set; }

        public string CustomerName { get; set; }

        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main()
        {
            //create object
            Customer customer = new Customer()
            {
                CustomerId = 1,
                CustomerName = "Khalid",
                Age = 20
            };

            //create object of JavaScriptSerializer
            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();


            //I would like to write the content into the file, so I need a StreamWriter or FileStream
            string filePath = @"D:\Coding\Development\C#\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\Section_27_IO_Serialization_Encoding\Json_Serialization\customer.txt";
            
            StreamWriter streamWriter = new StreamWriter(filePath);

            //Serialize
            string json = javaScriptSerializer.Serialize(customer);
            streamWriter.WriteLine(json);
            streamWriter.Close();
            Console.WriteLine(json);
            Console.WriteLine("Serialized");

            //Deserialize
            StreamReader streamReader = new StreamReader(filePath);
            Customer customer_from_file = javaScriptSerializer.Deserialize(streamReader.ReadToEnd(),typeof(Customer)) as Customer;
            
            Console.WriteLine(customer_from_file.CustomerId);
            Console.WriteLine(customer_from_file.CustomerName);
            Console.WriteLine(customer_from_file.Age);


            Console.ReadKey();
        }
    }
}
