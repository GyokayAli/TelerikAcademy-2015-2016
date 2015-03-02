//Problem 4. Sub-string in text
//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
/*Example:

The target sub-string is "in"

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
 */

using System;

    class SubstringInText
    {
        static void Main()
        {
            string theText = "We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string substring = "in";

            int count = 0;
            int index = theText.ToLower().IndexOf(substring, 0);

            while (index >= 0)
            {
                count++;
                index++;
                index = theText.ToLower().IndexOf(substring, index);
            }
            Console.WriteLine("The substring \"{0}\" appears {1} time/s in the text", substring, count);
        }
   }

