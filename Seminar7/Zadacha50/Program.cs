/*
Задача 50. Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает 
индексы этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

7 -> 0 , 2
5 -> 1 , 0
18 -> нет такого элемента
*/
Console.Write("Введите количество строк массива m: ");
bool row = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов массива n: ");
bool columns = int.TryParse(Console.ReadLine(), out int n);
Console.Write("Введите число которое нужно найти в массиве: ");
bool Number = int.TryParse(Console.ReadLine(), out int num);

if (row == false || columns == false || Number == false)
{
    Console.WriteLine("Введены не правильные данные!");
    return;
}

int[,] FillArray2D(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(-100, 100);
        }
    }
    return array;
}

void PrdoubleArray2D(int[,] array) // метод для вывода в консоль

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] result = FillArray2D(m, n);
PrdoubleArray2D(result);
SearchingNumberArray(result);

int[] SearchingNumberArray (int[,] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if num = 
    }
}