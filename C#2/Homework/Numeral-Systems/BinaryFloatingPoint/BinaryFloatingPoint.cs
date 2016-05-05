//  Problem 9.* Binary floating-point
//  
//      Write a program that shows the internal binary representation of
//      given 32-bit signed floating-point number in IEEE 754 format(the C# type float).
//  
//  Example:
//  number   sign       exponent    mantissa
//  -27,25   	1   	10000011 	10110100000000000000000

namespace Namespace
{
    using System;

    class BinaryFloatingPoint
    {
        unsafe static void Main()
        {
            Console.WriteLine("Enter float number");
            float number = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.CurrentCulture);

            //number = -27.25f;
            void* numberPointer = &number;
            string numberBinary = Convert.ToString(*(int*)numberPointer, 2);
            string sign = numberBinary.Substring(0,1);
            string exponent = numberBinary.Substring(1,8);
            string mantissa = numberBinary.Substring(9, 20);

            Console.WriteLine("number: {0}", number);
            Console.WriteLine("sign: {0} exponent: {1} mantissa: {2}",sign, exponent, mantissa);
        }
    }
}
