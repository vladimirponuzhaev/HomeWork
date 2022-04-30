// Задача 15: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Например:[345, 897, 568, 234] -> 2

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
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    int evenNumber = 0;
    int unevenNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) evenNumber++;
        else unevenNumber++;
    }
    WriteLine(String.Join(", ", array) + ".");
    WriteLine();
    WriteLine($"Количество чётных чисел в массиве: {evenNumber}, количество нечётных чисел в массиве: {unevenNumber}.");
    WriteLine();
}