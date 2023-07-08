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

// 1
// Console.WriteLine("Chalov");
// Console.WriteLine("Aleksei");
// Console.WriteLine("Vyacheslavovich");

// 2
// Console.Write("0\n00\n000\n0000\n00000");

// 3
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

// 4
// Console.WriteLine("Введите 4 числа:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());
// int num4 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"{num1} {num2} {num3} {num4}");

// 5
// Console.Write("1 13 49");

// 6
// Console.Write("7  15  100");

// 7
// Console.Write("1710\n19");

// 8
// Console.Write("18\n24\n30");

// 9
// Console.WriteLine("Введите 4 числа:");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());
// int num4 = Convert.ToInt32(Console.ReadLine());
// Console.Write($"{num1}\n{num2}\n{num3}\n{num4}");

// 10
// Console.WriteLine($"Пятница\nиюль\nАлексей");

// 11
// int[,] array = new int[5, 8];
 
// int rows = array.GetUpperBound(0) + 1;         // количество строк
// int columns = array.GetUpperBound(1) + 1;     // количество столбцов
// // int columns = array.Length / rows;        // количество столбцов
// // или так

 
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         Console.Write($"{array[i, j]} \t");
//     }
//     Console.WriteLine();
// }
// НЕ ДОДЕЛАЛ

// 12


// 13
// int digitOne = 1; int digitTwo = 5; int digitThree = 3;
// Console.WriteLine(digitOne + digitTwo + digitThree);

// 14
