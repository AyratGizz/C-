// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double[,] coordinates = new double[2, 2];// создание двумерного массива 2х2
double[] crossPoint = new double[2]; // создание массива "Точка пересечения" длиной в 2 значения (координаты)

void Inputcoordinatess() // считывание с консоли введённых координат k, b - координаты прямых линий
{
    for (int i = 0; i < coordinates.GetLength(0); i++) // строки
    {
        Console.WriteLine($"Введите координаты k и b {i + 1}-го уравнения (y = k * x + b): ");
        for (int j = 0; j < coordinates.GetLength(1); j++) // столбцы
        {
            if (j == 0)
            {
                Console.Write($"Введите координату k: ");
            }
            else
            {
                Console.Write($"Введите координату b: ");
            }
            coordinates[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Calculation(double[,] coordinates) // вычисление x, y
{
    crossPoint[0] = (coordinates[1, 1] - coordinates[0, 1]) / (coordinates[0, 0] - coordinates[1, 0]); // x = b2-b1 / k1-k2
    crossPoint[1] = crossPoint[0] * coordinates[0, 0] + coordinates[0, 1]; // y = x * k1 + b1
    return crossPoint;
}

void Result(double[,] coordinates) // вывод результатов координат пересечения и проверка параллельности или совпадения прямых
{
    if (coordinates[0, 0] == coordinates[1, 0] && coordinates[0, 1] == coordinates[1, 1])
    {
        Console.Write($"Прямые совпадают!");
        return;
    }
    if (coordinates[0, 0] == coordinates[1, 0] && coordinates[0, 1] != coordinates[1, 1])
    {
        Console.Write($"Прямые параллельны!");
        return;
    }
    else
    {
        Calculation(coordinates);
        Console.Write($"Точка пересечения прямых: ({crossPoint[0]}, {crossPoint[1]})");
    }
}

Inputcoordinatess();
Result(coordinates);