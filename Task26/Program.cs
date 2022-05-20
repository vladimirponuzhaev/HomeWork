﻿// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. Массив размером 2 x 2 x 2.
// Например: 12(0,0,0) 22(0,0,1)
//           45(1,0,0) 53(1,0,1)

using System;
using static System.Console;
using static System.Convert;

Clear();

int dimension1 = ReadInteger("Введите размер 1: ");
int dimension2 = ReadInteger("Введите размер 2: ");
int dimension3 = ReadInteger("Введите размер 3: ");
int count2DNumbers = 89;

if (dimension1 * dimension2 * dimension3 <= count2DNumbers)
{
int[,,] array = CreateArray3D(dimension1, dimension2, dimension3);
for (int d1 = 0; d1 < array.GetLength(0); d1++)
for (int d2 = 0; d2 < array.GetLength(1); d2++)
for (int d3 = 0; d3 < array.GetLength(2); d3++)
WriteLine($"array[{d1}, {d2}, {d3}] = {array[d1, d2, d3]}");
}
else
{
WriteLine("Невозможно заполнить массив двухзначными неповторяющимися числами");
}

int[,,] CreateArray3D(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];

    int value = 10;
    int[] twoDigitValues = new int[89];
    for (int i = 0; i < twoDigitValues.Length; i++)
        twoDigitValues[i] = value++;

    int minValueIndex = 0;
    for (int d1 = 0; d1 < array.GetLength(0); d1++)
        for (int d2 = 0; d2 < array.GetLength(1); d2++)
            for (int d3 = 0; d3 < array.GetLength(2); d3++)
            {
                int valueIndex = new Random().Next(minValueIndex, twoDigitValues.Length);
                array[d1, d2, d3] = twoDigitValues[valueIndex];
                twoDigitValues[valueIndex] = twoDigitValues[minValueIndex];
                minValueIndex++;
            }
    return array;
}

int ReadInteger(string message)
{
    Write(message);
    return ToInt32(ReadLine());
}