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


