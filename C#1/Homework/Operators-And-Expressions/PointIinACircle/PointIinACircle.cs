//  Problem 7. Point in a Circle
//  
//      Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
//  
//  Examples:
//  x   	y 	  inside
//  0   	1 	  true
//  -2   	0     true
//  -1   	2 	  false
//  1.5    -1 	  true
//  -1.5   -1.5   false
//  100    -30    false
//  0 	    0     true
//  0.2 	-0.8  true
//  0.9 	-1.93 false
//  1    	1.655 true

namespace Namespace
{
    using System;
    class PointIinACircle
    {
        static void Main()
        {
            Console.Write("enter number for X coordinate: ");
            double pointX = double.Parse(Console.ReadLine());
            Console.Write("enter number for Y coordinate: ");
            double pointY = double.Parse(Console.ReadLine());
            double circleCentreX = 0, circleCentreY = 0, circleRadius = 2;

            if ((Math.Pow((pointX - circleCentreX), 2) + Math.Pow((pointY - circleCentreY),2)) <= Math.Pow(circleRadius,2))
            {
                Console.WriteLine("point is in circle: true");
            }
            else
            {
                Console.WriteLine("point is in circle: false");
            }
        }
    }
}
