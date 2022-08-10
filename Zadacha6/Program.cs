Console.Write ("Введите любое число и программа определит чётноё оно или нечётное: ");

int number = Convert.ToInt32 (Console.ReadLine());
if (number % 2 == 0) 
Console.WriteLine ("Введённое число чётное");
else Console.WriteLine ("Введённое число нечётное");


