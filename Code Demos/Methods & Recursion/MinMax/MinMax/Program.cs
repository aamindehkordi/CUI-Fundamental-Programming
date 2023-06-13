using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMax
{
    class Program
    {
        static int Min(int a, int b)
        {
            if (a < b) {
                return a;
            } else {
                return b;
            }
        }

        static double Min(double a, double b)
        {
            if (a < b) {
                return a;
            } else {
                return b;
            }
        }

        static string Min(string a, string b)
        {
            if (string.Compare(a, b) < 0) {
                return a;
            } else {
                return b;
            }
        }

        // This is another way to write a short function, it is optional and rarely used
        static int Max(int a, int b) => a > b ? a : b;
        static double Max(double a, double b) => a > b ? a : b;

        static string Max(string a, string b)
        {
            return (string.Compare(a, b) > 0 ? a : b);
        }


        static void Main(string[] args)
        {
            Console.WriteLine($"Min(5, 7)=            {Min(5, 7)}");
            Console.WriteLine($"Min('Zack', 'Aaron')= {Min("Zack", "Aaron")}");
        }
    }
}
