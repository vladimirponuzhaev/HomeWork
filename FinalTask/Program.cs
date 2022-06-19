// Задание: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами
// Например: ["hello", "2", "world", ":-)"] -> ["2", ":-)"]; ["1234", "1567", "-2", "computer science"] -> ["-2"]; ["Russia", "Denmark", "Kazan"] -> []

using System;
using static System.Console;

Clear();

string[] array1 = new string[] { "hello", "2", "world", ":-)" };
PrintArray(array1);
Formation(array1);
Write("Итог: ");
PrintArray(array1);
WriteLine();

string[] array2 = new string[] { "1234", "1567", "-2", "computer science" };
PrintArray(array2);
Formation(array2);
Write("Итог: ");
PrintArray(array2);
WriteLine();

string[] array3 = new string[] { "Russia", "Denmark", "Kazan" };
PrintArray(array3);
Formation(array3);
Write("Итог: ");
PrintArray(array3);

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
    WriteLine();
}
void Formation(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        string element = arr[i];
        if (element.Length <= 3)
        {
            arr[i] = element;
        }
        else arr[i] = string.Empty;
    }
}