//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace lab_112_collections
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Collections myColl = new Collections();
//        }

//    }

//public class Collections
//{
//    /*
//    * recieve 3 numbers
//    * put these threenumbers in an array
//    * output numbers , double each one and put in a stack
//    * repeat ie output numbers, double and store in queue
//    * output numbers, square them and put in a list<int>
//    * add up numbers in the list<int> and return total
//    */

//    public int Collections20MinuteLab(int num1, int num2, int num3)
//    {
//            int[] myArray = new int[3] { 1, 2, 3 };
//            Stack<int> myStack = new Stack<int>();
//            Queue<int> myQueue = new Queue<int>();
//            List<int> myList = new List<int>();

//            foreach (var item in myArray)
//            {
//                myStack.Push(item * 2);
//                Console.WriteLine(item);
//            }

//            foreach (var item in myStack)
//            {
//                myQueue.Enqueue(item * 2);
//                Console.WriteLine(item);
//            }

//            foreach (var item in myQueue)
//            {
//                myList.Add(item * item);
//                Console.WriteLine(item);
//            }

//            return myList.Sum();
//    }
//}

//}
