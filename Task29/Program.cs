// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Например: M = 1, N = 15 -> 120; M = 4, N = 8 -> 30.

using System;
using static System.Console;

Clear();

WriteLine($"M = 1, N = 15 -> {SumNumbers(1, 15)}");

int SumNumbers(int FirstNumber, int LastNumber)
{
    if (LastNumber == FirstNumber) return LastNumber;
    return FirstNumber + SumNumbers(FirstNumber + 1, LastNumber);
}