//Problem 13.* Comparing Floats
//    
//    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//    
//    Note: Two floating-point numbers a and b cannot be compared directly by a == b because of 
//    the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if
//    they are more closely to each other than a fixed constant eps.
//    
//    Examples:                    Equal
//                              (with precision 
//     Number a 	 Number b     eps=0.000001) Explanation
//     5.3 	         6.01     	   false 	    The difference of 0.71 is too big (> eps)
//     5.00000001    5.00000003    true 	    The difference 0.00000002 < eps
//     5.00000005    5.00000001    true 	    The difference 0.00000004 < eps
//    -0.0000007     0.00000007    true 	    The difference 0.00000077 < eps
//    -4.999999     -4.999998 	   fals         Border case. The difference 0.000001 == eps. We consider the numbers are different.
//     4.999999 	 4.999998 	   false 	    Border case. The difference 0.000001 == eps. We consider the numbers are different.

namespace ComparingFloats
{
    using System;
    class ComparingFloats
    {
        static void Main()
        {
            double firstNumber = 0;
            double secondNumber = 0;

            Console.Write("Enter a floating point number like [1.234567]: ");
            firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Enter a second floating point number: ");
            secondNumber = double.Parse(Console.ReadLine());

            bool equal = CompareFloats(firstNumber,secondNumber);
            string result = equal ? "The float values ARE EQUAL" : "The float values are NOT EQUAL";
            Console.WriteLine("\n {0} to the precision eps = 0.000001",result);
        }

        public static bool CompareFloats(double value1, double value2, double precision = 0.000001)
        {
            if (value1 != value2)
            {
                double substractionResult = (Math.Abs(value1)) - (Math.Abs(value2));
                bool equal = substractionResult < precision;
                return (equal);
            }
            return true;
        }
    }
}
