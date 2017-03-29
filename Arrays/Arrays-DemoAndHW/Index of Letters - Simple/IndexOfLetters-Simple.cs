//Write a program that creates an array containing all letters from the alphabet (a-z). 
//Read a word from the console and print the index of each of its letters in the array.

namespace Index_of_Letters___Simple
{
    using System;
    class IndexOfLetters_Simple
    {
        static void Main()
        {
            //input as string; no arrays
            string wordInput = Console.ReadLine();

            //char var start with value 'a' - first value for the small letters in the ascii;
            char start = 'a';

            //loop for each char in the string; cw-s the difference b/n the ascii code of each letter of the word and the code of 'a';
            for (int i = 0; i < wordInput.Length; i++)
            {
                Console.WriteLine((int)wordInput[i] - (int)start);

            }
        }
    }
}
