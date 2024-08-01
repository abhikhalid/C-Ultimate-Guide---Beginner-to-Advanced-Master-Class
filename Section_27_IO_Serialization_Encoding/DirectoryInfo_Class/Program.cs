using System;
using System.IO;

namespace DirectoryInfo_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string countriesPath = @"D:\Coding\Development\C#\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\Section_27_IO_Serialization_Encoding\DirectoryInfo_Class\Countries";
            DirectoryInfo directoryInfo = new DirectoryInfo(countriesPath);

            //Create
            directoryInfo.Create();
            Console.WriteLine("countries folder created");

            //CreateSubdirectory
            directoryInfo.CreateSubdirectory("Bangladesh");
            directoryInfo.CreateSubdirectory("UK");
            directoryInfo.CreateSubdirectory("USA");
            Console.WriteLine("'Bangladesh','UK','USA' folders created");

            //FileInfo.Create()
            new FileInfo(directoryInfo.FullName + @"\capitals.txt").Create().Close();
            new FileInfo(directoryInfo.FullName + @"\sports.txt").Create().Close();
            new FileInfo(directoryInfo.FullName + @"\population.txt").Create().Close();

            Console.WriteLine("'capitals.txt', 'sports.txt', 'population.txt' files created");

            //MoveTo
            string worldPath = @"D:\Coding\Development\C#\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\Section_27_IO_Serialization_Encoding\DirectoryInfo_Class\World";
            directoryInfo.MoveTo(worldPath);
            Console.WriteLine("'countries' moved to 'world'");

            //GetFiles
            FileInfo[] files = directoryInfo.GetFiles();

            foreach (FileInfo file in files)
            {
                Console.WriteLine(file.FullName,file.Length);
            }


            //GetDirectories
            DirectoryInfo[] directories = directoryInfo.GetDirectories();

            foreach (DirectoryInfo dir in directories)
            {
                Console.WriteLine(dir.FullName);
            }


            //Delete
            //directoryInfo.Delete();  //by default Delete method deletes a folder if it is empty.
            directoryInfo.Delete(true); // all the sub-directorie gets deleted using recursion.
            Console.WriteLine("'world' folder deleted");

            Console.ReadKey();
        }
    }
}
