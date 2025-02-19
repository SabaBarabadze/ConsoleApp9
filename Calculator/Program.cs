using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {


         //    1. კალკულატორი
            int val;
            do
            {
                Console.WriteLine("Sheiyvanet pirveli ricxvi");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Sheiyvanet Shemdegi ricxvi");
                int num2 = int.Parse(Console.ReadLine());


                Console.WriteLine("1.Mimateba");
                Console.WriteLine("2.Gamokleba");
                Console.WriteLine("3.Gayofa");
                Console.WriteLine("4.Gamravleba");

                Console.WriteLine("Airchiet moqmedeba");
                string res = Console.ReadLine();

              //  სვიჩ ქეისით ვაკეთებთ კალკულატორის მეინიუს
                switch (res)
                {
                    case "1":
                        Console.WriteLine($"Shedegi {num1 + num2}");
                        break;

                    case "2":
                        Console.WriteLine($"Shedegi {num1 - num2}");
                        break;

                    case "3":
                        if (num2 != 0)
                            Console.WriteLine($"Shedegi {num1 / num2}");
                        break;

                    case "4":
                        Console.WriteLine($"Shedegi {num1 * num2}");
                        break;

                    default:
                        break;
                }
              //  რათა განმეორდეს ისევ
                Console.WriteLine("Gsurt gagrdzeleba?");
                Console.WriteLine("1.Ki");
                Console.WriteLine("2.ara");
                val = int.Parse(Console.ReadLine());
            } while (val == 1);
        }
    }
}
