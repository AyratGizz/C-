// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.
Console.Write("Программа находит расстояние между двумя точками в 3D пространстве!");
Console.Write("Введите координату А1: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату В1: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату А2: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату В2: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату А3: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату В3: ");
int bz = Convert.ToInt32(Console.ReadLine());

double FindDistance (int ax, int ay, int bx, int by, int az, int bz)
{
    double A = Math.Pow ((ay - ax), 2);
    double B = Math.Pow ((by - bx), 2);
    double Z = Math.Pow ((bz - az), 2);
    double Distance = Math.Sqrt(A+B+Z);
    return Distance;
}
double result = FindDistance (ax, ay, bx, by, az, bz);

Console.WriteLine (result);
