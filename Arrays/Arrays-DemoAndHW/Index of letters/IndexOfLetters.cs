//Write a program that creates an array containing all letters from the alphabet (a-z). 
//Read a word from the console and print the index of each of its letters in the array.

namespace Index_of_letters
{
    using System;
    using System.Linq;
    class IndexOfLetters
    {
        static void Main()
        {
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToLower().ToCharArray();
            //char[] alphabet = Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (Char)i).ToArray();

            char[] input = Console.ReadLine().ToLower().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (input[i] == alphabet[j])
                    {
                        Console.WriteLine(j);
                    }

                }

            }
        }
    }
}
