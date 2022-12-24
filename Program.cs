// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

/*
Console.WriteLine("Сколько чисел вы хотите ввести?");
int m = Convert.ToInt32(Console.ReadLine());
int counter = 1;
int result = 0;
while (counter <= m)
{
    Console.Write($"Введите {counter} число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 0) result++;
    counter++;
}
Console.WriteLine();
Console.WriteLine($"Количество положительных чисел - {result}");

*/



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
Console.WriteLine("Введите k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2:");
int k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
int x = 0;
int y = 0;
if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые не имеют точек пересечения т.к. они параллельны друг другу");
if (k1 != k2 && b1 != b2)
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения прямых ({x}; {y})");
}

*/