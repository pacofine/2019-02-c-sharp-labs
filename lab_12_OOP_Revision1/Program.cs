using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12_OOP_Revision1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            p.field = 0;
            var c = new Child();
            c.field = 0;
        }
    }

    interface IDoSomething
    {

    }

    public class Parent
    {
        //field
        public int field;
    }

    //inherit from parent
    //implement an interface
    public class Child : Parent
    {

    }

    //sealed : no more children
    sealed class GrandChild : Child
    {

    }

    
}
