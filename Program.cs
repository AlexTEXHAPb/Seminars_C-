// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Read(string message) // Метод ввода
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[,] array) // Метод заполнения и вывода на экран массива со случайными вещественными числами
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100,100)/10.0;
            System.Console.Write($"{array[i, j],6} ");
        }
    System.Console.WriteLine();
    }
}

Console.Clear();
int rows = Read("Введите количество строк массива");
int colums = Read("Введите количество столбцов массива");
double[,] RndArray = new double[rows, colums];
FillArray(RndArray);

// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, 
// и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int Read(string message) // Метод ввода
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArray(int[,] array) // Метод заполнения и вывода на экран массива со случайными числами 
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-100, 100);
//             System.Console.Write($"{array[i, j],4} ");
//         }
//     System.Console.WriteLine();
//     }
// }

// void FindElement(int[,] array, int find) // Метод поиска элемента массива
// {
//     int flag =0;
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == find)
//                 {
//                 System.Console.Write($"Позиция элемента в массиве: строка {i+1}, столбец {j+1}.");
//                 System.Console.WriteLine();
//                 flag = 1;
//                 }
//         }
//     if (flag == 0)
//     System.Console.Write("Такого элемента в массивеи нет.");
// }

// Console.Clear();
// int rows = Read("Введите количество строк массива");
// int colums = Read("Введите количество столбцов массива");
// int[,] RndArray = new int[rows, colums];
// FillArray(RndArray);
// int element = Read("Введите значение искомого элемента массива");
// FindElement(RndArray, element);

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int Read(string message) // Метод ввода
// {
//     Console.WriteLine(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// void FillArray(int[,] array) // Метод заполнения и вывода на экран массива из целых чисел 
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(-100, 100);
//             System.Console.Write($"{array[i, j],6} ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void PrintAvr(int[,] array) // Метод вывода среднего арифметического элементов в каждом столбце
// {
//     System.Console.WriteLine("Cреднее арифметическое элементов в каждом столбце:");
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         double sum = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             sum += array[i, j];
//         }
//         Console.Write($"{Math.Round((sum / array.GetLength(0)), 1),6} ");
//     }
// }

// Console.Clear();
// int rows = Read("Введите количество строк массива");
// int colums = Read("Введите количество столбцов массива");
// int[,] RndArray = new int[rows, colums];
// FillArray(RndArray);
// PrintAvr(RndArray);

// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. 
// Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

// void SortArray(int[,] array)
// {
//     int[] array1 = new int[array.GetLength(0) * array.GetLength(1)];
//     int z = 0;
//     int[,] arraySort = new int[array.GetLength(0), array.GetLength(1)];
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array1[z] = array[i, j];
//             z++;
//         }
//     Console.WriteLine("Отсортированный массив: ");
//     for (int i = 0; i < array1.Length; i++)
//     {
//         for (int j = 0; j < array1.Length - 1 - i; j++)
//         {
//             if (array1[j] > array1[j + 1])
//             {
//                 (array1[j], array1[j + 1]) = (array1[j + 1], array1[j]);
//             }
//         }
//     }
//     z = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             arraySort[i, j] = array1[z];
//             z++;
//             Console.Write($" {arraySort[i, j],3}");
//         }
//         System.Console.WriteLine();
//     }
// }

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             array[i, j] = new Random().Next(-30, 30);
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write($"{array[i, j],3} ");
//         }
//         System.Console.WriteLine();
//     }
// }
// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[rows, cols];
// FillArray(array);
// PrintArray(array);
// SortArray(array);

// задача 2 HARD необязательная. Считается за четыре обязательных ) то есть три этих и одна с будущего семинара
// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры), причем чтоб количество элементов было четное. 
// Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый элемент гарантированно
// и только один раз переместился на другое место и выполнить перемешивание за m*n / 2 итераций. То есть если массив три на четыре, 
// то надо выполнить за 6 итераций. И далее в конце опять вывести на экран как таблицу.
// например, на входе массив 2*3
// 2 3 5
// 1 9 4
// первая итерация перемешивания - выбрали индексы 0, 0 и 1, 2 случайный образом, поменяли ячейки
// 4 3 5
// 1 9 2
// вторая итерация - индексы 0, 0 и 1, 2 не трогаем, так как это уже перемещенные ячейки, 
// выбираем случайным образом из оставшихся ячеек, выбрали ячейки 0, 1 и 0, 2, поменяли значения
// 4 5 3
// 1 9 2
// третья итерация - теперь остались только ячейки 1, 0 и 1, 1, меняем их местами
// 4 5 3
// 9 1 2
