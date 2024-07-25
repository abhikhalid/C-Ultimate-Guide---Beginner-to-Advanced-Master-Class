using System;
using System.Collections.Generic;

namespace Collection_of_Objects_ConsoleApp
{
    internal class Program
    {
        static void Main()
        {
            List<Product> products = new List<Product>();

            string choice;

            do
            {
                Console.WriteLine("Enter Product ID: ");
                int pId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Product Name:");
                string pName = Console.ReadLine();
                Console.WriteLine("Enter Price:");
                double unitPrice = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Date of Manufacture (yyyy-MM-dd):");
                DateTime dom = DateTime.Parse(Console.ReadLine());

                Product product = new Product()
                {
                    ProductID = pId,
                    ProductName = pName,
                    Price = unitPrice,
                    DateOfManufacture = dom
                };

                products.Add(product);

                Console.WriteLine("Product Added\n");
                Console.WriteLine("Do you want to continue to next product?");
                choice = Console.ReadLine();    

            } while (choice != "No" && choice != "no" && choice != "n");


            foreach (Product product in products)
            {
                Console.WriteLine(product.ProductID+","+product.ProductName
                    + ", "+product.Price + ", "+product.DateOfManufacture.ToShortDateString());
            }

            Console.ReadKey();

        }
    }
}
