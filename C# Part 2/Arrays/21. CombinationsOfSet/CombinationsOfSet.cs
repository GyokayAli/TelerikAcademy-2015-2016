//Problem 21.* Combinations of set
//Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N].
/* Example:
 *           N     K     RESULT
 *                       {1, 2} 
 *                       {1, 3} 
 *                       {1, 4} 
 *                       {1, 5} 
 *           5     2     {2, 3}
 *                       {2, 4}
 *                       {2, 5}
 *                       {3, 4}
 *                       {3, 5}
 *                       {4, 5}
 */

using System;

class CombinationsOfSet
    {
        static void Main()
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter K: ");
            int[] k = new int[int.Parse(Console.ReadLine())];

            Combination(k, n, 0, 0);
        }

        static void Check(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.WriteLine(arr[i] + 1);
                }
                else
                {
                    Console.Write(arr[i] + 1 + " ");
                }
            }
        }

        static void Combination(int[] arr, int n, int i, int next)
        {
            if (i == arr.Length)
            {
                Check(arr);
                return;
            }

            for (int j = next; j < n; j++)
            {
                arr[i] = j;

                Combination(arr, n, i + 1, j + 1);
            }
        }
}

