using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_04_array
{
    public class Array
    {
        public int CreateArray()
        {
            int[] myArray = new int[10];
            //insert squares
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = i * i;
                Console.WriteLine(myArray[i]);
            }
            
            //check values
            int total = 0;
            foreach (var i in myArray)
            {
                total += i;
                Console.WriteLine(i);
                Console.WriteLine(total);
            }
            return total;
        }
    }
}
