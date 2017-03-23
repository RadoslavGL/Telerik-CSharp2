//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find the maximal sum of K elements in the array.
//Input:On the first line you will receive the number N;On the second line you will receive the number K;On the next N lines the numbers of the array will be given
//Print the maximal sum of K elements in the array

namespace MaximalKSum
{
    using System;
    class MaximalKSum
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] arrayInputs = new int[N];

            //filling
            for (int i = 0; i < arrayInputs.Length; i++)
            {
                arrayInputs[i] = int.Parse(Console.ReadLine());
            }

            //sorting
            arrayInputs = SortDescending(arrayInputs);

            //checking if it's really sorted;
            string arrayInputsString = string.Join(", ", arrayInputs);
            Console.WriteLine(arrayInputsString);

            int maxSum = 0;
            for (int i = 0; i < K; i++)
            {
                maxSum += arrayInputs[i];
            }

            Console.WriteLine(maxSum);

        }

        static int[] SortDescending(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int swap = array[i];
                        array[i] = array[j];
                        array[j] = swap;
                    }
                }
            }

            return array;
        }
    }
}
