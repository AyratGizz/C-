void GetMaxNumberRandomValue()
{
    int randomValue = new Random().Next(10, 100);

    Console.WriteLine($"Random value - {randomValue}");

    int lastNumber = randomValue % 10;
    int firstNumber = randomValue / 10;

    int max = lastNumber;

    if (lastNumber == firstNumber)
    {
        Console.WriteLine("Числа равны!");
    }
    else
    {
        if (max < firstNumber)
        {
            max = firstNumber;
        }

        Console.WriteLine($"MAX = {max}");
    }
}
GetMaxNumberRandomValue();
