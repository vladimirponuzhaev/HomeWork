// Задача 8: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Например: 456 -> 46, 782 -> 72, 918 -> 98.

using System;
using static System.Console;

Clear();

int RandomNumber = new Random().Next(100, 1000);

int NewRandomNumber = RandomNumber / 100 * 10 + RandomNumber % 10;

WriteLine($"Если из числа {RandomNumber} удалить вторую цифру, получится число {NewRandomNumber}");
WriteLine();