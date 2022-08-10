Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number1 > number2) max = number1;
if (number2 > number3) max = number2;
if (number3 > number2) max = number3;

Console.Write("Большее число: ");
Console.Write(max);

