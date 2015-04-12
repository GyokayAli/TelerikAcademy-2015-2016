namespace Matrix
{
    using System;
    using System.Text;

    class Test
    {
        private static Random random = new Random();

        static void Main(string[] args)
        {
            TestMatrix();
        }

        public static void TestMatrix()
        {
            // Test with different types
            Matrix<int> integerMatrix = new Matrix<int>(3, 3);
            Matrix<float> floatMatrix = new Matrix<float>(3, 3);

            Matrix<double> matrix = new Matrix<double>(3, 3);
            matrix = FillMatrix(matrix);

            Matrix<double> secondMatrix = new Matrix<double>(3, 3);
            secondMatrix = FillMatrix(secondMatrix);

            // Test operations
            Matrix<double> added = matrix + secondMatrix;
            Matrix<double> subtracted = matrix - secondMatrix;
            Matrix<double> multiplied = matrix * secondMatrix;

            double index = matrix[1, 1];

            string trueMatrix = matrix ? "Matrix is true." : "Matrix is false.";

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Testing matrix:")
                .AppendLine("\nMatrix A: ")
                .Append(matrix.ToString())
                .AppendLine("\nMatrix B: ")
                .Append(secondMatrix.ToString())
                .AppendLine("\nMatrix A + Matrix B: ")
                .Append(added.ToString())
                .AppendLine("\nMatrix A - Matrix B: ")
                .Append(subtracted.ToString())
                .AppendLine("\nMatrix A * Matrix B: ")
                .Append(multiplied.ToString())
                .AppendFormat("\nIndex matrix[1,1]: {0}\n", index)
                .AppendLine(trueMatrix);

            Console.WriteLine(sb.ToString());
        }

        public static Matrix<T> FillMatrix<T>(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.Rows; row++)
            {
                for (int col = 0; col < matrix.Cols; col++)
                {
                    dynamic num = random.Next(0, 20);
                    matrix[row, col] = (T)num;
                }
            }

            return matrix;
        }
    }
}
