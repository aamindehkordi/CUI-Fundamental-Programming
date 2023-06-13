using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace speedConversionActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a speed in mph: ");
            int mph = int.Parse(Console.ReadLine());

            double convRate = 1.609344; //float = 1.609f       decimal = 1.609M
            int kph = (int)(mph * convRate);
                    // ^^ is teling the compiler "It's okay I know what I am doing"

            Console.WriteLine($"{mph}mph is {kph}kph.");
                            //^ better than (mph + "mph is " + kph "kph.")

        }
    }
}
