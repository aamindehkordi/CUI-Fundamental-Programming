using System;

namespace Fibonacci
{
    /// <summary>
    /// This class contains the main entry point for the application.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Calculates the nth Fibonacci number iteratively.
        /// </summary>
        /// <param name="degree">The degree of the Fibonacci number to calculate.</param>
        /// <returns>The nth Fibonacci number.</returns>
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

        /// <summary>
        /// Calculates the nth Fibonacci number recursively.
        /// </summary>
        /// <param name="degree">The degree of the Fibonacci number to calculate.</param>
        /// <returns>The nth Fibonacci number.</returns>
        static int RecursiveFibonacci(int degree)
        {
            if (degree <= 2)
            {
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