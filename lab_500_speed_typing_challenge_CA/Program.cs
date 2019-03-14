using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;

namespace TypingChallenge
{
    class Program
    {
        public static List<char> alphabet = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };
        
        public static int time;
        public static int score;

        static void Main(string[] args)
        {
            Console.WriteLine("Choose mode");
            Console.WriteLine("Mode 1: Stict");//strict mode you only get points for the letters typed in the correct mode
            Console.WriteLine("Mode 2: Random");//get points for any character 
            int mode = Int32.Parse(Console.ReadLine());
            
            if (mode == 1)
            {
                Mode_1(time);
            } else if (mode == 2)
            {
                Mode_2(time);
            }
        }

        public static int Mode_1(int time)
        {
            Console.WriteLine("Choose your time in (seconds)");
            time = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Complete the alphabet in the correct order in " + time + " seconds");
            
            Stopwatch stopwatch = new Stopwatch();
            Console.ReadKey();
            stopwatch.Start(); 

            while (stopwatch.Elapsed.TotalSeconds < time)
            {
                char inputLetters = (Console.ReadKey().KeyChar);

                if (alphabet[0] == inputLetters)
                {
                    Console.WriteLine("\nCorrect!");
                    score++; 
                    alphabet.RemoveAt(0);
                }
                else
                {
                    Console.WriteLine("\nTry Again"); 
                    continue;
                }
            }

            Console.WriteLine("Out of Time! \nTime elapsed: {0:hh\\:mm\\:ss} \nScore: {1}", stopwatch.Elapsed, score);

            stopwatch.Stop();
            Console.ReadLine();
            return score;
        }

        public static int Mode_2(int score)
        {
            Console.WriteLine("Choose your time in (seconds)");
            time = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Complete the alphabet in the correct order in {0} seconds");

            Stopwatch stopwatch = new Stopwatch();
            Console.ReadKey();
            stopwatch.Start();

            while (stopwatch.Elapsed.TotalSeconds < time)
            {
                char inputLetters = (Console.ReadKey().KeyChar);
                Console.WriteLine("");
                score++;
            }

            Console.WriteLine("Out of Time! \nTime elapsed: {0:hh\\:mm\\:ss} \nScore: {1}", stopwatch.Elapsed, score);

            stopwatch.Stop();
            Console.ReadLine();

            return score;
        }
    }
}


