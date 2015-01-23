//Problem 11.* Numbers in Interval Dividable by Given Number
//Write a program that reads two positive integer numbers and prints how many 
//numbers p exist between them such that the reminder of the division by 5 is 0.
using System;

 class NumbersDividableByN
{
        static void Main()
        {
            Console.Write("Please enter the start number: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Please enter the end number: ");
            int end = int.Parse(Console.ReadLine());

            int p = 0;
            for (int i = start; i <= end; i++)
            {
                if (i % 5 == 0)                    
                    p += 1;

            }

            Console.WriteLine("\n" + p);
        }
}

