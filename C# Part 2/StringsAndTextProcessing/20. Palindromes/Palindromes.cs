//Problem 20. Palindromes
//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Text.RegularExpressions;

class Palindromes
{
    static void Main()
    {
        string text = "ABBA, lamal, exe, cat, sos, dad, mom, hero";

        foreach (Match item in Regex.Matches(text, @"\w+"))
        {
            if (IsPalindrome(item.Value)) Console.WriteLine(item);
        }
    }

    static bool IsPalindrome(string str)
    {
        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
}

