using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace lab_202_PhilsLab
{
    class Program
    {
        static void Main(string[] args)
        {
                var instance = new Sum();

                int range = 1000000;

                var output = instance.SumOfaMill(range);
                Console.WriteLine(output.TotalSum);
                Console.WriteLine(output.TimeTaken);
                Console.WriteLine();

                var output01 = instance.MyArr(range);
                Console.WriteLine(output01.TotalSum);
                Console.WriteLine(output01.TimeTaken);
                Console.WriteLine();

                var output02 = instance.MyList(range);
                Console.WriteLine(output02.TotalSum);
                Console.WriteLine(output02.TimeTaken);
                Console.WriteLine();

                var output03 = instance.MyQueue(range);
                Console.WriteLine(output03.TotalSum);
                Console.WriteLine(output03.TimeTaken);
                Console.WriteLine();

                var output04 = instance.MyStack(range);
                Console.WriteLine(output04.TotalSum);
                Console.WriteLine(output04.TimeTaken);
                Console.WriteLine();

                var output05 = instance.MyDictionary(range);
                Console.WriteLine(output05.TotalSum);
                Console.WriteLine(output05.TimeTaken);
                Console.WriteLine();

                var output06 = instance.MyArrList(range);
                Console.WriteLine(output06.TotalSum);
                Console.WriteLine(output06.TimeTaken);
                Console.WriteLine();

                var output07 = instance.MyHashSet(range);
                Console.WriteLine(output07.TotalSum);
                Console.WriteLine(output07.TimeTaken);
                Console.WriteLine();

                var output08 = instance.MyLinkedList(range);
                Console.WriteLine(output08.TotalSum);
                Console.WriteLine(output08.TimeTaken);
                Console.WriteLine();
            }

        }



        public struct SumAndTime
        {
            public int TotalSum;
            public long TimeTaken;
        }



        public class Sum
        {
            public SumAndTime SumOfaMill(int range)
            {
                Stopwatch Timer = new Stopwatch();
                Timer.Start();

                int sum = 0;
                for (int i = 0; i < range; i++)
                {
                    sum += i;
                }

                Timer.Stop();

            using (var db = new NorthwindEntities())
            {
                TestResultsNew resultToCreate = new TestResultsNew
                {
                    TestName = "SumOfaMil",
                    Range = range,
                    TotalSum = sum,
                    TimeElapsed = Timer.ElapsedMilliseconds,
                };

                db.TestResultsNews.Add(resultToCreate);
                db.SaveChanges();
            }

            return new SumAndTime()
                {
                    TotalSum = sum,
                    TimeTaken = Timer.ElapsedMilliseconds
                };
            }


            public SumAndTime MyArr(int range)
            {
                Stopwatch Timer = new Stopwatch();
                Timer.Start();

                int[] myArr = new int[range];

                int sum = 0;
                for (int i = 0; i < myArr.Length; i++)
                {
                    myArr[i] = i;
                    sum += i;
                }

                Timer.Stop();

                using (var db = new NorthwindEntities())
                {
                    TestResultsNew resultToCreate = new TestResultsNew
                    {
                        TestName = "MyArr",
                        Range = range,
                        TotalSum = sum,
                        TimeElapsed = Timer.ElapsedMilliseconds,
                    };

                    db.TestResultsNews.Add(resultToCreate);
                    db.SaveChanges();
                }

                return new SumAndTime()
                {
                    TotalSum = sum,
                    TimeTaken = Timer.ElapsedMilliseconds
                };
            }


            public SumAndTime MyList(int range)
            {
                Stopwatch Timer = new Stopwatch();
                Timer.Start();

                var myList = Enumerable.Range(1, range).ToList();

                int sum = 0;
                foreach (var item in myList)
                {
                    sum += item;
                }

                Timer.Stop();

                using (var db = new NorthwindEntities())
                {
                    TestResultsNew resultsToCreate = new TestResultsNew
                    {
                        TestName = "MyList",
                        Range = range,
                        TotalSum = sum,
                        TimeElapsed = Timer.ElapsedMilliseconds
                    };

                    db.TestResultsNews.Add(resultsToCreate);
                    db.SaveChanges();
                }

                return new SumAndTime()
                {
                    TotalSum = sum,
                    TimeTaken = Timer.ElapsedMilliseconds
                };
            }


            public SumAndTime MyQueue(int range)
            {
                Stopwatch Timer = new Stopwatch();
                Timer.Start();

                var myQueue = new Queue<int>();

                int sum = 0;
                for (int i = 0; i < range; i++)
                {
                    myQueue.Enqueue(i);
                }

                foreach (var item in myQueue)
                {
                    sum += item;
                }

                Timer.Stop();

                using (var db = new NorthwindEntities())
                {
                    TestResultsNew resultsToCreate = new TestResultsNew
                    {
                        TestName = "MyQueue",
                        Range = range,
                        TotalSum = sum,
                        TimeElapsed = Timer.ElapsedMilliseconds
                    };

                    db.TestResultsNews.Add(resultsToCreate);
                    db.SaveChanges();

                }

                return new SumAndTime()
                {
                    TotalSum = sum,
                    TimeTaken = Timer.ElapsedMilliseconds
                };
            }


            public SumAndTime MyStack(int range)
            {
                Stopwatch Timer = new Stopwatch();
                Timer.Start();

                var myStack = new Stack<int>();

                for (int i = 0; i < range; i++)
                {
                    myStack.Push(i);
                }

                int sum = 0;
                foreach (var item in myStack)
                {
                    sum += item;
                }

                Timer.Stop();

                using (var db = new NorthwindEntities())
                {
                    TestResultsNew resultsToCreate = new TestResultsNew
                    {
                        TestName = "MyStack",

                        Range = range,
                        TotalSum = sum,
                        TimeElapsed = Timer.ElapsedMilliseconds
                    };

                    db.TestResultsNews.Add(resultsToCreate);
                    db.SaveChanges();
                }

                return new SumAndTime()
                {
                    TotalSum = sum,
                    TimeTaken = Timer.ElapsedMilliseconds
                };
            }


            public SumAndTime MyDictionary(int range)
            {
                Stopwatch Timer = new Stopwatch();
                Timer.Start();

                var myDictionary = new Dictionary<int, int>();

                for (int i = 0; i < range; i++)
                {
                    myDictionary.Add(i, i);
                }

                int sum = 0;
                foreach (var item in myDictionary)
                {
                    sum += item.Value;
                }

                Timer.Stop();

                using (var db = new NorthwindEntities())
                {
                    TestResultsNew resultsToCreate = new TestResultsNew
                    {
                        TestName = "MyDictionary",
                        Range = range,
                        TotalSum = sum,
                        TimeElapsed = Timer.ElapsedMilliseconds
                    };

                    db.TestResultsNews.Add(resultsToCreate);
                    db.SaveChanges();
                }

                return new SumAndTime()
                {
                    TotalSum = sum,
                    TimeTaken = Timer.ElapsedMilliseconds
                };
            }


            public SumAndTime MyArrList(int range)
            {
                Stopwatch Timer = new Stopwatch();
                Timer.Start();

                var myArrList = new ArrayList();

                for (int i = 0; i < range; i++)
                {
                    myArrList.Add(i);
                }

                int sum = 0;
                foreach (int item in myArrList)
                {
                    sum += item;
                }

                Timer.Stop();

                using (var db = new NorthwindEntities())
                {
                    TestResultsNew resultsToCreate = new TestResultsNew
                    {
                        TestName = "MyArrList",
                        Range = range,
                        TotalSum = sum,
                        TimeElapsed = Timer.ElapsedMilliseconds
                    };

                    db.TestResultsNews.Add(resultsToCreate);
                    db.SaveChanges();
                }

                return new SumAndTime()
                {
                    TotalSum = sum,
                    TimeTaken = Timer.ElapsedMilliseconds
                };
            }


            public SumAndTime MyHashSet(int range)
            {
                Stopwatch Timer = new Stopwatch();
                Timer.Start();

                var myHash = new HashSet<int>();

                for (int i = 0; i < range; i++)
                {
                    myHash.Add(i);
                }

                int sum = 0;
                foreach (int item in myHash)
                {
                    sum += item;
                }

                Timer.Stop();

                using (var db = new NorthwindEntities())
                {
                    TestResultsNew resultsToCreate = new TestResultsNew
                    {
                        TestName = "MyHashSet",
                        Range = range,
                        TotalSum = sum,
                        TimeElapsed = Timer.ElapsedMilliseconds
                    };

                    db.TestResultsNews.Add(resultsToCreate);
                    db.SaveChanges();
                }

                return new SumAndTime()
                {
                    TotalSum = sum,
                    TimeTaken = Timer.ElapsedMilliseconds
                };
            }


            public SumAndTime MyLinkedList(int range)
            {
                Stopwatch Timer = new Stopwatch();
                Timer.Start();

                var myLinkedList = new LinkedList<int>();

                for (int i = 0; i < range; i++)
                {
                    myLinkedList.AddLast(i);
                }

                int sum = 0;
                foreach (int item in myLinkedList)
                {
                    sum += item;
                }

                Timer.Stop();

                using (var db = new NorthwindEntities())
                {
                    TestResultsNew resultsToCreate = new TestResultsNew
                    {
                        TestName = "MyLinkedList",
                        Range = range,
                        TotalSum = sum,
                        TimeElapsed = Timer.ElapsedMilliseconds
                    };

                    db.TestResultsNews.Add(resultsToCreate);
                    db.SaveChanges();
                }

                return new SumAndTime()
                {
                    TotalSum = sum,
                    TimeTaken = Timer.ElapsedMilliseconds
                };

            }
        }
    }
