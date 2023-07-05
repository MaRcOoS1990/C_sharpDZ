// Console.WriteLine("Введите число ");

// int N = Convert.ToInt32(Console.ReadLine());
// int number = 2;
// if (N < 0 )
// {
//     Console.Write("Введите положительное число ");
// }
// if (N % 2 == 1)
// {
//     N -- ;
// }
// while (number <= N)
// {
//     Console.WriteLine(number);
//     number = number + 2;
// }


// Console.WriteLine("Введите число ");

// int Num = Convert.ToInt32(Console.ReadLine());

// if (Num % 2 == 0)
// {
//     Console.WriteLine("Ваше число " + Num + " является четным");
// }
// if (Num % 2 == 1) 
// {
//     Console.WriteLine("Ваше число " + Num + " НЕ является четным");
// }
// if (Num % 2 == -1)
// {
//     Console.WriteLine("Ваше число " + Num + " НЕ является четным");
// }




// Console.WriteLine("Введите три числа ");
// int Num1 = Convert.ToInt32(Console.ReadLine());
// int Num2 = Convert.ToInt32(Console.ReadLine());
// int Num3 = Convert.ToInt32(Console.ReadLine());
// int max = Num1;
// if (Num1 < Num2)
// {
//     max = Num2;
// }
// if (Num2 < Num3)
// {
//     max = Num3;
// }
// if (max < Num1)
// {
//     max = Num1;
// }
// Console.WriteLine("Максимальным являеться число " + max);


// Console.WriteLine("Введите два числа ");
// int Number1 = Convert.ToInt32(Console.ReadLine());
// int Number2 = Convert.ToInt32(Console.ReadLine());
// int max = Number1;
// int min = Number2;
// if (Number1 < Number2)
// {
//     max = Number2;
//     min = Number1;
// }
// Console.WriteLine("Максимальным являеться число " + max + " Минимальным являеться число " + min);


// int randomNumber = new Random().Next(10, 100);
// Console.WriteLine(randomNumber);
// int firstDigit = randomNumber / 10;
// int secondDigit = randomNumber % 10;
// int max = firstDigit;
// if (secondDigit > max)
// {
//     max = secondDigit;
// }
// Console.WriteLine($"Максимальным являеться число  {max}");


// int randomNumber = new Random().Next(100, 1000);
// Console.WriteLine(randomNumber);
// int firstDigit = randomNumber / 100;
// int secondDigit = randomNumber % 10;
// Console.WriteLine($"{firstDigit}{secondDigit}");

// int randomNumber = new Random().Next(100, 1000);
// int result = (randomNumber / 100) * 10 + randomNumber % 10;
// Console.WriteLine($"{randomNumber}  {result}");


// int randomNumber = new Random().Next(100, 1000);
// string num = Convert.ToString(randomNumber);
// Console.WriteLine($"{randomNumber}  {num[0]}{num[2]}");



// Console.WriteLine("Введите два числа ");
// int Number1 = Convert.ToInt32(Console.ReadLine());
// int Number2 = Convert.ToInt32(Console.ReadLine());
// if (Number1 % Number2 == 0)
// {
//     Console.WriteLine("Первое число кратно второму");
// }
// else
// {
//     int num = Number1 % Number2;
//     Console.WriteLine("Первое число не кратно второму, остаток = " + num);
// }


// Console.WriteLine("Введите число ");
// int Number1 = Convert.ToInt32(Console.ReadLine());
// if (Number1 % 7 == 0 && Number1 % 23 == 0)
// {
//     Console.WriteLine($"Число {Number1} делиться без остатка на 7 и 23");
// }
// else
// {
//     Console.WriteLine($"Число {Number1} делиться на 7 с остатком { Number1 % 7}");
//     Console.WriteLine($"Число {Number1} делиться на 23 с остатком { Number1 % 23}");
// }


// Домашняя работа 2

// Console.WriteLine("Введите трехзначное число");
// int numberTriple = Convert.ToInt32(Console.ReadLine());
// string numTriple = Convert.ToString(numberTriple);
// int num = numTriple.Length;
// if (num <= 2 || num >= 4)
// {
//     Console.WriteLine("Было сказанно ввести трехзначное число");
//     return;
// }
// Console.WriteLine($"{numTriple[1]} - являеться второй цифрой введенного числа");

// Console.WriteLine("Введите трехзначное число");
// int numberTriple = Convert.ToInt32(Console.ReadLine());
// if (numberTriple < 100 || numberTriple >= 1000)
// {
//     Console.WriteLine("Было сказанно ввести трехзначное число");
//     return;
// }
// Console.WriteLine($"{numberTriple / 10 % 10} - являеться второй цифрой введенного числа");




// Console.WriteLine("Введите число");
// int Number1 = Convert.ToInt32(Console.ReadLine());
// string Number = Convert.ToString(Number1);
// int num = Number.Length;
// if (num <= 2 )
// {
//     Console.WriteLine("Число не содержит третью цифру");
//     return;
// }
// Console.WriteLine($"Третьей цифрой являеться - {Number[2]}");




// Console.WriteLine("Введите число от 1 до 7");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num < 1 || num >= 8)
// {
//     Console.WriteLine("Вы ввели не верное число ");
//     return;
// }
// if (num >= 1 && num <= 5)
// {
//     Console.WriteLine("Сегодня не выходной ");
// }
// else 
// {
//     Console.WriteLine("Сегодня выходной ");
// }





// int[] array = new int[10];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//      array[i] = rand.Next(100, 1000);
//      Console.WriteLine(array[i]);
// }
// for (int i = 0; i < array.Length; i++)
// {
//      int num1 = array[i]; num1 = num1 / 100 * (num1 % 100 / 10) * (num1 % 10); 
//      int num = array[i]; num = num / 100 + num % 100 / 10 + num % 10;
//     if (num1 !=0 && num1 % num == 0)
//     {
//         Console.WriteLine("Интересное число " + array[i]);
//     }
// }


// Семинар 3

// Console.Write("Введите число: ");
// string? stringNumber= Console.ReadLine();
// int number;
// bool isNumber = int.TryParse(stringNumber, out number);
// if (isNumber)
// {
//     Console.WriteLine($"в строчке {stringNumber} находятся только цифры");
// }
// else
// {
//     Console.WriteLine($"в строчке {stringNumber} находятся символы");
//     Console.WriteLine(number);
// }


// Console.Write("Введите координату по оси оХ: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату по оси оY: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.Write("Вы находитесь в 1 четверти");
// }
// else if (x < 0 && y > 0)
// {
//     Console.Write("Вы находитесь в 2 четверти");
// }
// else if (x < 0 && y < 0)
// {
//     Console.Write("Вы находитесь в 3 четверти");
// }
// else if (x > 0 && y < 0)
// {
//     Console.Write("Вы находитесь в 4 четверти");
// }
// else 
// {
//     Console.Write("Вы попали в одну из осей");
// }


// Console.Write("Введите координату по оси оХ для первой точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оY для первой точки: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оХ для второй точки: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату по оси оY для второй точки: ");
// int y2 = Convert.ToInt32(Console.ReadLine());

// double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)),2);
// Console.Write($"Расстояние: {d}");


// Console.WriteLine("Введите число :");
// int start;
// int end = Convert.ToInt32(Console.ReadLine());
// for (start = 1; start <= end; start++)
// {
//     Console.Write(Math.Pow(start, 2) + " ");
// }


