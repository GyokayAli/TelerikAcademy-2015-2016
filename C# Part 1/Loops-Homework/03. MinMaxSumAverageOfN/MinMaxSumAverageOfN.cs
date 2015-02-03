//Problem 3. Min, Max, Sum and Average of N Numbers
/*Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.*/

using System;
using System.Linq;

class MinMaxSumAverageOfN
{
        static void Main()
        {
            Console.WriteLine("How many numbers do you need?: ");
            
            int[] numbers = new int[int.Parse(Console.ReadLine())];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write(@"
min: {0}
max: {1}
sum: {2}
avg: {3:F2}
",         numbers.Min(), numbers.Max(), numbers.Sum(), numbers.Average());
        }
}

