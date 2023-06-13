using System;

namespace VarsInMemory
{
    class VarsInMemory
    {
        static void Main(string[] args)
        {
            int celcius = 100; // run this through the debugger, showing the watch and memory windows
            int fahrenheit = celcius * 9 / 5 + 32;

            string message1 = $"Water boils at {fahrenheit} degrees fahrenheit";
            string message2 = "Water boils at " + fahrenheit + " degrees fahrenheit";
            string message3 = "Water boils at ";
            message3 += fahrenheit;
            message3 = " degrees fahrenheit";

            Console.WriteLine(message1);
            Console.WriteLine(message2);
            Console.WriteLine(message3);
        }
    }
}
