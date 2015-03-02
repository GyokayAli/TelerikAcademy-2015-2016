//Problem 15. Replace tags
//Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].

using System;

class ReplaceTags
{
    static void Main()
    {
        string inputHTML = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
        Console.WriteLine(inputHTML);

        inputHTML = inputHTML.Replace("<a href=\"", "[URL=");
        inputHTML = inputHTML.Replace("</a>", "[/URL]");
        inputHTML = inputHTML.Replace("\">", "]");

        Console.WriteLine("\nOutput string:");
        Console.WriteLine(inputHTML);
    }
}

