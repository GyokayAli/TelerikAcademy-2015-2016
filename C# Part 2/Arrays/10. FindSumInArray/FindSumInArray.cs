//Problem 10. Find sum in array
//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example.. Array: 4, 3, 1, 4, 2, 5, 8   S:	11	Result: 4, 2, 5

using System;
using System.Linq;

class FindSumInArray
{
        static void Main()
        {
            Console.WriteLine("Enter N integers, separated by a comma/space: ");
            int[] nums = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.Write("Enter Sum: ");
            int sum = int.Parse(Console.ReadLine());

            int currSum = 0;
            int startIndex = 0;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                currSum += nums[i];
                startIndex = i;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    currSum += nums[j];
                    if (currSum == sum)
                    {
                        for (int k = startIndex; k <= j; k++)
                        {
                            Console.Write(nums[k] + ", ");
                        }
                        break;
                    }
                }
                currSum = 0;
            }
            Console.WriteLine();
        }
}

