class Sample
{
    public static void Main()
    {
        // Local Constant
        const string developerName = "khalid";

        //create reference variables
        Product product1, product2, product3;

        // create objects
        product1 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); //1
        product2 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); //2 
        product3 = new Product();
        Product.SetTotalNoOfProducts(Product.GetTotalNoOfProducts() + 1); //3

        //initialize fields
        //product1.productID = 1001;
        product1.SetProductID(1001);
        //product1.productName = "Mobile";
        product1.SetProductName("Mobile");
        //product1.cost = 20000;
        product1.SetCost(20000);
        //product1.quantityInStock = 1200;
        product1.SetQunatityInStock(1200);

        //product2.productID = 1002;
        product2.SetProductID(1002);
        //product2.productName = "Laptop";
        product2.SetProductName("Laptop");
        //product2.cost = 45000;
        product2.SetCost(45000);
        //product2.quantityInStock = 3400;
        product2.SetQunatityInStock(3400);

        //product3.productID = 1003;
        product3.SetProductID(1003);
        //product3.productName = "Speakers";
        product3.SetProductName("Speakers");
        //product3.cost = 36000;
        product3.SetCost(36000);
        //product3.quantityInStock = 800;
        product3.SetQunatityInStock(800);

        //call methods
        product1.CalculateTax();
        product2.CalculateTax();
        product3.CalculateTax();

        //get values from fields
        System.Console.WriteLine(developerName);

        System.Console.WriteLine("Product 1:");
        System.Console.WriteLine("Product ID: " + product1.GetProductID());
        System.Console.WriteLine("Product Name: " + product1.GetProductName());
        System.Console.WriteLine("Product Cost: " + product1.GetCost());
        System.Console.WriteLine("Quantity in Stock: " + product1.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + product1.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " + product1.GetTax());

        System.Console.WriteLine("Product 2:");
        System.Console.WriteLine("Product ID: " + product2.GetProductID());
        System.Console.WriteLine("Product Name: " + product2.GetProductName());
        System.Console.WriteLine("Product Cost: " + product2.GetCost());
        System.Console.WriteLine("Quantity in Stock: " + product2.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + product2.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " + product2.GetTax());

        System.Console.WriteLine("Product 3:");
        System.Console.WriteLine("Product ID: " + product3.GetProductID());
        System.Console.WriteLine("Product Name: " + product3.GetProductName());
        System.Console.WriteLine("Product Cost: " + product3.GetCost());
        System.Console.WriteLine("Quantity in Stock: " + product3.GetQuantityInStock());
        System.Console.WriteLine("Date of Purchase: " + product3.GetDateOfPurchase());
        System.Console.WriteLine("Tax: " + product3.GetTax());

        int totalQuantity = product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
        System.Console.WriteLine("Total Quantity", totalQuantity);
        System.Console.WriteLine("Total no. of products:" + Product.GetTotalNoOfProducts()); // 3
        System.Console.WriteLine("Category of products:" + Product.CategoryName); // Output: Computers


        //TO DO: Find out the highes cost of the three product

        System.Console.ReadKey();
    }
}
