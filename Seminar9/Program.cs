// Семинар 9. Как не нужно писать код. Часть 3.
/*
// Задача 63
Console.Clear();
Console.WriteLine("Введите число inputString");
int inputString = Convert.ToInt32(Console.ReadLine());

string S = String.Empty;

string FillStringInNumDiapazon(string Str, int IntIndex)
{
    Str = "1 ";
    if (IntIndex == 1)
    {

        return Str;
    }
    else
    {

        Str =  FillStringInNumDiapazon(Str, IntIndex - 1) + $"{Convert.ToString(IntIndex)} ";
    }
    return Str;
}

string result = FillStringInNumDiapazon(S, inputString);
Console.WriteLine(result);
*/
/*
//Вариант 2



*/

/*
//Задача 65
Console.WriteLine("Введите число inputString");
int inputString = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M");
int M = Convert.ToInt32(Console.ReadLine());

string S = String.Empty;

string FillStringInNumDiapazon(string Str, int IntIndex, int FromNum)
{
    Str = $"{Convert.ToString(FromNum)} ";
    if (IntIndex == FromNum)
    {

        return Str;
    }
    else
    {

        Str =  FillStringInNumDiapazon(Str, IntIndex - 1, FromNum) + $"{Convert.ToString(IntIndex)} ";
    }
    return Str;
}

string result = FillStringInNumDiapazon(S, inputString, M);
Console.WriteLine(result);
*/
/*
//Задача 67
Console.Clear();
Console.WriteLine("Введите число N");
string inputString = Console.ReadLine();
char[] arr = inputString.ToCharArray();

int NumLenght = arr.Length;

int MathPow(char[] array, int IntIndex)
{
    int Sum = 0;

    if (IntIndex == 0)
    {
        Sum = (array[IntIndex] - '0');
        return Sum;
    }
    else
    {

        Sum = (arr[IntIndex]-'0') + MathPow(arr, IntIndex - 1);
        
    }
    return Sum;
}

int result = MathPow(arr, NumLenght - 1);
Console.WriteLine(result);
// Задача 67 Вариант 2
/*
/ Найти сумму цифр в числе с помощью рекурсии.
// System.Console.WriteLine("Введие число");
// int number = Convert.ToInt32(Console.ReadLine());

// int SumNumbers(int num)
// {
//     int sum = 0;
//     if (num > 0)
//     {
//         return sum = num % 10 + SumNumbers(num / 10);
//     }
//     else
//     {
//         return sum;
//     }
// }
// int result = SumNumbers(number);
// System.Console.WriteLine(result);
*/

/*
//Задача 69
Console.Clear();
Console.WriteLine("Введите число А");
int inputNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень В");
int inputPow = Convert.ToInt32(Console.ReadLine());

int MathPow(int a, int Pow, int index = 1)
{
    int result = a;
    if (Pow == 0)
    {
        return 1;
    }

    else if (index < Pow)
    {
        result = result * MathPow(a, Pow, index + 1);
    }
    return result;
}

Console.WriteLine(MathPow(inputNum, inputPow));
*/
/*
//Задача 69 - Вариант 2
Console.Clear();
Console.WriteLine("Введите число А");
int inputNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень В");
int inputPow = Convert.ToInt32(Console.ReadLine());

int MathPow(int a, int Pow)
{
    int result = a;
    if (Pow > 0)
    {
        result = result * MathPow(a, Pow - 1);
    }
    else
    {
        return 1;
    }
    return result;
}

Console.WriteLine(MathPow(inputNum, inputPow));

*/
