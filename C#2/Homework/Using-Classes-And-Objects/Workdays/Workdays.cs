//  Problem 5. Workdays
//  
//      Write a method that calculates the number of workdays between today
//      and given date, passed as parameter.
//      Consider that workdays are all days from Monday to Friday 
//      except a fixed list of public holidays specified preliminary as array.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Workdays
    {
        private static DateTime[] publicHolidays = new DateTime[] {new DateTime(2016,06,01),
                                                                   new DateTime(2016,06,02),
                                                                   new DateTime(2016,06,03)};

        static void Main()
        {
            DateTime givenDate = new DateTime(2016, 07, 01);
            DateTime today = new DateTime(DateTime.Today.Year,                
                                          DateTime.Today.Month,
                                          DateTime.Today.Day);

            int workdays = CountWorkdays(today,givenDate);
            Console.WriteLine("from today:{0} to:{1} there is {2} workdays",
                               today.ToShortDateString(),
                               givenDate.ToShortDateString(),
                               workdays);
        }

        private static int CountWorkdays(DateTime from, DateTime to)
        {
            if (to<from)
            {
                throw new ArgumentException("The given date should be later than today");
            }

            var totalDays = 0;
            for (var date = from; date < to; date = date.AddDays(1))
            {
                if (date.DayOfWeek != DayOfWeek.Saturday &&
                    date.DayOfWeek != DayOfWeek.Sunday &&
                    !publicHolidays.Contains(date))
                {
                    totalDays++;
                }
            }
            return totalDays;
        }
    }
}
