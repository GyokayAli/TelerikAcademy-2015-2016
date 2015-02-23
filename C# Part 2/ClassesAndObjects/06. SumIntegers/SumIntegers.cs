//Problem 6. Sum integers
/*You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
 */

using System;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        Console.WriteLine("Please enter a sequence of positive integers separated by spaces:");

        int[] numbers = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        Console.WriteLine("Sum: " + numbers.Sum());
    }
}

