// Задача 18: Пользователь вводит с клавиатуры N чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Например: 0, 7, 8, -2, -2 -> 2; 1, -7, 567, 89, 223 -> 4.

using System;
using static System.Console;
using static System.Convert;

Clear();

Write("Введите любые числа через пробел: ");
double[] N = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), ToDouble);
double result = N.Count(i => i > 0);
WriteLine();
WriteLine($"Количество чисел больше 0 –> {result}");
WriteLine();