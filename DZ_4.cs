// Домашнее задание номер четыри



// Console.Write("Введите число A : ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B : ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// int result = 1;
// for (int i = 1; i <= num2; i++)
// {    
//     result *=  num1;
// }
// Console.WriteLine($"Число {num1} в степени {num2} = {result}");



// Console.Write("Введите число : ");
// int num = Convert.ToInt32(Console.ReadLine());
// int len = NumberLen(num);
// SumNumbers(num, len);
// int NumberLen(int a)
// {
//     int index = 0;
//     while (a > 0)
//     {
//         a /= 10;
//         index++;
//     }
//     return index;
// }
// void SumNumbers(int n, int len)
// {
//     int sum = 0;
//     for (int i = 1; i <= len; i++)
//     {
//         sum += n % 10;
//         n /= 10;
//     }
//     Console.WriteLine($"Сумма цифр в числе {num} = {sum}");
// }



// int[] array = new int[8];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//      array[i] = rand.Next(10, 1000);
// }
// Console.WriteLine($"Массив : [ {string.Join("; ", array)} ]");


// int num;
// int[] array = new int[8];
// num = 0;
// do
// {
//     array[num] = Convert.ToInt32(Console.ReadLine());
//     num++;
// }
// while (num < 8);
// Console.WriteLine($"Массив : [ {string.Join("; ", array)} ]");
