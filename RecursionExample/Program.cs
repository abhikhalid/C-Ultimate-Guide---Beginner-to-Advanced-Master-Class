class Sample
{
    public double Factorial(int number)
    {
        if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        System.Console.WriteLine("Enter a number:");
        int n = int.Parse(System.Console.ReadLine());

        Sample s = new Sample();
       
        double fact = s.Factorial(n);

        System.Console.WriteLine("Factorial of " + n + " is " + fact);

        System.Console.ReadKey();
    }
}

