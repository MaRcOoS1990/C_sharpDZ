// Console.WriteLine("Введите размер массива :");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// Random rand = new Random();
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(100, 1000);
//     Console.Write($" {string.Join("; ", array[i])} ;");
// }
// int cout = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         cout++;
//     }
// }
// Console.WriteLine($"  Колличество четных чисел в массиве = {cout}");


// Console.WriteLine("Введите размер массива :");
// int size2 = Convert.ToInt32(Console.ReadLine());
// int[] array2 = new int[size2];
// Random rand = new Random();
// for (int i = 0; i < array2.Length; i++)
// {
//     array2[i] = rand.Next(-1000, 1000);
//     Console.Write($" {string.Join("; ", array2[i])} ;");
// }
// int sum = 0;
// for (int i = 1; i < array2.Length; i += 2)
// {
//    sum += array2[i];
// }
// Console.WriteLine($"  Сумма нечетных элементов = {sum}");


Console.WriteLine("Введите размер массива :");
int size3 = Convert.ToInt32(Console.ReadLine());
double[] array3 = new double[size3];
Random rand = new Random();
double min = array3[0];
double max = array3[0];
for (int i = 0; i < array3.Length; i++)
{
    array3[i] = rand.NextDouble();
}
for (int i = 0; i < array3.Length; i++)
{
    array3[i] = Math.Round(array3[i], 6);
    array3[i] = array3[i] * 100;
    Console.Write($" {string.Join("; ", array3[i])} ;");
}
for (int i = 0; i < array3.Length; i++)
{
    if (array3[i] > max) max = array3[i];
    if (array3[i] < min) min = array3[i];    
}
Console.WriteLine($"  Разница между {max} и {min} = {max - min}");