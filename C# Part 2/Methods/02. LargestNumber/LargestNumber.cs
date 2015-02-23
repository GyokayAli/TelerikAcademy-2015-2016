//Problem 2. Get largest number
//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class LargestNumber
{
    static void Main()
    {
        Console.Write("Please enter first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Please enter second number: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Please enter third number: ");
        int num3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Largest of 3 is: " + GetLargestNum(GetLargestNum(num1, num2), num3));
    }

    static int GetLargestNum(int num1, int num2)
    {
        if (num1 > num2)
            return num1;
        else
            return num2;
    }
}

