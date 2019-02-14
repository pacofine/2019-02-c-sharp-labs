using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace lab_08
{
    class Program
    {
        static void Main(string[] args)
        {

            string data01 = File.ReadAllText("file.txt");
            Console.WriteLine(data01);

            string data02 = File.ReadAllText("file.txt", Encoding.UTF8);
            Console.WriteLine("\n\n\n" + Environment.NewLine + data02);

            Console.WriteLine($"\n\n\n{data02}");

            Console.WriteLine($"{"hi",-20}{"there",-20}");

            //read array
            string[] data03 = File.ReadAllLines("file.txt");
            Console.WriteLine("\n\nReading as Array\n\n");
            Console.WriteLine(data03[0]);
            Console.WriteLine(data03[1]);
            Console.WriteLine(data03[2]);

            //write data
            Console.WriteLine("\ncreate new file\n");
            File.WriteAllText("file2.txt", "here is \nsome \ndata");
            Console.WriteLine(File.ReadAllText("file2.txt"));

            Console.WriteLine("\nNow write an array\n");
            File.WriteAllLines("file3.txt", data03);
            Console.WriteLine("\nAnd read it back\n");
            Console.WriteLine(File.ReadAllText("file3.txt"));

            //cope file 
            File.Copy("file.txt", "copyfile.txt", true);

            //delete
            File.Delete("file.txt");

            Console.WriteLine("\ndoes my file exist?\n");
            Console.WriteLine(File.Exists("file.txt"));

            Console.WriteLine(File.GetCreationTime("file.txt"));
            Console.WriteLine(File.GetCreationTime("file.txt"));

            //extra info
            var fileinfo = new FileInfo("file.txt");
            Console.WriteLine(fileinfo.DirectoryName);
            Console.WriteLine(fileinfo.Extension);

            //Directory
            Directory.CreateDirectory("folderA");
            Directory.CreateDirectory("folderB");
            Directory.Delete("folderB");
            File.Create("foldera/abc.txt");
            var fileArray = Directory.GetFiles("foldera");
            Console.WriteLine(fileArray[0]);
        }
    }
}
