using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnOrderedMode
{
    class UnorderedMode
    {
        static void Main(string[] args)
        {
            List<char> alphabet = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };

            Console.WriteLine("Choose your time in (seconds)");
            int x = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Complete the alphabet in the correct order in " + x + " seconds");

            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();

            while (true)
            {
                char inputLetters = (Console.ReadKey().KeyChar);

                if (alphabet == inputLetters)
                {
                    Console.WriteLine("\nCorrect!");
                    alphabet.RemoveAt(0);
                }
                
                if (stopwatch.Elapsed.TotalSeconds > x)
                {
                    Console.WriteLine("Out of Time. Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
                    Console.WriteLine($"Score: {alphabet.Count}");
                    break;
                }

            }
            stopwatch.Stop();
        }
    }
}
