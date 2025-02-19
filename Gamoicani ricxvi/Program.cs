using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamoicani_ricxvi
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  3.რიცხვის გამოცნობა

            Random rand = new Random();
            int randomnum = rand.Next(1, 11);
            int yournum = 0;
            int mcdeloba = 0;
            Console.WriteLine("Sheiyvanet ricxvi ertidan atamde");
            while (randomnum != yournum)
            {

                yournum = int.Parse(Console.ReadLine());
                if (yournum > randomnum)
                {
                    Console.WriteLine("Airchie ufro dabali ricxvi");
                }
                else if (yournum < randomnum)
                {
                    Console.WriteLine("Airchie ufro magali ricxvi");
                }
                else
                {
                    Console.WriteLine("Shen gamoicani!");
                    Console.WriteLine($"Pasuxi iko: {randomnum}");
                }
                mcdeloba++;
                Console.WriteLine($"Sheni mcdeloba: {mcdeloba}");
            }

        }
    }
}
