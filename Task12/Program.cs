// Задача 12: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Например: 3, 5 -> 243(3⁵), 2, 4 -> 16.

using System;
using static System.Console;
using static System.Convert;

Clear();

Write("Введите число А: ");
int NumberA = ToInt32(ReadLine());

Write("Введите натуральное число B: ");
int NumberB = ToInt32(ReadLine());

if (NumberB > 1)
{
    int result = Pow(NumberA, NumberB);
    WriteLine($"{NumberA} ^ {NumberB} = {Pow(NumberA, NumberB)}");
}
else
{
    Write($"Введённое число B: {NumberB}, не является натуральным");
}

int Pow(int NumA, int NumB)
{
    int ProdOfNum = NumA;

    while (NumB > 1)
    {
        NumB = NumB - 1;
        ProdOfNum = ProdOfNum * NumA;
    }
    return ProdOfNum;
}