//Problem 4. Maximal sequence
//Write a program that finds the maximal sequence of equal elements in an array.

using System;
using System.Linq;

class MaximalSequence
{
        static void Main()
        {
            Console.WriteLine("Enter N integers, separated by a comma/space: ");
            int[] nums = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int currSequence = 1;
            int tempSequence = 1;
            int equalNum = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    tempSequence++;
                }
                else
                {
                    tempSequence = 1;
                }

                if (tempSequence > currSequence)
                {
                    currSequence = tempSequence;
                    equalNum = nums[i];
                }
            }
            for (int i = 0; i < currSequence; i++)
            {
                Console.Write("{0}",equalNum);
            }
            Console.WriteLine();
        }
}

