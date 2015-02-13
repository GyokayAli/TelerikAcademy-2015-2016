//Problem 18.* Remove elements from array
/*Write a program that reads an array of integers and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
 *Print the remaining sorted array.
 *Example .. INPIT: 6, 1, 4, 3, 0, 3, 6, 4, 5	RESULT: 1, 3, 3, 4, 5
 */

using System;
using System.Collections.Generic;
using System.Linq;


class RemoveElementsFromArray
{
        static void Main()
        {
            Console.WriteLine("Enter N integers, separated by a comma/space: ");
            List<int> nums = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToList();

            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] > nums[i + 1] || nums[i] < nums[0])
                {
                    nums.Remove(nums[i]);
                }
            }
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(i < nums.Count - 1 ? nums[i] + ", " : nums[i] + "\n");
            }
        }
}
