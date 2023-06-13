using System;

namespace ComplexVars
{
    class ComplexVars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A bunch of messy variables:");
            decimal pt1_x = 12.5e-12M;
            decimal pt1_y = 1.3M;
            Console.WriteLine("  (" + pt1_x + ", " + pt1_y + ")");
            decimal pt2_x = -6;
            decimal pt2_y = 103;
            Console.WriteLine("  (" + pt2_x + ", " + pt2_y + ")\n");


            Console.WriteLine("Using objects (complex variables):");
            Point pt1 = new Point(7, -15);
            Point pt2 = new Point(0, 0);
            pt2.y = 150;
            Console.WriteLine($"  {pt1}");
            Console.WriteLine($"  {pt2.y}");
        }


        class Point // <-- notice the name of the class
        {
            private decimal _x, _y;            // <-- "private" means that programmers who use our class cannot access these variables directly

            public Point(decimal x, decimal y) // <-- this function has the same exact name, it's called "The Constructor"
            {
                _x = Math.Abs(x) % 100;        // <-- we chose to initialize _x and _y, but it's not required
                _y = Math.Abs(y) % 100;
            }

            public decimal x                    // <-- we create these "getter" and "setter" functions to access the private variables
            {
                get { return _x; }
                set { _x = Math.Abs(value) % 100; }
            }

            public decimal y
            {
                get { return _y; }
                set { _y = Math.Abs(value) % 100; }
            }

            public override string ToString()   // <-- this is a special function name that is used when you call Console.WriteLine
            {
                return $"({_x}, {_y})";
            }
        }
    }
}
