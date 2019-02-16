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
                "Sebastian",
                "Nadi",
                "Michael",
                "Maiwand",
                "Amira",
                "Anisha",
                "Adam",
                "Jacob",
                "Tyrone",
                "Luke",
                "Sam",
                "JDarren"
            };

            List<String> lastName = new List<string>()
            {
                "Rodriguez",
                "Adem",
                "Wright",
                "Hussain",
                "Shah",
                "Mallikaratchy",
                "Goddard",
                "Little",
                "Nembhard",
                "Dawes",
                "Bowdem-Williams",
                "Montesdeoca"
            };

            List<int> age = new List<int>()
            {
                23,
                27,
                22,
                23,
                24,
                23,
                23,
                22,
                27,
                25,
                26,
                24
            };

            var permutations = new List<Tuple<int, int, int>>();
            List<string> people = new List<string>();

            Random random = new Random();
            int a, b, c;

            //We want to generate 500 names.
            while (permutations.Count < 50)
            {
                a = random.Next(0, firstName.Count);
                b = random.Next(0, lastName.Count);
                c = random.Next(0, age.Count);

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
                                                        age[tuple.Item3])
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



