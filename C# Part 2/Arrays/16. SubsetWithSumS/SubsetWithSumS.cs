//Problem 16.* Subset with sum S
//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S
//Example.. INPUT ARRAY: 2, 1, 2, 4, 3, 5, 2, 6	   SUM: 14	RESULT: yes

using System;
using System.Collections.Generic;
using System.Linq;

class SubsetWithSumS
{
        static void Main()
        {
            Console.WriteLine("Enter N integers, separated by a comma/space: ");
            int[] nums = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.Write("Enter Sum: ");
            int s = int.Parse(Console.ReadLine());

            int sum = 0, counter = 0;
            string[] binStr = new string[nums.Length];
            for (int i = 1; i < (int)Math.Pow(2, nums.Length); i++)
            {
                string bin = Convert.ToString(i, 2).PadLeft(nums.Length, '0');
                for (int j = 0; j < nums.Length; j++)
                {
                    binStr[j] = Convert.ToString(bin[j]);
                    sum = sum + int.Parse(binStr[j]) * nums[j];
                }
                if (sum == s)
                {
                    counter++;
                }
                sum = 0;
            }
            if (counter > 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
}

