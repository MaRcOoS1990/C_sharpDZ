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



