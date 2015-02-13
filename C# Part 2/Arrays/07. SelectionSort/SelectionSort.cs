//Problem 7. Selection sort
//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;
using System.Linq;

 class SelectionSort
{
        static void Main()
        {
            Console.WriteLine("Enter N integers, separated by a comma/space: ");
            int[] nums = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int min, temp;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] < nums[min])
                    {
                        min = j;
                    }
                }
                temp = nums[i];
                nums[i] = nums[min];
                nums[min] = temp;
            }

            Console.Write("\nAfter SELECTION sorting: ");
            Console.WriteLine(string.Join(" ", nums));
        }
}

