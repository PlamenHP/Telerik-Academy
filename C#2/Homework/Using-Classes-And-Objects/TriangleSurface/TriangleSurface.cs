//  Problem 4. Triangle surface
//  
//      Write methods that calculate the surface of a triangle by given:
//          Side and an altitude to it;
//          Three sides;
//          Two sides and an angle between them;
//      Use System.Math.
//  
//  Example:
//  input                       output
//  * a = 23.2, h = 5       	58
//  * a = 11, b = 12, c = 13 	61.48
//  * a = 10, b = 7, C = 25° 	14.79

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class TriangleSurface
    {
        static void Main()
        {
            Console.WriteLine("{0:f2}", TriangleAreaBySideAndAltitude(23.2, 5));
            Console.WriteLine("{0:f2}",TriangleAreaByThreeSides(11, 12, 13));
            Console.WriteLine("{0:f2}",TriangleAreaByTwoSidesAndAngle(10, 7, 25));
        }

        private static double TriangleAreaBySideAndAltitude(double a, double h)
        {
            double area = (a*h)/2;
            return area;
        }

        private static double TriangleAreaByThreeSides(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        private static double TriangleAreaByTwoSidesAndAngle(double a, double b, double angle)
        {
            double area = (a*b*Math.Sin(Math.PI/180*angle))/2;
            return area;
        }
    }
}
