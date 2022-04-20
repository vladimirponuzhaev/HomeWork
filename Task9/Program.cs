// Задача 9: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Например: 14212 -> нет, 12821 -> да, 23432 -> да.

using System;
using static System.Console;

Clear();

Write("Введите любое пятизначное число: ");
int FiveDigitNumber = int.Parse(ReadLine()!);

if (FiveDigitNumber / 10000 == FiveDigitNumber % 10 && (FiveDigitNumber / 1000 % 10 == FiveDigitNumber / 10 % 10))
{
    WriteLine();
    WriteLine($"В введённое число: {FiveDigitNumber}, является палиндромом.");
    WriteLine();
}
else
{
    WriteLine();
    WriteLine($"Введённое число: {FiveDigitNumber}, НЕ является палиндромом.");
    WriteLine();
}