﻿// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Программа выводит третью цифру заданного числа или сообщит, что третьей цифры нет!");

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2)
{
    Console.WriteLine("Третья цифра числа: " + NumberText[2]);
}
else
{
    Console.WriteLine("К сожалению третьей цифры нет");
}