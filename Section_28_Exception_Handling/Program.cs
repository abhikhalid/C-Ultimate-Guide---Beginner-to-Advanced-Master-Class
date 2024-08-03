using System;

namespace Section_28_Exception_Handling
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int a, b;

                Console.Write("Enter First Number : ");
                string input1 = Console.ReadLine();
                a = int.Parse(input1);

                Console.Write("Enter Second Number:");
                string input2 = Console.ReadLine();
                b = int.Parse(input2);

                int c = a / b; // b = 0; it raises 'DivideByZero' exception.
                Console.WriteLine("Result of Division:" + c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally //no matter exception is raised or not faised, finally block will exceute.
            {
                Console.ReadKey();
            }
        }
    }
}
