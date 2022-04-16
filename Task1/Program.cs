// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Например: a = 5, b = 7 -> max = 7, min = 5; a = 2, b = 10 -> max = 10, min = =2; a = -9, b = -3 -> max = -3, min = -9

Console.Clear();

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA > numberB)
{
    Console.WriteLine($"Большее число = {numberA}");
    Console.WriteLine($"Меньшее число = {numberB}");
}
else
{
    Console.WriteLine($"Большее число = {numberB}");
    Console.WriteLine($"Меньшее число = {numberA}");
}

if (numberA == numberB)
{
    Console.WriteLine("Числа равны");
}