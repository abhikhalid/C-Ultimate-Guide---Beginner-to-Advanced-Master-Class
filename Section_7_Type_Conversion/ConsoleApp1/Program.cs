class Program
{
    static void Main()
    {
        //sbyte
        int a = 500;

        //float
        float b;

        //int to float
        b = a;
        b = (float)a; // Explicit Casting

        byte c;
        c = (byte)a; // loosy conversion

        System.Console.WriteLine(a); 
        System.Console.WriteLine(b); 
        System.Console.WriteLine(c); 
        System.Console.ReadKey();
    }
}