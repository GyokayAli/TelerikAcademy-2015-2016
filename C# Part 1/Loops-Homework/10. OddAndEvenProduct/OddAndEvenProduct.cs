//Problem 10. Odd and Even Product
/* You are given n integers (given in a single line, separated by a space).
 * Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
 * Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */

using System;
using System.Linq;

class OddAndEvenProduct
{
        static void Main()
        {
            Console.WriteLine("Enter Integers (given in a single line, separated by a space) :");
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x))
                .ToArray();

            int oddProd = 1;
            int evenProd = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                    oddProd *= numbers[i];

                else 
                    evenProd *= numbers[i];
            }

            bool equalProducts = oddProd == evenProd;

            Console.WriteLine(equalProducts ? "Yes\nproduct = {0}" : "No\nodd_product = {0}\neven_product = {1}"
                            , oddProd, evenProd);
        }
}

