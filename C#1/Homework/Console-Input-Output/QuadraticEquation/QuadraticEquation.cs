//  Problem 6. Quadratic Equation
//  
//      Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//  
//  Examples:
//  a 	  b 	c 	roots
//  2 	  5 	-3 	x1=-3; x2=0.5
//  -1 	  3 	0 	x1=3; x2=0
//  -0.5  4 	-8 	x1=x2=4
//  5 	  2 	8 	no real roots

namespace Namespace
{
    using System;
    class QuadraticEquation
    {
        static void Main()
        {
            Console.Write("enter coefficient a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("enter coefficient b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("enter coefficient c: ");
            double c = double.Parse(Console.ReadLine());
            double x1 = double.NaN;
            double x2 = double.NaN;

            SolveQuadratic(a, b, c, out  x1, out x2);
            if (double.IsNaN(x1))
            {
                Console.WriteLine("no real roots");
            }
            else if (x1 == x2)
            {
                Console.WriteLine("x1=x2={0}",x1);
            }
            else
            {
                Console.WriteLine("x1={0};  x2={1}",x1,x2);
            }
        }
        public static void SolveQuadratic(double a, double b, double c, out double x1, out double x2)
        {
            //Quadratic Formula: x = (-b +- sqrt(b^2 - 4ac)) / 2a

            //Calculate the inside of the square root
            double insideSquareRoot = (b * b) - 4 * a * c;

            if (insideSquareRoot < 0)
            {
                //There is no solution
                x1 = double.NaN;
                x2 = double.NaN;
            }
            else
            {
                //Compute the value of each x
                //if there is only one solution, both x's will be the same
                double sqrt = Math.Sqrt(insideSquareRoot);
                x1 = (-b - sqrt) / (2 * a);
                x2 = (-b + sqrt) / (2 * a);
            }
        }
    }
}
