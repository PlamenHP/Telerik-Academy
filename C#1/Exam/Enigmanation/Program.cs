using System;

namespace Enigmanation
{
    class Enigmanation
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            decimal result = 0;
            decimal bracketResult = 0;
            char currentOperator = '+';
            char bracketOperator = '+';
            bool inBracket = false;
            foreach (var symbol in expression)
            {
                if (inBracket)
	            {
                    if (symbol == '+' ||
                        symbol == '-' ||
                        symbol == '*' ||
                        symbol == '%')
                    {
                        bracketOperator = symbol;
                    }

                    if (symbol >= '0' && symbol <= '9')
                    {
                        int currentNumber = symbol - '0';

                        switch (bracketOperator)
                        {
                            case '+': bracketResult += currentNumber; break;
                            case '-': bracketResult -= currentNumber; break;
                            case '*': bracketResult *= currentNumber; break;
                            case '%': bracketResult %= currentNumber; break;
                        }
                    }		 
	            }
                else
                {
                    if (symbol == '+' ||
                        symbol == '-' ||
                        symbol == '*' ||
                        symbol == '%')
                    {
                        currentOperator = symbol;
                    }

                    if (symbol >= '0' && symbol <= '9')
                    {
                        int currentNumber = symbol - '0';

                        switch (currentOperator)
                        {
                            case '+': result += currentNumber; break;
                            case '-': result -= currentNumber; break;
                            case '*': result *= currentNumber; break;
                            case '%': result %= currentNumber; break;
                        }
                    }
                }

                if (symbol == '(')
                {
                    inBracket = true;
                    continue;
                }

                if (symbol == ')')
                {
                    switch (currentOperator)
                    {
                        case '+': result += bracketResult; break;
                        case '-': result -= bracketResult; break;
                        case '*': result *= bracketResult; break;
                        case '%': result %= bracketResult; break;
                    }

                    bracketResult = 0;
                    bracketOperator = '+';
                    inBracket = false;
                }
            }

            Console.WriteLine("{0:F3}", result);
        }

    }
}