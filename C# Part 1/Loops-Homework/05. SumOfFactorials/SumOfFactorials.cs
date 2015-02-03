//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N
/*Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
 *Use only one loop. Print the result with 5 digits after the decimal point.*/

using System;

class SumOfFactorials
{
        static void Main()
        {
            Console.Write("Please enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter X: ");
            int x = int.Parse(Console.ReadLine());

            decimal xPowN = 1m;
            decimal fact = 1m;
            decimal sum = 1m;

            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                xPowN *= x;
                sum += (fact / xPowN);
            }
            Console.WriteLine("{0:F5}", sum);
        }
}

