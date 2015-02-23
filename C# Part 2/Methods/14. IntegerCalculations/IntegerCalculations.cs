//Problem 14. Integer calculations
//Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
//Use variable number of arguments.

using System;
using System.Linq;

    class IntegerCalculations
    {
        static void Main()
        {
            Console.WriteLine("Please create an array of integers, separated by a comma/space: ");
            int[] nums = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            Console.WriteLine("\nThe Minimum of set integers: {0}", GetMin(nums));
            Console.WriteLine("The Maximum of set integers: {0}", GetMax(nums));
            Console.WriteLine("The Average Sum of set integers: {0}", GetAverageSum(nums));
            Console.WriteLine("The Sum of set integers: {0}", GetSum(nums));
            Console.WriteLine("The Product of set integers: {0}\n", GetProduct(nums));
        }

        static int GetMin(params int[] numbers)
        {
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min) min = numbers[i];
            }
            return min;
        }

        static int GetMax(params int[] numbers)
        {
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max) max = numbers[i];
            }
            return max;
        }

        static int GetSum(params int[] numbers)
        {
            return numbers.Sum();
        }

        static decimal GetAverageSum(params int[] numbers)
        {
            return (decimal)GetSum(numbers) / numbers.Length;
        }

        static int GetProduct(params int[] numbers)
        {
            return numbers.Aggregate(1, (current, t) => current * t);
        }
    }

