// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Например: 2, 3, 7 -> 7; 44, 5, 78 -> 78; 22, 3, 9 -> 22.

using System;
using static System.Console;

Clear();

WriteLine("Введите первое число: ");
int numberA = int.Parse(ReadLine());

WriteLine("Введите второе число: ");
int numberB = int.Parse(ReadLine());

WriteLine("Введите третье число: ");
int numberC = int.Parse(ReadLine());

int max = numberA;

if (numberB > max)
{
    max = numberB;
}

if (numberC > max)
{
    max = numberC;
}

WriteLine($"Максимальное число: {max}");