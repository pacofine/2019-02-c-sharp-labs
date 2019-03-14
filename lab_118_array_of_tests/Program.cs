using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace lab_118_array_of_tests
{
    class Program
    {
        static void Main(string[] args)
        {
            FileOperationSynchronous newf = new FileOperationSynchronous();
            //string sdf = newf.FileReadWrite(10);
        }
    }
    public class FileOperationSynchronous
    {
        public long FileReadWrite(int NumberOfFiles)
        {
            string data = "saving some data - ";

            //create a stopwatch
            var s = new Stopwatch();
            s.Start();
            //write 1000 times to a file synchronously
            for (int i = 0; i < NumberOfFiles; i++)
            {
                File.WriteAllText("data.txt", data + i);
            }

            //read 1000 times that same file 
            for (int i = 0; i < NumberOfFiles; i++)
            {
                File.ReadAllText("data.txt");
            }

            //end stopwatch
            s.Stop();
            string output = "Total times NumberOfFiles files write the read is " +
                $"{s.ElapsedMilliseconds}";

            //upgrade to this : create 1000 files!
            //string file name  = "data" + string.format(i,d3) + ".txt";
            //data000.txt data999.txt

            return s.ElapsedMilliseconds;
        }

        public long TaskArrayFileReadWrite(int NumberOfFiles)
        {
            //one task (input) => {method body}
            var singleTask = Task.Run(() => { });

            Task.WaitAll(singleTask);

            var s = new Stopwatch();
            s.Start();
            //array of tasks 
            Task[] tasks = new Task[NumberOfFiles];

            for (int i = 0; i < NumberOfFiles; i++)
            {
                tasks[0] = Task.Run(() =>
                {
                    //write to file

                    //read from file
                });
            }
            Task.WaitAll(tasks);
            s.Stop();
            return s.ElapsedMilliseconds;

            //homework 1) complete and test read/write 1000 then 10000 files as task
                     //2) : create new project , add Northwind update contact
                     //     name of 1 customer 1000 times using 1000 tasks
        }

    }
}

