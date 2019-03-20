using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_402_total_amount_of_point
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myStringArray = { "1:1", "2:2", "3:3", "4:4", "2:2", "3:3", "4:4", "3:3", "4:4", "4:4" };

            Console.WriteLine(TotalPoints(myStringArray));
        }

        public static int TotalPoints(string[] games)
        {
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;

            for (int i = 0; i < games.Length; i++)
            {
                char[] score = games[i].ToCharArray();

                for (int j = 0; j < score.Length; j++)
                {
                    int x = Convert.ToInt32(score[0].ToString());
                    int y = Convert.ToInt32(score[2].ToString());

                    if (x > y)
                    {
                        sum1 += 3 / 3;
                    }
                    else if (x < y)
                    {
                        sum2 += 0;
                    }
                    else if (x == y)
                    {
                        sum3 += 1;
                    }
                }
            }

            int sum = sum1 + sum2 + sum3/3;
            return sum;
        }
    }
}
