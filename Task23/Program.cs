// Задача 23: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив: 1 4 7 2
//                         5 9 2 3
//                         8 4 2 4
// В итоге получается вот такой массив: 1 2 4 7
//                                      2 3 5 9
//                                      2 4 4 8

using System;
using static System.Console;

Clear();

int row = 4;
int col = 4;
int min = 1;
int max = 10;

int[,] table = GetMatrix(row, col, min, max);
PrintTable(table);
WriteLine();
int[,] rowSort = SortRowAscending(table);
PrintTable(rowSort);

int[,] GetMatrix(int row, int col, int min, int max)
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

int[,] SortRowAscending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minPosition = j;
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] < array[i, minPosition]) minPosition = k;
            }
            int tmp = array[i, j];
            array[i, j] = array[i, minPosition];
            array[i, minPosition] = tmp;
        }

    }
    return array;
}

void PrintTable(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Write(matrix[i, j] + " ");
        }
        WriteLine();
    }
}