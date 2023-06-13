using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            float piFloat = 3.14159f;
            float piDouble = piFloat;
            Console.WriteLine($"PI as a double, from a float: {piDouble}");
            //int piInt = piFloat; // even float to int requires an explcit cast
            //Console.WriteLine($"PI as an int, from a float: {piInt}");

            string str = "The value of PI is: " + piDouble;
            Console.WriteLine(str);

            //long x = uint.MaxValue + 1; // without explicit casting, the addition takes place before conversion, so a compile error ensues
            //uint y = x; // must be an explicit cast for this to compile
        }
    }
}
