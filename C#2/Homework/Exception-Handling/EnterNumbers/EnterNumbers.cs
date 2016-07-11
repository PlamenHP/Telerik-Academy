

namespace Namespace
{
    using System;
    using System.Collections.Generic;

    class EnterNumbers
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 1 };
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    int number = ReadNumber();

                    if (number > numbers[numbers.Count-1])
                    {
                        numbers.Add(number);
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Exception");
                    return;
                }
            }
            numbers.Add(100);

            Console.WriteLine(string.Join(" < ",numbers));
        }

        private static int ReadNumber()
        {
            int number;
            try
            {
                number = int.Parse(Console.ReadLine());

                if (number < 2 || number > 99)
                {
                    throw new FormatException();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return number;
        }
    }
}
