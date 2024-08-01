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

            Console.ReadKey();
        }
    }
}
