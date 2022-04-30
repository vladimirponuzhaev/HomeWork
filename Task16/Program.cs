// Задача 16: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Например:[3, 7, 23, 12] -> 19; [-4, -6, 89, 6] -> 0

using System;
using static System.Console;

Clear();

int size = 4;
PrintResult(FillArray(size));

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-99, 100);
    }
    return array;
}

void PrintResult(int[] array)
{
    int summaElements = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) summaElements += array[i];
    }
    WriteLine(String.Join(", ", array) + ".");
    WriteLine();
    WriteLine($"Сумма чисел, стоящих на нечётных позициях, составляет: {summaElements}.");
    WriteLine();
}