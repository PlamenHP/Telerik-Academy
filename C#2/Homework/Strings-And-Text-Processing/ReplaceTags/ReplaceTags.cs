//  Problem 15. Replace tags
//  
//      Write a program that replaces in a HTML document given as string all the tags <a href="URL">TEXT</a> with corresponding markdown notation [TEXT](URL).
//  
//  Example:
//  input                         
//  <p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>	
//
//  output
//  <p>Please visit [our site](http://academy.telerik.com) to choose a training course. Also visit [our forum](www.devbg.org) to discuss the courses.</p>

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    class Sentences
    {
        static string input = string.Empty;
        static string tag1 = "<a href=\"";
        static string tag2 = "\">";
        static string tag3 = "</a>";

        static int tag1Index = 0;
        static int tag2Index = 0;
        static int tag3Index = 0;
        // container for the final result
        static StringBuilder result = new StringBuilder();
        // variables for extracting the text before the tag
        static int textStart = 0;
        static int textEnd = 0;
        static int textLength = 0;
        static string text = String.Empty;
        // variables for extracting the url
        static int urlStart = 0;
        static int urlEnd = 0;
        static int urllength = 0;
        static string url = string.Empty;
        // variables for extracting the hint
        static int hintStart = 0;
        static int hintEnd = 0;
        static int hintlength = 0;
        static string hint = string.Empty;
        //////////////////////////////////////////////////////////////////
        static void Main()
        {
            Read_the_input_from_the_console();
            SearchForTag();
            while (TagIsFound())
            {
                Extract_text_url_and_hint();
                Add_them_to_the_result_in_the_proper_format();
                Search_for_another_tag();
            }
            if (We_still_have_text_after_the_last_tag())
            {
                Add_it_to_the_result();
            }
            Print_the_result();
        }
        ///////////////////////////////////////////////////////////////////
        private static string ExtractText()
        {
            if (result.Length == 0)
            {
                textStart = 0;
            }
            else
            {
                textStart = tag3Index + tag3.Length;
            }
            textEnd = tag1Index - 1;
            textLength = textEnd - textStart + 1;
            text = input.Substring(textStart, textLength);
            return text;
        }

        private static string ExtractUrl()
        {
            urlStart = tag1Index + tag1.Length;
            urlEnd = tag2Index - 1;
            urllength = urlEnd - urlStart + 1;
            url = input.Substring(urlStart, urllength);
            return url;
        }

        private static string ExtractHint()
        {
            hintStart = tag2Index + tag2.Length;
            hintEnd = tag3Index - 1;
            hintlength = hintEnd - hintStart + 1;
            hint = input.Substring(hintStart, hintlength);
            return hint;
        }

        private static bool We_still_have_text_after_the_last_tag()
        {
            return (tag3Index + tag3.Length) < (input.Length - 1);
        }

        private static bool TagIsFound()
        {
            return (tag1Index != -1);
        }

        private static void SearchForTag()
        {
            tag1Index = input.IndexOf(tag1, 0);
        }

        private static void Extract_text_url_and_hint()
        {
            text = ExtractText();
            tag2Index = input.IndexOf(tag2, tag1Index);
            tag3Index = input.IndexOf(tag3, tag2Index);
            url = ExtractUrl();
            hint = ExtractHint();
        }

        private static void Search_for_another_tag()
        {
            tag1Index = input.IndexOf(tag1, tag1Index + 1);
        }

        private static void Add_them_to_the_result_in_the_proper_format()
        {
            result.AppendFormat("{0}[{1}]({2})", text, hint, url);
        }

        private static void Add_it_to_the_result()
        {
            textStart = tag3Index + tag3.Length;
            textEnd = input.Length - 1;
            textLength = textEnd - textStart + 1;
            text = input.Substring(textStart, textLength);
            result.Append(text);
        }

        private static void Print_the_result()
        {
            Console.WriteLine(result.ToString());
        }

        private static void Read_the_input_from_the_console()
        {
            input = Console.ReadLine();
        }
    }

}
