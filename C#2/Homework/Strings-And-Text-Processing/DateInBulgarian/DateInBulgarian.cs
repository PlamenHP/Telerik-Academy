//  Problem 17. Date in Bulgarian
//  
//      Write a program that reads a date and time given in the format: 
//  day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes(in the same format) along with the day of week in Bulgarian.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    class DateInBulgarian
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string format = "d.M.yyyy HH:mm:ss";
            DateTime date = new DateTime();
            
            try
            {
                date = DateTime.ParseExact(input, format, CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                Console.WriteLine("invalid date format");
            }

            date = date.AddHours(6).AddMinutes(30);
            var culture = CultureInfo.CreateSpecificCulture("bg-BG");
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("date + 6hr + 30min = {0} day of week:{1}",date,date.ToString("ddddd", culture));
        }
    }
}
