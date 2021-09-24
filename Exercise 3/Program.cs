using System;
using System.IO;
namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in drives)
            {
                if (drive.IsReady)
                {
                    Console.WriteLine($"Drive name: {drive.Name}");
                    Console.WriteLine($"Format: {drive.DriveFormat}");
                    Console.WriteLine($"Type: {drive.DriveType}");
                    Console.WriteLine($"Root directory: {drive.RootDirectory}");
                    Console.WriteLine($"Volume label: {drive.VolumeLabel}");
                    Console.WriteLine($"Free space: {drive.TotalFreeSpace}");
                    Console.WriteLine($"Available space { drive.AvailableFreeSpace}");
                    Console.WriteLine($"Total size: {drive.TotalSize}");
                    Console.WriteLine();
                }
            }
            String path = @"C:\Users\DELL\Documents";

            var files = Directory.GetDirectories(path);

            foreach (var file in files)
            {
                Console.WriteLine("This is an all file in your MyDocuments:");
                Console.WriteLine(file);
            }
            string text = System.IO.File.ReadAllText(@"C:\Users\DELL\Documents\New folder\HoTen.txt");
                 Console.WriteLine("\nThis is a text file in MyDocuments:");
                 Console.WriteLine(text);

        }


    }
    

}

