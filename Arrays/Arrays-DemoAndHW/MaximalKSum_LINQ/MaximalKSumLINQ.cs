//Write a program that reads two integer numbers N and K and an array of N elements from the console. 
//Find the maximal sum of K elements in the array.
//Input:On the first line you will receive the number N;On the second line you will receive the number K;On the next N lines the numbers of the array will be given
//Print the maximal sum of K elements in the array

//works but uses too much memory to pass the tests in bgcoder

namespace MaximalKSum_LINQ
{
    using System;
    using System.Linq;

    class MaximalKSumLINQ
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());

            int[] arrayImputs = new int[N];

            for (int i = 0; i < arrayImputs.Length; i++)
            {
                arrayImputs[i] = int.Parse(Console.ReadLine());

            }

            arrayImputs = arrayImputs.OrderByDescending(a => a).ToArray();

            //string arrayImputsString = string.Join(", ", arrayImputs);
            //Console.WriteLine(arrayImputsString);

            int maxSum = 0;

            for (int i = 0; i < K; i++)
            {
                maxSum += arrayImputs[i];
            }

            Console.WriteLine(maxSum);
        }
    }
}
