using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Planets
{
    class Planet
    {
        private readonly string name;
        private readonly double mass;
        private readonly double radius;
        public static double g; //universal gravitational constant
        public static double newtonToPoundsConversion;
        public Planet(string tmpName, double tmpMass, double tmpRadius)
        {
            g = 0;//6.674083131313131313 * 10 ^ -11;    <------- it's not working so i j put 0

            name = tmpName;
            mass = tmpMass;
            radius = tmpRadius;
        }

        public double GetWeight(double tmpWeight)
        {
            g = 6.67 * (Math.Pow(10, -11));
            double newtons = (g * tmpWeight * mass) / Math.Pow(radius, 2);
            newtonToPoundsConversion = 0.224808943;
            double result = newtons * newtonToPoundsConversion;
            return result;

        }

        public override string ToString()
        {
            return $"{name}, {mass}kg, {radius}m";
        }
    }
}
