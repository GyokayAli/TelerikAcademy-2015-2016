//Problem 14. Quick sort
//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;
using System.Linq;

class QuickSort
{
        static void Main()
        {
            Console.WriteLine("Enter N integers, separated by a comma/space: ");
            int[] nums = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            SortQuick(nums, 0, nums.Length - 1);
            Console.WriteLine("QUICK SORT");
            Console.WriteLine(String.Join(", ", nums));
        }

        static public int Partition(int[] numbers, int left, int right)
        {
            int pivot = numbers[left];
            while (true)
            {
                while (numbers[left] < pivot)
                    left++;

                while (numbers[right] > pivot)
                    right--;

                if (left < right)
                {
                    int temp = numbers[right];
                    numbers[right] = numbers[left];
                    numbers[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }

        static public void SortQuick(int[] arr, int left, int right)
        {
            int pivot;

            if (left < right)
            {
                pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    SortQuick(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    SortQuick(arr, pivot + 1, right);
                }
            }
        }
}

