using System;

namespace BoundingErrors
{
    /// <summary>
    /// This class contains the main entry point for the application.
    /// </summary>
    class Program
    {
        // Define a constant value for the first row of the matrix
        private const double firstRowDefaultValue = 3.14159;

        static void Main(string[] args)
        {
            // Define an array of integers
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Loop through the array and set each element to 0
            for (int i = 0; i <= myArray.Length; i++)
            {
                myArray[i] = 0; // This line will throw an IndexOutOfRangeException
            }

            // Define an array of strings
            string[] myStrings = { "one", "two", "three" };

            // Attempt to set the value of an element that is out of range
            myStrings[myStrings.Length] = "New Value"; // This line will throw an IndexOutOfRangeException

            // Define a 2D array of doubles
            double[,] myMatrix = { { 1.1, 2.2, 3.3 }, { 4.4, 5.5, 6.6 }, { 7.7, 8.8, 9.9 } };

            // Loop through the first row of the matrix and set each element to the default value
            for (int i = 0; i < myMatrix.Length; i++)
            {
                myMatrix[0, i] = firstRowDefaultValue;
            }
        }
    }
}
