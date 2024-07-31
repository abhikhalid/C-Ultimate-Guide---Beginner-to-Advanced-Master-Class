using System;
using System.Text;


namespace UniCode_Character_Encodiing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mytext = "অ";
            Console.WriteLine(mytext);

            string mytext2 = "\u0987";
            Console.WriteLine(mytext2);


            string sentence = "The quick brown fox jumps over the lazy dog";
            //In real life, when writng to file, we do this
            byte[] bytes = Encoding.Unicode.GetBytes(sentence);

            string sentence2 = Encoding.Unicode.GetString(bytes);
            Console.WriteLine(sentence2);

            Console.ReadKey();
        }
    }
}
