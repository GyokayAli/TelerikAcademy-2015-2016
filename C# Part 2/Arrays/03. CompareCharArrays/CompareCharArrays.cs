//Problem 3. Compare char arrays
//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
        static void Main()
        {
            Console.Write("Please specify first array's length: ");
            char[] firstArray = new char[int.Parse(Console.ReadLine())];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = char.Parse(Console.ReadLine());
            }

            Console.Write("Please specify second array's length: ");
            char[] secondArray = new char[int.Parse(Console.ReadLine())];
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = char.Parse(Console.ReadLine());
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
                Console.WriteLine("{0}", isEqual ? "They contain the same characters." : "But with different characters!");
            }
        }
}

