//Problem 9. Sorting array
//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;
using System.Linq;

class SortingArray
{
    static void Main()
    {
        Console.WriteLine("Please create an array of integers, separated by a comma/space: ");
        int[] numArr = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        Console.Write("\nEnter start index: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter end index: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine("\nMax element in interval [{0}, {1}] is {2}", start, end, FindMaxElementInInterval(numArr, start, end));

        Console.WriteLine("\nNumbers in Ascending order: {0}", string.Join(" ", SortAscending(numArr)));

        Console.WriteLine("Numbers in Descending order: {0}\n", string.Join(" ", SortDescending(numArr)));
    }

    static int FindMaxElementInInterval(int[] numbers, int start, int end, int swapIndex = 0)
    {
        if (start < 0 || start >= numbers.Length || end < 0 || end >= numbers.Length)
            throw new IndexOutOfRangeException();

        int maxIndex = start;

        for (int i = start; i <= end; i++)
            if (numbers[maxIndex] < numbers[i])
                maxIndex = i;

        int temp = numbers[swapIndex];
        numbers[swapIndex] = numbers[maxIndex];
        numbers[maxIndex] = temp;

        return numbers[swapIndex];
    }

    static int[] SortAscending(int[] numbers)
    {
        int size = numbers.Length;
        int[] sorted = new int[size];

        for (int i = size - 1; i >= 0; i--)
            sorted[i] = FindMaxElementInInterval(numbers, 0, i, i);

        return sorted;
    }

    static int[] SortDescending(int[] numbers)
    {
        int size = numbers.Length;
        int[] sorted = new int[size];

        for (int i = 0; i < size; i++)
            sorted[i] = FindMaxElementInInterval(numbers, i, size - 1, i);

        return sorted;
    }
}
