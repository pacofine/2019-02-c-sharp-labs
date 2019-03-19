using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_13_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Parent
    {
        //method
        void doThis()
        {

        }
        
        //can override
        public virtual void doThat() //if the this method is marked as vitual then it can be overridden within a child class
        {

        }
    }

    class Child1 : Parent
    {
        //can override parent method : polymorphism
        public override void doThat()
        {
            base.doThat();
        }
    }

    class Child2 : Parent
    {
        //can override parent method : polymorphism
        public override void doThat()
        {
            base.doThat();
        }
    }

    class Child3 : Parent
    {
        //can override parent method : polymorphism
        public override void doThat()
        {
            base.doThat();
        }
    }
}
