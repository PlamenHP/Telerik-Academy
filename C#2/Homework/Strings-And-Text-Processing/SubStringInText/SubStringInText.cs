//  Problem 4. Sub-string in text
//  
//      Write a program that finds how many times a sub-string is contained in a given text(perform case insensitive search).
//  
//  Example:
//  
//  The target sub-string is in
//  
//  The text is as follows: We are living in an yellow submarine.We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//  
//  The result is: 9

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;
    class SubStringInText
    {
        static void Main()
        {
            string substring = Console.ReadLine();
            string text = Console.ReadLine();

            Console.WriteLine(SubstringCountV2(text,substring));
        }

        private static int SubstringCountV1(string text, string substring)
        {
            return Regex.Matches(text,substring).Count;
        }

        private static int SubstringCountV2(string text, string substring)
        {
            int count = 0;
            int index = text.IndexOf(substring, 0);
            while (index != -1)
            {
                count++;
                index = text.IndexOf(substring, index+substring.Length);
            }
            return count;
        }

        private static int SubstringCountV3(string text, string substring)
        {
            int length = text.Length - (substring.Length-1);
            bool match = true;
            int count = 0;
            for (int i = 0; i < length ; i++)
            {
                if (text[i] == substring[0])
                {
                    match = true;                 
                    for (int j = 1; j < substring.Length && match == true; j++)
                    {
                        if (text[i+j] != substring[j])
                        {
                            match = false;
                        }
                        else
                        {
                            if (j==substring.Length-1)
                            {
                                count++;
                            }
                        }
                    }
                }

            }
            return count;
        }
    }
}
