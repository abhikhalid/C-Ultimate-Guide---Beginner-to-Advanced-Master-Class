using System;
using System.IO;

namespace StreamWriter_and_StreamReader
{
    internal class Program
    {
        static void Main()
        {
            string filePath = @"D:\Coding\Development\C#\C_Sharp-Ultimate-Guide-Beginner-to-Advanced-Master-Class\Section_27_IO_Serialization_Encoding\FileStream_Class\cat.txt";

            //StreamWriter streamWriter = new StreamWriter(filePath);
           
            FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write); 
            //StreamWriter streamWriter = new StreamWriter(fileStream);
            
            
            //as a developer you are using the strea writer directly but it internally uses the file stream in that way
            //it works so here the benefit for you is you need not worry about converting the string value into byte array

            //streamWriter.WriteLine("Hello");

            //you have to close the stream writer once you close the stream writer internally
            //what it happens is it actually closes the file stream so it will automatically dispose
            //the file stream so any memory allocation of this file stream will be deleted and also the file
            //gets closed to the operating system so that when next time when you try to modify or overwrite that
            //particular file you will not get any errors.

            //streamWriter.Close();

            //or

            using(StreamWriter streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.WriteLine("Hello");
                //streamWriter.Close(); optional
            }
        }
    }
}
