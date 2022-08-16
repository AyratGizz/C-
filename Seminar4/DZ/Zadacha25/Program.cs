/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
Console.WriteLine("Программа возводит введённое число в ввёднную вами степень!");
Console.Write("Введите число которое нужно возвести в степень: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число степени в которое нужно возвести число: ");
double b = Convert.ToInt32(Console.ReadLine());

double ComPow (double a, double b)
{
    double Pow = Math.Pow(a, b);
    return Pow;
}
double result = ComPow (a, b);
Console.WriteLine ($"Число {a} в степени {b} = {result}");

