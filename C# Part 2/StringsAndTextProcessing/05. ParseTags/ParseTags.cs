//Problem 5. Parse tags
/*You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */

using System;
using System.Text;
class ParseTags
{
    static void Main()
    {
        string tagText = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

        StringBuilder uppercaseString = new StringBuilder();
        for (int i = 0; i < tagText.Length; i++)
        {
            if (tagText[i] == '<')
            {
                i += 8; // <upcase>  == length is 8
                while (tagText[i] != '<')
                {
                    uppercaseString.Append(tagText[i].ToString().ToUpper());
                    i++;
                }
                i += 8;
            }
            else
            {
                uppercaseString.Append(tagText[i]);
            }
        }
        Console.WriteLine(uppercaseString.ToString());
    }
}

