/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Write("Введите количество трёхзначных элементов в массиве: ");
int lenN = Convert.ToInt32(Console.ReadLine());

int[] array = new int[lenN];

int[] FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000);
    }
    return arr;
}
Console.Write("[");
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write("]");
}

int CheckNumbersEven(int[] arr)
{
    int check = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            check++;
        }
    }
    return check;
}
int[] result = FillArray(array);
PrintArr(array);
Console.WriteLine();
int CheckNumEven = CheckNumbersEven(array);
Console.WriteLine($"Чётных чисел в массиве: {CheckNumEven}");
