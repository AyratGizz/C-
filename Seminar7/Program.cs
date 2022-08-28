/* //Выведите случайный двумерный массив размерностью m * n
Console.Write("Введите количество строк массива m: ");
bool row = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов массива n: ");
bool columns = int.TryParse(Console.ReadLine(), out int n);

if (row == false || columns == false) // проверка правильности введенных чисел пользователем
{
    Console.WriteLine("Введены не правильные данные!");
    return;
}
int [,] result = FillArray2D(m, n, 1, 11);
PrintArray2D(result);

int[,] FillArray2D(int m, int n, int minValue, int maxValue) // метод создания случайного массива размером m * n
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(minValue, maxValue +1);
        }
    }
    return array;
}

void PrintArray2D(int[,] array) // метод для вывода в консоль

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
*/
//----------------------------------------------------------------
/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент
в массиве находится по формуле: A mn = m + n.
Выведите полученный массив на экран.
m =3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/
/*
Console.Write("Введите количество строк массива m: ");
bool row = int.TryParse(Console.ReadLine(), out int rows);
Console.Write("Введите количество столбцов массива n: ");
bool cols = int.TryParse(Console.ReadLine(), out int columns);
// Console.Write("Введите минимельное число массива с: ");
// bool minValue = int.TryParse(Console.ReadLine(), out int с);
// Console.Write("Введите максимальное число массива s: ");
// bool maxValue = int.TryParse(Console.ReadLine(), out int s);

if (row == false || cols == false)
{
    Console.WriteLine("Введены не правильные данные!");
    return;
}

int[,] FillArray2D(int rows, int columns) // метод создания массива по формуле: A mn = m + n
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        array[i, 0] = i + 1;
    }
    for (int j = 1; j < columns; j++)
    {
        array[0, j] = j + 1;
    }
    for (int ix = 1; ix < rows; ix++)
    {
        for (int jy = 0; jy < columns; jy++)
        {
            array [ix, jy] = array [ix,0] + array [0, jy];
        }
    }
    return array;
}

void PrintArray2D(int[,] array) // метод для вывода в консоль

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

int[,] result = FillArray2D(rows, columns);
PrintArray2D(result);
*/
//----------------------------------------------------------------
/* Задача 49: Задайте двумерный массив. Найдите элементы,
у которых оба индекса четные, и замените эти элементы на их квадраты.
*/
/*
Console.Write("Введите количество строк массива m: ");
bool row = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов массива n: ");
bool columns = int.TryParse(Console.ReadLine(), out int n);

if (row == false || columns == false) // проверка правильности введенных чисел пользователем
{
    Console.WriteLine("Введены не правильные данные!");
    return;
}


int[,] FillArray2D(int m, int n) // метод создания случайного массива размером m * n
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            //array[i, j] = random.Next(10);
            if ((i % 2 == 0) || (j % 2 == 0))
            {
                array[i, j] = Convert.ToInt32(Math.Pow(random.Next(10), 2));
            }
            else
            {
                array[i, j] = random.Next(10);

            }
        }
    }
    return array;
}

void PrintArray2D(int[,] array) // метод для вывода в консоль

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
PrintArray2D(result);
*/
//----------------------------------------------------------------
/*Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами (0,0); (1,1) и т.д.).
*/
/*
Console.Write("Введите количество строк массива m: ");
bool row = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов массива n: ");
bool columns = int.TryParse(Console.ReadLine(), out int n);

if (row == false || columns == false) // проверка правильности введенных чисел пользователем
{
    Console.WriteLine("Введены не правильные данные!");
    return;
}


int[,] FillArray2D(int m, int n) // метод создания случайного массива размером m * n
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(10);
        }

    }
    return array;
}

void PrintArray2D(int[,] array) // метод для вывода в консоль

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

int SummaArrayDiagonal(int[,] array)
{
    // Работает только если i < j и массив квадратный
    int summa =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        summa+= array [i,i];
    }
    return summa;

    // int summa = 0;
    // for (int i = 0; i < array.GetLength(0); i++)
    // {
    //     for (int j = 0; j < array.GetLength(1); j++)
    //     {
    //         if (i == j)
    //         {
    //             summa += array[i, j];
    //         }
    //     }
    // }
    // return summa;
}

int[,] result = FillArray2D(m, n);
PrintArray2D(result);

Console.WriteLine(SummaArrayDiagonal(result));

*/

