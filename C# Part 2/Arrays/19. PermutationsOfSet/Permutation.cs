//Problem 19.* Permutations of set
//Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
/* Example:
 *            N           RESULT
 *                      {1, 2, 3}
 *                      {1, 3, 2}
 *            3         {2, 1, 3} 
 *                      {2, 3, 1}
 *                      {3, 1, 2} 
 *                      {3, 2, 1}
 */

using System;

class Permutation
{
    static void Main()
    {
        Console.Write("Please enter N: ");
        int[] arr = new int[int.Parse(Console.ReadLine())];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i + 1;
        }

        Perm(arr, 0, arr.Length - 1);
    }

    private static void Perm(int[] arr, int k, int n)
    {
        if (k == n)
        {
            Print(arr);
        }
        else
        {
            for (int i = k; i <= n; i++)
            {
                Swap(arr, k, i);
                Perm(arr, k + 1, n);
                Swap(arr, k, i);
            }
        }

    }

    private static void Swap(int[] arr, int k, int i)
    {
        int t = arr[k];
        arr[k] = arr[i];
        arr[i] = t;
    }
    private static void Print(int[] arr)
    {
        Console.Write("{0}{1}", '{', arr[0]);
        for (int i = 1; i < arr.Length; i++)
        {
            Console.Write(", {0}", arr[i]);
        }
        Console.WriteLine("}");
    }
}

