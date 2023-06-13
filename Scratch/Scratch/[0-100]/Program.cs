using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_100_
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean x = true;
            while (x)
            {
                Console.Write("Type a Number [0-10]: ");
                String answer = Console.ReadLine();
                //int myNum = int.Parse(answer);

                switch (answer)
                {
                    case "0":
                        Console.WriteLine("zero");
                        break;
                    case "1":
                        Console.WriteLine("one");
                        break;
                    case "2":
                        Console.WriteLine("two");
                        break;
                    case "3":
                        Console.WriteLine("three");
                        break;
                    case "4":
                        Console.WriteLine("four");
                        break;
                    case "5":
                        Console.WriteLine("five");
                        break;
                    case "6":
                        Console.WriteLine("six");
                        break;
                    case "7":
                        Console.WriteLine("seven");
                        break;
                    case "8":
                        Console.WriteLine("eight");
                        break;
                    case "9":
                        Console.WriteLine("nine");
                        break;
                    case "10":
                        Console.WriteLine("ten");
                        break;

                    default:
                        Console.WriteLine($"I don't think that \"{answer}\" " +
                                           "means what you think it means");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
