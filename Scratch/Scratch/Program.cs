using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your third number: ");
            int z = int.Parse(Console.ReadLine());

            if(x > y && x > z)
            {
                Console.WriteLine($"Your biggest number is {x}");
                if(y > z)
                {
                    Console.WriteLine($"Your second largest number is {y}");
                    Console.WriteLine($"Your smallest number is {z}");
                }
                else
                {
                    Console.WriteLine($"Your second largest number is {z}");
                    Console.WriteLine($"Your smallest number is {y}");
                }            
            }
            if (y > x && y > z)
            {
                Console.WriteLine($"Your biggest number is {y}");
                if (x > z)
                {
                    Console.WriteLine($"Your second largest number is {x}");
                    Console.WriteLine($"Your smallest number is {z}");
                }
                else
                {
                    Console.WriteLine($"Your second largest number is {z}");
                    Console.WriteLine($"Your smallest number is {x}");
                }
            }
            if (z > y && x < z)
            {
                Console.WriteLine($"Your biggest number is {z}");
                if (y > x)
                {
                    Console.WriteLine($"Your second largest number is {y}");
                    Console.WriteLine($"Your smallest number is {x}");
                }
                else
                {
                    Console.WriteLine($"Your second largest number is {x}");
                    Console.WriteLine($"Your smallest number is {y}");
                }
            }
        }
    }
}
