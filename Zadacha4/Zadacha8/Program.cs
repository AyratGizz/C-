Console.Write("Введите число и программа покажет все четные числа в диапазоне от 1 до вашего числа: ");
int number = Convert.ToInt32(Console.ReadLine());

int i = 1;
bool not = true;

Console.Write("Все чётные числа от 1 до " + number);
Console.WriteLine(": ");

    while (i <= number)
        {
        if (i % 2 != 1)
            {
            Console.Write(i + ", ");
            not = false;
            }
            i++;
        }

        if (not)
        {
            Console.WriteLine("В данном диапазоне нет чётных чисел!");
        }
