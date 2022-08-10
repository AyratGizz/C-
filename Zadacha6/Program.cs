Console.Write ("Введите любое число и программа определит чётноё оно или не чётное: ");

int number = Convert.ToInt32 (Console.Read());
if (number % 2 == 0) Console.WriteLine ("Число чётное");
else Console.WriteLine ("Число нечётное");


