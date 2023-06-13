using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Program
    {
        public static void Main(string[] args)
        {
            Planet p1 = new Planet("Earth", 5.97e24, 6.38e6);
            double w1 = p1.GetWeight(90);
            Console.WriteLine($"{p1},\n{w1} ");
        }
    }
}
