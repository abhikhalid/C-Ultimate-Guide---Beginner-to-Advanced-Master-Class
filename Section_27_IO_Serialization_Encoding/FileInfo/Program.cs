using System;
using System.IO;

namespace FileInfo1
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "D:\\Coding\\Development\\C#\\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\\Section_27_IO_Serialization_Encoding\\FileInfo\\japan.txt";
            string destPath = "D:\\Coding\\Development\\C#\\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\\Section_27_IO_Serialization_Encoding\\FileInfo\\another.txt";
            string destPath2 = "D:\\Coding\\Development\\C#\\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\\Section_27_IO_Serialization_Encoding\\FileInfo\\somethingelse.txt";

            FileInfo fileInfo = new FileInfo(filePath);
           
            //Create()
            fileInfo.Create().Close();
            Console.WriteLine("japan.txt created");

            //CopyTo()
            FileInfo fileInfo2 = fileInfo.CopyTo(destPath);
            Console.WriteLine(fileInfo2.Name + " created.");


            //MoveTo()
            fileInfo2.MoveTo(destPath2);
            Console.WriteLine(fileInfo2.Name + "moved");

            //Delete()
            fileInfo2.Delete();
            Console.WriteLine(fileInfo2.Name + " deleted");
            
            Console.ReadKey();

        }
    }
}
