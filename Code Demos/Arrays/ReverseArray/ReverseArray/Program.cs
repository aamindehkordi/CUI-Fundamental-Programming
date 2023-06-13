using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] myArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

            // output the array
            Console.Write("BEFORE: ");
            foreach (char c in myArray) {
                Console.Write($"{c} ");
            }
            Console.Write("\n");


            // 1. Why doesn't this work? fix it
            // 2. Rather than reverse the array, increment each value
            // 3. Only increment every other element
            // 4. Now incremnet every other element in reverse
            // 5. Print the first and last three elements
            for (int idx = 0; idx < myArray.Length; idx++)
            {
                int endIdx = myArray.Length - 1;

                char dummy = myArray[idx];
                myArray[idx] = myArray[endIdx - idx];
                myArray[endIdx - idx] = dummy;
            }


            // output the array
            Console.Write("AFTER:  ");
            foreach (char c in myArray) {
                Console.Write($"{c} ");
            }
            Console.Write("\n");
        }
    }
}
