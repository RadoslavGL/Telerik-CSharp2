namespace Demo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Demo
    {
        static void Main()
        {
            //int[] numbers = { 1, 2, 3, 4 };
            //string[] myStringArray;

            ////new array with 5 elements; 
            ////[number_of_elements] vs. { 1 , 2 , 3, 4 - elements }
            //int[] myIntArray = new int[5];

            //// positions: 0, 1, 2, 3, 4;
            //int[] newIntArray = new int[5];

            //// two types of memory in csharp:
            //// - stack: variables are stored there;
            //// - heap: for arrays

            //string[] arr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("arr[{0}] = {1}", i, arr[i]);
            //}


            //var daysOfWeek = new string[] 
            //    {
            //    "Monday",
            //    "Tuesday",
            //    "Wednesday",
            //    "Thursday",
            //    "Friday", 
            //    "Saturday",
            //    "Sunday"
            //    };

            //Console.WriteLine("Today is {0}", daysOfWeek[2]);

            //int count = 10;
            //int[] numbers = new int[count];

            //for (int j = 0; j < numbers.Length; j++)
            //{
            //    numbers[j] = j * j;
            //}


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine("arr[{0}] = {1}", i, numbers[i]);
            //}


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            ////string numbersString = string.Join("\n", numbers);
            //string numbersString = string.Join(", ", numbers);
            //Console.WriteLine(numbersString);

            //int[] reversedNumbers = numbers.Reverse().ToArray();

            ////int[] reversedNumbers = new int[numbers.Length];

            ////for (int i = 0; i < numbers.Length; i++)
            ////{
            ////    reversedNumbers[i] = numbers[numbers.Length - 1 - i];
            ////}

            //string reversedNumbersString = string.Join(", ", reversedNumbers);
            //Console.WriteLine(reversedNumbersString);



            //int n = int.Parse(Console.ReadLine());
            //int[] arr = new int[n];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //string nString = string.Join(", ",arr);
            //Console.WriteLine(nString);


            //string[] stringNumbers = Console.ReadLine().Split(' ');
            //int[] numbers = new int[stringNumbers.Length];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(stringNumbers[i]);
            //}

            //string numbersString = string.Join(", ", numbers);
            //Console.WriteLine(numbersString);

            //int[] reversedNumbers = new int[numbers.Length];
            //for (int i = 0; i < reversedNumbers.Length; i++)
            //{
            //    reversedNumbers[i] = numbers[numbers.Length - 1 - i];
            //}

            //string reversedNumbersString = string.Join(", ", reversedNumbers);
            //Console.WriteLine(reversedNumbersString);

            ////read from console and parse to int in one row; spaces between the members of the string
            //int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();



            //int[] numbers = { 1, 2, 3, 3, 2, 1 };
            //bool isSymentric = true;

            //for (int i = 0; i < numbers.Length / 2; i++)
            //{
            //    if (numbers[i] != numbers[numbers.Length - 1 - i])
            //    {
            //        isSymentric = false;
            //    }
            //}

            //Console.WriteLine("Is symetric: {0}", isSymentric);


            //string[] digits = {
            //                    "One",
            //                    "Two",
            //                    "Three",
            //                    "Four"                                
            //                    };

            //foreach (string digit in digits)
            //{
            //    Console.WriteLine(digit);
            //}


            //int[] numbers = Enumerable.Range(1, 10).ToArray();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    int number = numbers[i];
            //    Console.WriteLine(number);
            //}


            //int[] numbers = new int[5];
            //List<int> numbersList = new List<int>(5);


            //List<int> numbersList = new List<int>
            //{
            //    1, 2, 3, 4, 5, 6, 7
            //};
            //Console.WriteLine("Count: {0}", numbersList.Count);
            //Console.WriteLine(string.Join(", ",numbersList));

            //numbersList.Add(1);
            //Console.WriteLine("Count: {0}", numbersList.Count);
            //Console.WriteLine(string.Join(", ", numbersList));

            //numbersList.Remove(1);
            //Console.WriteLine("Count: {0}", numbersList.Count);
            //Console.WriteLine(string.Join(", ", numbersList));

            //numbersList.RemoveAt(3);
            //Console.WriteLine("Count: {0}", numbersList.Count);
            //Console.WriteLine(string.Join(", ", numbersList));

            //numbersList.Insert(2, 88);
            //Console.WriteLine("Count: {0}", numbersList.Count);
            //Console.WriteLine(string.Join(", ", numbersList));


            List<int> numbers = new List<int>();

            int count = 18;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Count: {0} -> Capacity: {1}", 
                    numbers.Count, numbers.Capacity);
                numbers.Add(1);
            }

            numbers.TrimExcess();

            Console.WriteLine("Count: {0} -> Capacity: {1}",
                    numbers.Count, numbers.Capacity);

        }
    }
}
