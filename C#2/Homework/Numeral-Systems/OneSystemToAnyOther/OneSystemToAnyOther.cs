//  Problem 7. One system to any other
//  
//      Write a program to convert from any numeral system of given base s 
//      to any other numeral system of base d.  (2 ≤ s, d ≤ 16).


namespace Namespace
{
    //using System;
    //using System.Collections.Generic;
    //using System.Linq;
    //
    //class OneSystemToAnyOther
    //{
    //    static void Main()
    //    {
    //        Console.Write("Numerical system base to convert from (2<= S <= 16) S= ");
    //        int fromBase = int.Parse(Console.ReadLine());
    //        Console.Write("Numerical system base to convert to (2<= D <= 16) D= ");
    //        int toBase = int.Parse(Console.ReadLine());
    //        Console.Write("Enter number in {0} based format: ",fromBase);
    //        string number = Console.ReadLine();
    //
    //        int dec = Convert.ToInt32(number, fromBase);
    //        string result = Convert.ToString(dec, toBase);
    //
    //        Console.WriteLine("Result: {0}",result);
    //    }
    //}

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class OneSystemToAnyOther
    {
        static void Main()
        {
            int fromNumericBase = int.Parse(Console.ReadLine());
            string number = Console.ReadLine();
            int toNumericBase = int.Parse(Console.ReadLine());


            long decimalNumber = NToDecimal(number, fromNumericBase);
            string resultNumber = DecimalToN(decimalNumber, toNumericBase);

            Console.WriteLine(resultNumber);
        }

        private static string DecimalToN(long decimalNumber, int numBase)
        {
            StringBuilder resultBuilder = new StringBuilder();
            int reminder = 0;

            while (decimalNumber != 0)
            {
                reminder = (int)(decimalNumber % numBase);
                resultBuilder.Append(decHexVal[reminder]);
                decimalNumber /= numBase;
            }

            //reverse the result and remove leading zeroes
            string result = resultBuilder.ToString();
            result = String.Join("", result.Reverse());
            result = result.TrimStart('0');
            result = result.ToUpper();
            return result;
        }

        private static long NToDecimal(string number, int numBase)
        {
            long result = 0;
            number = number.ToLower();
            long power = 1;

            for (int i = 0; i < number.Length; i++)
            {
                char digit = number[number.Length - 1 - i];
                result = result + hexDecVal[digit] * power;
                power = power * numBase;
            }
            return result;
        }

        private static Dictionary<char, int> hexDecVal = new Dictionary<char, int>
    {
        {'0', 0},
        {'1', 1},
        {'2', 2},
        {'3', 3},
        {'4', 4},
        {'5', 5},
        {'6', 6},
        {'7', 7},
        {'8', 8},
        {'9', 9},
        {'a', 10},
        {'b', 11},
        {'c', 12},
        {'d', 13},
        {'e', 14},
        {'f', 15},
    };

        private static Dictionary<int, char> decHexVal = new Dictionary<int, char>
    {
        { 0,'0'},
        { 1,'1'},
        { 2,'2'},
        { 3,'3'},
        { 4,'4'},
        { 5,'5'},
        { 6,'6'},
        { 7,'7'},
        { 8,'8'},
        { 9,'9'},
        {10,'A'},
        {11,'B'},
        {12,'C'},
        {13,'D'},
        {14,'E'},
        {15,'F'},
    };
    }
}
