

namespace Namespace
{
    using System;
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new FormatException();
                }
                Console.WriteLine("{0:F3}", Math.Sqrt(number));
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
        private static void ReadNumber(int start, int end)
        {

        }
    }
}
