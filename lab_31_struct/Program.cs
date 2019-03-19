using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_31_struct
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class x { }

    struct Point
    {
        public int x;
        public int y;

        //constructor 
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
