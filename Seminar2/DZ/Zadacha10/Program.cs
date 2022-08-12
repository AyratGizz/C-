// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Программа принимает на вход трехзначное число и выводит вторую цифру числа!");

Console.Write("Введи трёхзначное число: ");

int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
Console.WriteLine("Вторая цифра этого числа: "+stringNumber[1]);

