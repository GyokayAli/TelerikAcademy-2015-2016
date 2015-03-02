//Problem 5. Maximal area sum
/*Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
 *Example:
 *         input	output
 *         4
 *         2 3 3 4 
 *         0 2 3 4    17
 *         3 7 1 2 
 *         4 3 3 2
 */

using System;
using System.IO;
using System.Linq;

class MaximumAreaSum
{
    static void Main()
    {
        var matrixReader = new StreamReader("../../Files/matrix.txt");
        string line = matrixReader.ReadLine();
        int n = Convert.ToInt32(line);
        int[,] matrix = new int[n, n];

        //fill matrix
        int rows = 0;
        while (line != null)
        {
            line = matrixReader.ReadLine();
            if (line != null)
            {
                string[] str = line.Split(' ');

                for (int i = rows; i <= rows; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        matrix[i, j] = Int32.Parse(str[j]);
                    }
                }
                rows++;
            }
        }
        //print matrix
        int bestRow = 0;
        int bestCol = 0;

        for (int row = bestRow; row < bestRow + n; row++)
        {
            for (int col = bestCol; col < bestCol + n; col++)
            {
                Console.Write("{0,2}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        //calculate max sum area of the matrix
        int maxValue = 0;
        int tempValue;
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                tempValue = 0;

                for (int checkRow = 0; checkRow < 2; checkRow++)
                {
                    for (int checkCol = 0; checkCol < 2; checkCol++)
                    {
                        tempValue += matrix[row + checkRow, col + checkCol];
                    }
                }
                maxValue = Math.Max(maxValue, tempValue);
            }
        }
        //print the result
        Console.WriteLine("The maximum area sum is: {0}", maxValue);
        //write result in file
        File.WriteAllText("../../Files/MaxSumAreaResult.txt", maxValue.ToString());
        Console.WriteLine("\nNew file is written!");
    }
}

