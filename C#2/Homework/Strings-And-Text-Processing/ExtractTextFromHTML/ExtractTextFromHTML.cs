//  Problem 25. Extract text from HTML
//  
//      Write a program that extracts from given HTML file its title(if available), 
//      and its body text without the HTML tags.
//  
//  Example input:
//  
//  <html>
//    <head><title>News</title></head>
//    <body><p><a href = "http://academy.telerik.com" > Telerik
//  
//     Academy</a> aims to provide free real-world practical
//  
//     training for young people who want to turn into
//     skilful .NET software engineers.</p></body>
//  </html>
//  
//  
//  Output:
//  
//  
//  Title: News
//  
//  Text: Telerik Academy aims to provide free real-world practical training for young people 
//  who want to turn into skilful .NET software engineers.

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class ExtractTextFromHTML
    {
        static void Main()
        {
            StringBuilder htmlCode = new StringBuilder();
            string currentLine;

            while ((currentLine = Console.ReadLine().Trim()) != "</html>")
            {
                htmlCode.Append(currentLine+" ");
            }

            bool inTag = false;
            bool inTitle = false;
            bool inText = false;
            StringBuilder text = new StringBuilder();
            StringBuilder title = new StringBuilder();
            StringBuilder tag = new StringBuilder();
            foreach (var letter in htmlCode.ToString())
            {
                if (inTitle)
                {
                    if (letter == '<')
                    {
                        inTitle = false;
                        inTag = true;
                    }
                    else
                    {
                        title.Append(letter);
                    }
                }

                else if (inTag)
                {
                    if (letter == '>')
                    {
                        inTag = false;

                        if (tag.ToString() == "title")
                        {
                            inTitle = true;
                        }
                        tag.Clear();
                    }
                    else
                    {
                        tag.Append(letter);
                    }
                }

                else if (letter == '<')
                {
                    inTitle = false;
                    inTag = true;
                    inText = false;
                }

                else
                {
                    if (!inText)
                    {
                        text.Append(" ");
                    }
                    inText = true;
                    text.Append(letter);
                }
            }

            if (title.Length>0)
            {
                Console.WriteLine("Title: {0}",title.ToString());
            }
            if (text.Length > 0)
            {
                Console.WriteLine("Text: {0}", text.ToString().Trim());
            }
        }
    }
}
