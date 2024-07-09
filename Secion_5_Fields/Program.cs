//It's a good way of programming style to declare all the resuable classes inside the class library; instead of writing them in the console application.
// by adding reference of the Class Library to the Console Application, it will add reference of the compiled file of class libaray into the console application project.

class Sample
{
   public static void Main()
    {
        //create reference variables
        Product product1, product2, product3;

        // create objects
        product1 = new Product();
        product2 = new Product();
        product3 = new Product();

        //initialize fields
        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityInStock = 1200;

        product2.productID = 1002;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.quantityInStock = 3400;

        product3.productID = 1003;
        product3.productName = "Speakers";
        product3.cost = 36000;
        product3.quantityInStock = 800;

        //get values from fields
        System.Console.WriteLine("Product 1:");
        System.Console.WriteLine("Product ID: " + product1.productID);
        System.Console.WriteLine("Product Name: " + product1.productName);
        System.Console.WriteLine("Product Cost: " + product1.cost);
        System.Console.WriteLine("Quantity in Stock: " + product1.quantityInStock);

        System.Console.WriteLine("Product 2:");
        System.Console.WriteLine("Product ID: " + product2.productID);
        System.Console.WriteLine("Product Name: " + product2.productName);
        System.Console.WriteLine("Product Cost: " + product2.cost);
        System.Console.WriteLine("Quantity in Stock: " + product2.quantityInStock);

        System.Console.WriteLine("Product 3:");
        System.Console.WriteLine("Product ID: " + product3.productID);
        System.Console.WriteLine("Product Name: " + product3.productName);
        System.Console.WriteLine("Product Cost: " + product3.cost);
        System.Console.WriteLine("Quantity in Stock: " + product3.quantityInStock);

        int totalQuantity = product1.quantityInStock+ product2.quantityInStock + product3.quantityInStock;
        System.Console.WriteLine("Total Quantity", totalQuantity);

        //TO DO: Find out the highes cost of the three product

        System.Console.ReadKey();
    }
}
