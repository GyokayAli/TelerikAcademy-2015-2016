//Problem 14. Word dictionary
//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.

using System;

class WordDictionary
{
    static void Main()
    {
        string[] dictionary = { ".NET - platform for applications from Microsoft",
                                "CLR - managed execution environment for .NET",
                                "namespace - hierarchical - organization of classes",
                              "abstract - The abstract modifier can be used with classes, methods, properties, indexers, and events.",
    "as - The as operator is used to perform conversions between compatible types.",
    "base - The base keyword is used to access members of the base class from within a derived class",
    "bool - The bool keyword is an alias of System.Boolean. It is used to declare variables to store the Boolean values, true and false.",
    "break - The break statement terminates the closest enclosing loop or switch statement in which it appears.",
    "byte - The byte keyword denotes an integral type that stores values as indicated in the following table.",
    "case - The switch statement is a control statement that handles multiple selections by passing control to one of the case statements within its body.",
    "catch - The try-catch statement consists of a try block followed by one or more catch clauses, which specify handlers for different exceptions.",
    "char - The char keyword is used to declare a Unicode character in the range indicated in the following table.",
    "checked - The checked keyword is used to control the overflow-checking context for integral-type arithmetic operations and conversions.",
    "class - Classes are declared using the keyword class."};

        Console.Write("Please enter a word: ");
        string word = Console.ReadLine();
        foreach (string line in dictionary)
        {
            if (line.IndexOf(word) == 0)
            {
                Console.WriteLine(line);
            }
        }
    }
}

