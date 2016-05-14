//  Problem 3. Compare char arrays
//  
//      Write a program that compares two char arrays lexicographically (letter by letter).


namespace Namespace
{
    using System;
    class CompareCharArrays
    {
        static void Main()
        {
            char[] firstArray = Console.ReadLine().ToCharArray();
            char[] secondArray = Console.ReadLine().ToCharArray();

            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine(">");
                    break;
                }

                if (firstArray[i] < secondArray[i])
                {
                    Console.WriteLine("<");
                    break;
                }

                if (firstArray.Length > secondArray.Length)
                {
                    if (i == secondArray.Length - 1)
                    {
                        Console.WriteLine(">");
                    }
                }
                else if (firstArray.Length < secondArray.Length)
                {
                    if (i == firstArray.Length - 1)
                    {
                        Console.WriteLine("<");
                    }
                }
                else if (firstArray.Length == secondArray.Length)
                {
                    if (i == firstArray.Length - 1)
                    {
                        Console.WriteLine("=");
                    }
                }

            }
        }
    }
}
