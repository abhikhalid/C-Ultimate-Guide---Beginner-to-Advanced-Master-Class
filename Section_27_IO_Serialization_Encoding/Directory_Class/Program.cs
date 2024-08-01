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
            string populationFilePath = countriesFolderPath + @"\population.txt";


            File.Create(capitalsFilePath).Close();
            File.Create(sportsFilePath).Close();
            File.Create(populationFilePath).Close();

            Console.WriteLine("Files 'captials.txt', 'sports.txt', 'population.txt' created");

            Console.ReadKey();
        }
    }
}
