using System;

namespace SimpleArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int classIdNumber = 209444;
            Console.WriteLine($" -= CSC 101 {classIdNumber} =-");

            int[] midtermScores = { 85, 66, 75, 78, 72, 83, 88, 71, 47, 69 };
            Console.WriteLine($"\nPrinting the array");
            Console.WriteLine($"These are the midterm scores:");
            Console.WriteLine($"  {midtermScores}");


            Console.WriteLine($"\nPrinting elements of the array");
            Console.WriteLine($"These are the midterm scores:");
            foreach (int score in midtermScores)
            {
                //score += 10;
                Console.WriteLine($"  {score}");
            }


            Console.WriteLine($"\nPrinting elements of the array");
            Console.WriteLine($"These are the weighted midterm scores:");
            for (int i = 0; i < midtermScores.Length; i++)
            {
                midtermScores[i] = (int)Math.Round(1.1 * midtermScores[i], 0);
                Console.WriteLine($"  Student #{i + 1,-2}: {midtermScores[i]:N0}");
            }

        }
    }
}
