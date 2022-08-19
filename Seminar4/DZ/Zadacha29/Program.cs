/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Write("Введите ряд чисел, через запятую : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";    // дополнительня запятая для поиска конца строки

string RemovingSpaces(string series) // функция для удаления пробелов из строки, если введено через пробел...
{
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}

void CheckNumber(int series) //  функция  проверки на правильность ввода и отсутствия лишних символов
{

    if (series == '0' || series == '1' || series == '2'|| series == '3' 
    || series == '4' || series == '5' || series == '6' || series == '7' 
    || series == '8' || series == '9' || series == ',' || series == '-'
    || series == ' ' || series == '1'+'2'+'3'+'4'+'5'+'6'+'7'+'8'+'9'+'0')
    {
    }
    else
    {
        Console.WriteLine($"Ошибка ввода! Введите цифры через запятую!");

    }
}

int[] ArrayNumbers(string seriesNew) // функция  для создания и заполнения массива из строки
{

    int[] array = new int[1];    // инициализация массива из 1 элемента

    int j = 0;

    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew2 = "";

        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew2 += seriesNew[i];
            //CheckNumber(seriesNew[i]);
            i++;
        }
        array[j] = Convert.ToInt32(seriesNew2);    // заполняет массив значениями из строки
        if (i < seriesNew.Length - 1)
        {
            array = array.Concat(new int[] { 0 }).ToArray();    // добавляет новый нулевой элемент в конец массива
        }
        j++;
    }
    return array;
}


void PrintArry(int[] coll) // функция вывода массива в консоль (на печать)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("Массив [");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


string seriesNew = RemovingSpaces(seriesOfNumbers);
int[] array = ArrayNumbers(seriesNew);
PrintArry(array);