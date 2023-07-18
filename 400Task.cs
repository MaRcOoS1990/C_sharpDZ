using System;
using System.Diagnostics;
// Console.Write("Введите пятизначное число или строку из 5 символов: ");
// string? polin = Console.ReadLine();
// int number;
// bool isNumber = int.TryParse(polin, out number);
// if (isNumber)
// {
//     Console.WriteLine($"в строчке {polin} находятся только цифры");
//     int polinD = Convert.ToInt32(polin);
//     if (polinD < 10000 || polinD > 100000)
//     {
//         Console.WriteLine("Было сказанно ввести пятизначное число");
//         return;
//     }
//     if (polinD / 10000 == polinD % 10 && polinD % 10000 / 1000 == polinD % 100 / 10)
//     {
//         Console.WriteLine("Число является палиндромом");
//     }
//     else
//     {
//         Console.WriteLine("Число не является палиндромом");
//     }
// }
// else
// {
//     Console.WriteLine($"в строчке {polin} находятся символы");
// }
// char[] Cpolin = polin.ToCharArray();
// char[] CCpolin = polin.ToCharArray();
// Array.Resize(ref Cpolin, Cpolin.Length + 5);
// if (CCpolin == Cpolin)
// {
//     Console.WriteLine("Палиндром");
// }
// Console.WriteLine(Cpolin);

// *1
// Console.WriteLine("Chalov");
// Console.WriteLine("Aleksei");
// Console.WriteLine("Vyacheslavovich");

// *2
// Console.Write("0\n00\n000\n0000\n00000");

// *3
// Console.WriteLine("Введите 3 трехзначных числа:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// if (num1 <= 99 || num1 >999)
// {
//     Console.WriteLine("Вы ввели не верное число");
//     return;
// }
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 <= 99 || num2 >999)
// {
//     Console.WriteLine("Вы ввели не верное число");
//     return;
// }
// int num3 = Convert.ToInt32(Console.ReadLine());
// if (num3 <= 99 || num3 >999)
// {
//     Console.WriteLine("Вы ввели не верное число");
//     return;
// }
// Console.WriteLine($"{num1}  {num2}  {num3}");

// *4
// Console.WriteLine("Введите 4 числа:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());
// int num4 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num1} {num2} {num3} {num4}");

// *5
// Console.Write("1 13 49");

// *6
// Console.Write("7  15  100");

// *7
// Console.Write("1710\n19");

// *8
// Console.Write("18\n24\n30");

// *9
// Console.WriteLine("Введите 4 числа:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());
// int num4 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{num1}\n{num2}\n{num3}\n{num4}");

// *10
// Console.WriteLine($"Пятница\nиюль\nАлексей");

// *11
// int[,] array = new int[5, 8];

// int rows = array.GetUpperBound(0) + 1;         // количество строк
// int columns = array.GetUpperBound(1) + 1;     // количество столбцов
// int columns = array.Length / rows;        // количество столбцов
// или так


// string[,] table = new string[2, 8];
// for (int rows = 0; rows < 2; rows++)
// {
//     table[rows, 0] = "A";
// }
// for (int columns = 0; columns < 8; columns++)
// {
//     table[0, columns] = "A";
//     table[rows, 0] = "A";
// }
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 8; colums++)
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }

// int[,] matrix = new int[2, 8];
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 8; columns++)
//     {
//         matrix[rows, columns] = 9;
//     }
// }

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 1; colums < 8; colums++)
//     {
//         Console.Write($"{matrix[rows, colums]} ");
//     }
//     Console.WriteLine();
// }

// НЕ ДОДЕЛАЛ

// *12


// *13
// int digitOne = 1; int digitTwo = 5; int digitThree = 3;
// Console.WriteLine(digitOne + digitTwo + digitThree);

// *14
// Console.WriteLine("Введите ваше имя: ");
// string? name = Console.ReadLine();
// Console.WriteLine("Введите вашу фамилию: ");
// string? familia = Console.ReadLine();
// Console.WriteLine($"{name}\n{familia}");

// *15
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Квадрат числа {number} = {number * number}");

// *16
// Console.WriteLine("Введите число: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{number1} {number2}");

// *17
// Console.WriteLine("Введите число 1: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 3: ");
// int number3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма чисел = {number1 + number2 + number3} ,а произведение = {number1 * number2 * number3}");

// *18
// Console.WriteLine("Введите число школьников: ");
// int people = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество яблок: ");
// int apples = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{apples / people} столько яблок будет у каждого школьника,{apples % people} остаток яблок");

// *19
// Console.WriteLine("Введите число школьников: ");
// int people = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите колличество яблок: ");
// int apples = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{apples / people} столько яблок будет у каждого школьника,{apples % people} остаток яблок");

// *20 
// Console.WriteLine("Введите стоимость пирожка в рублях и копейках: ");
// double cost = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Сколько пирожков вы хотите купить?");
// double baker = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Вы должны заплатить = {cost * baker % 100} рублей , копеек");

// *21
// Console.WriteLine("Введите число :");
// double number = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Число {number} в 6 степени = {Math.Pow(number, 6)}");

// *22
// Console.WriteLine("Введите сторону квадрата :");
// double number = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Периметр квадрата = {number * 4}");

// *23
// Console.WriteLine("Возведем число в степень.");
// Console.WriteLine("Введите число :");
// double number = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите степень :");
// double numberDegree = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Число {number} в {numberDegree} степени = {Math.Pow(number, numberDegree)}");

// *24
// Console.WriteLine("Введите число a :");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число b :");
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число c :");
// int c = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{a} , {b} , {c} ");
// int temp = 0;
// int temp2 = 0;
// temp = a; temp2 = c; a = b; b = temp2; c = temp;
// Console.WriteLine($"{a} , {b} , {c} ");
// temp = a; temp2 = b; b = c; c = temp; a = temp2;
// Console.WriteLine($"{a} , {b} , {c} ");

// *25
// Console.WriteLine("Введите сторону куба: ");
// int cubeV = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Объм куба = {cubeV * cubeV * cubeV} и площадь одной стороны куб = {cubeV * 6}");

// *26
// Console.WriteLine("Сколько кг конфет купим?: ");
// int candys = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сколько кг печенья купим?: ");
// int coocies = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Сколько кг яблок купим?: ");
// int apples = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите стоимость 1 кг всех продуктов: ");
// int cost = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Стоимость всей покупки = {(candys + coocies + apples) * cost}");

// *27
// Console.WriteLine("Введите число 1: ");
// double number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число 2: ");
// double number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма = {number1 + number2}\nРазность = {number1 - number2}\nПроизведение = {number1 * number2}\nДеление 1го на 2ое = {number1 / number2}");

// *28
// Console.WriteLine("Введите количество дней: ");
// int days = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество месяцев: ");
// int months = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество лет: ");
// int yars = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Всего дней = {months * 30 + yars * 12 * 30 + days}");

// *29
// double Kelvin = 273.15;
// double Faringeit = 32;
// Console.WriteLine("Введите температуру по цельсию: ");
// double Celsiy = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Температура по цельсию = {Celsiy}\nТемпература по фарингейту = {Celsiy * Faringeit}\nТемпература по кельвину = {Celsiy * Kelvin}");

// *30
// Console.WriteLine("Введите количество секунд: ");
// int sec = Convert.ToInt32(Console.ReadLine());
// int minutes = sec / 60;
// int newSec = sec - minutes * 60;
// int hour = minutes / 60;
// int newMinnutes = minutes - hour * 60;
// TimeSpan time = new TimeSpan(hour, newMinnutes, newSec);
// Console.WriteLine("{0} its {1}", sec, time);

// *31
// Console.WriteLine(543 / 130);

// *32
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0)
// {
//     return;
// }
// Console.WriteLine($"{number % 10}");

// *33
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0)
// {
//     return;
// }
// Console.WriteLine($"{number % 100 / 10}");

// *34
// Console.WriteLine("Введите число от 1 до 999: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0 || number > 999)
// {
//     Console.WriteLine("Нет! Введите число от 1 до 999");
//     return;
// }
// Console.WriteLine($"{number % 10 + number % 100 / 10 + number / 100}");

// *35
// Console.WriteLine("Введите число от 1000 до 999999: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 1000 || number > 999999)
// {
//     Console.WriteLine("Нет! Введите число от 1000 до 999999");
//     return;
// }
// else
// {
//     number = number / 1000;
// }

// Console.WriteLine($"{number % 10 + number % 100 / 10 + number / 100}");

// *36
// Console.WriteLine("Введите число от 1 до 999: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0 || number > 999)
// {
//     Console.WriteLine("Нет! Введите число от 1 до 999");
//     return;
// }
// Console.WriteLine($"Число единиц = {number % 10}\nЧисло десятков = {number % 100 / 10}\nПроизведение его цифр = {number % 10 * (number % 100 / 10) * (number / 100)}\nСумма его цифр = {number % 10 + number % 100 / 10 + number / 100}");

// *37
// Console.WriteLine("Введите число от 1 до 999: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0 || number > 999)
// {
//     Console.WriteLine("Нет! Введите число от 1 до 999");
//     return;
// }
// int a = number / 100;
// int b = number % 100 / 10;
// int c = number % 10;
// Console.WriteLine($"{c}{b}{a}\n{b}{c}{a}\n{c}{a}{b}\n{b}{a}{c}\n{a}{c}{b}");

// *38
// Console.Write("Введите число от 1 до 999: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 0 || number > 999)
// {
//     Console.WriteLine("Нет! Введите число от 1 до 999");
//     return;
// }
// int a = number / 100;
// int b = number % 100 / 10;
// int c = number % 10;
// Console.WriteLine($"{a}{b}{c}\n{b}{c}{a}\n{c}{a}{b}\n{a}{c}{b}\n{b}{a}{c}\n{c}{b}{a}");

// *39(Вещественные числа)
// Console.Write("Введите первое число: ");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите второе число: ");
// double num2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"{(num1 + num2) / 2}");

// *40
// Console.Write("Введите массу тела: ");
// double m = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите объем тела: ");
// double v = Convert.ToDouble(Console.ReadLine());
// double plotnost = m / v;
// Console.WriteLine($"Плотность тела = {plotnost}");

// *41
// Console.Write("Введите количество жителей: ");
// double m = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите площадь государства: ");
// double v = Convert.ToDouble(Console.ReadLine());
// double plotnost = m / v;
// Console.WriteLine($"Плотность населения = {plotnost}");

// *42