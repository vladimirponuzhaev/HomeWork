// Задача 13: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Например: 452 -> 11, 82 -> 10, 9012 -> 12.

using System;
using static System.Console;
using static System.Convert;

Clear();

Write("Введите любое число: ");
int inputNumber = ToInt32(ReadLine());
WriteLine($"Сумма цифр числа {inputNumber}: {SumDigits(inputNumber)}");

int SumDigits(int number)
{
    int result = 0;
    while (number > 0)
    {
        result = number + result % 10;
        number = number / 10;
    }
    return result;
}