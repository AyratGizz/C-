/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int N)
  {
    int lengtNum = Convert.ToString(N).Length;
    int result = 0;
    int resultSum = 0;

    for (int i = 0; i < lengtNum; i++)
    {
      result = N - N % 10;
      resultSum = resultSum + (N - result);
      N = N / 10;
    }
   return resultSum;
  }

int sumNumber = SumNumber(number);
Console.WriteLine($"Сумма цифр числа = {sumNumber}");