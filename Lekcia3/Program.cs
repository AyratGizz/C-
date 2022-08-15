//*** Таблица умножения

// for (int i = 2; i <= 10; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }
//----------------------------------------------------
//****Форматирование (изменение) текста символов...
// string text = "- Я думаю, - сказал князь, улыбаясь, -ыто, "
//             + "ежели бы вас послали вместо нашего милого Винцегероде,"
//             + "Вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue) // - создание метода Replace
// { // начало тела метода
//     string result = ""; //""; == String.Empty == пустая строка - присваивание result изначально пустой строки

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// } // окончание тела метода

// string newText = Replace(text, ' ', '|'); //вызов метода и указание что на что заменить...
// Console.WriteLine(newText); // вывод результата нв консоль
// Console.WriteLine();// пустая строка для разрыва и лучшего визуала
// newText = Replace(newText, 'к', 'К')
// Console.WriteLine(newText);
//-----------------------------------------------------
//***Сортировка цифр от минимум до максимум
// int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};
// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }

// void SelectionSort(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         int maxPosition = i;
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if (array[j] < array[maxPosition]) maxPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = temporary;
//     }
// }
// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);
//--------------------------------------------------
//*** САМОСТОЯТЕЛЬНАЯ РАБОТА - Сортировка цифр от максимум до минимум
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);