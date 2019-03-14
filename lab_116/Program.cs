using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_116
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 10;
            var y = 0;

            try
            {
                try
                {
                    var z = x / y;
                    throw new Exception("\nthis is a seriouse error, fix it!!\n");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"Division of {0} by zero.");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("\n\they - thrown exception has been fixed\n.");
            }
            finally
            {
                Console.WriteLine("\nall done");
            }
        }
    }
}
