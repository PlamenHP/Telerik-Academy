//  Problem 18. Extract e-mails
//  
//      Write a program for extracting all email addresses from given text.
//      All sub-strings that match the format<identifier>@<host>…<domain>
//      should be recognized as emails.
//  

namespace Namespace
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    class ExtractEmails
    {
        static void Main()
        {
            StringBuilder input = new StringBuilder();
            string line;

            while ((line = Console.ReadLine()) != "")
            {
                line = Console.ReadLine();
                input.Append(line);
            }

            Regex emailRegex = new Regex(@"\w{2,}([-+.]\w{2,})*@\w{2,}([-.]\w{2,})*\.\w{2,}([-.]\w{2,})*", RegexOptions.IgnoreCase);

            MatchCollection emailMatches = emailRegex.Matches(input.ToString());

            StringBuilder sb = new StringBuilder();

            foreach (Match emailMatch in emailMatches)
            {
                sb.AppendLine(emailMatch.Value);
            }

            Console.WriteLine(sb);
        }
    }
}
