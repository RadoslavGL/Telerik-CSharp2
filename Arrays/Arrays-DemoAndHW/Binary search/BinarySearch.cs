namespace Binary_search
{
    using System;
    class BinarySearch
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arrN = new int[N];

            //fill the array;
            for (int i = 0; i < arrN.Length; i++)
            {
                arrN[i] = int.Parse(Console.ReadLine());
            }

            int xValue = int.Parse(Console.ReadLine());
            bool isInTheArray = false;

            int lowerBorder = 0;
            int upperBorder = arrN.Length - 1;
            int middle = (upperBorder + lowerBorder) / 2;

            while (upperBorder >= lowerBorder && isInTheArray != true)
            {
                middle = (lowerBorder + upperBorder) / 2;

                if (arrN[middle] < xValue)
                {
                    lowerBorder = middle + 1;
                }
                else if (arrN[middle] > xValue)
                {
                    upperBorder = middle - 1;
                }
                else
                {
                    isInTheArray = true;
                }

            }

            if (isInTheArray == true)
            {
                Console.WriteLine(middle);
            }
            else
            {
                Console.WriteLine("-1");
            }

        }
    }
}
