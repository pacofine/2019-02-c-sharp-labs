using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace lab_113_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class arraylist
    {
        public int arraylistMethod(int a, int b, int c, int d)
        {
            //accept 4 intigers 
            //put to array
            //extract ==> double ==> put to a queue
            //extract ==> double ==> put to a stack
            //extract ==> double ==> put to a dictionary
            //put to arraylist
            //extract and get the sum of the items and return this sum
             int[] myArray = new int[] { a, b, c, d };
             Queue<int> myQueue = new Queue<int>();
             Stack<int> myStack = new Stack<int>();
             Dictionary<int, int> sebDict = new Dictionary<int, int>();

            for (int i = 0; i < myArray.Length; i++)
            {
                myQueue.Enqueue(i * 2);
            }

            foreach (var item in myQueue)
            {
                myStack.Push(item * 2);
            }

            for (int i = 0; i < myStack.Length; i++)
            {
                var square = stack.Pop();
                square *= square;

                dict.Add(i, square);
            }


            return -1;
        }
    }
}
