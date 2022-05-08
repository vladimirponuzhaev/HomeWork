// Задача 19: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Например: k1 = 5, b1 = 2; k2 = 9, b2 = 4 -> (-0,5; -0,5).

using System;
using static System.Console;
using static System.Convert;
using static System.Math;

Clear();

Write("Введите k1: ");
double k1 = ToDouble(ReadLine());
Write("Введите b1: ");
double b1 = ToDouble(ReadLine());
Write("Введите k2: ");
double k2 = ToDouble(ReadLine());
Write("Введите b2: ");
double b2 = ToDouble(ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

WriteLine($"Пересечение в точке: ({Round(x, 2)};{Round(y, 2)})");