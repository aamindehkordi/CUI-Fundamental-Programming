using System;
using MathPoints;

namespace UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            CartesianPoint pointA = new CartesianPoint(1.0, 2.5);
            CartesianPoint pointB = new CartesianPoint(3.0, -7.42);

            Console.WriteLine($"Point A = {pointA} has magnitude {pointA.Magnitude()}");
            Console.WriteLine($"Point B = {pointB} has magnitude {pointB.Magnitude()}");
            Console.WriteLine($"They are {CartesianPoint.DistanceBetween(pointA, pointB):N2} apart");
        }
    }
}
