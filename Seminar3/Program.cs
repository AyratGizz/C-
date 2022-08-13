// See https://aka.ms/new-console-template gor more information
// Звдвча 17. Напишите программу, которая принимает на вход координаты точки (х и у), причем x и y не равны "0" 
//и выдаёт номер четверти плоскости, в которой находится эта точка.

// int x = Convert.ToInt32(Console.ReadLine());

// int y = Convert.ToInt32(Console.ReadLine());
// int result = FindNumberQuarter(x, y);

// if (result == -1)
// {
//     Console.WriteLine("Что-то пошло не так");
// }
// Console.WriteLine(result);

// int FindNumberQuarter(int x, int y)
// {
//     if (x > 0 && y = 0)
//     {
//         return 1;
//     }

//     if (x < 0 && y > 0)
//     {
//         return 2;
//     }

//     if (x < 0 && y < 0)
//     {
//         return 3;
//     }


//     if (x > 0 && y < 0)
//     {
//         return 4;
//     }
//     throw new Exception("Введено не верное число!"); //return -1;
// }

//--------------------------------------------------------------
// Console.Write("Введите x1= ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y1= ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите x2= ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y2= ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// Double findlenghe(int xa, int xb, int ya, int yb)

// {
//     Double a = Math.Sqrt((xb-xa)*(xb-xa)+(yb-ya)*(yb-ya));
//     return a;
// }
// Double result = findlenghe (x1, x2, y1, y2);
// Console.WriteLine(result);

//--------------------------------------------------------------
// Console.WriteLine("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());

// int[] TableSquares (int s)
// {
//     int[] array = new int[s];
//     for (int i = 1; i <= n; i++)
//     {
//         array[i - 1] = i * i;
//     }
//     return array;
// }
// int[] result = TableSquares(n);
// for (int i = 0; i < result.Length; i++)
// {
//     Console.WriteLine(result[i]);
// }
//-------------------------------------------------------------
// int ax = Convert.ToInt32(Console.ReadLine());
// int ay = Convert.ToInt32(Console.ReadLine());
// int bx = Convert.ToInt32(Console.ReadLine());
// int by = Convert.ToInt32(Console.ReadLine());

// double FindDistance (int ax, int ay, int bx, int by)
// {
//     double A = Math.Pow ((ax - ay), 2);
//     double B = Math.Pow ((bx - by), 2);
//     double Distance = Math.Sqrt(A+B);
//     return Distance;
// }
// double result = FindDistance (ax, ay, bx, by);

// Console.WriteLine (result);

//---------------------------------------------------------------
// Console.Write ("Введите чилсо: ");
// double number = Convert.ToInt32(Console.ReadLine());

// double SqrtNumbers (double number)
// {
//     for (int i=1; i < number; i++)
//     {
//         Math.Pow(number,2);
//         return number;
//         //Console.Write(number);
//         // Console.Write (", ");
//         // throw new Exception("Ввведите другое чилсо!");
//     }
// }
// Console.Write(number);
//---------------------------------------------------------------