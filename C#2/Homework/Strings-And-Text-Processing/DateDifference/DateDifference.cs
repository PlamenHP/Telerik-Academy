//  Problem 16. Date difference
//  
//      Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//  
//  Example:
//  
//  Enter the first date: 27.02.2006
//  Enter the second date: 3.03.2006
//  Distance: 4 days


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class ProgramDateDifference
    {
        private static CultureInfo provider = CultureInfo.InvariantCulture;
        private static string format;
        private static string inputDate1, inputDate2;
        private static DateTime date1 ;
        private static DateTime date2 ;

        static void Main()
        {
            inputDate1 = ReadInput();
            date1 = ParseDate(inputDate1);

            inputDate2 = ReadInput();       
            date2 = ParseDate(inputDate2);
            Console.WriteLine("Distance {0} days", (date2 - date1).Days);

        }
        private static DateTime ParseDate(string inputDate)
        {
            format = "d.M.yyyy";
            DateTime result = new DateTime();   
                
            try
            {
                result =  DateTime.ParseExact(inputDate, format, provider);
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not in the correct format.", inputDate);
            }
            return result;
        }
        private static string ReadInput()
        {
            Console.WriteLine("enter date in the format: day.month.year");
            return Console.ReadLine();
        }
    }
}
