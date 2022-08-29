/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
Console.Write("Введите количество строк массива m: ");
bool row = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов массива n: ");
bool columns = int.TryParse(Console.ReadLine(), out int n);

if (row == false || columns == false)
{
    Console.WriteLine("Введены не правильные данные!");
    return;
}

int[,] FillArray2D(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    int avarage = 0;
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(0, 10);
        }

    }
    return array;
}

int[,] result = FillArray2D(m, n);
PrintArray2D(result);

void PrintArray2D(int[,] array)

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

void ArithmeticMeanArray (int[,] result)
{
for (int i = 0; i < m; i++)
{
    double arithmeticMean = 0;
    for (int j = 0; j < n; j++)
    {
        arithmeticMean += result[j, i];
    }
    arithmeticMean = Math.Round(arithmeticMean / m, 1);
    Console.WriteLine($"Среднеарефметическое столбца № {i + 1} : {arithmeticMean}");
}
}
ArithmeticMeanArray(result);














