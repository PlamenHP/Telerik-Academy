// Problem 3. Divide by 7 and 5
// 
//     Write a Boolean expression that checks for given integer if it can be divided 
//     (without remainder) by 7 and 5 at the same time.
// 
// Examples:
// n 	Divided by 7 and 5?
// 3 	false
// 0 	true
// 5 	false
// 7 	false
// 35 	true
// 140 	true

namespace DivideBy7and5
{
    using System;
    class DivideBy7and5
    {
        static void Main()
        {
            Console.Write("enter integer: ");
            int number = int.Parse(Console.ReadLine());

            bool divisibleOn5and7 = ((number % 5 == 0) && (number % 7 == 0));
            Console.WriteLine("the number {0} divisible by 5 and 7", divisibleOn5and7 ? "is" : "is not");
        }
    }
}
