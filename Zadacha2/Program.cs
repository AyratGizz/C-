Console.WriteLine("Введите два числа и программа определит какое больше!");
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > number1)
{
    Console.Write("Большое число: ");
    Console.Write(max = number2);
}
else 
{
    Console.Write("Большое число: ");
    Console.Write(max = number1);
}
