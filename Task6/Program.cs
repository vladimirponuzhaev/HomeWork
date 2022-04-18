// Задача 6: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Например: 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6.

using System;
using static System.Console;

Clear();

Write("Введите любое число: ");
int AnyNumber = int.Parse(ReadLine()!);

string ThirdDigit = AnyNumber.ToString();

if (AnyNumber >= 100)
{
    WriteLine(ThirdDigit[2]);
}
else
{
    WriteLine($"В числе {AnyNumber} нет третьей цифры!");
}