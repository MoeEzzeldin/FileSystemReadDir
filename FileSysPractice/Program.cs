using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSysPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            //reading dir
            //string filePath = @"C:\Users\Ahmed\source\WorkSpace\Practice\FileSys";
            //string[] dirs = Directory.GetDirectories(filePath, "*", SearchOption.AllDirectories);
            //foreach(var dir in dirs)
            //    Console.WriteLine(dir);

            //reading file
            string filePath = @"C:\Users\Ahmed\source\WorkSpace\Practice\FileSys";
            string[] Files = Directory.GetFiles(filePath, "*", SearchOption.AllDirectories);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            foreach ( var file in Files)
                Console.WriteLine(Path.GetFileName(file));
            stopwatch.Stop();
            Console.WriteLine($"{Files.Length} files processed");
            Console.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds} ms");
            Console.WriteLine($"Time per file: {(double)stopwatch.ElapsedMilliseconds / Files.Length:F3} ms"); Console.ReadLine();
        }

 
    }
}