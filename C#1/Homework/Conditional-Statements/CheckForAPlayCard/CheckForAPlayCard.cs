//  Problem 3. Check for a Play Card
//  
//      Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
//      Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:
//  
//  character 	Valid card sign?
//  5 	        yes
//  1 	        no
//  Q 	        yes
//  q 	        no
//  P 	        no
//  10      	yes
//  500 	    no

namespace Namespace
{
    using System;
    using System.Collections.Generic;
    class CheckForAPlayCard
    {
        static void Main()
        {
            List<string> cards = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            Console.Write("enter a string to check if it is a valid card sign: ");
            string input = Console.ReadLine();

            Console.WriteLine(cards.Contains(input)?"yes":"no"); 
        }
    }
}
