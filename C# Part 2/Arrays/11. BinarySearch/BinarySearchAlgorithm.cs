//Problem 11. Binary search
//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;
using System.Linq;


class BinarySearchAlgorithm
{
        static void Main()
        {
            Console.WriteLine("Enter N integers, separated by a comma/space: ");
            int[] nums = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.Write("Please enter X value to be found: ");
            int xValue = int.Parse((Console.ReadLine()));

            Array.Sort(nums);
            Console.WriteLine("\nArray after sorting: {0}", string.Join(", ", nums));

            // 0 is the start/min value
            int index = BinarySearch(nums, xValue, 0, nums.Length);

            if (index != -1)
                Console.WriteLine("Number {0} found at index: {1}", xValue, index);
            else
                Console.WriteLine("Number {0} not found!", xValue);

        }

        private static int BinarySearch(int[] arr, int x, int min, int max)
       {
           if (max < min)
               // set is empty, so return value showing not found
               return -1;
           else
           {
               // calculate midpoint to cut set in half
               int mid = min + ((max - min) / 2);

               // three-way comparison
               if (arr[mid] > x)
                   // key is in lower subset
                   return BinarySearch(arr, x, min, mid - 1);
               else if (arr[mid] < x)
                   // key is in upper subset
                   return BinarySearch(arr, x, mid + 1, max);
               else
                   // key has been found
                   return mid;
           }
       }
}

