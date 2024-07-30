using System;

namespace Octal_Number_System
{
    class Program
    {
        static void Main()
        {
            int dec1 = 289;
            string oct1 = Convert.ToString(dec1,8);

            Console.WriteLine(oct1);

            int dec2 =  Convert.ToInt32(oct1,8);
            Console.WriteLine(dec2);

            Console.ReadKey();
        }
    }
}
