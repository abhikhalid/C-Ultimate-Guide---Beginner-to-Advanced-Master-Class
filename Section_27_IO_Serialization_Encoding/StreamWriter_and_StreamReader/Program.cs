using System;
using System.IO;

namespace StreamWriter_and_StreamReader
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"D:\Coding\Development\C#\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\Section_27_IO_Serialization_Encoding\FileStream_Class\cat.txt";

            FileInfo fileInfo = new FileInfo(filePath);

            //FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);


            //4 ways to create new object of StreamWriter
            //StreamWriter streamWriter = new StreamWriter(filePath);
            //StreamWriter streamWriter = new StreamWriter(fileStream);
            //StreamWriter streamWriter = fileInfo.AppendText();
            
            using(StreamWriter streamWriter = fileInfo.CreateText())
            {
                streamWriter.WriteLine("Russia has population about 145,934,000");
                streamWriter.WriteLine("Germany has population about 145,934,000");
                streamWriter.WriteLine("United Kingdom has population about 145,934,000");
                //streamWriter.Close(); optional
            }

            Console.WriteLine("europe.txt created");

            //3 ways to create object of StreamReader
            StreamReader streamReader = new StreamReader(filePath);
            StreamReader streamReader1 = fileInfo.OpenText();

            FileStream fileStream2 = new FileStream(filePath,FileMode.Open,FileAccess.Read);

            using(StreamReader streamReader2 = new StreamReader(fileStream2))
            {
                Console.WriteLine("\nFile read. File content is:");

                //To read full file
                //string content_from_file = streamReader2.ReadToEnd();
                //Console.WriteLine(content_from_file);

                //To read part-by-part (10 Character)
                char[] buffer = new char[10];
                int char_count;
                do
                {
                    char_count = streamReader2.Read(buffer, 0, 10);
                    string s1 = new string(buffer);
                    Console.WriteLine(s1);

                } while (char_count > 0);
            }


            Console.ReadKey();
        }
    }
}
