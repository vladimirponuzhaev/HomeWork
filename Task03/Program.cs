// Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Например: 4 -> да; -3 -> нет; 7 -> нет.

using System;
using static System.Console;

Clear();

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

if (number % 2 == 0)
{
    WriteLine($"{number} - чётное число");
}

else
{
    WriteLine($"{number} - нечётное число");
}