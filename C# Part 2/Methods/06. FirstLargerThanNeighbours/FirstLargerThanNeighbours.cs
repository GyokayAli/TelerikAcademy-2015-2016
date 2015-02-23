//Problem 6. First larger than neighbours
//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;
using System.Linq;

namespace FirstLargerThanNeighbours
{
class FirstLargerThanNeighbours
{
    static void Main()
    {
        Console.WriteLine("Please create an array of integers, separated by a comma/space: ");
        int[] intArray = Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToArray();

        int count = 0;
        for (int i = 0; i < intArray.Length; i++)
        {
            if (CheckNeighbours(intArray, i))
            {
                Console.WriteLine("The index of the first element in array that is larger than its neighbours is: {0}", i);
                count++;
                return;
            }
        }

        if (count == 0) 
            Console.WriteLine(-1);
    }

    static bool CheckNeighbours(int[] array, int position)
    {
        
        bool result = false;
        if (position == 0)
            result = array[position] > array[position + 1];
        else if
            (position == array.Length - 1) result = array[position] > array[position - 1];
        else
            result = array[position] > array[position - 1] && array[position] > array[position + 1];
        return result;
    }

}
}