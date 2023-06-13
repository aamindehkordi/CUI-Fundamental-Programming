using System;

namespace ExploringScope
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int cnt = 0; cnt < 10; cnt++)
            {
                //float ten = float.Parse("10.34");
                int ten = int.Parse("10.34"); // throws an exception because 10.34 is not an integer
            }
            Console.WriteLine(ten); // the variable ten is out of scope
        }
    }
}
