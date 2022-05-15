using System;
using static System.Console;
using static System.Convert;
using static System.Math;
using static System.String;

Clear();

// Семинар 1 – Задача 0: Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например: 4 -> 16, -3 -> 9, -7 -> 49.
// Console.Write("Введите число: ");
// int Number = int.Parse(Console.ReadLine()!);
// int sqr = Number * Number;
// int sqr1 = Convert.ToInt32(Math.Pow(Number, 2));
// WriteLine($"Квадрат числа {Number} = {sqr} {sqr1}");

// Семинар 1 – Задача 1: Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго числа.
// Например: a = 5, b = 25 -> да; a = 2, b = 10 -> нет; a = 9, b = -3 -> нет; a = -3, b = 9 -> да.
// int numberA;
// int numberB;
// WriteLine("Введите первое число");
// numberA = int.Parse(ReadLine()!);
// WriteLine("Введите второе число");
// numberB = int.Parse(ReadLine()!);
// if (numberB == numberA * numberA)
// {
//     WriteLine($"Первое число: {numberA} является квадратом второго: {numberB}");
// }
// else
// {
//     WriteLine($"Первое число: {numberA} НЕ является квадратом второго: {numberB}");
// }

// Семинар 1 – Задача 2: Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// Например: 3 -> Среда, 5 -> Пятница и т.д.
// int Day;
// WriteLine("Введите номер дня недели: от 1 до 7");
// int Day = ToInt32(ReadLine()!);
// if (Day == 1)
// {
//     WriteLine("Понедельник - рабочий день");
// }
// if (Day == 2)
// {
//     WriteLine("Вторник - рабочий день недели");
// }
// if (Day == 3)
// {
//     WriteLine("Среда - рабочий день недели");
// }
// if (Day == 4)
// {
//     WriteLine("Четверг - рабочий день недели");
// }
// if (Day == 5)
// {
//     WriteLine("Пятница - рабочий день недели");
// }
// if (Day == 6)
// {
//     WriteLine("Суббота - выходной день недели");
// }
// if (Day == 7)
// {
//     WriteLine("Воскресенье - выходной день недели");
// }

// Семинар 1 – Задача 3: Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Например: 4 -> - 4, -3, -2, -1, 0, 1, 2, 3, 4; 2 -> - 2, -1, 0, 1, 2.
// int Number1 = ToInt32(ReadLine()!);
// int Number2 = -Number1;
// for (int i = Number2; i <= Number1; i++)
// {
//     Write($"{Number2}, ");
//     Number2++;
// }
// while (Number2 <= Number1)
// {
//     Write($"{Number2}, ");
//     Number2++;
// }

// Семинар 1 – Задача 4: Напишите программу, которая принимает на вход трёхзначное и на выходе показывает последнюю цифру этого числа.
// Например: 456 -> 6, 782 -> 2, 918 -> 8.
// int number = ToInt32(ReadLine());
// int TowDigit = number / 10;
// int ThirdDigit = number % 10;
// WriteLine($"TowDigit={TowDigit}, ThirdDigit={ThirdDigit}");

// Семинар 1 – Задача 5: Напишите программу, которая принимает на вход четырёхзначное число и на выходе показывает первую цифру этого числа.
// Например: 4567 -> 4, 3782 -> 3, 9186 -> 9.
// int fournumber = ToInt32(ReadLine());
// int FirstNumber = fournumber / 1000;
// WriteLine($"Первая цифра четырёхзначного числа - {fournumber} = {FirstNumber}");

// ДЗ 1 – Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Например: a = 5, b = 7 -> max = 7, min = 5; a = 2, b = 10 -> max = 10, min = =2; a = -9, b = -3 -> max = -3, min = -9.
// int FirstNumber;
// int SecondNumber;
// WriteLine("Введите первое число");
// FirstNumber = ToInt32(ReadLine());
// WriteLine("Введите второе число");
// SecondNumber = ToInt32(ReadLine());
// if (FirstNumber > SecondNumber)
// {
//     WriteLine($"Первое число {FirstNumber} больше второго числа {SecondNumber}");
// }
// if (FirstNumber == SecondNumber)
// {
//     WriteLine($"Числа равны!");
// }
// else
// {
//     WriteLine($"Второе число {SecondNumber} больше первого числа {FirstNumber}");
// }

// ДЗ 1 – Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Например: 2, 3, 7 -> 7; 44, 5, 78 -> 78; 22, 3, 9 -> 22.
// int FirstNumber;
// int SecondNumber;
// int ThirdNumber;
// WriteLine("Введите первое число");
// FirstNumber = ToInt32(ReadLine());
// WriteLine("Введите второе число");
// SecondNumber = ToInt32(ReadLine());
// WriteLine("Введите третье число");
// ThirdNumber = ToInt32(ReadLine());
// int Max = FirstNumber;
// if (SecondNumber > Max)
// {
//     Max = SecondNumber;
// }
// if (ThirdNumber > Max)
// {
//     Max = ThirdNumber;
// }
// WriteLine($"Max={Max}");

// ДЗ 1 – Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Например: 4 -> да; -3 -> нет; 7 -> нет.
// int Number;
// WriteLine("Введите число");
// Number = ToInt32(ReadLine());
// if (Number % 2 == 0)
// {
//     WriteLine($"Данное число {Number} является чётным");
// }
// else
// {
//     WriteLine($"Данное число {Number} НЕ является чётным");
// }

// ДЗ 1 – Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// Например: 5 -> 2, 4; 8 -> 2, 4, 6, 8.
// WriteLine("Введите любое число");
// int N = ToInt32(ReadLine());
// int evenNum = 1;
// Write($"Все чётные числа от 1 до {N}: ");
// while (evenNum < N) // Решение через – while
// {
//     if (evenNum % 2 == 0) Write($"{evenNum}, ");
//     evenNum++;
// }
// Write($"Все чётные числа от 1 до {N}: ");
// for (int i = 1; i <= N; i = i + 1) // Решение через – for
// {
//     if (i % 2 == 0)
//     {
//         Write($"{i}, ");
//     }
// }

// Семинар 2 - Задача 7: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Например: 456 -> 46, 782 -> 72, 918 -> 98.
// Решение математическим методом
// int ThreeDigit = new Random().Next(100, 1000); // Задаём случайное трёхзначное число.
// int FirstNumber = ThreeDigit / 100; // Находим первую цифру заданного трёхзначного случайного числа.
// int ThirdNumber = ThreeDigit % 10; // Находим вторую цифру заданного трёхзначного случайного числа. 
// WriteLine($"{ThreeDigit} -> " + FirstNumber + ThirdNumber); // Вывод в консоль трёхзначного числа и первой, третьей цифр.
// Решение методом через массивы - строковая переменная
// int ThreeDigit = new Random().Next(100, 1000); // Задаём случайное трёхзначное число.
// string ThreeDigitS = ThreeDigit.ToString(); // Задаём строковую переменную.
// int FirstNumber = ToInt32(ThreeDigitS[0].ToString()); // Находим первую цифру заданного трёхзначного случайного числа.
// int ThirdNumber = ToInt32(ThreeDigitS[2].ToString()); // Находим вторую цифру заданного трёхзначного случайного числа. 
// WriteLine($"{ThreeDigit} -> " + FirstNumber + ThirdNumber); // Вывод в консоль трёхзначного числа и первой, третьей цифр.

// Семинар 2 - Задача 8: Напишите программу, которая будет принимать на вход два числа и выводит, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
// Например: 34, 5 -> не кратно, остаток 4; 16, 4 -> кратно.
// WriteLine($"Введите первое число: ");
// int FirstNumber = ToInt32(ReadLine());
// WriteLine($"Введите второе число: ");
// int SecondNumber = ToInt32(ReadLine());
// if (FirstNumber % SecondNumber == 0) WriteLine($"{FirstNumber}, {SecondNumber} -> кратно");
// else WriteLine($"{FirstNumber}, {SecondNumber} -> не кратно, остаток = {FirstNumber % SecondNumber}");

// Семинар 2 - Задача 9: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// Например: 14 -> нет, 46 -> нет, 161 -> да.
// WriteLine("Введите любое число: ");
// int Number = ToInt32(ReadLine());
// string result = Number % 7 == 0 && Number % 23 == 0 ? $"{Number} -> дa" : $"{Number} -> нет"; // Через тернарный оператор
// WriteLine(result);
// if (Number % 7 == 0 && Number % 23==0) // Через оператор if .. else
// {
//     WriteLine($"{Number} -> дa");
// }
// else
// {
//     WriteLine($"{Number} -> нет");
// }

// Семинар 2 - Задача 10: Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// Например: 5, 25 -> да, 16, 4 -> да, 34, 7 -> нет.
// WriteLine("Введите первое число: ");
// int FirstNumber = ToInt32(ReadLine());
// WriteLine("Введите второе число: ");
// int SecondNumber = ToInt32(ReadLine());
// string result = FirstNumber * FirstNumber == SecondNumber ? $"{SecondNumber} является квадратом числа {FirstNumber}" : SecondNumber * SecondNumber == FirstNumber ? $"{FirstNumber} является квадратом числа {SecondNumber}" : $"Ни одно из чисел не является квадратом другого";
// WriteLine(result);

// ДЗ 2 – Задача 5: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Например: 456 -> 5, 782 -> 8, 918 -> 1.
// WriteLine("Введите любое трёхзначное число: ");
// int ThreeDigitNumber = ToInt32(ReadLine());
// int SecondDigit = ThreeDigitNumber / 10 % 10;
// WriteLine($"{ThreeDigitNumber} -> {SecondDigit}");

// ДЗ 2 - Задача 6: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Например: 645 -> 5; 78 -> третьей цифры нет; 32679 -> 6.
// WriteLine("Введите любое число: ");
// int AnyNumber = ToInt32(ReadLine());
// Write($"Третья цифра введённого числа {AnyNumber} - ");
// if (AnyNumber > 99) // Решение математическим методом
// {
//     while (AnyNumber > 999)
//     {
//         AnyNumber /= 10;
//         AnyNumber %= 10;
//         WriteLine($"{AnyNumber}");
//     }

// }
// else WriteLine($"В ведённом числе {AnyNumber} - третьей цифры нет");
// string ThirdDigit = AnyNumber.ToString(); // Решение через массив
// if (AnyNumber >= 100)
// {
//     WriteLine($"Третья цифра введённого числа {AnyNumber} - {ThirdDigit[2]}");
// }
// else WriteLine($"В ведённом числе {AnyNumber} - третьей цифры нет");

// ДЗ 2 - Задача 7: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Например: 6 -> да, 7 -> да, 1 -> нет.
// WriteLine("Введите цифру, обозначающую день недели: ");
// int DayOfWeek = ToInt32(ReadLine());
// if (DayOfWeek == 0 ^ DayOfWeek >= 8)
// {
//     WriteLine("Введённая цифра, не обозначает какой-либо день недели!");
//     Write("Повторите попытку, введя цифру от 1 до 7");
// }
// if (DayOfWeek >= 1 && DayOfWeek <= 5)
// {
//     WriteLine("Введённая цифра, обозначаюет РАБОЧИЙ день недели!");
// }
// if (DayOfWeek == 6 || DayOfWeek == 7)
// {
//     WriteLine("Введённая цифра, обозначаюет выходной день недели - субботу или воскресенье!");
// }

// ДЗ 2 - Задача 8: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// Например: 456 -> 46, 782 -> 72, 918 -> 98.
// int ThreeDigitNumber = new Random().Next(100, 1000);
// string ThreeDigitNumberN = ThreeDigitNumber.ToString();
// int FirstDigit = ToInt32(ThreeDigitNumberN[0].ToString());
// int SecondDigit = ToInt32(ThreeDigitNumberN[2].ToString());
// WriteLine($"{ThreeDigitNumber} -> {FirstDigit}{SecondDigit}");

// Семинар 3 - Задача 11: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// Наример: 1 -> x > 0 y > 0.
// WriteLine("Введите номер четверти: ");
// int quarter = ToInt32(ReadLine());
// switch (quarter)
// {
//     case 1:
//         {
//             WriteLine("x > 0; y > 0");
//             break;
//         }
//     case 2:
//         {
//             WriteLine("x < 0; y > 0");
//             break;
//         }
//     case 3:
//         {
//             WriteLine("X < 0; Y < 0");
//             break;
//         }
//     case 4:
//         {
//             WriteLine("X > 0; Y < 0");
//             break;
//         }
//     default:
//         {
//             WriteLine("Введена неправильная четверть");
//             break;
//         }
// }

// Семинар 3 - Задача 12: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// Наример: // Например: X = -3, Y = 5 -> 2-я четверть.
// Write("Введите координату X ≠ 0: ");
// int coordinateX = ToInt32(ReadLine());
// Write("Введите координату Y ≠ 0: ");
// int coordinateY = ToInt32(ReadLine());
// string Coordinates = coordinateX > 0 && coordinateY > 0 ? $"Введены координаты 1-й чертверти." : coordinateX < 0 && coordinateY > 0 ? $"Введены координаты 2-й чертверти." : coordinateX < 0 && coordinateY < 0 ? $"Введены координаты 3-й чертверти." : coordinateX > 0 && coordinateY < 0 ? $"Введены координаты 4-й чертверти." : $"Введены некорректные координаты X и/или Y!";
// WriteLine(Coordinates);

// Семинар 3 - Задача 13: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
// Наример: // A(3, 6), B(2, 1) -> 5,09; A(7, -5), B(1, -1) -> 7,21.
// Write("Введите координату X1: ");
// var X1 = ToInt32(ReadLine());
// Write("Введите координату Y1: ");
// var Y1 = ToInt32(ReadLine());
// Write("Введите координату X1: ");
// var X2 = ToInt32(ReadLine());
// Write("Введите координату Y1: ");
// var Y2 = ToInt32(ReadLine());
// var DistancePoint = Sqrt(Pow(X2 - X1, 2) + Pow(Y2 - Y1, 2));
// WriteLine($"Расстояние между двумя точками в 2D пространстве = {Round(DistancePoint, 2)}");

// Семинар 3 - Задача 14: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// Например: 5 -> 1, 4, 9, 16, 25; 2 -> 1, 4
// Write("Введите любое число: ");
// int AnyNumber = ToInt32(ReadLine());
// int QuadOfNumber = 1;
// Write($"{AnyNumber} -> ");
// while (QuadOfNumber <= AnyNumber)
// {
//     Write($"{Pow(QuadOfNumber, 2)} ");
//     QuadOfNumber++;
// }

// ДЗ 3 - Задача 9: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Например: 14212 -> нет, 12821 -> да, 23432 -> да.
// WriteLine("Введите любое пятизначное число: ");
// int FiveDigitNumber = ToInt32(ReadLine());
// if (FiveDigitNumber / 10000 == FiveDigitNumber % 10 && FiveDigitNumber / 1000 % 10 == FiveDigitNumber / 10 % 10)
// {
//     WriteLine();
//     WriteLine($"Число {FiveDigitNumber} является палиндромом.");
//     WriteLine();
// }
// else
// {
//     WriteLine();
//     WriteLine($"Число {FiveDigitNumber} НЕ является палиндромом.");
//     WriteLine();
// }

// ДЗ 3 - Задача 10: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// Например: A(3,6,8); B(2, 1, -7) -> 15.84, A(7, -5, 0); B(1, -1, 9) -> 11.53.
// Write("Введите координату X1: ");
// var X1 = ToInt32(ReadLine());
// Write("Введите координату Y1: ");
// var Y1 = ToInt32(ReadLine());
// Write("Введите координату Z1: ");
// var Z1 = ToInt32(ReadLine());
// Write("Введите координату X2: ");
// var X2 = ToInt32(ReadLine());
// Write("Введите координату Y2: ");
// var Y2 = ToInt32(ReadLine());
// Write("Введите координату Z2: ");
// var Z2 = ToInt32(ReadLine());
// var DistancePoint = Sqrt(Pow(X2 - X1, 2) + Pow(Y2 - Y1, 2) + Pow(Z2 - Z1, 2));
// WriteLine($"Расстояние между двумя точками в 3D пространстве = {Round(DistancePoint, 2)}");

// ДЗ 3 - Задача 11: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// Например: 3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125.
// WriteLine("Введите любое число: ");
// int AnyNumber = ToInt32(ReadLine());
// int CubeNumbers = 1;
// while (CubeNumbers <= AnyNumber)
// {
//     Write($"{Pow(CubeNumbers, 3)} ");
//     CubeNumbers++;
// }

// Вывод в строку массива, используя - String.Join(” “, x)
// int[] r = new int[5];
// string t = "123456789";
// for (int i = 0; i < 5; i++)
// {
//     r[i] = new Random().Next(10);
// }
// WriteLine(String.Join(", ", t.ToArray())); // Вывод строки через "," t.ToArray - разбей строку t на символы
// WriteLine(String.Join(", ", r)); // Вывод масссива в строку

// Семинар 4 - Задача 15: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// Например: 7 -> 28, 4 -> 10, 8 -> 36.
// Write("Ведите А: ");
// WriteLine(Summa(ToInt32(ReadLine())));
// int Summa(int number)
// {
//     int sum = 0;
//     for (int i = 1; i <= number; i++)
//     {
//         sum += i;
//         if (i < number) Write(i + " + ");
//         else Write(i + " ");
//     }
//     Write($"= ");
//     return sum;
// }

// Семинар 4 - Задача 16: Напишите программу, котрая принимает число и выдаёт количество цифр в числе.
// Например: 23 -> 2, 4 -> 1, 353 -> 3.
// Write("Введите любое число: ");
// int number = ToInt32(ReadLine());
// WriteLine($"В числе {number} - {Digits(number)} цифр(а)(ы)");
// // WriteLine("Количество цифр введённого числа " + number + " = {0}", Digits(number));
// int Digits(int numS)
// {
//     int i = 0;
//     while (numS > 0)
//     {
//         numS = numS / 10;
//         i++;
//     }
//     return i;
// }

// Семинар 4 - Задача 17: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// Например: Например: 4 -> 24, 5 -> 120.
// Write("Введите любое число: ");
// int Number = ToInt32(ReadLine());
// WriteLine($"Произведение чисел от 1 до {Number} = " + ProductNumbers(Number));
// int ProductNumbers(int NewNumber)
// {
//     int ProdNum = 1;
//     for (int i = 1; i <= NewNumber; i++)
//     {
//         ProdNum *= i;
//     }
//     return ProdNum;
// }

// Семинар 4 - Задача 18: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Например: [1,0,1,1,0,1,0,0].
// int[] Array = new int[8];
// for (int i = 0; i < 8; i++)
// {
//     Array[i] = new Random().Next(2);
// }
// WriteLine($"[{Join(", ", Array)}]");
// Динамический массив; можно задать длину массива
// Write("Введите длину массива: ");
// int ArrayLength = ToInt32(ReadLine());
// WriteLine($"[{String.Join(", ", Array(ArrayLength))}]");
// int[] Array(int length)
// {
//     int[] array = new int[length];
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(2);
//     }
//     return array;
// }

// ДЗ 4 - Задача 12: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Например: 3, 5 -> 243 (3⁵); 2, 4 -> 16.


// ДЗ 4 - Задача 13: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Например: 452 -> 11, 82 -> 10, 9012 -> 12.


// ДЗ 4 - Задача 14: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Например: 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]; 6, 1, 33 -> [6, 1, 33].


//----------------------------------------------------------------------

// using System;

// double numberA = new Random().NextDouble() * 10;
// double numberB = new Random().Next(1, 10);
// double result = numberA / numberB;
// Console.WriteLine($"{numberA:F2} / {numberB:F2} = {result:F5}");

// namespace CSharpLesson8
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // ## Объявление массивов и инициализация массивов
//             // ### Объявление массивов
//             Console.WriteLine("## Объявление массивов и инициализация массивов");
//             Console.WriteLine("### Объявление массивов");

//             int[] na1; // массив типа int

//             int[] na2 = new int[5]; // массив из пяти элементов типа int

//             int[] na3;
//             na3 = new int[5]; // массив из пяти элементов типа int

//             Console.WriteLine(na3[0]); // значение: 0
//             Console.WriteLine(na3[1]); // значение: 0
//             //Console.WriteLine(na1[0]); // ошибка компиляции
//             Console.WriteLine();

//             // ### Инициализация массивов
//             Console.WriteLine("### Инициализация массивов");

//             bool[] ba1 = new bool[3];
//             Console.WriteLine("ba1[0]: " + ba1[0].ToString());

//             string[] sa1 = new string[3];
//             sa1[0] = "abc";
//             sa1[1] = "def";
//             sa1[2] = "ghi";
//             Console.WriteLine($"sa1: {sa1[0]}, {sa1[1]}, {sa1[2]}");

//             double[] da1 = new double[3] { 0.1, 0.2, 0.3 };
//             Console.WriteLine($"da1: {da1[0]}, {da1[1]}, {da1[2]}");

//             double[] da2 = { 0.4, 0.5, 0.6 };
//             Console.WriteLine($"da2: {da2[0]}, {da2[1]}, {da2[2]}");

//             Console.WriteLine();

//             // ### Неявная типизация
//             Console.WriteLine("### Неявная типизация");

//             var va2 = new string[3];
//             va2[0] = "John";
//             va2[1] = "Mary";
//             va2[2] = "Mike";
//             Console.WriteLine($"va2: {va2[0]}, {va2[1]}, {va2[2]}");

//             var va1 = new[] { 1, 2, 3 };
//             Console.WriteLine($"va1: {va1[0]}, {va1[1]}, {va1[2]}");

//             Console.WriteLine();

//             // ## Доступ к элементам массива. Обход элементов массива
//             Console.WriteLine("## Доступ к элементам массива. Обход элементов массива");

//             int[] na4 = { 1, 2, 3, 4, 5 };
//             Console.WriteLine($"na4[0]: {na4[0]}");
//             //Console.WriteLine($"na4[10]: {na4[10]}");

//             for (int i = 0; i < na4.Length; i++)
//             {
//                 Console.Write(na4[i].ToString() + " ");
//             } // 1 2 3 4 5
//             Console.WriteLine();

//             foreach (var v in na4)
//             {
//                 Console.Write(v.ToString() + " ");
//             } // 1 2 3 4 5
//             Console.WriteLine();

//             for (int i = 0; i < na4.Length; i++)
//             {
//                 na4[i] = (na4[i] + 3) * 10;
//                 Console.Write(na4[i].ToString() + " ");
//             } // 40 50 60 70 80
//             Console.WriteLine();

//             // ## Передача массива в метод
//             Console.WriteLine("## Передача массива в метод");

//             int[] na5 = { 1, 2, 3, 4, 5 };
//             foreach (var v in na5) // 1 2 3 4 5
//                 Console.Write(v + " ");

//             Console.WriteLine();

//             WorkWithArray(na5);

//             foreach (var v in na5) // 123 2 3 4 5
//                 Console.Write(v + " ");

//             Console.WriteLine();

//             // ## Многомерные массивы
//             // ### Прямоугольные массивы
//             Console.WriteLine("## Многомерные массивы");
//             Console.WriteLine("### Прямоугольные массивы");

//             double[,] dm1 = new double[3, 3];
//             for (int i = 0; i < 3; i++)
//                 for (int j = 0; j < 3; j++)
//                     dm1[i, j] = i + j;

//             for (int i = 0; i < 3; i++)
//             {
//                 for (int j = 0; j < 3; j++)
//                     Console.Write($"{dm1[i, j]} ");
//                 Console.WriteLine();
//             }

//             Console.WriteLine();

//             double[,] dm2 = { { 1, 2, 3 }, { 4, 5, 6 } };
//             for (int i = 0; i < 2; i++)
//             {
//                 for (int j = 0; j < 3; j++)
//                     Console.Write($"{dm2[i, j]} ");
//                 Console.WriteLine();
//             }
//             Console.WriteLine();

//             // ## Зубчатые массивы
//             Console.WriteLine("## Зубчатые массивы");

//             int[][] nm1 = new int[3][];

//             for (int i = 0; i < nm1.Length; i++)
//                 nm1[i] = new int[i + 1];

//             for (int i = 0; i < nm1.Length; i++)
//             {
//                 for (int j = 0; j < nm1[i].Length; j++)
//                     Console.Write($"{nm1[i][j]} ");

//                 Console.WriteLine();
//             }

//             Console.WriteLine();

//             // ## Класс System.Array
//             Console.WriteLine("## Класс System.Array");

//             int[] na6 = { 1, 2, 3, 4, 5, 6, 7 };
//             int[,] nm2 = { { 1, 2, 3 }, { 4, 5, 6 } };
//             int[][] nm3 = new int[3][];

//             for (int i = 0; i < nm3.Length; i++)
//                 nm3[i] = new int[i + 1];

//             Console.WriteLine($"na6: Length={na6.Length}, Rank={na6.Rank}"); // na6: Length=7, Rank=1
//             Console.WriteLine($"nm2: Length={nm2.Length}, Rank={nm2.Rank}"); // nm2: Length=6, Rank=2
//             Console.WriteLine($"nm3: Length={nm3.Length}, Rank={nm3.Rank}"); // nm3: Length=3, Rank=1

//             Console.WriteLine("BinarySearch result: " + Array.BinarySearch(na6, 5).ToString()); // BinarySearch result: 4

//             var na7 = (int[])na6.Clone();

//             Array.Clear(na7, 2, 2);

//             PrintArray<int>("na6", na6); // na6: 1 2 3 4 5 6 7
//             PrintArray<int>("na7", na7); // na7: 1 2 0 0 5 6 7

//             Array.Copy(na7, na6, 4);
//             PrintArray<int>("na6 after copy", na6); // na6 after copy: 1 2 0 0 5 6 7

//             (new int[] { 1, 2, 3, 4 }).CopyTo(na6, 0);
//             PrintArray<int>("na6", na6); // na6: 1 2 3 4 5 6 7

//             var ans = Array.Exists<int>(na6, v => (v % 2) == 0);
//             Console.WriteLine($"Is even number exists in na6? Answer: {ans}");

//             Array.Fill<int>(na7, 7);
//             PrintArray<int>("na7", na7); // na7: 7 7 7 7 7 7 7

//             Console.WriteLine($"Value at 3 index in na6: {na6.GetValue(3)}");

//             Console.WriteLine($"Index of value=5 in na6: {Array.IndexOf(na6, 5)}");

//             Array.Reverse(na6);
//             PrintArray<int>("na6", na6); // na6: 7 6 5 4 3 2 1

//             Array.Sort(na6);
//             PrintArray<int>("na6", na6); // na6: 1 2 3 4 5 6 7

//         }
//         public static void WorkWithArray(int[] arr)
//         {
//             arr[0] = 123;
//         }

//         public static void PrintArray<T>(string txt, T[] arr)
//         {
//             Console.Write($"{txt}: ");
//             foreach (var v in arr)
//             {
//                 Console.Write($"{v} ");
//             }
//         }
//     }
// }