// ****Программа которая выводит случайное число из отрезка [10, 90] и показывает наибольшую цифру числа.
// void GetMaxNumberRandomValue()
// {
//     int randomValue = new Random().Next(10, 100);

//     Console.WriteLine($"Random value - {randomValue}");

//     int lastNumber = randomValue % 10;
//     int firstNumber = randomValue / 10;

//     int max = lastNumber;

//     if (lastNumber == firstNumber)
//     {
//         Console.WriteLine("Числа равны!");
//     }
//     else
//     {
//         if (max < firstNumber)
//         {
//             max = firstNumber;
//         }

//         Console.WriteLine($"MAX = {max}");
//     }
// }
// GetMaxNumberRandomValue();

//---------------------------------------------------------------------------------
//*** Программа которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа

//Console.WriteLine("Определяется рандомное число");

//int number = Convert.ToInt32(Console.ReadLine());
// Random random = new Random();
// int number = random.Next(100, 1000);
// Console.Write(number);
// int number2 = number % 10;
// int number3 = number / 100;
// Console.Write($" {number3}{number2} ");

//---------------------------------------------------------------------------------
//***

// void GoNumbers (int num1, int num2)
// {
//     if (num2 % num1 == 0)
//     {
//         Console.WriteLine("Второе число кратно перовму");
//     }
//     else Console.WriteLine(num2 % num1);
// }

// Console.Write ("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе чило: ");
// int num2 = Convert.ToInt32(Console.ReadLine());


// GoNumbers(num1, num2);

//-----------------------------------------------------------------------------------
//***

