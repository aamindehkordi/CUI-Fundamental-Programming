using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("This program will sum the numbers [0,n]");
            Console.Write("Please input the value n: ");
            int lastNumber = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 0; i <= lastNumber; i++)
            {
                sum += i;
            }

            Console.WriteLine($"The sum [0,{lastNumber}] is {sum}");
        }
    }
}
