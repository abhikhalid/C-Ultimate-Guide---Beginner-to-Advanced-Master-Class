class Program
{
    static void Main()
    {
        int a = 1000;

        string b;

        // int -> string
        b = System.Convert.ToString(a);

        System.Console.WriteLine(a);
        System.Console.WriteLine(b);

        System.Console.ReadKey();
    }
}