//  Problem 5. Parse tags
//  
//      You are given a text.Write a program that changes the text in all regions surrounded by the tags<upcase> and</upcase> to upper-case.
//  
//     The tags cannot be nested.
//  
//  Example: We are living in a<upcase> yellow submarine</upcase>.We don't have <upcase>anything</upcase> else.
//  
//  
//  The expected result: We are living in a YELLOW SUBMARINE.We don't have ANYTHING else.

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class ParseTags
    {

        private const string openTag = "<upcase>";
        private const string closeTag = "</upcase>";

        static void Main()
        {
            string text = Console.ReadLine();
            string parsedText = Parse(ref text);
            Console.WriteLine(parsedText);
        }

        private static string Parse(ref string text)
        {
            StringBuilder result = new StringBuilder();
            StringBuilder by = new StringBuilder();
            int startIndex = text.IndexOf(openTag);
            int endIndex = 0;

            while (startIndex != -1)
            {
                //copy text from outside the tags
                result.Append(text.Substring(endIndex, startIndex - endIndex));
                endIndex = text.IndexOf(closeTag, startIndex);
                //copy text from inside the tags
                startIndex = startIndex + openTag.Length;
                result.Append(text.Substring(startIndex, endIndex - startIndex).ToUpper());
                startIndex = text.IndexOf(openTag,startIndex);
                endIndex = endIndex + closeTag.Length;
            }

            if (endIndex < text.Length)
            {
                result.Append(text.Substring(endIndex, text.Length-endIndex));
            }

            return result.ToString();
        }
    }
}
