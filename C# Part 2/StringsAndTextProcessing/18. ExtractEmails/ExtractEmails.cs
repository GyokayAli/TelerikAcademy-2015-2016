//Problem 18. Extract e-mails
//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text;
class ExtractEmails
{
    static void Main()
    {
        string data = @"Email examples example@abv.bg or liberty042@mail.ru, or example@yahoo.com
                      meff_dont_stay@mail.ru, japaneseeyes@mail.ru, chebr007@mail.ru, golowcko@mail.ru, vk20106@mail.ru";
           
        //instantiate with this pattern 
        Regex emailRegex = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            RegexOptions.IgnoreCase);
        //find items that matches with our pattern
        MatchCollection emailMatches = emailRegex.Matches(data);

        StringBuilder sb = new StringBuilder();

        foreach (Match emailMatch in emailMatches)
        {
            sb.AppendLine(emailMatch.Value);
        }
        Console.WriteLine("List of emails extracted: ");
        Console.WriteLine("\n{0}",sb.ToString());
    }
}
