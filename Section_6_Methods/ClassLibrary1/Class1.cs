// The Class Libaray will be compiled as DLL file.

//It's a good way of programming style to declare all the resuable classes inside the class library; instead of writing them in the console application.
// by adding reference of the Class Library to the Console Application, it will add reference of the compiled file of class libaray into the console application project.
public class Product
{
    //fields
    //public int productID=1001; (not good way)
    private int productID;
    private string productName;
    private double cost;
    private double tax;
    private int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Computer";
    private readonly string dateofPurchase;

    public Product()
    {
        dateofPurchase = System.DateTime.Now.ToShortDateString();
    }

    // Set Method for ProductID
    public void SetProductID(int value)
    {
        this.productID = value;
    }

    // Get method for producctID
    public int GetProductID()
    {
        return this.productID;
    }

    //Set method for productName
    public void SetProductName(string value)
    {
        this.productName = value;
    }

    //Get method for productName
    public string GetProductName()
    {
        return this.productName;
    }

    //Set method for cost
    public void SetCost(double value)
    {
        this.cost = value;
    }

    //Get method for cost
    public double GetCost()
    {
        return this.cost;
    }

    //Set method for tax
    public void SetTax(double value)
    {
        this.tax = value;
    }

    //Get method for tax
    public double GetTax()
    {
        return this.tax;
    }

    //Set method for quantityInStock
    public void SetQunatityInStock(int value)
    {
        this.quantityInStock = value;
    }

    //Get method for quantityInStock
    public int GetQuantityInStock()
    {
        return this.quantityInStock;
    }

    //Get method for dateofPurchase
    public string GetDateOfPurchase()
    {
        return this.dateofPurchase;
    }

    public void Method()
    {
        TotalNoProducts = 0;
    }

    // method
    // cost <=2000 then tax = 10%
    // cost > 20000 then tax = 12.5%
    public void CalculateTax(double percentage = 4.5)
    {
        //create local variable
        double t;
        //calculate tax
        if (this.cost <= 2000)
        {
            t = this.cost * 10 / 1000;
        }
        else
        {
            t = this.cost * percentage / 1000;
        }
        this.tax = t;
    }
    
    //Method Overloading
    public void CalculateTax(double cost, double percentage)
    {
        //create local variable
        double t;
        //calculate tax
        if (cost <= 2000)
        {
            t = cost * 5 / 1000;
        }
        else
        {
            t = this.cost * percentage / 1000;
        }
        this.tax = t;
    }

    //static method
    public static void SetTotalNoOfProducts(int value)
    {
        TotalNoProducts = value;
    }

    public static int GetTotalNoOfProducts()
    {
        return TotalNoProducts;
    }

    //static method: Calculates Total Quantity
    public static int GetTotalQuantity(Product product1, Product product2, Product product3)
    {
        return product1.GetQuantityInStock() + product2.GetQuantityInStock() + product3.GetQuantityInStock();
    }
}
