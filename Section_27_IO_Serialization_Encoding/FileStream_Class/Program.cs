using System;
using System.IO;
using System.Text;

namespace FileStream_Class
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"D:\Coding\Development\C#\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\Section_27_IO_Serialization_Encoding\FileStream_Class\dog.txt";


            //FileStream fileStream = new FileStream(filePath,FileMode.Create,FileAccess.Write);
            //FileStream fileStream = File.Create(filePath);
            //FileStream fileStream = File.Open(filePath,FileMode.Create,FileAccess.Write);
            //FileStream fileStream = File.OpenWrite(filePath);

            //or

            FileInfo fileInfo = new FileInfo(filePath);
            FileStream fileStream = fileInfo.Open(FileMode.Create, FileAccess.Write);
            //FileStream fileStream = fileInfo.OpenWrite();

            //create content
            string content = "Dog is one of the domestic animal";
            byte[] bytes = Encoding.ASCII.GetBytes(content);

            //Write
            fileStream.Write(bytes, 0, bytes.Length);


            //some other work here (assume 100 lines of code)

            string content2 = "other text here";
            byte[] bytes2 = Encoding.ASCII.GetBytes(content2);

            fileStream.Write(bytes2 , 0, bytes2.Length);

            fileStream.Close(); // in order to save the file properly, we have to close the stream.

            Console.WriteLine("dog.txt created");

            Console.ReadKey();
        }
    }
}
