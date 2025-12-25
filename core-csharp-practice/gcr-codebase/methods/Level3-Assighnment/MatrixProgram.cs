using System;

class MatrixProgram
{
    static Random rand = new Random();

    static double[,] CreateMatrix(int rows, int cols)
    {
        double[,] mat = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                mat[i, j] = rand.Next(1, 10);
        return mat;
    }

    static double[,] Add(double[,] A, double[,] B)
    {
        int r = A.GetLength(0), c = A.GetLength(1);
        double[,] result = new double[r, c];
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                result[i, j] = A[i, j] + B[i, j];
        return result;
    }

    static double[,] Subtract(double[,] A, double[,] B)
    {
        int r = A.GetLength(0), c = A.GetLength(1);
        double[,] result = new double[r, c];
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                result[i, j] = A[i, j] - B[i, j];
        return result;
    }

    static double[,] Multiply(double[,] A, double[,] B)
    {
        int r1 = A.GetLength(0), c1 = A.GetLength(1);
        int r2 = B.GetLength(0), c2 = B.GetLength(1);
        double[,] result = new double[r1, c2];
        for (int i = 0; i < r1; i++)
            for (int j = 0; j < c2; j++)
                for (int k = 0; k < c1; k++)
                    result[i, j] += A[i, k] * B[k, j];
        return result;
    }

    static double[,] Transpose(double[,] A)
    {
        int r = A.GetLength(0), c = A.GetLength(1);
        double[,] result = new double[c, r];
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                result[j, i] = A[i, j];
        return result;
    }

    static double Determinant2x2(double[,] A)
    {
        return A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];
    }

    static double[,] Inverse2x2(double[,] A)
    {
        double det = Determinant2x2(A);
        if (det == 0) throw new Exception("Inverse not possible");
        double[,] inv = new double[2, 2];
        inv[0, 0] = A[1, 1] / det;
        inv[0, 1] = -A[0, 1] / det;
        inv[1, 0] = -A[1, 0] / det;
        inv[1, 1] = A[0, 0] / det;
        return inv;
    }

    static void Print(double[,] A)
    {
        int r = A.GetLength(0), c = A.GetLength(1);
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
                Console.Write($"{A[i, j],6:F2} ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static void Main()
    {
        double[,] A = CreateMatrix(2, 2);
        double[,] B = CreateMatrix(2, 2);

        Console.WriteLine("Matrix A:");
        Print(A);

        Console.WriteLine("Matrix B:");
        Print(B);

        Console.WriteLine("Addition:");
        Print(Add(A, B));

        Console.WriteLine("Subtraction:");
        Print(Subtract(A, B));

        Console.WriteLine("Multiplication:");
        Print(Multiply(A, B));

        Console.WriteLine("Transpose of A:");
        Print(Transpose(A));

        Console.WriteLine("Determinant of A:");
        Console.WriteLine(Determinant2x2(A));

        Console.WriteLine("Inverse of A:");
        Print(Inverse2x2(A));
    }
}