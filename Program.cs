// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void GetNums(int num)
{
    Console.Write(num + " ");
    if (num > 1) GetNums(num - 1);
    if (num < 1) GetNums(num + 1);
}

Console.Write("Input num: ");
int num = Convert.ToInt32(Console.ReadLine());

GetNums(num);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int Num (int m, int n)
{                                                               // Описание работы рекурсии в методе, если m = 1, n = 4:
    Console.Write(m);                                           
    if (m < n) return Num (m + 1, n) + m;                       // Num(1, 4) --> if (1 < 4) Num(2, 4) + 1
    if (m > n) return Num (m - 1, n) + m;                       // Num(2, 4) --> if (2 < 4) Num(3, 4) + 2
    return n;                                                   // Num(3, 4) --> if (3 < 4) Num(4, 4) + 3
}                                                               // Num(4, 4) --> if (4 < 4) 4

Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = Num (m, n);
Console.Write(result);

*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
/*
int GetAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return GetAkkerman(m - 1, 1);
    if (m > 0 && n > 0)  return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
    return 0;
}


Console.Write("Input M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input N: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = GetAkkerman(m, n);
Console.Write(result);
*/
