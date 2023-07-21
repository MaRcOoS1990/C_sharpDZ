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

// ChangeRows(array2D);
// Console.WriteRows("");
// PrintMatrix(array2D);




// int RowsSumElements(int[,] matrix, int i)
// {
//     int sumRows = matrix[i, 0];
//     for (int j = 1; j < matrix.GetLength(1); j++)
//     {
//         sumRows += matrix[i, j];
//     }
//     return sumRows;
// }

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

// SumOfRow(array2D);






// Console.Write("Введите количество строк 1 матрицы: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов 1 матрицы: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите minimum число 1 матрицы: ");
// int minRandom = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите maximum число 1 матрицы: ");
// int maxRandom = Convert.ToInt32(Console.ReadLine());
// int[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);


// Console.Write("Введите количество строк 2 матрицы: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов 2 матрицы: ");
// int columns2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите minimum число 2 матрицы: ");
// int minRandom2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите maximum число 2 матрицы: ");
// int maxRandom2 = Convert.ToInt32(Console.ReadLine());
// int[,] secondArray2d = GetsecondMatrix(rows2, columns2, minRandom2, maxRandom2);

// if (rows != columns2 || columns != rows2)
// {
//     Console.WriteLine("Error");
//     return;
// }

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

// int[,] GetsecondMatrix(int l, int d, int min, int max)
// {
//     int[,] secondMatrix = new int[l, d];
//     for (int i = 0; i < secondMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < secondMatrix.GetLength(1); j++)
//         {
//             secondMatrix[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return secondMatrix;
// }

// Console.WriteLine("Матрица: ");
// PrintMatrix(array2D);

// Console.WriteLine("Матрица2: ");
// PrintMatrix(secondArray2d);

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

// int[,] newMatrix = new int[rows, columns2];

// MultiplicationMatrix(array2D, secondArray2d, newMatrix);
// Console.WriteLine($"Произведение первой и второй матрицы :");
// PrintMatrix(newMatrix);

// void MultiplicationMatrix(int[,] matrix, int[,] secondMatrix, int[,] newMatrix)
// {
//     for (int i = 0; i < newMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < newMatrix.GetLength(1); j++)
//         {
//             int result = 0;
//             for (int k = 0; k < matrix.GetLength(1); k++)
//             {
//                 result += matrix[i, k] * secondMatrix[k, j];
//             }
//             newMatrix[i, j] = result;
//         }
//     }
// }





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
//                 threeArray[i, j, k] = new Random().Next(min, max);
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
//                 Console.Write($"{threeArray[i, j, k]} ({i},{j},{k}) \t");
//             }
//             Console.WriteLine();
//         }
//     }
// }



// int m = 4;
// int[,] matrix2D = new int[m, m];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= matrix2D.GetLength(0) * matrix2D.GetLength(1))
// {
//     matrix2D[i, j] = temp;
//     temp++;
//     if (i <= j + 1 && i + j < matrix2D.GetLength(1) - 1)
//         j++;
//     else if (i < j && i + j >= matrix2D.GetLength(0) - 1)
//         i++;
//     else if (i >= j && i + j > matrix2D.GetLength(1) - 1)
//         j--;
//     else
//         i--;
// }

// PrintMatrix2(matrix2D);

// void PrintMatrix2(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] / 10 <= 0)
//                 Console.Write(array[i, j] + "\t");
//             else Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }


