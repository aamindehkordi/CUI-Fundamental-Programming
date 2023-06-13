using System;

namespace BoundingErrors
{
    class Program
    {
        private const double firstRowDefaultValue = 3.14159;

        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i <= myArray.Length; i++)
            {
                myArray[i] = 0;
            }


            string[] myStrings = { "one", "two", "three" };
            myStrings[myStrings.Length] = "New Value";


            double[,] myMatrix = { { 1.1, 2.2, 3.3 }, { 4.4, 5.5, 6.6 }, { 7.7, 8.8, 9.9 } };
            for (int i = 0; i < myMatrix.Length; i++)
            {
                myMatrix[0, i] = firstRowDefaultValue;
            }

        }
    }
}
