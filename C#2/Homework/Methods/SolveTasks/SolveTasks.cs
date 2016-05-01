//  Problem 13. Solve tasks
//  
//      Write a program that can solve these tasks:
//          Reverses the digits of a number
//          Calculates the average of a sequence of integers
//          Solves a linear equation a* x + b = 0
//      Create appropriate methods.
//      Provide a simple text-based menu for the user to choose which task to solve.
//      Validate the input data:
//          The decimal number should be non-negative
//          The sequence should not be empty
//          a should not be equal to 0


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SolveTasks
    {
        static void Main()
        {

            int choice = 0;
            do
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("Press 1 to reverse the digits of a decimal number");
                Console.WriteLine("Press 2 to calculate the average of a sequence of integers");
                Console.WriteLine("Press 3 to solve a linear equation a * x + b = 0");
                Console.WriteLine("Press 4 to exit");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        ReverseDigits();
                        break;
                    case 2:
                        CalculateAverage();
                        break;
                    case 3:
                        SolveEquation();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("incorrect input!");
                        break;
                }
            } while (choice != 4);
        }

        private static void ReverseDigits()
        {
            Console.WriteLine("Enter a positive decimal number:");
            decimal number;

            while (!decimal.TryParse(Console.ReadLine(), out number) ||
                    number < 0)
            {
                Console.WriteLine( "incorrect input!" );
                Console.WriteLine("Enter a positive decimal number:");
            }

            decimal result = ReverseDigits(number);
            Console.WriteLine("Reversed number: {0}", result);
        }

        private static decimal ReverseDigits(decimal number)
        {
            string reverseNumber = new string (number.ToString().Reverse().ToArray());
            decimal result = decimal.Parse(reverseNumber);
            return result;
        }

        private static void CalculateAverage()
        {
            Console.WriteLine("enter the length of the sequence N= ");
            int n = 0;

            while (!int.TryParse(Console.ReadLine(), out n) ||
                    n <= 0)
            {
                Console.WriteLine("incorrect input!");
                Console.WriteLine("enter the length of the sequence N= ");
            }
            List<int> sequence = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}:",i+1);
                sequence.Add(int.Parse(Console.ReadLine()));
            }
            decimal result = CalculateAverage(sequence);
            Console.WriteLine("Average is: {0}", result);
        }

        private static decimal CalculateAverage(List<int> data)
        {
            int sum = 0;

            for (int i = 0; i < data.Count; i++)
            {
                sum += data[i];
            }

            decimal result = (decimal)sum / data.Count;
            return result;
        }

        private static void SolveEquation()
        {
            Console.Write("Enter a number not equal to 0, a= ");
            int a;

            while (!int.TryParse(Console.ReadLine(), out a) ||
                    a == 0)
            {
                Console.WriteLine("incorrect input!");
                Console.Write("Enter integer number not equal to 0, a= ");
            }

            Console.Write("Enter integer number b= ");
            int b = int.Parse(Console.ReadLine());

            decimal result = SolveEquation(a,b);
            Console.WriteLine("x is: {0:f6}", result);
        }

        private static decimal SolveEquation(decimal a, decimal b)
        {
            decimal x = 0;
            x = (b / a) * (-1);
            return x;
        }
    }
}
