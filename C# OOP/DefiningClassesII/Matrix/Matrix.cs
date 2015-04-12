/*Problem 8. Matrix
 * 
Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals).
Problem 9. Matrix indexer
Implement an indexer this[row, col] to access the inner matrix cells.
 * 
Problem 10. Matrix operations
Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
Throw an exception when the operation cannot be performed.
Implement the true operator (check for non-zero elements).
*/

namespace Matrix
{
    using System;
    using System.Collections;

    public class Matrix<T>
    {
        private int rows;
        private int cols;
        private T[,] matrix;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }

            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException();
                }

                this.cols = value;
            }
        }

        public T this[int rowIndex, int colIndex]
        {
            get
            {
                return this.matrix[rowIndex, colIndex];
            }

            set
            {
                if (rowIndex < 0 || rowIndex >= this.Rows || colIndex < 0 || colIndex >= this.Rows)
                {
                    throw new IndexOutOfRangeException();
                }

                this.matrix[rowIndex, colIndex] = value;
            }
        }

        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    if (matrix[row, col].Equals(default(T)))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArgumentException();
            }

            Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = (dynamic)first[row, col] + second[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if (first.Rows != second.Rows || first.Cols != second.Cols)
            {
                throw new ArgumentException();
            }

            Matrix<T> result = new Matrix<T>(first.Rows, first.Cols);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    result[row, col] = (dynamic)first[row, col] - second[row, col];
                }
            }

            return result;
        }

        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.Cols != second.Rows)
            {
                throw new ArgumentException();
            }

            Matrix<T> result = new Matrix<T>(first.Rows, second.Cols);

            for (int row = 0; row < result.Rows; row++)
            {
                for (int col = 0; col < result.Cols; col++)
                {
                    for (int secondRow = 0; secondRow < result.Cols; secondRow++)
                    {
                        result[row, col] = (dynamic)first[row, col] * second[secondRow, col];
                    }
                }
            }

            return result;
        }

        public override string ToString()
        {
            string rows = string.Empty;

            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    rows += string.Format("{0,5}", this.matrix[row, col]);
                }

                rows += Environment.NewLine;
            }

            return rows;
        }
    }
}
