using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BottlesOfMilk
{
    class Program
    {
        static void Main()
        {
            string drink = "milk"; // of course
            for (int bottles = 99; bottles > 0; bottles--)
            {
                Console.WriteLine($"{bottles} bottles of {drink} " + 
                    $"on the wall, {bottles} bottles of {drink}, take one " +
                    $"down and pass it around, {bottles-1} bottles of " +
                    $"{drink} on the wall.");
            }
        }
    }
}
