// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
Console.WriteLine("Программа принимает число и определяет палиндром оно или нет!");
Console.Write("Введите число: ");

int reverse (int number)
{
    string numberStr = Convert.ToString(number);
    char[] ReversNumber = numberStr.ToCharArray();
    Array.Reverse(ReversNumber);
    string finalNumber = new string(ReversNumber);
    return Convert.ToInt32(finalNumber);
}
int number = Convert.ToInt32(Console.ReadLine());
int Rev = reverse (number);
if (Rev ==number)
{
    Console.WriteLine("Ваше число палиндром.");
}
else
{
    Console.WriteLine("Ваше число не палиндром.");
}



// Console.WriteLine("Введите число");
// string number = Console.ReadLine();
// string number1 = "";

// string flipNumber(string number)
// {
//     for (int i = number.Length - 1; i >= 0; i--)
//     {
//         number1 += number[i];
//     }
//     if (number == number1)
//     {
//         return "Да";
//     }
//     else
//     {
//         return "Нет";
//     }

// }
// string result = flipNumber(number);
// Console.WriteLine(result);


