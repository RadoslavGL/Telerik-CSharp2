//Write a program to sort an array. Use the Selection sort algorithm:
//Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

namespace Selection_sort
{
    using System;
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrN = new int[n];

            for (int i = 0; i < arrN.Length; i++)
            {
                arrN[i] = int.Parse(Console.ReadLine());
            }

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

            Console.WriteLine(string.Join("\n", arrN));

        }
    }
}
