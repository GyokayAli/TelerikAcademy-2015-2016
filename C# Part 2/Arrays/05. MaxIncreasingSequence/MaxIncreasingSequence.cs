//Problem 5. Maximal increasing sequence
//Write a program that finds the maximal increasing sequence in an array.

using System;
using System.Linq;

class MaxIncreasingSequence
{
        static void Main()
        {
            Console.WriteLine("Enter N integers, separated by a comma/space: ");
            int[] nums = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int lastIndex = 0;
            int longestSeqLength = 1;
            int tempLength = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - 1 == nums[i - 1])
                {
                    ++tempLength;
                    if (tempLength > longestSeqLength)
                    {
                        longestSeqLength = tempLength;
                        lastIndex = i;
                    }
                }
                else
                {
                    tempLength = 1;
                }
            }

            int toSkip = lastIndex - longestSeqLength + 1;
            var sequence = nums.Skip(toSkip).Take(longestSeqLength).ToArray();
                     
            Console.Write("The maximal sequence of increasing elements is: " + string.Join(", ", sequence) + "\n");
        }
}

