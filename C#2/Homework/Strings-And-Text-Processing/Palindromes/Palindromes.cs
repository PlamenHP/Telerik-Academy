//  Problem 20. Palindromes
//  
//      Write a program that extracts from a given text all palindromes, 
//      e.g.ABBA, lamal, exe.


namespace Namespace
{
    using System;
    using System.Collections.Generic;

    class Palindromes
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] words = input.Split(' ');
            List<string> palindromes = new List<string>();
            int right = 0;
            int left = 0;
            foreach (var word in words)
            {
                left = 0;
                right = word.Length - 1;
                bool isPalindrome = true;

                while (left < right && isPalindrome)
                {
                    if (word[left]!=word[right])
                    {
                        isPalindrome = false;
                    }
                    left++;
                    right--;
                }

                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine(string.Join(" ", palindromes));
        }
    }
}
