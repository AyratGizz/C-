//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Программа принимает цифру дня недели и сообщает является ли этот день выходным!");

Console.Write("Введи цифру дня недели: ");
int NumberDay = Convert.ToInt32(Console.ReadLine());

void CheckingDay(int NumberDay)
{
    if (NumberDay == 6 || NumberDay == 7)
    {
        Console.WriteLine("День недели - выходной!");
    }
    else if (NumberDay < 1 || NumberDay > 7)
    {
        Console.WriteLine("Такой день недели ещё не придумали");
    }
    else Console.WriteLine("День недели - рабочий!");
}

CheckingDay(NumberDay);

