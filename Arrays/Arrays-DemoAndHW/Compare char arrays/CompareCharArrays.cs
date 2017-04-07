//Write a program that compares two char arrays lexicographically (letter by letter).
//Input: On the first line you will receive the first char array as a string // On the second line you will receive the second char array as a string
//Output:
//Print < if the first array is lexicographically smaller
//Print > if the second array is lexicographically smaller
//Print = if the arrays are equal

namespace Compare_char_arrays
{
    using System;
    class CompareCharArrays
    {
        static void Main()
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();

            string result = "=";

            int lengthComperison = Math.Min(firstString.Length, secondString.Length);

            for (int index = 0; index < lengthComperison; index++)
            {
                if (firstString[index] > secondString[index])
                {
                    result = ">";
                    break;
                }

                else if (firstString[index] < secondString[index])
                {
                    result = "<";
                    break;
                }

                else
                {
                    if (firstString.Length > secondString.Length)
                    {
                        result = ">";
                    }
                    else if (firstString.Length < secondString.Length)
                    {
                        result = "<";
                    }                                        
                }
            }

            Console.WriteLine(result);
        }
    }
}
