using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lab_200_PhilsLab
{
    class Program
    {
        public static int[] myArr; 
        public static List<int> myList = new List<int>();
        public static Queue<int> myQueue = new Queue<int>();
        public static Stack<int> myStack = new Stack<int>();
        public static Dictionary<int, int> myDictionary = new Dictionary<int, int>();
        public static ArrayList myArryList = new ArrayList();
        public static HashSet<int> myHash = new HashSet<int>();
        public static LinkedList<int> myLinkedList = new LinkedList<int>();

        public static int sum = 0;

        static void Main(string[] args)
        {
            var output = MyArray(1000000);
            Console.WriteLine(output.Sum);
            Console.WriteLine(output.TimeTaken);
            Console.WriteLine();
        }

        public static SumAndTime MyArray(int range)
        {
            myArr = new int[range];

            Stopwatch Timer = new Stopwatch();

            Timer.Start();

            for (int i = 1; i < myArr.Length; i++)
            {
                myArr[i] = i;
            }

            // reset counter
            sum = 0;

            for (int i = 1; i < myArr.Length; i++)
            {
                 sum += i;
            }

            Timer.Stop();

            return new SumAndTime()
            {
                TimeTaken = Timer.ElapsedMilliseconds,
                Sum = sum
            };
        }


    }


    public class SumAndTime
    {
        public long TimeTaken { get; set; }
        public int Sum { get; set; }
    }

}
