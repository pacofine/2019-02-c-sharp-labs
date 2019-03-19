using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_17_Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting app");
#if DEBUG
            Console.WriteLine("This is a debug app");
#endif
            Console.WriteLine("Finishing app");

#if SEBTEST
            Console.WriteLine("This is Seb Testing");
#endif
            Console.WriteLine("Finishing app");
        }
    }
}
