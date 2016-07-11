//  Problem 22. Words count
//  
//      Write a program that reads a string from the console and lists all different
//      words in the string along with information how many times each word is found.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class WordsCount
    {
        static void Main()
        {
            string input = Console.ReadLine();

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();
            string[] words = input.Split(new char[] { ' ','.',',','!','?'},StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
                else
                {
                    wordsCount.Add(word, 1);
                }
            }

            foreach (var item in wordsCount)
            {
                Console.WriteLine("{0} {1} times",item.Key,item.Value);
            }
        }
    }
}
