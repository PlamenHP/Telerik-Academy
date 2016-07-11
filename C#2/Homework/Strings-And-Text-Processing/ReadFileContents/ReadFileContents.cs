//  Problem 3. Read file contents
//  
//      Write a program that enters file name along with its full file 
//     path(e.g.C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//    Find in MSDN how to use System.IO.File.ReadAllText(…).
//      Be sure to catch all possible exceptions and print user-friendly error messages.
//  

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    class ReadFileContents
    {
        static void Main()
        {
            string input = Console.ReadLine().Replace("\\","\\\\");
            string text="";
            string error="";

            try
            {
                text = File.ReadAllText(input);
                Console.WriteLine(text);
            }
            catch (ArgumentNullException)
            {
                error = "Null reference";
            }
            catch (ArgumentException)
            {
                error = "Enter fle name";
            }
            catch (PathTooLongException)
            {
                error = "Path too long";
            }
            catch (DirectoryNotFoundException)
            {
                error = "Directory not fount";
            }
            catch (FileNotFoundException)
            {
                error = "File not found";
            }
            catch (IOException)
            {
                error = "IO Exception";
            }
            catch (UnauthorizedAccessException)
            {
                error = "Unautorised access";
            }
            catch (NotSupportedException)
            {
                error = "Not supported";
            }
            finally
            {
                Console.WriteLine(error);
            }         
        }
    }
}
