//Problem 20.* Variations of set
//Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
/*Example:
 *         N      K      RESULT
 *                       {1, 1}
 *                       {1, 2}
 *                       {1, 3}
 *                       {2, 1}
 *         3      2      {2, 2}
 *                       {2, 3}
 *                       {3, 1}
 *                       {3, 2}
 *                       {3, 3}
 */

using System;
using System.Collections.Generic;
using System.Linq;

class VariationsOfSet
{
        static void Main()
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter K: ");
            int k = int.Parse(Console.ReadLine());

            int c;
            for (int i = 0; i < Math.Pow(n, k); i++)
            {
                c = i;
                int[] array = new int[k];
                for (int j = 0; j < k; j++)
                {
                    array[k - j - 1] = c % n;
                    c = c / n;
                }
                Console.Write("{0}{1}", '{', array[0] + 1);
                for (int j = 1; j < k; j++)
                {
                    Console.Write(", {0}", array[j] + 1);
                }
                Console.WriteLine("}");
            }
        }
}

