// The Class Libaray will be compiled as DLL file.

//It's a good way of programming style to declare all the resuable classes inside the class library; instead of writing them in the console application.
// by adding reference of the Class Library to the Console Application, it will add reference of the compiled file of class libaray into the console application project.
public class Product
{
    //fields
    //public int productID=1001; (not good way)
    public int productID;
    public string productName;
    public double cost;
    public double tax;
    public int quantityInStock;
    public static int TotalNoProducts;
    public const string CategoryName = "Computer";
    public readonly string dateofPurchase;

    public Product()
    {
        dateofPurchase = System.DateTime.Now.ToShortDateString();
    }

    public void Method()
    {
        TotalNoProducts = 0;
    }

    // method
    // cost <=2000 then tax = 10%
    // cost > 20000 then tax = 12.5%
    public void CalculateTax()
    {
        //create local variable
        double t;
        //calculate tax
        if(cost <= 2000)
        {
            t = cost * 10 / 1000;
        }
        else
        {
            t = cost * 12.5 / 1000;
        }
        tax = t;
    }
}
