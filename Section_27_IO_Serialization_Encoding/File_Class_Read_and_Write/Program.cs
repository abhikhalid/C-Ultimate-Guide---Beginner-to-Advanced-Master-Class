using System;
using System.Collections.Generic;
using System.IO;

namespace File_Class_Read_and_Write
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "D:\\Coding\\Development\\C#\\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\\Section_27_IO_Serialization_Encoding\\File_Class_Read_and_Write\\dog.txt";

            string content = "The dog is one of the common domestic animal";
            
            File.WriteAllText(filePath, content);
            Console.WriteLine("dog.txt created");


            //ReadAllText
            string s= File.ReadAllText(filePath);

            Console.WriteLine("\nFile read:");
            Console.WriteLine(s);


            //collection
            List<string> list = new List<string>()
            {
                "Russia",
                "Bangladesh",
                "Maldives"
            };

            //file path
            string filePath2 = "D:\\Coding\\Development\\C#\\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\\Section_27_IO_Serialization_Encoding\\File_Class_Read_and_Write\\asia.txt";

            //WriteAllLines
            File.WriteAllLines(filePath2, list);
            Console.WriteLine("asia.txt created");


            //ReadAllLines
            string[] existingContent = File.ReadAllLines(filePath2);

            foreach (string line in existingContent)
            {
                Console.WriteLine(line);
            }

            Console.ReadKey();
        }
    }
}
