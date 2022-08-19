Console.Write("Введите количество элементов в массиве: ");
int len = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное число в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];

int[] FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min, max);
    }
    return arr;
}
Console.Write("Случайный массив: ");
Console.Write("[");
void PrintArr(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write("]");
}

int SumNumbersOddPlaces (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 !=1)
        {
        sum = sum + arr[i];
        }
    }
    return sum;

}

int[] result = FillArray(array);
PrintArr(array);
Console.WriteLine();
int SummaNumOddPlaces = SumNumbersOddPlaces(array);
Console.Write("Сумма элементов массива, стоящих на нечётных позициях = ");
Console.WriteLine(SummaNumOddPlaces);
