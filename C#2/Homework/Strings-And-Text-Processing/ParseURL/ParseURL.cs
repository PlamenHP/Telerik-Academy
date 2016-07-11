//  Problem 12. Parse URL
//  
//      Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//  
//  Example:
//  URL Information
//  http://telerikacademy.com/Courses/Courses/Details/212 	[protocol] = http
//  [server] = telerikacademy.com
//  [resource] = /Courses/Courses/Details/212

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ParseURL
    {
        static void Main()
        {
            string url = Console.ReadLine();
            List<string> urlParts = Parse(url);
            Print(urlParts);
        }

        private static void Print(List<string> urlParts)
        {          
            if (urlParts.Count == 1)
            {
                Console.WriteLine("[protocol]={0}", urlParts[0]);
            }
            else if (urlParts.Count==2)
            {
                Console.WriteLine("[protocol]={0}", urlParts[0]);
                Console.WriteLine("[server]={0}", urlParts[1]);
            }
            else if (urlParts.Count == 3)
            {
                Console.WriteLine("[protocol]={0}", urlParts[0]);
                Console.WriteLine("[server]={0}", urlParts[1]);
                Console.WriteLine("[resource]={0}", urlParts[2]);
            }
        }

        private static List<string> Parse(string url)
        {
            List<string> result = new List<string>();

            int protocolNameStartIndex = 0;
            int protocolNameEndIndex = url.IndexOf("://");
            int protocolNameLenght = protocolNameEndIndex - protocolNameStartIndex;
            string protocolName = url.Substring(protocolNameStartIndex, protocolNameLenght);
            result.Add(protocolName);

            string serverName = String.Empty;

            if (url.IndexOf("/") != -1)
            {
                int serverNameStartIndex = protocolNameEndIndex + "://".Length;
                int serverNameEndIndex = url.IndexOf("/", serverNameStartIndex);
                int serverNameLenght = serverNameEndIndex - serverNameStartIndex;
                serverName = url.Substring(serverNameStartIndex, serverNameLenght);
                result.Add(serverName);

                if (url.Length > serverNameEndIndex + 2)
                {
                    int resourceNameStartIndex = serverNameEndIndex;
                    int resourceNameEndIndex = url.Length;
                    int resourceNameLenght = resourceNameEndIndex - resourceNameStartIndex;
                    string resourceName = url.Substring(resourceNameStartIndex, resourceNameLenght);
                    result.Add(resourceName);
                }
            }
            else
            {
                int serverNameStartIndex = url.IndexOf("://") + 3;
                int serverNameEndIndex = url.Length - 1;
                int serverNameLenght = serverNameEndIndex - serverNameStartIndex;
                serverName = url.Substring(serverNameStartIndex, serverNameLenght);
                result.Add(serverName);
            }
            return result;
        }
    }
}
