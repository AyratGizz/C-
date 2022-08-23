// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write($"Введи число М (сколько чисел будем првоерять): ");
int M = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[M];

void InputNumbers(int M) // считывание введенных чисел с консоли в массив massiveNumbers длинной "M"
{
for (int i = 0; i < M; i++)
  {
    Console.Write($"Введите {i+1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}

int CheckNumPositive(int[] massiveNumbers) // проверка и подсчет введенных чисел на положительность ( больше 0)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) 
    count += 1; 
  }
  return count; // возвращает количество чисел > 0 (счетчик)
}

InputNumbers(M);
int result = CheckNumPositive(massiveNumbers); // запись метода CheckNumPositive который проверяет и считает в переменную result
Console.WriteLine($"Введено чисел больше 0: {result}"); // вывод result в консоль
