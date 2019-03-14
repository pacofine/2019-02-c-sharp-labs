using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_18_Streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            //not using streaming : writing directly
            string file01 = File.ReadAllText("data.txt");

            //stream reader
            //create stream reader object
            //enclose in 'using' block (complete 'cleanup' afterwards)
            //ReadLine() stream and read line by line

            //path as a variable
            //path is a variable so path01 is a relative path
            string path01 = "data.txt";
            //path02 is an absolute path
            string path02 = "C:/data/data.txt";
            //using 'escape' characters \t = tab \n = new line
            string path03 = "C:\\data\\data.txt";
            //@ means treat the following string literrally
            string path04 = @"C:\data\data.txt";
            //enviroment variables : my documents path
            string path05 = Environment.ExpandEnvironmentVariables("%userprofile%") + "\\data.txt";
            Console.WriteLine(path05);

            string path06 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\data.txt";

            using (var reader = new StreamReader(path06))
            {
                string output;
                //read every line
                //output to string 
                //check everytime that the string is not null
                //continue looping untill out of data
                while ((output = reader.ReadLine()) != null)
                {
                    list.Add(output);
                }
            }
            list.ForEach(output => Console.WriteLine(output));
            {

            }
        }
    }
}
