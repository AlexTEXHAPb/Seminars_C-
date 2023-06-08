//  Задача 54: Задайте двумерный массив. Напишите программу, которая 
//  упорядочит по убыванию элементы каждой строки двумерного массива.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  В итоге получается вот такой массив:
//  7 4 2 1
//  9 5 3 2
//  8 4 4 2

// int Read(string message) // Метод ввода
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArray(int[,] array) // Метод заполнения массива случайными числами
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array) // Метод вывода массива на экран 
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void SortArray(int[,] array) // Метод сортировки по убыванию элементов каждой строки
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.Clear();
// int rows = Read("Введите количество строк массива");
// int columns = Read("Введите количество столбцов массива");
// int[,] RndArray = new int[rows, columns];
// FillArray(RndArray);
// PrintArray(RndArray);
// SortArray(RndArray);
// Console.WriteLine();
// PrintArray(RndArray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка

// int Read(string message) // Метод ввода
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArray(int[,] array) // Метод заполнения массива случайными числами
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array) // Метод вывода массива на экран
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void LineNumber(int[,] array) // Метод вывода номера строки с наименьшей суммой элементов 
// {
//     int minSum = 0;
//     int lineNumber = 0;
//     int sum = 0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         minSum += array[0, i];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++) sum += array[i, j];
//         if (sum < minSum)
//         {
//             minSum = sum;
//             lineNumber = i;
//         }
//         sum = 0;
//     }
//     if (lineNumber == 1) Console.Write($"Наименьшая сумма элементов во {lineNumber + 1} строке");
//     else Console.Write($"Наименьшая сумма элементов в {lineNumber + 1} строке");
// }

// Console.Clear();
// int rows = Read("Введите количество строк массива");
// int columns = Read("Введите количество столбцов массива");
// int[,] RndArray = new int[rows, columns];
// FillArray(RndArray);
// PrintArray(RndArray);
// Console.WriteLine();
// LineNumber(RndArray);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int Read(string message) // Метод ввода
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArray(int[,] array) // Метод заполнения массива случайными числами
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] array) // Метод вывода массива на экран
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// void MultiArray(int[,] array1, int[,] array2) // Метод перемножения матриц и вывода результата на экран
// {
//     if (array1.GetLength(1) != array2.GetLength(0))
//     {
//         Console.WriteLine("Эти матрицы перемножить нельзя."); 
//         Console.WriteLine("Число столбцов первой матрицы должно быть равно числу строк во второй матрице.");
//         return;
//     }
//     int[,] multiArray = new int[array1.GetLength(0), array2.GetLength(1)];
//     for (int i = 0; i < array1.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2.GetLength(1); j++)
//         {
//             multiArray[i, j] = 0;
//             for (int k = 0; k < array1.GetLength(1); k++)
//             {
//                 multiArray[i, j] += array1[i, k] * array2[k, j];
//             }
//         }
//     }
//     PrintArray(multiArray);
// }

// int rows1 = Read("Введите количество строк первой матрицы: ");
// int columns1 = Read("Введите количество столбцов первой матрицы: ");
// int[,] array1 = new int[rows1, columns1];
// int rows2 = Read("Введите количество строк второй матрицы: ");
// int columns2 = Read("Введите количество столбцов второй матрицы: ");
// int[,] array2 = new int[rows2, columns2];
// FillArray(array1);
// PrintArray(array1);
// Console.WriteLine();
// FillArray(array2);
// PrintArray(array2);
// Console.WriteLine();
// MultiArray(array1, array2);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных
// чисел. Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// void FillArray(int[,,] array) // Метод заполнения трехмерного массива неповторяющимися случайными числами
// {
//     int count = 10;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[k, i, j] += count;
//                 count = count + new Random().Next(1, 20);
//             }
//         }
//     }
// }

// void PrintArrayIndex(int[,,] array) // Метод вывода элементов трехмерного массива c индексами
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// int[,,] array3D = new int[2, 2, 2];
// FillArray(array3D);
// PrintArrayIndex(array3D);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillSpiralArray(int[,] array, int n) //  Метод спирального заполнения массива начиная с 1
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array) //  Метод вывода массива в терминал
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int size = 4;
int[,] array = new int[size, size];
FillSpiralArray(array, size);
PrintArray(array);