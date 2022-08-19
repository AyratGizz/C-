//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int[] FillNewArray(int num)
// {
//     int j = 0;
//     int[] array = new int[num / 2];
//     for (int i = 1; i <= num; i++)
//     {
//         if (i % 2 == 0)
//         {
//             array[j] = i;
//             j++;
//         }
//     }
//     return array;
// }

// void ChekRangeNumbers(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");
//     }
// }

// int[] result = FillNewArray(number);
// ChekRangeNumbers(result);

//***Тоже самое с Лист----------------------------
// System.Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// List<int> FillNewArray(int num)
// {
//     List<int> list = new List<int>();
//     for (int i = 1; i <= num; i++)
//     {
//         if (i % 2 == 0)
//         {
//             list.Add(i);
//         }
//     }
//     return list;
// }

// void ChekRangeNumbers(List<int> list)
// {
//     for (int i = 0; i < list.Count; i++)
//     {
//         System.Console.Write($"{list[i]} ");
//     }
// }

// List<int> list = FillNewArray(number);
// ChekRangeNumbers(list);
//---------------------------------------------------------------
/* Задача 31: Задайте массив из 12 элементов, заполненный случайными числами 
из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел 
равна 29, сумма отрицательных равна -20.


int[] array = new int[12];

int[] FillArray(int[] arr)
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(-9, 10);
    }
    return arr;
}

int FindSumPositivNumbers (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) 
        {
            sum += arr[i];
        }
    }
    return sum;
}



int FindSumNegativNumbers (int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) 
        {
            sum += arr[i];
        }
    }
    return sum;
}
int [] fill = FillArray(array);
int sumPositive = FindSumPositivNumbers(fill);
int sumNegativ = FindSumNegativNumbers(fill);
Console.WriteLine (sumPositive);
Console.WriteLine ();
Console.WriteLine (sumNegativ);

void ChekRangeNumbers(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}

int[] result = FillArray(fill);
ChekRangeNumbers(result);

*/
//-------------------------------------------------------
// int[] array = new int[4] { -4, -8, 8, 2 };

// int[] FindRevers(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = arr[i] * -1;
//     }
//     return arr;
// }
// void ChekRangeNumbers(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         System.Console.Write($"{arr[i]} ");
//     }
// }

// int[] result = FindRevers(array);
// ChekRangeNumbers(result);
//----------------------------------------------------------
/*int[] array = new int[5] { 6, 7, 19, 345, 3 };
Console.WriteLine("Введите число!");

int find = Convert.ToInt32(Console.ReadLine());

bool FindRevers(int[] arr, int find)

{
        for (int i = 0; i < arr.Length; i++)
    {
        if (find == arr[i])
        {
            return true;
        }
    }
    return false;
}
bool result = FindRevers (array, find);
if (result == true)
{
    Console.WriteLine("Такое число есть в массиве!");
}
else
{
    Console.WriteLine("Такое числа нет в массиве!");
}
*/
//------------------------------------------------------------
// int[] array = new int[123];

// int[] FillArray(int[] arr)
// {
//     Random random = new Random();
//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = random.Next(1, 124);
//     }
//     return arr;
// }

// void PrintArr (int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i]);
//     }
// }

// int ChekRangeNumbers(int[] arr)
// {
//     int count = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] >= 10 && arr[i] <= 99)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }


// int [] result = FillArray (array);
// PrintArr (array);
// System.Console.WriteLine();
// int count = ChekRangeNumbers (result);
// Console.WriteLine(count);
//-----------------------------------------------------------------
//Задача 37
 
// int[] array = new int[11]; 
 
 
// int[] FillArray(int[] arr) 
// { 
//     Random random = new Random(); 
//     for (int i = 0; i < arr.Length; i++) 
//     { 
//         arr[i] = random.Next(1,20); 
//     } 
//     return arr; 
// } 
// void PrintArray(int[] arr) 
// { 
//     for (int i = 0; i < arr.Length; i++) 
//     { 
//         Console.Write($"{arr[i]} "); 
//     } 
// } 
// int[] FindMultiplyNumbers(int[]arr){ 
//     int[] multiplyNumbers = new int[arr.Length/2]; 
//     for (int i = 0; i < arr.Length/2; i++) 
//     { 
//         multiplyNumbers[i] = arr[i] * arr[arr.Length-1-i]; 
 
//     } 
//     return multiplyNumbers; 
// } 
 
// int[] n = FillArray(array); 
// PrintArray(n); 
// Console.WriteLine(); 
// int[] result = FindMultiplyNumbers(n); 
// PrintArray(result);
//----------------------------------------------------


