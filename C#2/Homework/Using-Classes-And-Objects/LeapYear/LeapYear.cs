//  Problem 1. Leap year
//  
//      Write a program that reads a year from the console and checks whether it is a leap one.
//      Use System.DateTime.

namespace Namespace
{
    using System;

    class LeapYear
    {
        static void Main()
        {
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}", System.DateTime.IsLeapYear(year)?"Leap":"Common"); 
        }
    }
}
