//Problem 8. Maximal sum
//Write a program that finds the sequence of maximal sum in given array.
//Can you do it with only one loop (with single scan through the elements of the array)?
//Example: 2, 3, -6, -1, 2, -1, 6, 4, -8, 8	 result: 2, -1, 6, 4

using System;
using System.Linq;


class MaximalSum
{
        static void Main()
        {
            Console.WriteLine("Enter N integers, separated by a comma/space: ");
            int[] nums = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int bestStart = 0, bestEnd = 0, bestSum = int.MinValue;
            int startIndex = 0, currentSum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (currentSum <= 0)
                {
                    startIndex = i;
                    currentSum = 0;
                }

                currentSum += nums[i];

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestStart = startIndex;
                    bestEnd = i;
                }
            }

            Console.WriteLine("Maximal sum: {0}", bestSum);
            Console.Write("Sequence of maximal sum: ");
            for (int i = bestStart; i <= bestEnd; i++)
            {
                Console.Write(i != bestEnd ? nums[i] + ", " : nums[i] + "\n");
            }
        }
}

