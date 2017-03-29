//Write a program that finds the most frequent number in an array of N elements.

namespace Frequent_number
{
    using System;
    class FrequentNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrN = new int[n];

            //fill the array
            for (int i = 0; i < arrN.Length; i++)
            {
                arrN[i] = int.Parse(Console.ReadLine());
            }

            //sorting the array
            for (int i = 0; i < arrN.Length - 1; i++)
            {
                for (int j = i + 1; j < arrN.Length; j++)
                {
                    if (arrN[i] > arrN[j])
                    {
                        int swap = arrN[i];
                        arrN[i] = arrN[j];
                        arrN[j] = swap;
                    }

                }

            }

            //check for sequence
            int maxCount = 1;
            int currentCount = 1;
            int countedNumber = 0;

            for (int i = 1; i < arrN.Length; i++)
            {
                if (arrN[i] == arrN[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    countedNumber = arrN[i];
                }

            }

            //print
            Console.WriteLine("{0} ({1} times)", countedNumber, maxCount);

        }
    }
}
