//Problem 2. Random numbers
//Write a program that generates and prints to the console 10 random values in the range [100, 200].

using System;

class RandomNumbers
    {
        static void Main()
        {
            Random randNum = new Random();

            Console.WriteLine("Ten random numbers:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randNum.Next(100, 200));
            }
        }
    }
