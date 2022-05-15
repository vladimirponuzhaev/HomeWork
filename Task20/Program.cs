// Задача 20: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Например: m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using System;
using static System.Console;
using static System.Convert;
using static System.Math;

Clear();

int m = 3;
int n = 4;
double[,] TableDouble = GetTableDouble(m, n);
PrintTable(TableDouble);

double[,] GetTableDouble(int m, int n)
{
    double[,] table = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rand.Next(-10, 10) + rand.NextDouble();
        }
    }
    return table;
}

void PrintTable(double[,] tab)
{
    for (int i = 0; i < tab.GetLength(0); i++)
    {
        for (int j = 0; j < tab.GetLength(1); j++)
        {
            Write(Round(tab[i, j], 1) + " ");
        }
        WriteLine();
    }
}