//  Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//  в промежутке от N до 1. Выполнить с помощью рекурсии.
//  N = 5. -> "5, 4, 3, 2, 1"
//  N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NaturalNumbers(int n, int num) // Метод вывода натуральных чисел
// {
//     if (num > n) return; // тумблер выключения
//     else
//     {
//         NaturalNumbers(n, num + 1);
//         if (num == 1) Console.Write("1.");
//         else Console.Write(num + ", ");
//     }
// }

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int num = 1;
// System.Console.WriteLine($"Натуральные числа в промежутке от {n} до 1: ");
// NaturalNumbers(n, num);

//  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N.
//  M = 1; N = 15 -> 120
//  M = 4; N = 8. -> 30
 
// int SumMN(int m, int n) // Метод подсчета суммы чисел от M до N
// {
//     int res = m;
//     if (m == n)
//         return 0;
//     else
//     {
//         m++;
//         res = m + SumMN(m, n);
//         return res;
//     }
// }

// Console.Clear();
// System.Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write(SumMN(num1 - 1, num2));

//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
//  m = 2, n = 3 -> A(m,n) = 9
//  m = 3, n = 2 -> A(m,n) = 29
 
int Akkerman(int m, int n) // Метод вычисления функции Аккермана
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
    }
}

Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"A({m},{n}) = {Akkerman(m, n)}"); 