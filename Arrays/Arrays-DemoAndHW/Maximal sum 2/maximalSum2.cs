//Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
//kadane's algorithm
//max subarray

namespace Maximal_sum_2
{
    using System;
    class maximalSum2
    {
        static void Main(string[] args)
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
                if (currentSum < 0)
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
