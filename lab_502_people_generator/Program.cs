using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_103_randomPeopleGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstName = new List<string>()
            {
                "Sebastian", "Nadi", "Michael", "Maiwand", "Amira", "Anisha", "Adam", "Jacob", "Tyrone", "Luke", "Sam", "JDarren"
            };

            List<String> lastName = new List<string>()
            {
                "Rodriguez", "Adem","Wright","Hussain", "Shah","Mallikaratchy","Goddard","Little","Nembhard","Dawes","Bowdem-Williams","Montesdeoca"
            };

            List<int> age_year = new List<int>();
            List<int> age_month = new List<int>();
            List<int> age_day = new List<int>();

            for (int DOB = 3; DOB < 7; DOB++)
            {
                age_year.Add(2000 - DOB);
            }

            for (int DOB = 3; DOB < 7; DOB++)
            {
                age_month.Add(2000 - DOB);
            }

            for (int DOB = 3; DOB < 7; DOB++)
            {
                age_day.Add(2000 - DOB);
            }
            
            var permutations = new List<Tuple<int, int, int>>();
            List<string> people = new List<string>();

            Random random = new Random();
            int a, b, c;

            //We want to generate 500 names.
            while (permutations.Count < 50)
            {
                a = random.Next(0, firstName.Count);
                b = random.Next(0, lastName.Count);
                c = random.Next(0, age_year.Count);

                Tuple<int, int, int> tuple = new Tuple<int, int, int>(a, b, c);

                if (!permutations.Contains(tuple))
                {
                    permutations.Add(tuple);
                }
            }

            foreach (var tuple in permutations)
            {
                people.Add(string.Format("{0} {1} {2}", firstName[tuple.Item1],
                                                        lastName[tuple.Item2],
                                                        age_year[tuple.Item3])
                );
            }

            foreach (var n in people)
            {
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }

    }
    
}



