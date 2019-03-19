using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_400_String_Ends_With
{
    class Program
    {
        //Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

        public static void Main(string[] args)
        {
            Console.WriteLine("type a word");
            string text1 = Console.ReadLine();

            Console.WriteLine("type the last two letters of that word word");
            string text2 = Console.ReadLine();

            Console.WriteLine(EndIn(text1, text2));
        }

        public static string EndIn(string text1, string text2)
        {
            return text1.EndsWith(text2) ? "true" : "false";
        }
    }
}
