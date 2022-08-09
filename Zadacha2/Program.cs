Console.WriteLine("Введите два числа и программа определит какое больше!");

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 > number1)
{
    Console.Write("Большое число: ");
    Console.WriteLine(number2);
    Console.Write("Меньшое число: ");
    Console.Write(number1);
}
else 
{
    Console.Write("Большое число: ");
    Console.WriteLine(number1);
    Console.Write("Меньшое число: ");
    Console.Write(number2);
}
