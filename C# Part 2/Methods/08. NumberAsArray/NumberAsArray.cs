//Problem 8. Number as array
//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        string input1 = Console.ReadLine();

        Console.Write("Enter second number: ");
        string input2 = Console.ReadLine();

        int numLen = (input1.Length > input2.Length) ? input1.Length : input2.Length;
        input1 = input1.PadLeft(numLen, '0');
        input2 = input2.PadLeft(numLen, '0');

        PrintTheNumber(SumArrays(CreateArrayNumber(input1), CreateArrayNumber(input2)));
        Console.WriteLine();
    }

    private static int[] CreateArrayNumber(string input)
    {
        int[] number = new int[input.Length];

        for (int i = 0; i < number.Length; i++)
        {
            number[i] = int.Parse(input[input.Length - 1 - i].ToString());
        }
        return number;
    }

    private static void PrintTheNumber(string number)
    {
        Console.Write("The summed number is: ");
        for (int i = number.Length - 1; i >= 0; i--)
        {
            Console.Write(number[i]);
        }
    }

    private static string SumArrays(int[] num1, int[] num2)
    {
        if (num1.Length > num2.Length)
        {
            return SumArrays(num2, num1);
        }

        string sum = string.Empty;
        int rest = 0;

        for (int i = 0; i < num2.Length; i++)
        {
            sum += ((num1[i] + num2[i]) % 10 + rest).ToString();
            rest = (num1[i] + num2[i]) / 10;
            if (rest > 0 && i == num2.Length - 1)
            {
                sum += rest;
            }
        }
        return sum;
    }
}

