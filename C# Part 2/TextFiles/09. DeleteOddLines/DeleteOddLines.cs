//Problem 9. Delete odd lines
//Write a program that deletes from given text file all odd lines.
//The result should be in the same file.

using System;
using System.IO;
using System.Collections.Generic;

class DeleteOddLines
{
    static void Main()
    {
       string path = "../../Files/text.txt";

       List<string> evenLines = new List<string>();
       using (StreamReader reader = new StreamReader(path))
       {
           int lineNum = 1;
           string line = reader.ReadLine();
           while (line != null)
           {
               if (lineNum % 2 == 0)
               {
                   evenLines.Add(line);
               }
               lineNum++;
               line = reader.ReadLine();
           }
           
       }
       using (StreamWriter output = new StreamWriter(path))
       {
           for (int i = 0; i < evenLines.Count; i++)
           {
               output.WriteLine(evenLines[i]);
           }
       }
       Console.WriteLine("\nOdd lines removed!\n");
    }
}

