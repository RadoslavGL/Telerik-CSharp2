//Write a program that finds the length of the maximal increasing sequence in an array of N integers.
//Input: On the first line you will receive the number N; On the next N lines the numbers of the array will be given
//Output: Print the length of the maximal increasing sequence

namespace MaximalIncreasingSequence
{
    using System;
    class MaximalIncreasingSequence
    {
        static void Main()
        {
            int numberInputs = int.Parse(Console.ReadLine());
            int[] arrayInputs = new int[numberInputs];
            int currentSequence = 1;
            int maxSequence = 1;

            //filling the array
            for (int i = 0; i < arrayInputs.Length; i++)
            {
                arrayInputs[i] = int.Parse(Console.ReadLine());
            }

            //checks for increasing array
            for (int i = 1; i <= arrayInputs.Length - 1; i++)
            {
                if (arrayInputs[i] > arrayInputs[i - 1])
                {
                    currentSequence++;

                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }

                }

                else
                {
                    currentSequence = 1;
                }

            }

            Console.WriteLine(maxSequence);

        }
    }
}
