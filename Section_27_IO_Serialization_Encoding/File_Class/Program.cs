using System;
using System.IO;

namespace File_Class
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "D:\\Coding\\Development\\C#\\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\\Section_27_IO_Serialization_Encoding\\File_Class\\bangladesh.txt";
            string filePath2 = "D:\\Coding\\Development\\C#\\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\\Section_27_IO_Serialization_Encoding\\File_Class\\bangladesh2.txt";
            string filePath3 = "D:\\Coding\\Development\\C#\\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\\Section_27_IO_Serialization_Encoding\\File_Class\\another.txt";


            //if the file already exists, then the file will be overridden.
            File.Create(filePath).Close();
            Console.WriteLine("Bangladesh.txt created");

            bool exists = File.Exists(filePath);

            if(exists)
            {
                // it will create a new file at filepath2 location then copies all the content from filePath
                File.Copy(filePath,filePath2);
                Console.WriteLine("Copied bangladesh.txt to bangladesh2.txt");

                File.Move(filePath2,filePath3);  // move method moves a file from one location to another location (must be ina same drive), also can rename file.
                Console.WriteLine("Moved bangladesh2.txt file to another.txt");

                File.Delete(filePath3);
                Console.WriteLine("another.txt deleted");
            }
            else
            {
                Console.WriteLine("File not found");
            }

            Console.ReadKey();
        }
    }
}
