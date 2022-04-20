// Задача 5: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Например: 456 -> 5; 782 -> 8; 918 -> 1.

using System;
using static System.Console;

Clear();

Write("Введите трёхзначное число: ");
int ThreeDigitNumber = int.Parse(ReadLine()!);
int SecondDigit = (ThreeDigitNumber / 10) % 10;

WriteLine($"Вторая цифра введённого трёхзначного числа: {SecondDigit}");