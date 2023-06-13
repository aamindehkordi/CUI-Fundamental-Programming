using System;

namespace PrimitiveTech
{
    class PrimitiveTech
    {
        static void Main(string[] args)
        {
            //string myString = "-17"; // this causes an exception because uint.Parse cannot handle the negative number
            string myString = "17";
            uint myUint = uint.Parse(myString);
            Console.WriteLine(myUint);

            myUint = System.UInt32.MaxValue + 1; // msvc detects problem at compile time (what about run time?)
            //myUint = System.UInt32.MaxValue;
            Console.WriteLine(myUint);
            myUint = myUint + 1;
            Console.WriteLine($"{myUint} <-- woah, this should be 4294967296, right!?");

            double myDouble = System.Double.MinValue;
            Console.WriteLine($"\nThe minimum possible double is {myDouble}");
            Console.WriteLine($"The smallest possible double is {System.Double.Epsilon}\n");

            int myInt = 1 / 3; // make sure to specify floats, not ints or doubles!
            Console.WriteLine($"{myInt} <-- makes sense, an int would truncate the decimal");
            float myFloat = 1 / 3; // make sure to specify floats, not ints or doubles!
            Console.WriteLine($"{myFloat} <-- woah, what happened: 1/3 as a float, really!?");
            myDouble = 1.0 / 3.0; // 0.3333333331
            Console.WriteLine($"You should look at myDouble in the debugger");

            decimal myDecimal = 1M / 3M;
            Console.WriteLine($"{myDecimal} <-- ah, that's better\n");

            char myChar;
            for (myChar = 'A'; myChar < 'D'; myChar++) // why don't we see 'D'?
            {
                Console.Write(myChar);
            }
            Console.WriteLine();
            Console.WriteLine((char)(myChar + 32)); // what's happening here and why did we switch to lower case?

            Console.WriteLine("'D' is really " + (int)'D' + " and 'd' is really " + (int)'d');

            Console.WriteLine("\tall done\\\\");
        }
    }
}
