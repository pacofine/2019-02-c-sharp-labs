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
        static void Main(string[] args)
        {
            //list of letters in the alphabet
            //mainly used in mode1
            List<char> alphabet = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'x', 'y', 'z' };
            bool ordered = true;
            int score = 0;

            Console.WriteLine("Choose mode");
            Console.WriteLine("Mode 1: Stict");//strict mode you only get points for the letters typed in the correct mode
            Console.WriteLine("Mode 2: Random");//get points for any character 
            int mode = Int32.Parse(Console.ReadLine());

            //mode 1 if loop
            if (mode == 1)
            {
                Console.WriteLine("Choose your time in (seconds)");
                int x = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Complete the alphabet in the correct order in " + x + " seconds");

                //create the stop watch
                Stopwatch stopwatch = new Stopwatch();
                Console.ReadKey(); // ensures the game only begins after a key is pressed
                stopwatch.Start(); //starts the stop watch

                while (ordered == true)
                {
                    char inputLetters = (Console.ReadKey().KeyChar);

                    if (alphabet[0] == inputLetters)
                    {
                        Console.WriteLine("\nCorrect!"); // if letter correct 
                        score++; //increases the score for every correct character typed
                        alphabet.RemoveAt(0);
                    }
                    else
                    {
                        Console.WriteLine("\nTry Again"); //if letter incorrcet not in array order
                        continue;
                    }
                    if (stopwatch.Elapsed.TotalSeconds > x)
                    {
                        break;
                    }

                }
                Console.WriteLine("Out of Time. Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
                Console.WriteLine($"Score: {score}");

                stopwatch.Stop();
                Console.ReadLine();
            }

            //mode 2 if loop
            else if (mode == 2)
            {
                Console.WriteLine("Choose your time in (seconds)");
                int x = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Complete the alphabet in the correct order in " + x + " seconds");

                Stopwatch stopwatch = new Stopwatch();
                Console.ReadKey();
                stopwatch.Start();

                while (ordered == true)
                {
                    char inputLetters = (Console.ReadKey().KeyChar);
                    Console.WriteLine(""); //new line after every letters
                    score++; //increases the score for every character typed

                    if (stopwatch.Elapsed.TotalSeconds > x)
                    {
                        break;
                    }
                }
                Console.WriteLine("Out of Time. Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
                Console.WriteLine($"Score: {score}");

                stopwatch.Stop();
                Console.ReadLine();
            }

            
        }
    }  
}

//input a number e.g 10
//this number is interpreted as seconds e.g 10 seconds
//two modes
//first mode: ordered mode 
//second mode: 
//game: how many characters can you type in in the time interval
//output - number of characters 
//bonus


