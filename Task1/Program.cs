// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Например: a = 5, b = 7 -> max = 7, min = 5; a = 2, b = 10 -> max = 10, min = =2; a = -9, b = -3 -> max = -3, min = -9

using System;
using static System.Console;

Clear();

WriteLine("Введите первое число: ");
int numberA = int.Parse(ReadLine()!);
WriteLine("Введите второе число: ");
int numberB = int.Parse(ReadLine()!);

if (numberA > numberB)
{
    WriteLine($"Большее число = {numberA}");
    WriteLine($"Меньшее число = {numberB}");
}
else
{
    WriteLine($"Большее число = {numberB}");
    WriteLine($"Меньшее число = {numberA}");
}

if (numberA == numberB)
{
    WriteLine("Числа равны");
}