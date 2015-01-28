//Problem 11.* Number as Words
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

using System;

class NumberAsWord
{
    static string[] ones = new string[] { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
    static string[] teens = new string[] { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
    static string[] tens = new string[] { "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    static void Main()
    {
        Console.Write("Please enter a number between [0..999]: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("The number {0} in words is {1}",num, NumberToWord(num));
    } 

    private static string CheckInt(int n, string leftDigits)
    {
        if (n == 0)
        {
            return leftDigits;
        }

        string friendlyInt = leftDigits;
        if (friendlyInt.Length > 0)
        {
            friendlyInt += " ";
        }

        if (n < 10)
        {
            friendlyInt += ones[n];
        }
        else if (n < 20)
        {
            friendlyInt += teens[n - 10];
        }
        else if (n < 100)
        {
            friendlyInt += CheckInt(n % 10, tens[n / 10 - 2]);
        }
        else if (n < 1000)
        {
            friendlyInt += CheckInt(n % 100, (ones[n / 100] + " Hundred and"));
        }
        return friendlyInt; ;
    }

    public static string NumberToWord(int n)
    {
        if (n == 0)
        {
            return "Zero";
        }
        else if (n < 0)
        {
            return "Negative " + NumberToWord(-n);
        }

        return CheckInt(n, "");
    }
}


