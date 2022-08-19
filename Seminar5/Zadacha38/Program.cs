/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
Console.Write("Введите количество элементов в массиве: ");
int lenN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число в массиве: ");
int minN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число в массиве: ");
int maxN = Convert.ToInt32(Console.ReadLine());
double[] array = new double[lenN];

double[] FillArray(double[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(minN, maxN);
    }
    return arr;
}
Console.Write("Случайный массив: ");
Console.Write("[");
void PrintArr(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write("]");
}

double CheckMinMax(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) 
        {
            max = arr[i];
        }
        if (arr[i] < min) 
        {
            min = arr[i];
        }
    }
    double summa = max - min;
    return summa;
}

double[] result = FillArray(array);
PrintArr(array);
Console.WriteLine();
double Summa = CheckMinMax (array);
Console.Write($"Pазницу между максимальным и минимальным элементом массива = ");
Console.WriteLine(Summa);