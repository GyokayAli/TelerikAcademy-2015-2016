//Problem 5. Larger than neighbours
//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;
using System.Linq;
namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            Console.WriteLine("Please create an array of integers, separated by a comma/space: ");
            int[] intArray = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.Write("Please enter the element position in the array: ");
            int pos = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIs larger than its two neighbours?\n{0}", IsLargerThanNeigbours(intArray, pos) ? "TRUE" : "FALSE");


        }

        public static bool IsLargerThanNeigbours(int[] arr, int position)
        {

            bool isGreater = false;
            if (position < arr.Length && position > 0)
            {
                if (arr[position] > arr[position - 1] && arr[position] > arr[position + 1]) //check neighbours
                {
                    isGreater = true;
                }
            }
            else
            {
                Console.WriteLine("There are no neighbours to compare ");
                Environment.Exit(1);
            }
            return isGreater;
        }

    }

}