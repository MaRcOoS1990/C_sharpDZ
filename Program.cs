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

// polin / 10000 == polin % 10 && polin % 10000 / 1000 == polin % 100 / 10




// Семинар 4

// Console.WriteLine("Введите число");
// int limit = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 0; i <= limit; i++)
// {
//     sum += i;
// }
// Console.WriteLine($"Сумма всех чисел от 1 до {limit} = {sum}");



// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());
// int cout = 0;
// int numbercopy = number;
// if (number != 0)
// {
//     while (number > 0)
//     {
//         cout++;
//         number /= 10;
//     }
// }
// else
// {
//     cout++;
// }
// Console.WriteLine($"В числе {numbercopy} - {cout} цифр(ы)");




// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= N; i++)
// {
//     result *= i;
// }
// Console.WriteLine($"Факториал от числа {N} = {result}");


// int size = 8;
// int[] array = new int[size];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(2);
// }
// Console.WriteLine($"Массив: [ {string.Join("; ", array)} ]");




// Семинар 5

// int[] array = new int[12];
// int sumPositive = 0;
// int sumNegative = 0;
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-9, 10);
//     if (array[i] > 0)
//     {
//         sumPositive += array[i];
//     }
//     else
//     {
//         sumNegative += array[i];
//     }
// }
// Console.WriteLine($"Массив : [{string.Join("; ", array)}]");
// Console.WriteLine($"Сумма положительных чисел : {sumPositive}");
// Console.WriteLine($"Сумма отрицательных чисел : {sumNegative}");



// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);
//     }
//     return result;
// }

// int[] array = GetArray(7, 0, 10);
// Console.WriteLine($"Массив : [{string.Join("; ", array)}]");

// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= -1;
//     }
//     return array;
// }
// Console.WriteLine($"Массив перевернутый: [{string.Join("; ", ReverseArray(array))}]");



// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);
//     }
//     return result;
// }

// int[] array = GetArray(7, 0, 10);
// Console.WriteLine($"Массив : [{string.Join("; ", array)}]");

// bool FindElements(int[] arr, int element)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] == element)
//         {
//             return true;
//         }
//     }
//     return false;
// }

// int numberForSearch = 10;
// if (FindElements(array, numberForSearch))
// {
//     Console.WriteLine($"Элемент {numberForSearch} присутствует в массиве");
// }
// else
// {
//     Console.WriteLine($"Элемент {numberForSearch} отсутствует в массиве");
// }



// int[] GetArray(int size, int min, int max)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(min, max + 1);
//     }
//     return result;
// }
// int[] array = GetArray(7, 0, 10);
// Console.WriteLine($"Массив : [{string.Join("; ", array)}]");


// int[] MultiArr(int[] array)
// {
//     int sizeNewArray = array.Length / 2 + array.Length % 2;
//     int[] NewArray = new int[sizeNewArray];
//     for (int i = 0, j = array.Length - 1; i < array.Length / 2 ; i++, j--)
//     {
//         NewArray[i] = array[i] * array[j];
//     }
//     if (array.Length % 2 == 1)
//     {
//         NewArray[sizeNewArray - 1] = array[array.Length / 2];
//     }
//     return NewArray;
// }
// Console.WriteLine($"Массив : [{string.Join("; ", MultiArr(array))}]");


// Лекция про двумерные массивы и рекурсия

// string[] table = new string [2, 3];
// string.Empty
// int [,] matrix = new int[2,3];

// string[,] table = new string [2, 5];    
// table[1, 2] = "слово";
// for (int rows   = 0; rows < 2;  rows++)
// {
//     for (int colums = 0;  colums < 5; colums++)  
//     {
//         Console.WriteLine($"-{table[rows, colums]}-");
//     }
// }


// int [,] matrix = new int[3, 4];
// for (int rows = 0; rows < 3; rows++)  // ИЛИ  for (int rows = 0; rows < matrix.GetLenght(0); rows++)
// {
//     for (int colums = 0; colums < 4; colums++)   //ИЛИ  for (int colums = 0; colums < matrix.GetLenght(1); colums++)
//     {
//         Console.Write($"{matrix[rows, colums]} ");
//     }
// Console.WriteLine();
// }


// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//     for(int i = 0; i<matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//            matr[i,j] = new Random().Next(1,10);
//         }
//     }
// }

// int [,] matrix = new int[3, 4];

// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);


// int[,] pic = new int[,]
// {
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 },
// {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 },
// {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 },
// {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
// };

// void PrintImage(int[,] image)
// {
//     for (int i = 0; i < image.GetLength(0); i++)
//     {
//         for (int j = 0; j < image.GetLength(1); j++)
//         {
//             if (image[i, j] == 0) Console.Write($" ");
//             else Console.Write($"+");
//         }
//         Console.WriteLine();
//     }
// }

// void FillImage(int row, int col)
// {
//     if (pic[row, col] == 0)
//     {
//         pic[row, col] = 1;
//         FillImage(row - 1, col);
//         FillImage(row, col - 1);
//         FillImage(row + 1, col);
//         FillImage(row, col + 1);
//     }
// }


// PrintImage(pic);
// FillImage(13,13);
// PrintImage(pic);


// Рекурсия

// double Factorial(int n)
// {
//     if (n == 0) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 0; i < 40; i++)
// Console.WriteLine($"{i}! = {Factorial(i)}");


// double Fibonacci(int n)
// {
//     if  (n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) +Fibonacci(n-2);
// }
// for (int i = 1; i < 100; i++)
// Console.WriteLine($"{i}! = {Fibonacci(i)}");


// Семинар 6

// Console.Write("Введите строку: ");
// string[] firstArray = Console.ReadLine().Split(" ");
// Console.WriteLine(String.Join("; ", firstArray));


// int[] GetArray(int size, int min, int max)
// {
//     int[] array = new int[size]; // Только нули
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// void PrintArray(int[] arr)
// {
// foreach (int item in arr)
// {
//     Console.Write(item + " ");
// }
//     Console.Write("[  ");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write(arr[i] + "  ");
//     }
//     Console.Write("]");
// }

// int[] result = GetArray(9, 0, 15);
// PrintArray(result);
// ReversArray(result);
// Console.WriteLine("");
// PrintArray(result);
// PrintArray(CopyArray(result));

// *1

// int[] CopyArray(int[] array)
// {
//     int[] copyArray = new int[array.Length];
//     int size = array.Length;
//     for (int start = 0, end = size - 1; start < size; start++, end--)
//     {
//         copyArray[start] = array[end];
//     }
//     return copyArray;
// }

// *2
// void ReversArray(int[] array)
// {
//     int size = array.Length;
//     for (int i = 0, j = size - 1; i < size / 2; i++, j--)
//     {
//         int temp = array[i];
//         array[i] = array[j];
//         array[j] = temp;
//     }
// }


// int a = 3;
// int b = 4;
// int c = 5;

// bool IsTriangle(int a, int b, int c)
// {
//     return (((a + b) > c) && ((a + c) > b) && ((a + c) > c));
// }
// if (IsTriangle(a, b, c))
// {
//     Console.WriteLine("Треугольик существует");
// }
// else
// {
//     Console.WriteLine("Треугольник НЕ существует");
// }

// Console.WriteLine("Введите число : ");
// int N = Convert.ToInt32(Console.ReadLine());
// if (N < 2)
// {
//     return;
// }
// int[] fibonacci = new int[N];

// fibonacci[0] = 0;
// fibonacci[1] = 1;
// for (int i = 2; i < N; i++)
// {
//     fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
// }
// Console.WriteLine($"Массив: {string.Join(", ", fibonacci)}");

