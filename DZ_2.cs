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

