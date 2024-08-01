using System;
using System.IO;

namespace DriveInfo_Class
{
    internal class Program
    {
        static void Main()
        {
            DriveInfo driveInfo = new DriveInfo("c");
            
            Console.WriteLine("Name: "+driveInfo.Name);
            Console.WriteLine("Drive Type: "+driveInfo.DriveType);
            Console.WriteLine("Volume Label: "+driveInfo.VolumeLabel);
            Console.WriteLine("Root Directory:"+driveInfo.RootDirectory);
            Console.WriteLine("Total Size: "+(driveInfo.TotalSize/1024/1024/1024));
            Console.WriteLine("Free space: "+(driveInfo.AvailableFreeSpace/1024/1024/1024)+" GB");
        
            Console.ReadKey();
        }
    }
}
