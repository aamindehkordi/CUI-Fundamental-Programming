using System;

namespace SimpleArrays
{
    /// <summary>
    /// This class contains the main entry point for the application.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int classIdNumber = 209444;
            Console.WriteLine($" -= CSC 101 {classIdNumber} =-");

            // Define an array of integers
            int[] midtermScores = { 85, 66, 75, 78, 72, 83, 88, 71, 47, 69 };

            // Print the array
            Console.WriteLine($"\nPrinting the array");
            Console.WriteLine($"These are the midterm scores:");
            Console.WriteLine($"  {midtermScores}");

            // Print the elements of the array
            Console.WriteLine($"\nPrinting elements of the array");
            Console.WriteLine($"These are the midterm scores:");
            foreach (int score in midtermScores)
            {
                //score += 10; // This line is commented out because it is not used
                Console.WriteLine($"  {score}");
            }

            // Print the elements of the array after weighting them
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