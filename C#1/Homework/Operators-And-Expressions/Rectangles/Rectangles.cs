// Problem 4. Rectangles
// 
//     Write an expression that calculates rectangle’s perimeter and area by given width and height.
// 
// Examples:
// width 	height 	perimeter 	area
// 3 	    4     	14      	12
// 2.5 	    3    	11       	7.5
// 5 	    5 	    20      	25

namespace Rectangles
{
    using System;
    class Rectangles
    {
        static void Main()
        {
            Console.Write("enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("enter height: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("perimeter:{0} area:{1}", (width+height)*2, width*height);
        }
    }
}
