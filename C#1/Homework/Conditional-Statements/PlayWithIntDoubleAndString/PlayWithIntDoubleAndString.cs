//  Problem 9. Play with Int, Double and String
//  
//      Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//          If the variable is int or double, the program increases it by one.
//          If the variable is a string, the program appends * at the end.
//      Print the result at the console. Use switch statement.
//  
//  Example 1:
//  program 	user
//  Please choose a type: 	
//  1 --> int 	
//  2 --> double 	
//  3 --> string 	3
//  	
//  Please enter a string: 	hello
//  	
//  hello* 	
//  
//  Example 2:
//  program 	user
//  Please choose a type: 	
//  1 --> int 	
//  2 --> double 	2
//  3 --> string 	
//  	
//  Please enter a double: 	1.5
//  	
//  2.5 	

namespace Namespace
{
    using System;
    class PlayWithIntDoubleAndString
    {
        static void Main()
        {
            Console.Write(" Please choose a type:\n 1 --> int \n 2 --> double \n 3 --> string \n");
            Console.SetCursorPosition(" Please choose a type:".Length, 0);
            string type = Console.ReadLine();

            Console.Clear();
            Console.WriteLine(GetResult(type));
        }

        private static string GetResult(string type)
        {
            switch (type)
            {
                case "1":                   
                    int i = int.Parse(GetInput("int"));
                    return (++i).ToString();
                case "2": 
                    double d = double.Parse(GetInput("double"));
                    return (++d).ToString();                    
                case "3": 
                    string s = GetInput("string");
                    return s + "*";
                default:             
                    return "invalid choice";
            }
        }

        private static string GetInput(string choice)
        {
            Console.Write("Please enter a {0}: ", choice);
            return Console.ReadLine();
        }
    }
}
