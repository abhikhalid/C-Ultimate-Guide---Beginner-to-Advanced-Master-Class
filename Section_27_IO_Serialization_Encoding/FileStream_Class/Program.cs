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

            // It's recommended to create two stream, one is for reading and another one is for writing.

            //File Reading

            //FileStream fileStream2 = new FileStream(filePath,FileMode.OpenOrCreate,FileAccess.Read);
            //FileStream fileStream2 = File.Open(filePath,FileMode.OpenOrCreate,FileAccess.Read);
            //FileStream fileStream2 = fileInfo.Open(FileMode.OpenOrCreate,FileAccess.Read);
            FileStream fileStream2 = fileInfo.OpenRead();

            //create empty bytes[]
            byte[] bytes3 = new byte[fileStream2.Length]; 
            
            //Read
            fileStream2.Read(bytes3, 0, bytes3.Length);

            //Convert byte[] to string
            string content3 = Encoding.ASCII.GetString(bytes3);
            Console.WriteLine("\nFile read. File content is:");
            Console.WriteLine(content3);

            fileStream2.Close();

            Console.ReadKey();
        }
    }
}
