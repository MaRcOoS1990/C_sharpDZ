// Домашняя работа номер 3

// Console.WriteLine("Введите пятизначное число : ");
// int polin = Convert.ToInt32(Console.ReadLine());
// if (polin < 10000 || polin > 100000)
// {
//     Console.WriteLine("Было сказанно ввести пятизначное число");
//     return;
// }
// if (polin / 10000 == polin % 10 && polin % 10000 / 1000 == polin % 100 / 10)
// {
//     Console.WriteLine("Число является палиндромом");
// }
// else
// {
// Console.WriteLine("Число не является палиндромом");
// }

// второй вариант

// Console.Write("Введите пятизначное число или строку из 5 символов: ");
// string? polin= Console.ReadLine();
// int number;
// bool isNumber = int.TryParse(polin, out number);
// if (isNumber)
// {
//     Console.WriteLine($"в строчке {polin} находятся только цифры");
//     int polinD = Convert.ToInt32(polin);
//     if (polinD < 10000 || polinD > 100000)
// {
//     Console.WriteLine("Было сказанно ввести пятизначное число");
//     return;
// }
// if (polinD / 10000 == polinD % 10 && polinD % 10000 / 1000 == polinD % 100 / 10)
// {
//     Console.WriteLine("Число является палиндромом");
// }
// else
// {
// Console.WriteLine("Число не является палиндромом");
// }
// }
// else
// {
//     Console.WriteLine($"в строчке {polin} находятся символы");
// }
// static string Reverse( string Cpolin )
// {
//     char[] polin = Cpolin.ToCharArray();
//     Array.Reverse(polin);
//     return new string(polin);
// }



// Console.Write("Введите координату по оси оХ для первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оY для первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оZ для первой точки: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оХ для второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оY для второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оZ для второй точки: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)+ Math.Pow(z2 - z1, 2)),2);
// Console.Write($"Расстояние: {d}");


// Console.WriteLine("Введите число :");
// int start;
// int end = Convert.ToInt32(Console.ReadLine());
// for (start = 1; start <= end; start++)
// {
//     Console.Write(Math.Pow(start, 3) + " ");
// }


