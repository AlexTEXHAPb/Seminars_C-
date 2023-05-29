// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int HowManyPosNumbersInArray(int[]array) 
// { 
// int count = 0; 
// for (int i = 0; i < array.Length; i++) 
     
// if (array[i] > 0) count++; 
// return count; 
// } 
 
// System.Console.WriteLine("Enter elements of array with gaps:"); 
// int[] NewArray = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); 
 
// System.Console.WriteLine($"There are {HowManyPosNumbersInArray(NewArray)} positive numbers in this array.");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 
// Console.WriteLine("введите значение b1"); 
// double b1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("введите число k1"); 
// double k1 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("введите значение b2"); 
// double b2 = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("введите число k2"); 
// double k2 = Convert.ToInt32(Console.ReadLine()); 
 
// double x = (-b2 + b1)/(-k1 + k2); 
// double y = k2 * x + b2; 
 
// Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");

// Задача НЕГАФИБОНАЧЧИ. Задайте число. Составьте массив чисел НегаФибоначчи, в том числе для отрицательных индексов.
// Пример:
// для k = 9 массив будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]
