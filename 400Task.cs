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