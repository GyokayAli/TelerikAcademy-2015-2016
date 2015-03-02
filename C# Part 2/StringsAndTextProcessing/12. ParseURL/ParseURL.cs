//Problem 12. Parse URL
//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.


using System;
using System.Text.RegularExpressions;

class ParseURL
{
    static void Main()
    {
        Console.WriteLine("Please enter a URL: ");
        string url = Console.ReadLine();
        //test this http://telerikacademy.com/Courses/Courses/Details/212 
        var matches = Regex.Match(url, "(.*)://(.*?)(/.*)").Groups;
        Console.WriteLine(@"

[protocol] = {0}
[server] = {1}
[resource] = {2}

", matches[1], matches[2], matches[3]);
    }
}

