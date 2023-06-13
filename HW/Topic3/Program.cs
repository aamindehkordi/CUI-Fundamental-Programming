using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic3
{
    class Program
    {
        public static void DoublingFunction(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                input[i] = input[i] * 2;
            }
        }
        public static void Main(String[] args)
        {
            int[] input = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
            Program.DoublingFunction(input);Console.WriteLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }
        }
    }
}
