using System;
using System.Text;

namespace Ascii_Character_Encoding
{
    internal class Program
    {
        static void Main()
        {
            char ch = 'A';
            byte b = (byte)ch;

            Console.WriteLine(b); // 65

            char ch2 = (char)b; 
            Console.WriteLine(ch2); // A

            //generate byte[]
            byte[] bytes = new byte[128];

            for (byte i = 0; i < 128; i++)
            {
                bytes[i] = i;
            }

            string s = Encoding.ASCII.GetString(bytes);

            Console.WriteLine(s); // this will not show properly all the asii characters

            Console.OutputEncoding = Encoding.ASCII;
            Console.WriteLine(s);


            //while writing the data into the file by using filestreams, you may need to convert the value into byte array.
            
            //string to byte[]
            string sentence = "The quick brown fox jumps over the lazy dog";

            byte[] bytes2 =  Encoding.ASCII.GetBytes(sentence);

            string sentence2 = Encoding.ASCII.GetString(bytes2);

            Console.ReadKey();
        }
    }
}
