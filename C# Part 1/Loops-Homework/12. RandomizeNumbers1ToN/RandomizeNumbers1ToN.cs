//Problem 12.* Randomize the Numbers 1…N
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class RandomizeNumbers1ToN
{
        static void Main()
        {
            Console.Write("Please enter an integer number: ");
            int n = int.Parse(Console.ReadLine());
            int[] pool = new int[n];
            bool[] printed = new bool[n + 1];

            Random r = new Random();
            int rand = r.Next(1, n + 1);

            for (int i = 0; i < n; i++)
            {
                rand = r.Next(1, n + 1);
                if (!printed[rand])
                {
                    Console.Write("{0} ", rand);
                    printed[rand] = true;
                }
                else
                {
                    i--;
                }
            }
            Console.WriteLine();

        }
}

