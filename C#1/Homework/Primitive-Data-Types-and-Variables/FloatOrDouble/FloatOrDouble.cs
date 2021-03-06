﻿//Problem 2. Float or Double?
//
//    Which of the following values can be assigned to a variable of type 
//    float and which to a variable of type double: 
//    34.567839023, 12.345, 8923.1234857, 3456.091?
//    Write a program to assign the numbers in variables and print them to ensure no precision is lost.


using System;
using System.Collections.Generic;

namespace FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main()
        {
            List<object> digits = new List<object>();
            digits.Add(double.Parse("34.567839023"));
            digits.Add(float.Parse("12.345"));
            digits.Add(double.Parse("8923.1234857"));
            digits.Add(float.Parse("3456.091"));

            foreach (var digit in digits)
            {
                Console.WriteLine("{0,-10} [{1,15}]",digit.GetType(), digit);
            }
        }
    }
}
