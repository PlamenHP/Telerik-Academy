using System;

namespace Problem_2_Text_to_Number
{
    public class Text_to_Number
    {
        public static void Main()
        {
            Int64 result = 0;

            int numberN = int.Parse(Console.ReadLine());

            string text = Console.ReadLine();

            foreach (char item in text)
            {
                if (item == '@')
                {
                    Console.WriteLine(result);
                    break;
                }
                else if (char.IsDigit(item))
                {
                    result *= (item - '0') ;
                }
                else if (char.IsLetter(item))
                {
                    char lowercaseLetter = char.ToLower(item);
                    int letterNumber = lowercaseLetter - 'a';
                    result += letterNumber;
                }
                else
                {
                    result = result % numberN;
                }
            }
        }
    }
}
