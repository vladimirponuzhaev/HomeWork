// Задача 14: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Например: 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33].

using System;
using static System.Console;
using static System.Convert;

Clear();

int N = 8;
PrintArray(GetArray(N));

int[] GetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while (position < count)
    {
        position++;
    }
    Write(String.Join(", ", array) + ".");
}