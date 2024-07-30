using System;

namespace HexaDecimalNumberSystem
{
    internal class Program
    {
        static void Main()
        {
            int dec1 = 742;

            //decimal to hexadecimal
            string hex1 = Convert.ToString(dec1, 16);

            Console.WriteLine(hex1); 
            
            //hex to decimal
            int dec2 = Convert.ToInt32(hex1,16);
            Console.WriteLine(dec2);

            //hexadecimal literals
            
            //0x is the prefix for hexidecimal number. after prefix write any hexadecimal number.

            int dec3 = 0x64;
            Console.WriteLine(dec3);

            Console.ReadKey();
        }
    }
}
