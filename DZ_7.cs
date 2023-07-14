// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите minimum число: ");
// int minRandom = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите maximum число: ");
// int maxRandom = Convert.ToInt32(Console.ReadLine());
// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);
// Console.WriteLine("Матрица: ");
// PrintMatrix(array2D);
// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Введите номер строки: ");
// int numberOfRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int numberOfColumns = Convert.ToInt32(Console.ReadLine());
// if (numberOfRows < 0 || numberOfRows > rows)
// {
//     Console.WriteLine("Такого индекса нет!");
//     return;
// }
// else if (numberOfColumns < 0 || numberOfColumns > columns)
// {
//     Console.WriteLine("Такого индекса нет!");
//     return;
// }
// int result = array2D[numberOfRows, numberOfColumns];
// Console.Write($"На введеной позицие распологаеться число = {result}");


// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите minimum число: ");
// int minRandom = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите maximum число: ");
// int maxRandom = Convert.ToInt32(Console.ReadLine());
// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);
// Console.WriteLine("Матрица: ");
// PrintMatrix(array2D);
// int[,] GetMatrix(int m, int n, int min, int max)
// {
//     int[,] matrix = new int[m, n];
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         double resultOfCount = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             matrix[i, j] = new Random().Next(min, max + 1);
//             resultOfCount += matrix[i, j];
//         }
//         resultOfCount = Math.Round(resultOfCount, 3);
//         Console.WriteLine($"Среднее арифметическое столбца {j} = {resultOfCount / matrix.GetLength(0)} ");
//     }
//     return matrix;
// }
// void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}