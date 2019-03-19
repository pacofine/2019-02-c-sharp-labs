using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_oop
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent(); //syntactic sugar
            Parent p02 = new Parent(); //standared format
            p01.age = 10;
            p01.age = -10;
            Console.WriteLine(p01.age);

        }
    }

    class Parent
    {
        //field
        private int x;
        //prpperty
        public string Y {get; set;}
        private string ReadMeOnly { get;}
        public int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 0)
                {
                    this.age = value;
                }
            }
        }
        //
    }

    class Child : Parent
    {

    }
}
