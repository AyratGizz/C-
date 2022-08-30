/*// Задача 53
// Задайте двумерный массив. Поменяй местами первую и последнюю строку массива
Console.Clear();

int[,] array = new int[4, 4];
Random random = new Random();

int[,] FillArry(int[,] array)
{
    int[,] newArray = array;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            newArray[i,j] = random.Next(1,10);
        }
        Console.WriteLine();
    }
    return newArray;
}

int[,] newArray = FillArry(array);

int[,] SwapRowsArray (int[,] array)
{
    int[] tempArray = new int [array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        tempArray[i] = array[0,i];
    }
    for (int j = 0; j < array.GetLength(0); j++)
    {
        array[0,j] = array[3,j];
    }
    for (int k = 0; k < array.GetLength(0); k++)
    {
        array[3,k] = tempArray[k];
    }
    return array;
}

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

PrintArray2D(array);
int[,] result = SwapRowsArray(newArray);
Console.WriteLine();
PrintArray2D(array);
//--------------------------------------------------------

// Задача 53
Console.Write("Введите количество строк массива m: ");
bool row = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов массива n: ");
bool columns = int.TryParse(Console.ReadLine(), out int n);

if (row == false || columns == false) // проверка правильности введенных чисел пользователем
{
    Console.WriteLine("Введены не правильные данные!");
    return;
}

Console.WriteLine();
int[,] FillArray2D(int m, int n, int minValue, int maxValue) // метод создания случайного массива размером m * n
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(minValue, maxValue);
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

int[,] ChaingeRow(int[,] array)
{
    int temp = 0;
    int rows = array.GetLength(0);
    for (int i = 0; i < array.GetLength(1); i++)
    {
        temp = array[0, i];
        array[0, i] = array[rows - 1, i];
        array[rows - 1, i] = temp;
    }
    return array;
}

int[,] result2 = FillArray2D(m, n, 1, 10);

PrintArray2D(result2);
Console.WriteLine();

int[,] Chaing = ChaingeRow(result2);
PrintArray2D(Chaing);
*/
//-------------------------------------------------------------
//Задача 55
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
// int[,] result = FillArray2D(m, n, 1, 11);
// PrintArray2D(result);
Console.WriteLine();

int[,] FillArray2D(int m, int n, int minValue, int maxValue) // метод создания случайного массива размером m * n
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(minValue, maxValue);
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

int[,] result = FillArray2D(m, n, 1, 10);
PrintArray2D(result);
Console.WriteLine();

int[,] ChaingeElements(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }        
    }
    return array;
}

if (m != n)
{
    Console.WriteLine("Не возможно поменять строки со столбцами!");
}

else
{
    int[,] Chaing = ChaingeElements(result);
    PrintArray2D(Chaing);
}
*/
//------------------------------------------------------------------
/*
//Задача 57

Console.Write("Введите количество строк массива m: ");
bool row = int.TryParse(Console.ReadLine(), out int m);
Console.Write("Введите количество столбцов массива n: ");
bool columns = int.TryParse(Console.ReadLine(), out int n);

Console.Write("Введите минимальное значение массива: ");
bool minValue = int.TryParse(Console.ReadLine(), out int minNum);

Console.Write("Введите максимальное значение массива: ");
bool maxValue = int.TryParse(Console.ReadLine(), out int maxNum);

if (row == false || columns == false || minValue == false || maxValue == false) // проверка правильности введенных чисел пользователем
{
    Console.WriteLine("Введены не правильные данные!");
    return;
}
// int[,] result = FillArray2D(m, n, 1, 11);
// PrintArray2D(result);

Console.WriteLine();

int[,] FillArray2D(int m, int n, int minValue, int maxValue) // метод создания случайного массива размером m * n
{
    int[,] array = new int[m, n];
    Random random = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = random.Next(minValue, maxValue);
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

int[,] result = FillArray2D(m, n, minNum, maxNum);
PrintArray2D(result);
Console.WriteLine();

int[,] CounterElements(int[,] array, int minNum, int maxNum)
{


    int columns = 10; // нужно определить
    int[,] counts = new int[2, columns];



    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] >= 0)
            {
                counts[0, array[i, j]] += 1;
            }
            else
            {
                counts[1, -array[i, j]] += 1;
            }
        }
    }
    return counts;
}

int[,] Counter = CounterElements(result, minNum, maxNum);

void PrintResult(int[,] counter)
{
    for (int i = 0; i < counter.GetLength(0); i++)
    {
        for (int j = 0; j < counter.GetLength(1); j++)
        {
            if (i == 0)
            {
                Console.WriteLine($"Цифр {j} в массиве: {counter[i, j]}");
            }
            else
            {
                Console.WriteLine($"Цифр {-j} в массиве: {counter[i, j]}");
            }
        }
    }
}
PrintResult(Counter);
*/

/*

// Задача 61
Console.Write("Введите количество строк массива m: ");
bool row = int.TryParse(Console.ReadLine(), out int m);
// Console.Write("Введите количество столбцов массива n: ");
// bool columns = int.TryParse(Console.ReadLine(), out int n);

// Console.Write("Введите минимальное значение массива: ");
// bool minValue = int.TryParse(Console.ReadLine(), out int minNum);

// Console.Write("Введите максимальное значение массива: ");
// bool maxValue = int.TryParse(Console.ReadLine(), out int maxNum);


if (row == false) // проверка правильности введенных чисел пользователем
{
    Console.WriteLine("Введены не правильные данные!");
    return;
}

// Console.WriteLine();

// int[,] FillArray2D(int m, int n, int minValue, int maxValue) // метод создания случайного массива размером m * n
// {
//     int[,] array = new int[m, n];
//     Random random = new Random();

//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = random.Next(minValue, maxValue);
//         }
//     }
//     return array;
// }

void PrintArray2D(int[,] array) // метод для вывода в консоль

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        //string s = String.Empty;
        int[] row = new int [array.GetLength(0)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] != 0)
            {
                row[array.GetLength(1)/2-j] = array[i,j];
                
                //s = s + Convert.ToString(array[i, j]);
                //Console.Write($"{array[i, j]} ");
            }
        }
        PrintArr(row);

        //Console.Write(String.Format("{0, 8}", s));
        Console.WriteLine();
    }
}
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write("]");
}
// int[,] result = FillArray2D(m, n, minNum, maxNum);
// PrintArray2D(result);
Console.WriteLine();

int[,] TrianglePascal(int rows)
{
    int[,] triangle = new int[rows, rows];
    triangle[0, 0] = 1;
    triangle[1, 0] = 1;
    triangle[1, 1] = 1;
    for (int i = 2; i < rows; i++)
    {
        triangle[i, 0] = 1;
        for (int j = 1; j < rows; j++)

        {
            triangle[i, j] = triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
    return triangle;
}


int[,] result = TrianglePascal(m);
PrintArray2D(result);
*/

