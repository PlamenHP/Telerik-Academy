//Problem 9. Exchange Variable Values
//
//    Declare two integer variables a and b and assign them with 5 and 10 
//    and after that exchange their values by using some programming logic.
//    Print the variable values before and after the exchange.


namespace ExchangeVariableValues
{
    using System;
    class ExchangeVariableValues
    {
        static void Main()
        {
            int a = 1;
            int b = 9;

            Console.WriteLine("a = {0}   b = {1}", a, b);

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("a = {0}   b = {1}", a, b);
        }
    }
}
