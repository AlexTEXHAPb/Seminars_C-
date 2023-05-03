// Начинайте использовать функции , со следующего ДЗ это будет обязательно!

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Palindrom5(int x)
// {
//     if (x / 10000 > 10 | x / 10000 < 1)
//         Console.WriteLine("Нужно ввести пятизначное число, попробуйте еще раз");
//     else if (x / 10000 == (x % 100) % 10 && (x / 1000) % 10 == (x % 100) / 10)
//         Console.WriteLine("Это палиндром");
//     else
//         Console.WriteLine("Это не палиндром");
// }

// try
// {
//     Console.WriteLine("Ведите пятизначное число, а я определю является ли оно палиндромом");
//     Console.WriteLine("Для выхода из программы введите 0");
//     int n = 1;
//     while (n != 0)
//     {
//         int num = Convert.ToInt32(Console.ReadLine());
//         n = num;
//         if (n != 0) Palindrom5(num);
//     }
// }
// catch
// {
//     Console.WriteLine("Были введены некорректные данные, нужно было ввести целое пятизначное число");
// }

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double Dist(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
// }

// Console.WriteLine("Введите Координату x1 для точки А");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату y1 для точки А");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату z1 для точки А");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату x2 для точки B");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату y2 для точки B");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Введите Координату z2 для точки В");
// double z2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine($"Расстояние между точками А и В равно: {Math.Round(Dist(x1, y1, z1, x2, y2, z2), 2)}");

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Введите любое число:");
// int num = Convert.ToInt32(Console.ReadLine());
// int n = 1;
// double result = 0;
// while (n <= num)
// {
//     result = (Math.Pow(n, 3));
//     Console.Write($" {result}");
//     n++;
// }

// Задача 21 - HARD необязательная
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. 
// Сначала задается N с клавиатуры, потом задаются координаты точек.

// double Dist(int n)
// {
//     int i = 0; 
//     double sum = 0;
//     while (i < n)
//     {
//         Console.WriteLine($"Введите координату {i+1} точки А");
//         double koord1 = Convert.ToDouble(Console.ReadLine());
//         Console.WriteLine($"Введите координату {i+1} точки B");
//         double koord2 = Convert.ToDouble(Console.ReadLine());
//         sum = sum + Math.Pow(koord2 - koord1, 2);
//         i++;
//     }
//     return Math.Sqrt(sum);
// }

// Console.WriteLine("Введите мерность пространства N");
// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Расстояние между точками А и В в {N}-мерном пространстве равно: {Math.Round(Dist(N),2)}");

// Задача 19 - HARD необязательная
// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

void Palindrom(long x)
{
    int bit = 0;
    int i = 0;
    long temp = x;
    while (temp > 0)
    {
        temp = temp / 10;
        bit++;
    }
    temp = bit;
    while (temp > 1)
    {
        long x1 = x / Convert.ToInt64(Math.Pow(10, temp - 1));
        long x2 = x % 10;
        x = x / 10;
        x = x % Convert.ToInt64(Math.Pow(10, temp - 2));
        temp = temp - 2;
        if (x1 != x2)
        {
            Console.WriteLine("Это не палиндром");
            temp = 1;
        }
        i++;
    }
    if (i == bit / 2) Console.WriteLine("Это палиндром");
}

try
{
    Console.WriteLine("Ведите любое целое число, а я определю является ли оно палиндромом");
    Console.WriteLine("Для выхода из программы введите 0");
    long n = 1;
    while (n != 0)
    {
        long num = Convert.ToInt64(Console.ReadLine());
        n = num;
        if (n != 0) Palindrom(num);
    }
}
catch
{
    Console.WriteLine("Были введены некорректные данные, нужно было ввести целое число");
}

// Задача 3 НЕОБЯЗАТЕЛЬНАЯ. Напишите программу для. проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z (Теорема Де Моргана) .
// Но теперь количество предикатов не три, а генерируется случайным образом от 5 до 25, сами значения предикатов случайные, проверяем это утверждение 100 раз, 
// с помощью модуля time выводим на экран , сколько времени отработала программа. В конце вывести результат проверки истинности этого утверждения.