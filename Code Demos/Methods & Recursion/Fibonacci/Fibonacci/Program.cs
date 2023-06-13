using System;

namespace Fibonacci
{

    class Program
    {
        static int IterativeFibonacci(int degree)
        {
            int fibonacci = 1;
            int n2 = 1, n1 = 1;
            for (int i = 3; i <= degree; i++)
            {
                n2 = n1;
                n1 = fibonacci;
                fibonacci = n2 + n1;
            }
            return fibonacci;
        }


        static int RecursiveFibonacci(int degree)
        {
            if (degree <= 2) {
                return 1;
            }

            return RecursiveFibonacci(degree - 1) + RecursiveFibonacci(degree - 2);
        }



        static void Main(string[] args)
        {
            int degree = 6;
            if (args.Length > 0)
            {
                degree = int.Parse(args[0]);
            }

            Console.WriteLine($"The fibonacci sequence to degree {degree} is {IterativeFibonacci(degree)}");
            Console.WriteLine($"The fibonacci sequence to degree {degree} is {RecursiveFibonacci(degree)}");
        }
    }
}
