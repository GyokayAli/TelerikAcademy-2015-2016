//Problem 24. Order words
//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;

class OrderWords
{
    static void Main()
    {
        Console.WriteLine("Please enter a list of words separated by space:");
        string words = Console.ReadLine();
        string[] splitWords = words.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Array.Sort(splitWords);
        foreach (var item in splitWords)
        {
            if (item != "\r\n")
                Console.WriteLine(item);
        }
    }
}

