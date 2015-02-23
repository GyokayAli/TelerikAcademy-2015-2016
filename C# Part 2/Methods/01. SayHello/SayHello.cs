//Problem 1. Say Hello
//Write a method that asks the user for his name and prints “Hello, <name>”

using System;

class SayHello
{
    static void Main()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        PrintName(name);
    }

    static void PrintName(string name)
    {
        Console.Clear();
        Console.WriteLine("Hello, {0}!", name);
    }
}

