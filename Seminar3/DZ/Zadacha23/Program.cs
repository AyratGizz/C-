//Задача 23: Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Программа принимает число и выдаёт таблицу кубов чисел от 1 до вашего числа");
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] PowNumber(int s)
{
    int[] array = new int[s];
    for (int i = 1; i <= number; i++)
    {
        array[i - 1] = i*i*i;
    }
    return array;
}
int[] result = PowNumber(number);
for (int i = 0; i < result.Length; i++)
{
    Console.WriteLine(result[i]);
}
