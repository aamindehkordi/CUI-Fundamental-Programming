using System;


namespace Scratch
{
    class Program
    {
        static string Add(out int sum, int a, int b)
        {
            sum = a + b;

            return "Function completed successfully";
        }

        static void Main(string[] args)
        {
            int sum = 0;

            // I wouldn't do it this way, but it does demonstrate how to use output parameters
            Console.WriteLine($"{Add(out sum, 5, 3)}: the sum of 5 + 3 = {sum}");
        }
    }
}