// Задача 17: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Наример: [3 7 22 2 78] -> 76.

using System;
using static System.Console;

Clear();

int size = 5;
PrintResult(FillArray(size));

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintResult(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        // Write(Math.Round(array[i], 2).ToString() + ", "); // В таком виде не получается сообразить, как вывести элементы массива через "," с "." в конце.
        Write(array[i].ToString("0.00") + ", "); // В таком виде не получается сообразить, как вывести элементы массива через "," с "." в конце.
    }
    // WriteLine(String.Join(", ", array) + "."); // В таком виде не получается сообразить, как вывести элементы массива с округлением до .00.
    WriteLine();
    double difference = array.Max() - array.Min();
    WriteLine();
    WriteLine($"Минимальное значение массива – {array.Min():f2}, максимальное значение массива – {array.Max():f2}");
    WriteLine();
    WriteLine($"Разница между максимальным и минимальным элемантами массива составляет – {difference:f2}");
    WriteLine();
}