using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_16_NUnit_XUnit_Tests
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class TestMenow
    {
        public double TestThisMethodWorks(double x, double y, int p)
        {
            //2, 3, 3 ==> (2*3)=6 and raises this to the power 3 ie 36*6=216
            return Math.Pow((x*y),p);
        }
    }
}
