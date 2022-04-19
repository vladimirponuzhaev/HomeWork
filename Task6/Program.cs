// Задача 6: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Например: 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6.

using System;
using static System.Console;

Clear();

// 1-й способ
// Write("Введите любое число: ");
// int AnyNumber = int.Parse(ReadLine()!);

// if (AnyNumber > 99)
// {
//     while (AnyNumber > 999)
//         AnyNumber /= 10;
//     AnyNumber %= 10;
//     Console.WriteLine($"В введённом числе третья цифра: {AnyNumber}");
// }
// else
//     Console.WriteLine($"В введённом числе: {AnyNumber}, нет третьей цифры!");

// 2-й способ
Write("Введите любое число: ");
int AnyNumber = int.Parse(ReadLine()!);

string ThirdDigit = AnyNumber.ToString();

if (AnyNumber >= 100)
{
    WriteLine($"В введённом числе третья цифра: {ThirdDigit[2]}");
}
else
{
    WriteLine($"В числе {AnyNumber} нет третьей цифры!");
}