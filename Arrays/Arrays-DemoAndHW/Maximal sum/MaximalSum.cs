//Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.

namespace Maximal_sum
{
    using System;
    class MaximalSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrN = new int[n];

            //fill the array;
            for (int i = 0; i < arrN.Length; i++)
            {
                arrN[i] = int.Parse(Console.ReadLine());

            }
            
            //checks;
            int maxSum = 0;
            int currentSum = 0;

            for (int i = 0; i < arrN.Length; i++)
            {
                if (arrN[i] > arrN[i] + currentSum)
                {
                    currentSum = arrN[i];
                }

                else
                {
                    currentSum += arrN[i];
                }

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
