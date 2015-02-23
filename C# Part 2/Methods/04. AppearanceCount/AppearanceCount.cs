//Problem 4. Appearance count
//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        Console.WriteLine("Please create an array of integers, separated by a comma/space: ");
        int[] intArray = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        Console.Write("Please enter an integer to search in the array: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine("\nThe number {0} appears {1} times in the given array.", num, AppearanceCounter(intArray, num));
    }

    static int AppearanceCounter(int[] array, int num)
    {
        int counter = 0;
        foreach (int numInArray in array)
        {
            if (numInArray == num)
                counter += 1;
        }
        return counter;
    }
}

