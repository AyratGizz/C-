// ***Введите два числа и определите какое больше***
Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > number1)
{
    Console.Write("Максимальное число: ");
    Console.Write(max = number2);
}
else 
{
    Console.Write("Максимальное число: ");
    Console.Write(max = number1);
}
