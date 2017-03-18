//Write a program that finds the length of the maximal sequence of equal elements in an array of N integers.
//Input: On the first line you will receive the number N / On the next N lines the numbers of the array will be given
//Output: Print the length of the maximal sequence

namespace Maximal_sequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class MaximalSequence
    {
        static void Main(string[] args)
        {
            int numberInputs = int.Parse(Console.ReadLine());
            int[] arrayInputs = new int[numberInputs];
            int currentSequence = 1;
            int maxSequence = 1;


            // filling the array

            for (int i = 0; i < numberInputs; i++)
            {
                arrayInputs[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < numberInputs; i++)
            {
                if (arrayInputs[i] == arrayInputs[i - 1])
                {
                    currentSequence++;
                }
                else
                {
                    maxSequence = currentSequence;
                    currentSequence = 1;
                }

            }

            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
            }

            Console.WriteLine(maxSequence);
        }
    }
}
