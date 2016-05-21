//  Problem 8. Extract sentences
//  
//      Write a program that extracts from a given text all sentences containing given word.
//  
//  Example:
//  
//  The word is: in
//  
//  The text is: We are living in a yellow submarine.We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
//  
//  The expected result is: We are living in a yellow submarine.We will move out of it in 5 days.
//  
//  Consider that the sentences are separated by.and the words – by non-letter symbols.

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ExtractSentences
    {
        static void Main()
        {
            string word = "in";
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

            string[] sentences = text.Split('.');
            List<string> result = new List<string>();

            foreach (var item in sentences)
            {
                int index = item.IndexOf(word);
                while (index != -1)
                {
                    //if infront and behind are non letter symbols
                    if (!char.IsLetter(item[index - 1]) && !char.IsLetter(item[index + word.Length]))
                    {
                        result.Add(item);
                    }
                    index = item.IndexOf(word,index+word.Length);
                }
            }
            Console.WriteLine(string.Join(".",result)+".");
        }
    }
}
