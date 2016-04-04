//  Problem 12. Index of letters
//  
//      Write a program that creates an array containing all letters from the alphabet (A-Z).
//      Read a word from the console and print the index of each of its letters in the array.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    class IndexOfLetters
    {
        static void Main()
        {
            Console.WriteLine("Problem 12. Index of letters\n");
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            List<char> data = new List<char>();
            for (char ch = 'A'; ch < 'Z'; ch++)
            {
                data.Add(ch);
            }

            word = word.ToUpper();
            foreach (var ch in word)
            {
                Console.WriteLine("Index of {0} is: {1}",ch, FindIndexOf(data, ch));
            }
            
        }

        private static int FindIndexOf(List<char> data, char target)
        {
            int first = 0, last = data.Count - 1, mid = 0;

            while (first <= last)
            {
                mid = (last + first) / 2;

                if (target > data[mid])
                {
                    first = mid + 1;
                }

                else if (target < data[mid])
                {
                    last = mid - 1;
                }

                else
                {
                    return mid;
                }
            }
            return -1;
        }
    }
}
