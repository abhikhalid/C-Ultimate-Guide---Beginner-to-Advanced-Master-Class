using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BInaryWriter_and_BinaryReader
{
    internal class Program
    {
        static void Main()
        {
            short countryId = 1;
            string countryName = "Bangaldesh";
            long population = 65273511;
            string region = "Western Europe";

            string filePath = @"D:\Coding\Development\C#\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\Section_27_IO_Serialization_Encoding\BInaryWriter_and_BinaryReader\bangladesh.txt";
            
            FileStream fileStream = new FileStream(filePath,FileMode.Create,FileAccess.Write);

            using (BinaryWriter binaryWriter = new BinaryWriter(fileStream))
            {
                binaryWriter.Write(countryId); //0001
                binaryWriter.Write(countryName); //100 0100...
                binaryWriter.Write(population);
                binaryWriter.Write(region);
                //binaryWriter.Close(); //optional
            }

            Console.WriteLine("bangladesh.txt");

            //BinaryReader

            //now we have to read in the same order with the same data type we have written in the file

            FileStream fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            using (BinaryReader binaryReader = new BinaryReader(fileStream2))
            {
                int countryId_from_file = binaryReader.ReadInt16(); // ReadInt16() is equivalent to short
                string countryName_from_file = binaryReader.ReadString();
                long population_from_file = binaryReader.ReadInt64();
                string region_from_file = binaryReader.ReadString();

                Console.WriteLine("Country ID: " + countryId_from_file);
                Console.WriteLine("Country Name: "+ countryName_from_file);
                Console.WriteLine("Population: " + population_from_file);
                Console.WriteLine("Region: " + region_from_file);
            }
            
            Console.ReadKey();
        }
    }
}
