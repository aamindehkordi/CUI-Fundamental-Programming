using System;

namespace LeapYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leap years this millennium:");
            for (int year = 2000; year <= 3000; year += 4)
            {
                if (year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine($"  {year}");
                }
            }
        }
    }
}
