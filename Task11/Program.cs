// Задача 11: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Например: 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125.

using System;
using static System.Console;

Clear();

Write("Введите любое число: ");

double Number = double.Parse(ReadLine()!);

WriteLine();
Write($"Таблица кубов чисел от 1 до {Number}: ");

for (double F = 1; F <= Number; F++)
{
    Write($"{Math.Pow(F, 3)}, ");
}