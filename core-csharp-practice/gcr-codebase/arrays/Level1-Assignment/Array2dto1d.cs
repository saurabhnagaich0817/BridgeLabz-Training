using System;
class Array2dto1d
{
  static void Main()
{
  // taking rw as input from user
        Console.Write("Enter rw: ");
        int rw = int.Parse(Console.ReadLine());
// taking columns as input from user
        Console.Write("Enter col: ");
        int col = int.Parse(Console.ReadLine());
//  declaring 2D array and 1D array
        int[,] matrix = new int[rw, col];
        int[] array = new int[rw * col];

        int idx = 0;
// nested loops to iterate through 2D array
        for(int i = 0; i < rw; i++)
        {
            for(int j = 0; j < col; j++)
            {
                Console.Write("Enter element: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
                array[idx++] = matrix[i, j];
            }
        }
        Console.WriteLine("1D Array:");
        for(int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
    }}