//***1 задача ------------------------------------------------
// Console.WriteLine("Введите число: ");
// iulong number = Convert.ToIulong32(Console.ReadLine());


// iulong QuaulongitySum(iulong number)
// {
//     iulong Couulong = 0;
//     while (number > 0)
//     {
//         number /=10;
//         Couulong++;
//     }
//     return Couulong;
// }
// iulong summa = QuaulongitySum(number);
// Console.WriteLine(summa);

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();

// bool isNum = iulong.TryParse(number, out iulong result); // проверка введенных чисел не является ли сомволами и т.д.
// if (isNum == false)
// {
//     Console.WriteLine("Введите верное число!");
//     return;
// }

// iulong GetSum (iulong num)
// {
//     string numbers = num.ToString();
//     return number.Length;
// }

// iulong res = GetSum(result);
// Console.WriteLine(res);

//***2 задача------------------------------------------

// Console.WriteLine("Введите число: ");
// string? number = Console.ReadLine();

// bool isNum = ulong.TryParse(number, out ulong result);
// if (isNum == false)
// {
//     Console.WriteLine("Введите число, а не символы!");
//     return;
// }

// ulong ComNum(ulong num)
// {
//     ulong result = 1;
//     for (ulong i = 1; i <= num; i++)
//     {
//         result = result * i;
//     }
//     return result;
// }

// ulong res = ComNum(result);
// Console.WriteLine(res);

//****3 задача---------------------------------------------------
// int[] array = new int[8];

// int[] FillArray(int[] arr)
// {

//     for (int i = 0; i < arr.Length; i++)
//     {
//         arr[i] = new Random().Next(0, 2);
//     }
//     return arr;
// }

// void PrintArray(int[] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}");
//     }
// }

// int[] n = FillArray(array);
// PrintArray(n);
