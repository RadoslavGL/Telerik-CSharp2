//Write a program that reads two integer arrays of size N from the console and compares them element by element.
//input:
//On the first line you will receive the number N
//On the next N lines the numbers of the first array will be given
//On the next N lines the numbers of the second array will be given

namespace Compare_arrays
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int arrLenght = int.Parse(Console.ReadLine());
            int[] firstArray = new int[arrLenght];
            int[] secondArray = new int[arrLenght];


            for (int i = 0; i < arrLenght; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arrLenght; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }


            bool isEqual = true;

            for (int i = 0; i < arrLenght; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    isEqual = false;
                }
            }

            Console.WriteLine(isEqual ? "Equal" : "Not equal");

        }
    }
}
