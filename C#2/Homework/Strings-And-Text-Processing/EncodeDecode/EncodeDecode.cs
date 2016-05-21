//  Problem 7. Encode/decode
//  
//      Write a program that encodes and decodes a string using given encryption key(cipher).
//      The key consists of a sequence of characters.
//      The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc.When the last key character is reached, the next is the first.


namespace Namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    class EncodeDecode
    {
        static void Main()
        {
            string cipher = "8347fh9843278hyf78h239";
            string text = "We are living in a YELLOW SUBMARINE. We don't have ANYTHING else";
            Console.WriteLine(text + "\n");
            text = EncriptDecript(text, cipher);
            Console.WriteLine(text + "\n");
            text = EncriptDecript(text, cipher);
            Console.WriteLine(text);
        }

        private static string EncriptDecript(string text, string cipher)
        {
            StringBuilder result = new StringBuilder();
            int length = text.Length;
            int cipherLenght = cipher.Length;

            for (int i = 0; i < length; i++)
            {
                result.Append((char)(text[i] ^ cipher[i % cipherLenght]));
            }
            return result.ToString();
        }
    }
}
