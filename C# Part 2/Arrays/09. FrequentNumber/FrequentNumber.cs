//Problem 9. Frequent number
//Write a program that finds the most frequent number in an array.
// input: 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3  result: 4 (5 times)

using System;
using System.Collections.Generic;
using System.Linq;

class FrequentNumber
{
        static void Main()
        {
            Console.WriteLine("Enter N integers, separated by a comma/space: ");
            int[] nums = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int counter = 1, maxCount = 1, countNum = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    countNum = nums[i];
                }
            }
            if (maxCount > 1)
            {
                Console.WriteLine("\n{0} ({1} times)", countNum, maxCount);
            }
            else
            {
                Console.WriteLine("\nplease try again!");
            }
        }
}

