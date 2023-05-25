// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.WriteLine("Введите любое число A");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите любое число B");
// int B = Convert.ToInt32(Console.ReadLine());
// int result = Convert.ToInt32(Math.Pow(A, B));
// Console.WriteLine(result);

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summa(int num)
{
    int res = 0;
    int temp = num;
    while (temp > 1)
    {
        int x = temp % 10;
        temp = temp / 10;
        res = res + x;
    }
    return res;
}

try
{
    System.Console.WriteLine("Введите натуральное число");
    int num = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine($"сумма цифр в числе {num} равна {Summa(num)}");
}
catch
{
    System.Console.WriteLine("Надо вводить именно целое число!!!");
}


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// void PrintArray(int [] numbers)
// {
//     for (int x = 0; x < 8; x++)
//     System.Console.Write($" {numbers[x]}");
//     Console.WriteLine();
// }

// Задача 26 HARD Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.
// 456 -> 3
// 0 -> 1
// 89,126 -> 5
// 0,001->4
