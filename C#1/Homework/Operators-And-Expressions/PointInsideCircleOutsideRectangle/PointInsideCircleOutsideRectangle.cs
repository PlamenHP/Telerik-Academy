//    Problem 10. Point Inside a Circle & Outside of a Rectangle
//    
//        Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
//        and out of the rectangle R(top=1, left=-1, width=6, height=2).
//    
//    Examples:
//    x 	y 	inside K & outside of R
//    1 	2 	    yes
//    2.5 	2 	    no
//    0 	1       no
//    2.5 	1 	    no
//    2 	0 	    no
//    4 	0 	    no
//    2.5 	1.5 	no
//    2 	1.5 	yes
//    1 	2.5 	yes
//    -100 	-100 	no

namespace Namespace
{
    using System;
    class PointInsideCircleOutsideRectangle
    {
        static void Main()
        {
            Console.Write("enter number for X coordinate: ");
            double pointX = double.Parse(Console.ReadLine());
            Console.Write("enter number for Y coordinate: ");
            double pointY = double.Parse(Console.ReadLine());
            double circleCentreX = 1, circleCentreY = 1, circleRadius = 1.5;
            double recTop = 1, recLeft = -1, recWidth = 6, recHeight = 2;
            bool inCircle = false;
            bool outOfRectangle = false;

            inCircle = ((Math.Pow((pointX - circleCentreX), 2) +
                         Math.Pow((pointY - circleCentreY), 2)) <=
                         Math.Pow(circleRadius, 2)) ? true : false;

            outOfRectangle = ((recLeft < pointX) && (pointX < (recLeft + recWidth)) &&
                              (recTop > pointY) && (pointY > (recTop - recHeight))) ? false : true;

            Console.WriteLine("point is in circle and out of rectangle?: {0}", inCircle && outOfRectangle ? "yes" : "no");
        }
    }
}
