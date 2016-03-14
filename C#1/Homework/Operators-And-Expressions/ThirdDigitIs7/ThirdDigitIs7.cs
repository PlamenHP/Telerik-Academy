// Problem 5. Third Digit is 7?
// 
//     Write an expression that checks for given integer if its third digit from right-to-left is 7.
// 
// Examples:
// n 	Third digit 7?
// 5 	false
// 701 	true
// 9703 	true
// 877 	false
// 777877 	false
// 9999799 	true

namespace ThirdDigitIs7
{
    using System;
    class ThirdDigitIs7
    {
        static void Main()
        {
            Console.Write("enter integer: ");
            string number = Console.ReadLine();
            int indexFromRight = 3;
            bool digitIsSeven = false;

            if (number.Length >= indexFromRight)
            {
                char digitFromRight = number[number.Length - indexFromRight];
                digitIsSeven = digitFromRight == '7';                            
            }

            Console.WriteLine("third digit from right is 7: {0}", digitIsSeven ? "true" : "false"); 
        }
    }
}
