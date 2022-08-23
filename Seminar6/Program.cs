/*
/*double FibonacciBad(int n)
{
    if (n == 1 || n == 2) return 1;
    else return FibonacciBad(n - 1) + FibonacciBad(n - 2);
}
double FibonacciR(double[] f, int n)
{
    if (n == 1 || n == 2)
    {
        return f[n - 1] = 1;
    }
    else
    {
        if (f[n - 2] != 0)
        {
            if (f[n - 1] != 0)
                return f[n - 1] = f[n - 2] + f[n - 3];
            else
                return f[n - 1] = FibonacciR(f, n - 1) + f[n - 3];
        }
        else
            return f[n - 1] = FibonacciR(f, n - 1) + FibonacciR(f, n - 2);
    }
}
double FibonacciGood(int n)
{
    double[] f = new double[n];
    return FibonacciR(f, n);
}
int countTests = 40;
DateTime saveTime;
Console.WriteLine($"Цикл for: ");
saveTime = DateTime.Now;
int fibonacci1 = 1;
int fibonacci2 = 1;
for (int i = 1; i <= countTests; i++)
{
    Console.WriteLine($"f({i}) = {fibonacci2}");
    int temporary = fibonacci2;
    fibonacci2 += fibonacci1;
    fibonacci1 = temporary;
}
Console.WriteLine($"Для for прошло: {DateTime.Now - saveTime}");
Console.WriteLine($"FibonacciBad: ");
saveTime = DateTime.Now;
for (int i = 1; i <= countTests; i++)
{
    Console.WriteLine($"F({i}) = {FibonacciBad(i)}");
}
Console.WriteLine($"Для FibonacciBad прошло: {DateTime.Now - saveTime}");
Console.WriteLine($"FibonacciGood: ");
saveTime = DateTime.Now;
for (int i = 1; i <= countTests; i++)
{
    Console.WriteLine($"F({i}) = {FibonacciGood(i)}");
}
Console.WriteLine($"Для FibonacciR прошло: {DateTime.Now - saveTime}");

int[,] array2d = new int[10, 10];

Random random = new Random();
for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        array2d[i, j] = random.Next(10, 100);
    }
}

Print2dArray(array2d);

void Print2dArray(int[,] array)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write($"{array2d[i, j]} ");
        }

        Console.WriteLine();
    }
}
*/
//----------------------------------------------------------------

/* Console.WriteLine("!!!");

int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(minValue, maxValue + 1);
    }
    return array;
}

int[] array = GetRandomArray(4, 1, 10);

//далее реверс


int[] ReversArray(int[] array)
{
    int[] result = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        result[i] = array[array.Length-1-i];
    }
    return result;
}

int [] result = ReversArray(array);

void PrintArray (int[] array)// Вывод в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(array);
Console.WriteLine();
Console.Write("Перевернутый массив: ");
PrintArray(result);
*/

//--------------------------------------------------------
//*** Задача 40
/*
Console.Write("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int C = Convert.ToInt32(Console.ReadLine());

bool CheckLine(int a, int b, int c)
{
    if (C < A + B && A < B +C && B < A + C)
    {
        result = true;
    }
    else
    {
        result = false;
    }
    return result;
}

bool result = CheckLine (A, B, C);
Console.WriteLine(result);
*/
//-------------------------------------------------------
// Задача 42
/*Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

string ReversNumber(int N)
{
    string num = String.Empty;
    while (N > 0)
    {
        num = num + N % 2;
        N = N / 2;
    }
    return num;
}

char[] ReverseArray(string arr)
{
    char[] result = new char[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[arr.Length - 1 - i];
    }
    return result;
}

void PrintArray (char[] array) // Вывод в консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
}

string result = ReversNumber(N);
PrintArray (ReverseArray(result));
// ***---второй вариант-----------------------------------
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int value = 11;
// string binary = Convert.ToString(value, 2);
// Console.WriteLine(binary);

string Binury (int num)
{
    string str = string.Empty;

    while (num > 0)
    {
    str = $"{Convert.ToString(num%2)}{str}";
        num = num/2;
    }
    return str;
}

Console.WriteLine(Binury(number));

*/
//---------------------------------------------------------
//Задача 44
/*Console.WriteLine("Введите число строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[a, b];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);

int[,] NewMassiv(int[,] matr)
{
    int[,] matr2 = new int[matr.GetLength(0),matr.GetLength(1)];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr2[i, j] = matr [i,j];
        }
        
    }
    return matr2;
}

void PrintArray2(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
Console.WriteLine();
int [,] result2 = NewMassiv(matrix);
PrintArray2(result2);
*/


