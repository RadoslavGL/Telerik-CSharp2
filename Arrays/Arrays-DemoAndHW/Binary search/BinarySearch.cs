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

            //read the searched number from the console
            //create bool variable that checks if the index was found
            int xValue = int.Parse(Console.ReadLine());
            bool isInTheArray = false;

            //all be below listed are not values - they are indexes for the elements in the array;
            //create lower and upper borders for the search - lower = 0; upper = array.Length - 1;
            //create middle of the search to compare to; middle = (upper + lower) / 2 and this is logical;
            int lowerBorder = 0;
            int upperBorder = arrN.Length - 1;
            int middle = (upperBorder + lowerBorder) / 2;

            //search for the xValue and its index; 
            //logic: compare the array element with index "middle" to xValue and manage the borders if not matched;
            //if arrN[middle] < xValue -> lower border increased to middle + 1; 1 above the middle;
            //if arrN[middle] > xValue -> upper border decreased to middle - 1; 1 below the middle;
            //if arrN[middle] == xValue -> bool == true and the while condition stops
            //if lower >= upper and arrN[middle] != xValue we are still stopping as this means that value we search for is not in array
            // middle is recalculation for each iteration;
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

            //if bool == true -> we found the value in the array e.i. arrN[middle] == middle;
            //if bool == false -> we have not found the value and as per the instructions, we print "-1"

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
