using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

//time start 10:41 am
//time pause 11:51 am

namespace lab_121_hash_set_to_excel
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSetToExcel seb = new HashSetToExcel();
            seb.HashSetToExcelTest(1, 2, 3);
        }
    }

    //make a class to test
    public class HashSetToExcel
    {
        //instantiate the an arraythat takes in three variables
        public static int[] iArr = new int[3];
        //insatantiate a linklist a hashset and dictionary
        public static LinkedList<int> lList = new LinkedList<int>();
        public static HashSet<int> hSet = new HashSet<int>();
        public static Dictionary<int, int> iDic = new Dictionary<int, int>();

        public Custom HashSetToExcelTest(int a, int b, int c) //specify the variables that will be tested 
        {
            Stopwatch stopwatch = new Stopwatch(); //create the stopwatch

            stopwatch.Start();// start the stop watch 

            int[] iArr = { a, b, c }; //insert the values in the array

            //for each value in the array add it to a link-ist and multiply it by 2
            foreach (var item in iArr)
            {
                lList.AddLast(item * 2);
            }

            //for each item in the link-list, ad it to a hashset and multiply it by 2
            foreach (var item in lList)
            {
                hSet.Add(item * 2);
            }

            // for each in the hashset insert it in a dictionary and add 15 and multiply the sum by 3
            int i = 0;
            foreach (var item in hSet)
            {
                iDic.Add(i, (item + 15) * 3);
                i++;
            }

            stopwatch.Stop(); // stop the stop watch
            long time = stopwatch.ElapsedMilliseconds;

            string headers = "Time taken(ms):,Value 1:,Value 2:,Value 3:\n";

            if (!File.Exists("data.csv"))
            {
                File.WriteAllText("data.csv", headers);
            }

            File.AppendAllText("data.csv", $"{time},{iDic[0]},{iDic[1]},{iDic[2]}\n");
            Process.Start("data.csv");

            foreach (var item in iDic)
            {
                Console.WriteLine(item);
            }

            //here the value of each item in the dictionary is printed out along with the tim ellapsed in the stopwatch
            //the time ellapsed is the time taken for the values a, b  and c take to be processed
            return new Custom(iDic[0], iDic[1], iDic[2], time);
        }
    }

    public class Custom
    {
        public int first { get; set; }
        public int second { get; set; }
        public int third { get; set; }
        public long time { get; set; }

        public Custom(int first, int second, int third, long time)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            this.time = time;
        }

    }
}





