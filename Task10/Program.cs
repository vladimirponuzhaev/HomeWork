// Задача 10: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Например: A(3,6,8); B(2, 1, -7) -> 15.84, A(7, -5, 0); B(1, -1, 9) -> 11.53.

using System;
using static System.Console;

Clear();

Write("Введите координату X1: ");
double X1 = double.Parse(ReadLine()!);
Write("Введите координату Y1: ");
double Y1 = double.Parse(ReadLine()!);
Write("Введите координату Z1: ");
double Z1 = double.Parse(ReadLine()!);

WriteLine();
Write("Введите координату X2: ");
double X2 = double.Parse(ReadLine()!);
Write("Введите координату Y2: ");
double Y2 = double.Parse(ReadLine()!);
Write("Введите координату Z2: ");
double Z2 = double.Parse(ReadLine()!);

double Point = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2) + Math.Pow((Z2 - Z1), 2));

WriteLine();
WriteLine($"Расстояние между точками в 3D пространстве = {Point:f2}");
WriteLine();

// // Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// // A(3, 6); B(2, 1)-> 5,09; A(7, -5); B(1, -1)-> 7,21

// using System;
// using static System.Console;

// Clear();

// Write("Введите координату X1: ");
// double X1 = double.Parse(ReadLine()!);
// Write("Введите координату Y1: ");
// double Y1 = double.Parse(ReadLine()!);

// Write("Введите координату X2: ");
// double X2 = double.Parse(ReadLine()!);
// Write("Введите координату Y2: ");
// double Y2 = double.Parse(ReadLine()!);

// double Point = Math.Sqrt(Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2));

// WriteLine($"{Point:f2}");

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// Например: 5 -> 1, 4, 9, 16, 25; 2-> 1, 4

// using System;
// using static System.Console;

// Clear();

// Write("Введите любое число: ");

// int Number = int.Parse(ReadLine()!);

// for (int F = 1; F <= Number; F++)
// {
//     Write($"{F * F}, ");
// }