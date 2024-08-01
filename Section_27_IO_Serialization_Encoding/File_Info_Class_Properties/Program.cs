using System;
using System.IO;

namespace File_Info_Class_Properties
{
    internal class Program
    {
        static void Main()
        {
            string filePath = "D:\\Coding\\Development\\C#\\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\\Section_27_IO_Serialization_Encoding\\File_Info_Class_Properties\\japan.txt";

            FileInfo fileInfo = new FileInfo(filePath);
        
            Console.WriteLine("Exists:"+fileInfo.Exists);
            
            if(fileInfo.Exists )
            {
                Console.WriteLine("FullName: " + fileInfo.FullName);
                Console.WriteLine("Name:" + fileInfo.Name);
                Console.WriteLine("DirectoryName:" + fileInfo.DirectoryName);
                Console.WriteLine("Extension:" + fileInfo.Extension);
                Console.WriteLine("Length:" + fileInfo.Length);
                Console.WriteLine("LastWriteTime:" + fileInfo.LastWriteTime);
                Console.WriteLine("LastAccessTime:" + fileInfo.LastAccessTime);
                Console.WriteLine("CreationTime:" + fileInfo.CreationTime);
            }
            else
            {
                Console.WriteLine("File not found");
            }
         
            Console.ReadKey();
        }
    }
}
