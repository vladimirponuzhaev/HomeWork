// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа по убыванию в промежутке от M до N.
// Например: M = 1, N = 5 -> "5, 4, 3, 2, 1"; M = 4, N = 8 -> "8, 7, 6, 5, 4".

using System;
using static System.Console;

Clear();

PrintNumbers(1, 5);
WriteLine();

void PrintNumbers(int FirstNumber, int LastNumber)
{
    if (LastNumber < FirstNumber) return;
    PrintNumbers(FirstNumber + 1, LastNumber);
    Write(FirstNumber + " ");
}

int M = 4;
int N = 8;

string result = GetNumbers(M, N);
WriteLine(result);

string GetNumbers(int FirstNumber, int LastNumber)
{
    if (LastNumber == FirstNumber) return LastNumber.ToString();
    return (LastNumber + " " + GetNumbers(FirstNumber, LastNumber - 1));
}