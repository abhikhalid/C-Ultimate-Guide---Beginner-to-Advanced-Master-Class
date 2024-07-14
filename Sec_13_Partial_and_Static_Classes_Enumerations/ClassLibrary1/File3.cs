public partial class Product
{
    //public method
    public double GetTax()
    {
        double tax = Cost * 10 / 100;
        return tax;
    }

    
    //public method to call partial method
    public void CallGetTax()
    {
        GetTax2();
    }
}