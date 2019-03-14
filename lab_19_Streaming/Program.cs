using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace lab_19_Streaming
{
    class Program
    {
        static string line;
        static List<string> list = new List<string>();

        static void Main(string[] args)
        {
            //main thread!!!
            Console.WriteLine("Program has started");

            ReadData();
            Console.WriteLine("sleeping finished so starting work now!");
            ReadDataAsync();
            Console.WriteLine("code has finished");
            Console.ReadLine();
        }

        static void ReadData()
        {
            Thread.Sleep(2000);
        }

        static async void ReadDataAsync()
        {
            using (var reader = new StreamReader("data.txt"))
            {
                while (true)
                {
                    line = await reader.ReadLineAsync();
                    if (line == null)
                    {
                        break;  
                    }
                    list.Add(line);
                }
            }
            Thread.Sleep(3000);
            Console.WriteLine("work has finished raeding 100 text lines");
        }
    }
}
