//Problem 12. Null Values Arithmetic
//
//    Create a program that assigns null values to an integer and to a double variable.
//    Try to print these variables at the console.
//    Try to add some number or the null literal to these variables and print the result.


namespace NullValuesArithmetic
{
    using System;
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? someInteger = null;
            double? someDouble = null;

            Console.WriteLine("integer with null value:[" + someInteger + "]  double with null value:[" + someDouble + "]");

            someInteger = 22;
            someDouble = 83.5;

            Console.WriteLine("integer with 22 as value:[" + someInteger + "]  double with 83.5 as value:[" + someDouble + "]");
        }
    }
}
