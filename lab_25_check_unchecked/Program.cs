using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_25_check_unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(int.MaxValue);
            int x = int.MaxValue;
            Console.WriteLine(++x);
            int y = 400000000;
            int z = y + y;
            Console.WriteLine(z);

            //integers are not checked for overflow because cpu is intensive

            //explicitly checked for overflow
            checked
            {
                int a = int.MaxValue;
                //Console.WriteLine(++a);
            }

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(double.MaxValue);
        }
    }
}
