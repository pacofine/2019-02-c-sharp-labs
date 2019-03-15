using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_503_Collections
{
    class Program
    {
        public static int[] myArr = new int[10];
        public static List<int> myList = new List<int>();
        public static Stack<int> myStack = new Stack<int>();
        public static Queue<int> myQueue = new Queue<int>();
        public static Dictionary<int, int> myDic = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = i + 1;
            }

            foreach (var item in myArr)
            {
                myList.Add(item + 1);
            }

            foreach (var item in myList)
            {
                myStack.Push(item + 1);
            }

            foreach (var item in myStack)
            {
                myQueue.Enqueue(item + 1);
            }

            for (int i = 0; i < 10; i++)
            {
                myDic.Add(i, myQueue.Dequeue() + 1);
            }

            int total = 0;

            foreach (var item in myDic)
            {
                total += item.Value;
                
            }

            Console.WriteLine(total);
        }
    }
}
