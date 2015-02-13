//Problem 6. Maximal K sum
//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;
using System.Collections.Generic;
using System.Linq;

class MaxSumOfElementsK
{
        static void Main()
        {
            Console.WriteLine("Enter N integers, separated by a comma/space: ");
            int[] n = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.Write("Enter number of K elements: ");
            int k = int.Parse(Console.ReadLine());

            if (k > n.Length)
            {
                Console.WriteLine("The array has less than {0} elements.", k);
                return;
            }

            n = n.OrderByDescending(x => x).ToArray();
            Console.WriteLine("The maximal sum is {0}", n.Take(k).Sum());
        }
}
