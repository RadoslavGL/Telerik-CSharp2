//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

namespace Allocate_array
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class AllocateArray
    {
        static void Main()
        {
            int arrLenght = int.Parse(Console.ReadLine());
            int[] arr = new int[arrLenght];

            for (int i = 0; i < arrLenght; i++)
            {
                arr[i] = i * 5;
                Console.WriteLine(arr[i]);
            }


        }
    }
}
