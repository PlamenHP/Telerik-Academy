//  
//      A beer time is after 1:00 PM and before 3:00 AM.
//      Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], 
//      a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time 
//      according to the definition above or invalid time if the time cannot be parsed. 
//      Note: You may need to learn how to parse dates and times.
//  
//  Examples:
//  time 	    result
//  1:00 PM 	beer time
//  4:30 PM 	beer time
//  10:57 PM 	beer time
//  8:30 AM 	non-beer time
//  02:59 AM 	beer time
//  03:00 AM 	non-beer time
//  03:26 AM 	non-beer time

namespace Namespace
{
    using System;
    using System.Globalization;
    class BeerTime
    {
        static void Main()
        {
            Console.WriteLine("A beer time is after 1:00 PM and before 3:00 AM.\n");
            Console.Write("enter a time in format hh:mm tt (4:30 PM): ");

            DateTime result;
            if (DateTime.TryParse(Console.ReadLine(), out result))
            {
                TimeSpan input = result.TimeOfDay;
                TimeSpan start = new TimeSpan(3, 0, 0);
                TimeSpan end = new TimeSpan(13, 0, 0);

                Console.WriteLine("{0}", IsBeerTime(start, end, input)? "beer time" : "non-beer time");
            }
            else
                Console.WriteLine("invalid time");
        }

        private static bool IsBeerTime(TimeSpan start, TimeSpan end, TimeSpan input)
        {
            return (input < start) || (input >= end) ;
        }
    }
}
