//  Problem 7.* Arithmetical expressions
//  
//      Write a program that calculates the value of given arithmetical expression.
//      The expression can contain the following elements only:
//          Real numbers, e.g. 5, 18.33, 3.14159, 12.6
//          Arithmetic operators: +, -, *, / (standard priorities)
//          Mathematical functions: ln(x), sqrt(x), pow(x, y)
//          Brackets(for changing the default priorities): (, )
//  
//  Examples:
//  input output
//  (3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)     ~10.6
//  pow(2, 3.14) * (3 - (3 * sqrt(2) - 3.2) + 1.5*0.3) 	~21.22

namespace Namespace
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    class ArithmeticalExpressions
    {
        static void Main()
        {
            string expression = "(3+5.3) * 2.7 - ln(22) / pow(2.2, -1.7)";

            string formatedExpression = FormatExpression(expression);

            Queue reverseNotation = new Queue(ConvertToReversePolishNotation(formatedExpression));

            Stack result = CalculateReversePolishNotation(reverseNotation);
        }

        private static string FormatExpression(string expression)
        {
            expression.Replace(" ", string.Empty);
            List<string> result = new List<string>();
            decimal currentNumber = 0;
            char currentOperator = '+';

            foreach (var symbol in expression)
            {
                if (symbol >= '0' && 
                    symbol <= '9')
                {
                    currentNumber = (currentNumber *10) + (symbol - '0');
                    continue;
                }
                else
                {
                    if (currentNumber != 0)
                    {
                        result.Add(currentNumber.ToString());
                    }
                }

                if (symbol == '+' ||
                    symbol == '-' ||
                    symbol == '*' ||
                    symbol == '%' ||
                    symbol == '(' ||
                    symbol == ')')
                {
                    result.Add(symbol.ToString());
                    continue;
                }

                double powerFirst = 0;
                double number = 0;

                switch (symbol)
                {
                    case 'l':
                        expression.Skip(2);
                        result.Add(Math.Log(symbol).ToString());
                        expression.Skip(1);
                        break;
                    case 's':
                        foreach (var c in expression.Skip(4))
                        {
                            if (c.Equals(')'))
                            {
                                result.Add(Math.Sqrt(double.Parse(number)));
                                break;
                            }
                            number += c;
                        }
                        result.Add(Math.Sqrt(number).ToString());
                        expression.Skip(1);
                        break;
                    case 'p':
                        expression.Skip(3);
                        powerFirst = symbol;
                        expression.Skip(1);
                        result.Add(Math.Pow(powerFirst,symbol).ToString());
                        expression.Skip(1);
                        break;
                } 
            }
            return result;
        }

        private static Queue ConvertToReversePolishNotation(string expression)
        {
            Queue queue<string> = new Queue<string>();
            Stack<string> stack = new Stack<string>();

            foreach (var c in expression)
            {
                if (char.IsNumber(c))
                {
                    string num = c.ToString();
                    foreach (var n in expression.Skip(1))
                    {
                        if (char.IsNumber(n))
                        {

                        }
                    }
                }
            }
            return result;
        }

        private static Stack CalculateReversePolishNotation(Queue notation)
        {
            Stack result = new Stack();
            string s = string.Empty;
            return result;
        }
    }
}
