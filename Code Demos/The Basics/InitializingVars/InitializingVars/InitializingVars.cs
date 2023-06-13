using System;

namespace InitializingVars
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Int32 count  = 3; // warning because count is never used
            float  circleRadius = 1.32F;
            double totalArea;

            //totalArea = count * 3.14 * circleRadius * circleRadius; // the correct statement
            //totalArea = System.Double.NaN; // try using NaN to see hwo it affect calculations
            totalArea = Math.Round(totalArea, 2); // error because totalArea has not been assigned

            string message = "The total area of three circles of radius " + circleRadius + " is: " + totalArea;
            Console.WriteLine(message);
        }
    }
}
