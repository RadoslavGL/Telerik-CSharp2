//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
namespace Find_sum_in_array
{
    using System;
    using System.Linq;
    using System.Text;
    class FindSumInArray
    {
                static void Main(string[] args)
        {
            int[] arrNumbers = Console.ReadLine().Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            //string arrNumbersString = string.Join(", ", arrNumbers);
            //Console.WriteLine(arrNumbersString);

            int sum = int.Parse(Console.ReadLine());


        }
    }
}
