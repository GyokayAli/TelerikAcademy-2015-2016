//Problem 6. Save sorted names
//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
/*Example:
 *   input.txt	output.txt
 *   Ivan       George
 *   Peter      Ivan
 *   Maria      Maria
 *   George     Peter
 */

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class SaveSortedNames
{
    static void Main()
    {
        var inputNamesPath = new StreamReader("../../Files/names.txt");

        List<string> names = new List<string>();
        using (inputNamesPath)
        {
            names = inputNamesPath.ReadToEnd()
                .Split('\n')
                .Select(x => x.Trim())
                .OrderBy(x => x)
                .ToList();

            File.WriteAllLines("../../Files/sortedNames.txt", names);
            Console.WriteLine("The input file has been sorted succesfully!");
        }
    }
}

