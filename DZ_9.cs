// Console.Write("Введите число N :");
// int n = Convert.ToInt32(Console.ReadLine());
// string PrintNumbers(int start, int end)
// {
//     if (start == end) return end.ToString();
//     return start + "," + PrintNumbers(start - 1, end);
// }
// Console.WriteLine($"Числа от {n} до 1 : {PrintNumbers(n, 1)}.");




// Console.Write("Введите число N :");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число M :");
// int m = Convert.ToInt32(Console.ReadLine());
// int SumNumber(int m, int n)
// {
//     if (m == n) return m;
//     return n + SumNumber(m, n + 1);
// }
// Console.WriteLine($"Сумма чисел от {m} до {n} = {SumNumber(m, n)}");



// Console.Write("Введите число N :");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число M :");
// int m = Convert.ToInt32(Console.ReadLine());


// int СonsiderAckkerman(int n, int m)
// {
//     if (n == 0) return m + 1;
//     else if (m == 0) return СonsiderAckkerman(n - 1, 1);
//     else return СonsiderAckkerman(n - 1, СonsiderAckkerman(n, m - 1));
// }
// Console.WriteLine($"Аккерман = {СonsiderAckkerman(m, n)}");