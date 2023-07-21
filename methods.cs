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

// void ChangeRows(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i, k] < matrix[i, k + 1])
//                 {
//                     int temp = matrix[i, k + 1];
//                     matrix[i, k + 1] = matrix[i, k];
//                     matrix[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// *8

// int RowsSumElements(int[,] matrix, int i)
// {
//     int sumRows = matrix[i, 0];
//     for (int j = 1; j < matrix.GetLength(1); j++)
//     {
//         sumRows += matrix[i, j];
//     }
//     return sumRows;
// }

// *9

// void SumOfRow(int[,] matrix)
// {
//     int minSumRow = 0;
//     int sumRows = RowsSumElements(matrix, 0);
//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
//         int tempSumRows = RowsSumElements(matrix, i);
//         if (sumRows > tempSumRows)
//         {
//             sumRows = tempSumRows;
//             minSumRow = i;
//         }
//     }
//     Console.WriteLine($"\n{minSumRow + 1} - строкa с наименьшей суммой ({sumRows}) элементов ");
// }


// *10

// void MultiplicationMatrix(int[,] matrix, int[,] matrix2, int[,] newMatrix)
// {
//     for (int i = 0; i < newMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < newMatrix.GetLength(1); j++)
//         {
//             int result = 0;
//             for (int k = 0; k < matrix.GetLength(1); k++)
//             {
//                 result += matrix[i, k] * matrix2[k, j];
//             }
//             newMatrix[i, j] = result;
//         }
//     }
// }

// *11

// Console.WriteLine("Трехмерный массив: ");

// GetTrheeArray(2, 2, 2, -99, 99);
// int[,,] GetTrheeArray(int m, int n, int d, int min, int max)
// {
//     int[,,] threeArray = new int[m, n, d];
//     for (int i = 0; i < threeArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < threeArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < threeArray.GetLength(2); k++)
//             {
//                 threeArray[i, j, k] = new Random().Next(min, max );
//             }
//         }
//     }
//     PrintThreeArray(threeArray);
//     return threeArray;
// }


// void PrintThreeArray(int[,,] threeArray)
// {
//     for (int i = 0; i < threeArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < threeArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < threeArray.GetLength(2); k++)
//             {
//                 Console.Write($"{threeArray[i, j, k]} ({i}{j}{k})\t");
//             }
//         Console.WriteLine();
//         }
//     }
// }



// *12

