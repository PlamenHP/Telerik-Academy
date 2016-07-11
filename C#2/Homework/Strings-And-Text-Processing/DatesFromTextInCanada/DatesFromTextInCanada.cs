//   Problem 19. Dates from text in Canada
//   
//       Write a program that extracts from a given text all dates that match the
//       format DD.MM.YYYY.
//       Display them in the standard date format for Canada.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    class DatesFromTextInCanada
    {
        static void Main()
        {
            StringBuilder input = new StringBuilder();
            string line;

            while ((line = Console.ReadLine())!="")
            {
                input.Append(line);
            }

            Regex regex = new Regex("[0-9]{1,2}.[0-9]{1,2}.[0-9]{4}");

            MatchCollection dates = regex.Matches(input.ToString());

            var culture = CultureInfo.CreateSpecificCulture("en-CA");
            foreach (var item in dates)
            {
                Console.WriteLine("{0}",DateTime.Parse(item.ToString(),culture).ToShortDateString());
            }
        }
    }
}
