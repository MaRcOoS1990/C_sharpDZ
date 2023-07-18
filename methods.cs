// *1 

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

// *2

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


// *3

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

// *4

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

// *5

// void ChangeRows(int[,] matrix)
// {
//     int lastRowIndex = matrix.GetLength(0) - 1;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         int temp = matrix[0, i];
//         matrix[0, i] = matrix[lastRowIndex, i];
//         matrix[lastRowIndex, i] = temp;
//     }
// }

// *6

// int[,] ChangeMatrix(int[,] matrix)
// {
//     int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             result[j, i] = matrix[i, j];

//         }
//     }
//     return result;
// }

// *7

