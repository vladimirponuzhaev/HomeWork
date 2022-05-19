// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива: 1 4 7 2
//                             5 9 2 3
//                             8 4 2 4
//                             5 2 6 7
//                                и
//                             1 5 8 5
//                             4 9 4 2
//                             7 2 2 6
//                             2 3 4 7
// Их произведение будет равно следующему массиву:  1 20 56 10
//                                                 20 81  8  6
//                                                 56  8  4 24
//                                                 10  6 24 49

using System;
using static System.Console;

Clear();

int row = 3;
int col = 3;

int[,] matrix1 = CreateMatrix(row, col, 1, 10);
int[,] matrix2 = CreateMatrix(row, col, 1, 10);
int[,] product = MultiplyMatrix(matrix1, matrix2);
PrintMatrix(matrix1);
WriteLine("-----");
PrintMatrix(matrix2);
WriteLine("-------");
PrintMatrix(product);

int[,] CreateMatrix(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(min, max);
        }
    }
    return matrix;
}

int[,] MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] product = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            product[i, j] = matrix1[i, j] * matrix2[i, j];
        }
    }
    return product;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        WriteLine();
    }
}