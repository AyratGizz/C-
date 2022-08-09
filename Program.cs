// ***Введите два числа и определите какое больше***
Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
if (number2 > number1)
{
    Console.Write("Максимальное число: ");
    Console.Write(max = number2);
}
else 
{
    Console.Write("Максимальное число: ");
    Console.Write(max = number1);
}





























//Console.Write("Введите ваше имя: "); // Console.WriteLine - с новой строки
//string username = Console.ReadLine(); // считываение введенных данных и присваивание к переменной  username
//Console.Write("Привет, "); // вывод на экран 
//Console.Write(username);// подтягивание переменной и вывод на экран

//операторы - +  -  /  *  %  ()
// генератор числе - new Random ().Next (min,max) - даст случайное целое число от min до max-1

//---------------------------------------------------------------

//********НАЙДИТЕ СУММУ ДВУХ ЧИСЕЛ*******
//Console.Write("Введите число 1: ");
//int number1 = Convert.ToInt32(Console.ReadLine());//double - целое число, string - строки, bool - правда или ложь (логический)
//Console.Write("Введите число 2: ");
//int number2 = Convert.ToInt32(Console.ReadLine());
//int result = number1 + number2;
//Console.WriteLine(result);
//----------------------------------------------------------------

// ****ПРОПИСАТЬ ВСЕ ЧИСЛА ОТ МИНУСОВОГО ЗНАЧЕНИЯ ВВЕДЕННОГО ЧИСЛА ДО САМОГО ВВЕДННОГО ЧИСЛА****
//Console.Write("Введите число: ");

//int n = Convert.ToInt32(Console.ReadLine());
//int number = -n;

//while(number <= n)
//{
//    Console.WriteLine(number);
//    Console.WriteLine(" ");
//    number++;
//}
//-----------------------------------------------------------------

//ВАРИАНТ 2 ****ПРОПИСАТЬ ВСЕ ЧИСЛА ОТ МИНУСОВОГО ЗНАЧЕНИЯ ВВЕДЕННОГО ЧИСЛА ДО САМОГО ВВЕДННОГО ЧИСЛА****
//Console.Write("Введите число: ");
//int n = Convert.ToInt32(Console.ReadLine());

//for (int i = -n; i<=n; i++)
//{
//    Console.Write(i);
//    Console.Write(", ");
//}
//-----------------------------------------------------------------


//******ВЫВЕСТИ НА ЭКРАН ДЕНЬ НЕДЕЛИ ПО ВВЕДЕННОМУ ЧИСЛУ*****
//Console.Write("Введите номер дня недели: ");
//int number = Convert.ToInt32(Console.ReadLine());

//if(number==1)
//{    Console.WriteLine("Понедельник");}
//if(number==2)
//{    Console.WriteLine("Вторник");}
//if(number==3)
//{    Console.WriteLine("Среда");}
//if(number==4)
//{    Console.WriteLine("Четверг");}
//if(number==5)
//{    Console.WriteLine("Пятница");}
//if(number==6)
//{    Console.WriteLine("Суббота");}
//if(number==7)
//{    Console.WriteLine("Воскресенье");}

//------------------------------------------------------------------
//Вариант 2 со свитчем
//Console.Write("Введите номер дня недели: ");
//int number = Convert.ToInt32(Console.ReadLine());
//switch(number){
//    case 1:
//    Console.WriteLine("Понедельник");
//    break;
//    case 2:
//    Console.WriteLine("Вторник");
//    break;
//    case 3:
//    Console.WriteLine("Среда");
//    break;
//    case 4:
//    Console.WriteLine("Четверг");
//    break;
//    case 5:
//    Console.WriteLine("Пятница");
//    break;
//    case 6:
//    Console.WriteLine("Суббота");
//    break;
//    case 7:
//    Console.WriteLine("Воскресенье");
//    break;
//}


//--------------------------------------------------------------------

//*****ПОКАЗАТИЬ ПОСЛЕДНЮЮ ЦИФРУ ТРЕХЗНАЧНОГО ЧИСЛА****
//Console.Write("Введите число: ");
//double n = Convert.ToInt32(Console.ReadLine());
//if (n>=100 & n<1000)
//{
//    Console.WriteLine (n%10);
//}
//--------------------------------------------------------------------

