//  Problem 11.* Number as Words
//  
//      Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
//  
//  Examples:
//  numbers 	number as words
//  0   	Zero
//  9   	Nine
//  10  	Ten
//  12  	Twelve
//  19  	Nineteen
//  25  	Twenty five
//  98  	Ninety eight
//  98  	Ninety eight
//  273 	Two hundred and seventy three
//  400 	Four hundred
//  501 	Five hundred and one
//  617 	Six hundred and seventeen
//  711 	Seven hundred and eleven
//  999 	Nine hundred and ninety nine

namespace Namespace
{
    using System;
    class NumberAsWords
    {
        static void Main()
        {
            Console.WriteLine("Number as Words\n");
            Console.WriteLine("enter a number in the range [0…999] or 'q' to exit:");

            while (true)
            {
                string input = Console.ReadLine();
                string result = String.Empty;

                if (input == "q") break;

                if (int.Parse(input) == 0)
                {
                    result = "Zero";
                }
                else if (int.Parse(input) <= 99)
                {
                    result = GetUnderHundred(input);
                }
                else if (int.Parse(input) <= 999)
                {
                    result = GetHundredAndOver(input);
                }
                else
                {
                    result = "invalid program input";
                }

                Print(result);
            }
        }

        private static void Print(string result)
        {
            Console.WriteLine(result);
        }

        private static string GetTeens(string digit)
        {
            switch (digit)
            {
                case "0": return "";
                case "1": return "One";
                case "2": return "Two";
                case "3": return "Three";
                case "4": return "Four";
                case "5": return "Five";
                case "6": return "Six";
                case "7": return "Seven";
                case "8": return "Eight";
                case "9": return "Nine";
                case "10": return "Ten";
                case "11": return "Eleven";
                case "12": return "Twelve";
                case "13": return "Thirteen";
                default: return "GetTeens Invalid input";
            }
        }

        private static string GetWholeTents(string digit)
        {
            switch (digit)
            {
                case "2": return "Twenty";
                case "3": return "Thirty";
                case "4": return "Forty";
                case "5": return "Fifty";
                case "6": return "Sixty";
                case "7": return "Seventy";
                case "8": return "Eighty";
                case "9": return "Ninety";
                default: return "GetWholeTents Invalid input";
            }
        }

        private static string GetHundreds(string digit)
        {
            return GetTeens(digit) + " " + "hundred";
        }

        private static string GetUnderHundred(string digit)
        {
            if (int.Parse(digit) <= 13)
            {
                return GetTeens(digit);
            }
            else if (int.Parse(digit) <= 19)
            {
                return GetTeens(digit[1].ToString()) + "teen";
            }
            else if (int.Parse(digit) <= 99)
            {
                return GetWholeTents(digit[0].ToString()) + " " + GetTeens(digit[1].ToString()).ToLower();
            }
            else
            {
                return "GetUnderHundred Invalid input";
            }
        }

        private static string GetHundredAndOver(string digit)
        {
            string tenths = (int.Parse(digit.Substring(1, 2))).ToString();

            if (int.Parse(tenths) == 0)
            {
                return GetHundreds(digit[0].ToString());
            }
            else
            {
                return GetHundreds(digit[0].ToString()) + " and " + GetUnderHundred(tenths).ToLower();
            }  
        }

    }
}
