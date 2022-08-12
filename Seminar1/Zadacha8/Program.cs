Console.WriteLine("Программа покажет всt чётные от 1 до вашего числа!");

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;
bool inoe = true;

Console.Write("Чётные числа от 1 до " + number);
Console.WriteLine(": ");
while (i <= number)
{
    if (i % 2 != 1)
    {
        Console.Write(i + ", ");
        inoe = false;
    }
    i++;
}

if (inoe)
{
    Console.WriteLine("В диапазоне нет чётных чисел!");
}
        