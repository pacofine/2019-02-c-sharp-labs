using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_104_array_list_queue_stack_dict_01
{
    class Program
    {
        public static int[] sebArray = new int[10];
        public static List<int> sebList = new List<int>();
        public static Stack<int> sebStack = new Stack<int>();
        public static Queue<int> sebQueue = new Queue<int>();
        public static Dictionary<int, int> sebDic = new Dictionary<int, int>();

        static void Main(string[] args)
        {
            //put 10 numbers in an array
            for (int i = 0; i < 10; i++)
            {
                sebArray[i] = i + 1;
            }
            //move items to a list and add 1
            foreach (var num in sebArray)
            {
                sebList.Add(num + 1);
            }
            //move to a stack and add 1
            foreach (var num in sebList)
            {
                sebStack.Push(num + 1);
            }
            //move to a queue and add 1
            foreach (var num in sebStack)
            {
                sebQueue.Enqueue(num + 1);
            }
            //move to a dictionary and add 1
            foreach (var num in sebQueue)
            {

            }
            //return total
        }
    }


}
