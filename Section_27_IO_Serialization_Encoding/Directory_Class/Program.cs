using System;
using System.IO;

namespace Directory_Class
{
    internal class Program
    {
        static void Main()
        {
            string countriesFolderPath = "D:\\Coding\\Development\\C#\\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\\Section_27_IO_Serialization_Encoding\\Directory_Class\\Countries";
            
            Directory.CreateDirectory(countriesFolderPath);
            Console.WriteLine("countries folder created");

            string indiaPath = countriesFolderPath + @"\Bangladesh";
            string ukPath = countriesFolderPath + @"\UK";
            string usaPath = countriesFolderPath + @"\USA";

            //we have to create folder one by one, we can not create all three folder at a same time. 
            Directory.CreateDirectory(indiaPath);
            Directory.CreateDirectory(ukPath);
            Directory.CreateDirectory(usaPath);

            Console.WriteLine("Sub directories 'Bangladesh', 'UK' ans 'USA' created");

            //For Creating file, we can use 'File' or 'FileInfo'

            string capitalsFilePath = countriesFolderPath + @"\capitals.txt";
            string sportsFilePath = countriesFolderPath + @"\sports.txt";
            string populationFilePath = countriesFolderPath + @"\population.bat";


            //File.Create
            File.Create(capitalsFilePath).Close();
            File.Create(sportsFilePath).Close();
            File.Create(populationFilePath).Close();
            Console.WriteLine("Files 'captials.txt', 'sports.txt', 'population.bat' created");

            //Move
            string worldFolderPath = @"D:\Coding\Development\C#\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\Section_27_IO_Serialization_Encoding\Directory_Class\World";
            Directory.Move(countriesFolderPath,worldFolderPath);  //Rename Countries Folder to World Folder
            Console.WriteLine("'countries' folder moved to 'world'");


            //GetFiles
            //string[] files = Directory.GetFiles(worldFolderPath);
            string[] files = Directory.GetFiles(worldFolderPath,"*.txt"); // * => wildCard (file name can be anything but extension should be .txt)
            Console.WriteLine("\nFiles:");

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }


            //GetDirectories
            string[] directoreis = Directory.GetDirectories(worldFolderPath);
            Console.WriteLine("\nSub directories");

            foreach (string dir in directoreis)
            {
                Console.WriteLine(dir);
            }
            

            //Delete
            //Directory.Delete(worldFolderPath);  //call this if the directory contains empty
            Directory.Delete(worldFolderPath,true); //call this if the directory contains something
            Console.WriteLine("'world' folder deleted");

            Console.ReadKey();
        }
    }
}
