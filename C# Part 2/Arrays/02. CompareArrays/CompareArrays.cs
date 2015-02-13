//Problem 2. Compare arrays
//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
        static void Main()
        {
            Console.Write("Please specify first array's length: ");
            int[] firstArray = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Please specify second array's length: ");
            int[] secondArray = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            bool isEqual = true;
            if (firstArray.Length > secondArray.Length)
            {
                Console.WriteLine("\nThe first array is larger by length. So not equal!\n");
            }
            else if (secondArray.Length > firstArray.Length)
            {
                Console.WriteLine("\nThe second array is larger by length. So not equal!\n");
            }
            else
            {
                Console.WriteLine("\nBoth arrays are equal by length.");

                for (int i = 0; i < firstArray.Length; i++)
                {
                    if (firstArray[i] != secondArray[i])
                    {
                        isEqual = false;
                        break;
                    }                     
                }
                Console.WriteLine("{0}",isEqual ? "And with the same elements." : "But with different elements!");
            }
        }
}

