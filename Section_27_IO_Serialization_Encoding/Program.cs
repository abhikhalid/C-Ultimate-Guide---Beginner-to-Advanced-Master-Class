using System;

namespace Section_27_IO_Serialization_Encoding
{
    internal class Program
    {
        static void Main()
        {
            int dec1 = 13;
            string binary1 = Convert.ToString(dec1, 2); //decimal to binary number

            Console.WriteLine(binary1);

            int dec2 = Convert.ToInt32(binary1, 2); // binary to decimal
            Console.WriteLine(dec2);

            //binary Literals

            // literals means the value which we directly provide to the code, rather than taking input from the user
            //prefix 0b to make the compiler understand that, we are going to write binary number
            //Console will print the corresponding decimal number.
            
            Console.WriteLine(0b1100100); //decimal : 100
            Console.ReadKey();

            Console.ReadKey();
        }
    }
}
