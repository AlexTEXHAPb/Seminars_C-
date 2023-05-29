// Домашнее задание к 5 семинару
//34. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве. 

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(100, 1000);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         Console.Write($"{item} ");
//     System.Console.WriteLine();
// }


// int EvenNum(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//             count++;
//     }
//     return count;
// }

// int[] Myarray = new int[7];
// FillArray(Myarray);
// PrintArray(Myarray);
// int res = EvenNum(Myarray);
// System.Console.WriteLine($"количество чётных чисел в массиве = {res}");

// 36. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// void FillArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         array[i] = new Random().Next(50);
// }

// void PrintArray(int[] array)
// {
//     foreach (int item in array)
//         Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// int SumEvenPosition(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 0)
//             sum+= array[i];
//     }
//     return sum;
// }

// int[] Myarray = new int[7];
// FillArray(Myarray);
// PrintArray(Myarray);
// int result = SumEvenPosition(Myarray);
// System.Console.WriteLine($"Сумму элементов, стоящих на нечётных позициях = {result}");

// 38 задача. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double [] FillArray(int size)
// {
//     double [] array1 = new double [size];
//     for (int i = 0; i < array1.Length; i++)
//     {
//         array1[i] = Math.Round(new Random().NextDouble(),2) + new Random().Next(50);
//             }
//     return array1;

// }

// void PrintArray(double [] array)
// {
//     foreach (double item in array)
//         Console.Write($"{item} ");
//     System.Console.WriteLine();
// }

// void MaxMin(double [] array)
// {
//     double max = array[0];
//     double min = array[0];
    
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]> max) max= array [i];
//         if (array[i]< min) min= array [i];
//     }
//     System.Console.WriteLine($"максимальный элемент массива = {max}");
//     System.Console.WriteLine($"минимальный элемент массива = {min}");
//     System.Console.WriteLine($"разница между максимальным и минимальным элементом массива = {max - min}");

// }


// System.Console.WriteLine("введите размер массива");
// int size = Convert.ToInt32(Console.ReadLine());
// double [] array = FillArray(size);
// PrintArray(array);
// MaxMin(array);
