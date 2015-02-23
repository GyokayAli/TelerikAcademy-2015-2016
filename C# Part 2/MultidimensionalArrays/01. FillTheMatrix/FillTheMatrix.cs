//Problem 1. Fill the matrix
//Write a program that fills and prints a matrix of size (n, n) as shown below:
/*    A           B           C           D
 *  1 4 7       1 6 7       4 7 9       1 8 7
 *  2 5 8       2 5 8       2 5 8       2 9 6
 *  3 6 9       3 4 9       1 3 6       3 4 5
 */

using System;

class FillTheMatrix
{

    static void Main()
    {
        Console.Write("Please enter 'n': ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Matrix A");
        MatrixA(n);
        Console.WriteLine("\nMatrix B");
        MatrixB(n);
        Console.WriteLine("\nMatrix C");
        MatrixC(n);
        Console.WriteLine("\nMatrix D");
        MatrixD(n);
    }
    private static void MatrixA(int n)
    {
        int[,] matrix = new int[n, n];
        int counter = 1;

        for (int cols = 0; cols < n; cols++)
        {
            for (int rows = 0; rows < n; rows++)
            {
                matrix[rows, cols] = counter++;
                
            }
        }
        PrintMatrix(matrix, n);
    }

    private static void MatrixB(int n)
    {
        int[,] matrix = new int[n,n];
        int counter = 1;
        int currentRow = 0;
        int flip = -1;

        for (int col = 0; col < n; col++)
        {
            flip *= -1;
            for (int row = 0; row < n; row++)
            {
                matrix[currentRow, col] = counter++;
                currentRow += flip;
            }
            currentRow += -flip;
        }

        PrintMatrix(matrix, n);
    }

    private static void MatrixC(int n)
    {
        int[,]matrix = new int[n, n];
        int counter = 1;
        int currentRow;

        for (int row = n - 1; row >= 0; row--)
        {
            currentRow = row;
            for (int col = 0; col < n - row; col++)
            {
                matrix[currentRow++, col] = counter++;
            }
        }

        counter = n * n;

        for (int row = 0; row < n - 1; row++)
        {
            currentRow = row;
            for (int col = n - 1; currentRow >= 0; col--)
            {
                matrix[currentRow--, col] = counter--;
            }
        }

        PrintMatrix(matrix, n);
    }

    private static void MatrixD(int n)
    {

        int[,]matrix = new int[n, n];
        int[] rowMOD = new int[] { 1, 0, -1, 0 };
        int[] colMOD = new int[] { 0, 1, 0, -1 };
        int direction = 0;
        int counter = 1;
        int row = 0;
        int col = 0;
        int nextRow;
        int nextCol;

        while (counter <= n * n)
        {
            matrix[row, col] = counter++;
            nextRow = row + rowMOD[direction];
            nextCol = col + colMOD[direction];

            if ((nextRow < 0 || nextRow >= n) ||
                (nextCol < 0 || nextCol >= n) ||
                matrix[nextRow, nextCol] != 0)
            {
                direction = (direction + 1) % 4;
            }

            row += rowMOD[direction];
            col += colMOD[direction];
        }

        PrintMatrix(matrix, n);
        
    }
    private static void PrintMatrix(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0, -4}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    
}
