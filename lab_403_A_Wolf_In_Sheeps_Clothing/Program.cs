using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_403_A_Wolf_In_Sheeps_Clothing
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] string01 = { "Mallard", "Hook Bill", "African", "Crested", "Pilgrim", "Toulouse", "Blue Swedish" };
        }

        public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
        {
            // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
            string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

            foreach (var item in birds)
            {
               
            }

            return geese;
        }
    }
}
