//Problem 17.* Subset K with sum S
//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;
using System.Linq;

class SubsetKWithSumS
{
        static void Main()
        {
            Console.WriteLine("Enter N integers, separated by a comma/space: ");
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int n = arr.Length;

            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            if (k > n)
            {
                Console.WriteLine("Element in array are less then subset elements for sum K<={0}", n);
                Console.Write("K=");
                k = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter S: ");
            int s = int.Parse(Console.ReadLine());

            int sum = 0, counter = 0;
            string[] binStr = new string[n];
            for (int i = 1; i < (int)Math.Pow(2, n); i++)
            {
                string bin = Convert.ToString(i, 2).PadLeft(n, '0');
                for (int j = 0; j < k; j++)
                {
                    binStr[j] = Convert.ToString(bin[j]);
                    sum = sum + int.Parse(binStr[j]) * arr[j];
                }
                if (sum == s)
                {
                    counter++;
                }
                sum = 0;
            }
            if (counter > 0)
            {
                Console.WriteLine("\nyes");
            }
            else
            {
                Console.WriteLine("\nThere aren't {0} elements that have sum = {1}",k,s);
            }
        }
}

