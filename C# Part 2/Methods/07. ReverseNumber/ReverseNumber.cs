//Problem 7. Reverse number
//Write a method that reverses the digits of given decimal number.

using System;
using System.Linq;
public class ReverseNumber
{
    static void Main()
    {
        Console.Write("Please enter a decimal number: ");
        decimal dec = decimal.Parse(Console.ReadLine());

        Console.WriteLine("The number {0} when reversed is {1}", dec, ReverseDecimal(dec));
    }

    public static decimal ReverseDecimal(decimal dec)
    {
        return decimal.Parse(ReverseString(dec.ToString()));
    }

    public static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
