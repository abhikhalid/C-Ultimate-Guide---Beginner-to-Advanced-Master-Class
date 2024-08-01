using System;
using System.IO;

namespace Directory_Info_Class_Properties
{
    internal class Program
    {
        static void Main()
        {
            string dirPath = @"D:\Coding\Development\C#\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\Section_27_IO_Serialization_Encoding\Directory_Info_Class_Properties\Practice\Sample";
            
            DirectoryInfo directoryInfo = new DirectoryInfo(dirPath);

            if(directoryInfo.Exists )
            {
                Console.WriteLine("Full Name: "+directoryInfo.FullName);
                Console.WriteLine("Name: "+directoryInfo.Name);
                Console.WriteLine("Directory Name: "+directoryInfo.Parent);
                Console.WriteLine("Root: "+directoryInfo.Root);
                Console.WriteLine("Creation date and time: "+directoryInfo.CreationTime);
                Console.WriteLine("Last modification date and time: "+directoryInfo.LastWriteTime);
                Console.WriteLine("Last access date and time: "+directoryInfo.LastAccessTime);
            }

            Console.ReadKey();
        }
    }
}
