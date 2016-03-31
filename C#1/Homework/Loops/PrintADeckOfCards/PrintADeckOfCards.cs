//  Problem 4. Print a Deck of 52 Cards
//  
//      Write a program that generates and prints all possible cards from a standard deck of 52 cards 
//      (without the jokers). The cards should be printed using the classical notation 
//      (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//          The card faces should start from 2 to A.
//          Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
//          Use 2 nested for-loops and a switch-case statement.
//  
//  output
//  
//  2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//  3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//  …  
//  K of spades, K of clubs, K of hearts, K of diamonds
//  A of spades, A of clubs, A of hearts, A of diamonds


namespace Namespace
{
    using System;
    class PrintADeckOfCards
    {
        static void Main()
        {
            int cardsCount = 14;
            int suitsCount = 4;
            for (int face = 2; face <= cardsCount; face++)
            {
                for (int suit = 1; suit <= suitsCount; suit++)
                {
                    string result = GetCardFace(face) + " of " + GetCardSuit(suit);
                    Console.Write(result);
                }
                Console.WriteLine("\n");
            }
        }

        private static string GetCardFace(int face)
        {
            if (2 <= face && face <= 10) return face.ToString();
            switch (face)
            {
                case 11: return "J";
                case 12: return "D";
                case 13: return "K";
                case 14: return "A";
                default: return "GetCardFace Invalid input";
            }
        }

        private static string GetCardSuit(int suit)
        {
            switch (suit)
            {
                case 1: return "spades, ";
                case 2: return "clubs, ";
                case 3: return "hearts, ";
                case 4: return "diamonds";
                default: return "GetCardSuit Invalid input";
            }
        }

    }
}
