//Problem 9
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7,

using System;


namespace PrintSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            for (int i = 0; i < 10; i++ )
            {
                if (i % 2 == 0)
                    num[i] = i + 2;
                else
                    num[i] = -(i + 2);
            }

            Console.WriteLine(string.Join(", ", num));          
        }
    }
}
