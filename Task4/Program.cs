// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Например: 5 -> 2, 4; 8 -> 2, 4, 6, 8.

using System;
using static System.Console;

Clear();

Write("Введите число: ");
int N = int.Parse(ReadLine()!);

Write($"Все чётные числа: ");

for (int i = 1; i <= N; i = i + 1)
{
    if (i % 2 == 0)
    {
        Write($"{i}, ");
    }
}