using System;
using System.IO;

namespace FileStream_Class
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"D:\Coding\Development\C#\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\Section_27_IO_Serialization_Encoding\FileStream_Class";


            //FileStream fileStream = new FileStream(filePath,FileMode.Create,FileAccess.Write);
            //FileStream fileStream = File.Create(filePath);
            //FileStream fileStream = File.Open(filePath,FileMode.Create,FileAccess.Write);
            //FileStream fileStream = File.OpenWrite(filePath);
            
            //or

            FileInfo fileInfo = new FileInfo(filePath);
            FileStream fileStream = fileInfo.Open(FileMode.CreateNew,FileAccess.Write);
            //FileStream fileStream = fileInfo.OpenWrite();
        }
    }
}
