using System;
using System.Linq;
using System.Text.RegularExpressions;

class Sentences
{
    static void Main()
    {
        string word = Console.ReadLine();
        string input = Console.ReadLine();

        string[] sentences = input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

        var regex = new Regex("(^|[^A-Za-z])" + word + "([^A-Za-z]|$)");
        var result = sentences.Where(sentance => regex.Matches(sentance, 0).Count > 0).ToList();

        result.ForEach(x => Console.Write(x.Trim() + ". "));
    }
}