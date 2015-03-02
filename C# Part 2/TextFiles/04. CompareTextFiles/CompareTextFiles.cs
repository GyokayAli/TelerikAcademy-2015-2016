//Problem 4. Compare text files
//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        var reader1 = new StreamReader("../../Files/text1.txt");
        var reader2 = new StreamReader("../../Files/text2.txt");

        using (reader1)
        {
            using (reader2)
            {
                string firstFileContent = reader1.ReadLine();
                string secondFileContent = reader2.ReadLine();
                int counter = 0;
                int differentCount = 0;
                while (firstFileContent != null && secondFileContent != null)
                {
                    if (firstFileContent.CompareTo(secondFileContent) == 0)
                    {
                        counter++;
                    }
                    else
                    {
                        differentCount++;
                    }
                    firstFileContent = reader1.ReadLine();
                    secondFileContent = reader2.ReadLine();
                }
                Console.WriteLine("{0} lines are equal!", counter);
                Console.WriteLine("{0} lines are not equal!", differentCount);
            }
        }
    }
}

