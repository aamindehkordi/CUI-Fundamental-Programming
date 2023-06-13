using System;



namespace ToInfiniteAndBeyond
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = 1, zero = 0;

            //Console.WriteLine($"1   / 0   = {1 / 0}\n"); this won't even compile
            //Console.WriteLine($"1   / 0   = {one / zero}\n");
            Console.WriteLine($"1   / 0.0 = {1 / 0.0}\n");
            Console.WriteLine($"0.0 / 0.0 = {0.0 / 0.0}\n");
            Console.WriteLine($"TO INFINITE AND BEYOND! {Single.NegativeInfinity}");
        }
    }
}
